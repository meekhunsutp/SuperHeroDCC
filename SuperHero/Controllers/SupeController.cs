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
        private ApplicationDbContext _context;
        public SupeController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: SupeController
        public ActionResult Index()
        {
            List<Superhero> supes = _context.Supes.ToList();
            return View(supes);
        }

        // GET: SupeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SupeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SupeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Superhero supe)
        {
            try
            {
                _context.Supes.Add(supe);
                _context.SaveChanges();
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
            return View();
        }

        // POST: SupeController/Edit/5
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
