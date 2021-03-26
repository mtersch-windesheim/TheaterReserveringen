﻿using Microsoft.AspNetCore.Http;
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
            // TODO: Lijst van klanten ophalen

            List<Klant> klanten = klantService.GetAll().OrderBy(klant => klant.Naam).ToList();
            List<Reservering> reserveringen = reserveringService.GetAll();
            // ViewData["aantal"] = klanten.Count;
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
            return View();
        }

        // GET: KlantenController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KlantenController/Create
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

        // GET: KlantenController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KlantenController/Edit/5
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

        // GET: KlantenController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KlantenController/Delete/5
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
    }
}
