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
        private readonly IObjectService<Reservering> objectService;
        private readonly IObjectService<Klant> klantService;

        public ReserveringenController(IObjectService<Reservering> objectService, IObjectService<Klant> klantService)
        {
            this.objectService = objectService;
            this.klantService = klantService;
        }
        // GET: ReserveringenController
        public ActionResult Index()
        {
            return View(objectService.GetAll());
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
            List<Reservering> reserveringen = objectService.GetAll();
            // - reserveringen van huidige klant
            //List<Reservering> klantReserveringen = reserveringen.Where(res => res.KlantId == id).ToList();
            // - huidige klant (i.v.m. klantdetails bovenin)
            Klant klant = klantService.Get(id);

            ViewData["klantgegevens"] = $"{klant.Naam} - {klant.Email} - {klant.Woonplaats}";
            ViewData["klantId"] = id;

            return View(reserveringen);
        }
    }
}
