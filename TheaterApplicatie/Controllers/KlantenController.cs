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
    public class KlantenController : Controller
    {
        private readonly IObjectService<Klant> klantService;
        private readonly IObjectService<Reservering> reserveringService;

        public KlantenController(IObjectService<Klant> klantService, IObjectService<Reservering> reserveringService)
        {
            this.klantService = klantService;
            this.reserveringService = reserveringService;
        }
        // GET: KlantenController
        public ActionResult Index()
        {
            List<Klant> klanten = klantService.GetAll().OrderBy(klant => klant.Naam).ToList();
            List<Reservering> reserveringen = reserveringService.GetAll();
            foreach(Klant klant in klanten)
            {
                List<Reservering> klantReserveringen = reserveringen.Where(res => res.KlantId == klant.KlantId).ToList();
                klant.Reserveringen = klantReserveringen;
            }

            return View(klanten);
        }

        // GET: KlantenController/Details/5
        public ActionResult Details(int id)
        {
            Klant klant = klantService.Get(id);
            if (klant == null)
                return NotFound();
            else
                return View(klant);
        }

        // GET: KlantenController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KlantenController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Klant klant)
        {
            if (ModelState.IsValid)
            {
                if (klantService.Add(klant))
                    return RedirectToAction(nameof(Index));
                else
                    return View(klant);
            }
            else
                return View(klant);
        }

        // GET: KlantenController/Edit/5
        public ActionResult Edit(int id)
        {
            Klant klant = klantService.Get(id);
            if (klant == null)
                return NotFound();
            else
                return View(klant);
        }

        // POST: KlantenController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Klant klant)
        {
            if (!ModelState.IsValid)
                return View(klant);

            if (!klantService.Exists(id))
                return View(klant);         // Of: NotFound() ?

            if (klantService.Update(id, klant))
                return RedirectToAction(nameof(Index));
            else
                return View(klant);
        }

        // GET: KlantenController/Delete/5
        public ActionResult Delete(int id)
        {
            Klant klant = klantService.Get(id);
            if (klant == null)
                return NotFound();
            else
                return View(klant);
        }

        // POST: KlantenController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteAction(int id)
        {
            if (!klantService.Exists(id))
                return NotFound();

            if (klantService.Delete(id))
                return RedirectToAction(nameof(Index));
            else
                return NotFound();
        }
    }
}
