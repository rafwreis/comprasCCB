using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComprasCCB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComprasCCB.Controllers
{
    public class UnidadeController : Controller
    {
        // GET: Unidade
        public ActionResult Index()
        {
            var model = new List<UnidadeViewModel>()
            {
                new UnidadeViewModel(){ Id = 1, Descricao = "PC"},
                new UnidadeViewModel(){ Id = 2, Descricao = "UN"},
                new UnidadeViewModel(){ Id = 3, Descricao = "LT"}
            };

            return View(model);
        }

        // GET: Unidade/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Unidade/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Unidade/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UnidadeViewModel model)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Unidade/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Unidade/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UnidadeViewModel model)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Unidade/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Unidade/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}