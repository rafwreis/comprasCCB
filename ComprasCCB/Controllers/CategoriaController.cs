using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ComprasCCB.AcessoDados;
using ComprasCCB.AcessoDados.Dominio;
using ComprasCCB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComprasCCB.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ComprasCCBContext _comprasCCBContext;
        private readonly IMapper _mapper;

        public CategoriaController(ComprasCCBContext comprasCCBContext, IMapper mapper)
        {
            _comprasCCBContext = comprasCCBContext;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            var model = _mapper.Map<List<CategoriaViewModel>>(_comprasCCBContext.Categoria);                
            return View(model);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriaViewModel model)
        {
            try
            {
                _comprasCCBContext.Categoria.Add(_mapper.Map<Categoria>(model));
                _comprasCCBContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        public ActionResult Edit(int id)
        {
            var categoria = _comprasCCBContext
                .Categoria
                .FirstOrDefault(w => w.Id == id);

            var model = _mapper.Map<CategoriaViewModel>(categoria);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoriaViewModel model)
        {
            try
            {
                _comprasCCBContext.Entry(_mapper.Map<Categoria>(model)).State = EntityState.Modified;
                _comprasCCBContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

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