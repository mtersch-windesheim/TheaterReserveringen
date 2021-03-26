using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterApplicatie.Data;
using TheaterApplicatie.Models;

namespace TheaterApplicatie.Controllers
{
    public class ReserveringenController : Controller
    {
        private readonly IObjectService<Reservering> reserveringService;
        private readonly IObjectService<Klant> klantService;

        public ReserveringenController(IObjectService<Reservering> objectService, IObjectService<Klant> klantService)
        {
            this.reserveringService = objectService;
            this.klantService = klantService;
        }
        // GET: ReserveringenController
        public ActionResult Index()
        {
            return View(reserveringService.GetAll());
        }

        // GET: ReserveringenController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReserveringenController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReserveringenController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReserveringenController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReserveringenController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReserveringenController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReserveringenController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult EditWithKlantId(int id)
        {
            if (!klantService.Exists(id))
                return NotFound();
            
            // Wat nodig:
            // - *alle* stoelen (= Reservering-objecten in DB)
            List<Reservering> reserveringen = reserveringService.GetAll();
            // - huidige klant (i.v.m. klantdetails bovenin)
            Klant klant = klantService.Get(id);

            ViewData["klantgegevens"] = $"{klant.Naam} - {klant.Email} - {klant.Woonplaats}";
            ViewData["klantId"] = id;

            return View(reserveringen);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditWithKlantId(int? klantId, int[] reserveringIds)
        {
            if (!klantService.Exists(klantId.GetValueOrDefault()))
                return NotFound();
            else
            {
                List<Reservering> reserveringen = reserveringService.GetAll();
                List<Reservering> mutaties = new List<Reservering>();
                foreach (var reservering in reserveringen)
                {
                    // Opties:
                    // - reservering van klant, aangevinkt => geen mutatie
                    // - reservering van iemand anders => geen mutatie
                    // - reservering van klant, niet aangevinkt => mutatie: bezet = false; klantid leeg
                    if (reservering.KlantId.GetValueOrDefault() == klantId.GetValueOrDefault() && !reserveringIds.Contains(reservering.ReserveringId))
                    {
                        reservering.KlantId = null;
                        reservering.Bezet = false;
                        mutaties.Add(reservering);
                    }
                    // - reservering van niemand, aangevinkt => mutatie: bezet = true; klantid = id huidige klant
                    if (!reservering.Bezet && reserveringIds.Contains(reservering.ReserveringId))
                    {
                        reservering.KlantId = klantId;
                        reservering.Bezet = true;
                        mutaties.Add(reservering);
                    }
                    // - reservering van niemand, niet aangevinkt => geen mutatie
                }
                foreach(var reservering in mutaties)
                {
                    reserveringService.Update(reservering.ReserveringId, reservering);  // TODO: returnvalues controleren en evt. melding van maken
                }
                return RedirectToAction(nameof(KlantenController.Index), "Klanten");
            }
        }
    }
}
