using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComprasCCB.AcessoDados;
using ComprasCCB.AcessoDados.Dominio;
using ComprasCCB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ComprasCCB.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly ComprasCCBContext _comprasCCBContext;

        public FornecedorController(ComprasCCBContext comprasCCBContext)
        {
            _comprasCCBContext = comprasCCBContext;
        }

        // GET: Unidade
        public ActionResult Index()
        {
            var model = _comprasCCBContext
                .Fornecedor
                .Select(s => new FornecedorViewModel()
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
        public ActionResult Create(FornecedorViewModel model)
        {
            try
            {
                _comprasCCBContext
                   .Fornecedor.Add(new Fornecedor()
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
            var fornecedor = _comprasCCBContext
                .Fornecedor
                .FirstOrDefault(w => w.Id == id);

            var model = new FornecedorViewModel()
            {
                Id = fornecedor.Id,
                Descricao = fornecedor.Descricao
            };

            return View(model);
        }

        // POST: Unidade/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FornecedorViewModel model)
        {
            try
            {
                _comprasCCBContext.Entry(
                    new Fornecedor
                    {
                        Id = model.Id,
                        Descricao = model.Descricao
                    })
                .State = EntityState.Modified;

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