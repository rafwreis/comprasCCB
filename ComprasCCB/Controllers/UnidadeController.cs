using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComprasCCB.AcessoDados;
using ComprasCCB.AcessoDados.Dominio;
using ComprasCCB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComprasCCB.Controllers
{
    public class UnidadeController : Controller
    {
        private readonly ComprasCCBContext _comprasCCBContext;

        public UnidadeController(ComprasCCBContext comprasCCBContext)
        {
            _comprasCCBContext = comprasCCBContext;
        }

        // GET: Unidade
        public ActionResult Index()
        {
            var model = _comprasCCBContext
                .Unidade
                .Select(s => new UnidadeViewModel()
                {
                    Id = s.Id,
                    Descricao = s.Descricao
                });

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
                _comprasCCBContext
                   .Unidade.Add(new Unidade()
                   {
                       Descricao = model.Descricao
                   });

                _comprasCCBContext.SaveChanges();

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
            var unidade = _comprasCCBContext
                .Unidade
                .FirstOrDefault(w => w.Id == id);

            var model = new UnidadeViewModel()
            {
                Id = unidade.Id,
                Descricao = unidade.Descricao
            };

            return View(model);
        }

        // POST: Unidade/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UnidadeViewModel model)
        {
            try
            {
                var unidade = _comprasCCBContext.Unidade.FirstOrDefault(w => w.Id == model.Id);
                unidade.Descricao = model.Descricao;

                _comprasCCBContext
                  .Unidade.Attach(unidade);

                _comprasCCBContext.SaveChanges();

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