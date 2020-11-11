using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHero.Data;
using SuperHero.Models;

namespace SuperHero.Controllers
{
    public class SupeController : Controller
    {
        private ApplicationDbContext db;
        public SupeController(ApplicationDbContext _db)
        {
            db = _db;
        }
        // GET: SupeController
        public ActionResult Index()
        {
            List<Superhero> supes = db.Supes.ToList();
            return View(supes);
        }

        // GET: SupeController/Details/5
        public ActionResult Details(int id)
        {
            Superhero supeIdDetails = db.Supes.Find(id);
            return View(supeIdDetails);
        }

        // GET: SupeController/Create
        public ActionResult Create()
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }

        // POST: SupeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Superhero supe)
        {
            try
            {
                db.Supes.Add(supe);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SupeController/Edit/5
        public ActionResult Edit(int id)
        {
            Superhero supeIdEdit = db.Supes.Find(id);
            return View(supeIdEdit);
        }

        // POST: SupeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Superhero supe)
        {
            try
            {
                db.Supes.Update(supe);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SupeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SupeController/Delete/5
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
