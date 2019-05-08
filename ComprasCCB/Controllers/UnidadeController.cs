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
    public class UnidadeController : Controller
    {
        private readonly ComprasCCBContext _comprasCCBContext;
        private readonly IMapper _mapper;

        public UnidadeController(ComprasCCBContext comprasCCBContext, IMapper mapper)
        {
            _comprasCCBContext = comprasCCBContext;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            var model = _mapper.Map<List<UnidadeViewModel>>(_comprasCCBContext.Unidade);
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UnidadeViewModel model)
        {
            _comprasCCBContext.Unidade.Add(_mapper.Map<Unidade>(model));
            _comprasCCBContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            var unidade = _comprasCCBContext
                .Unidade
                .FirstOrDefault(w => w.Id == id);

            var model = _mapper.Map<UnidadeViewModel>(unidade);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UnidadeViewModel model)
        {
            _comprasCCBContext.Entry(_mapper.Map<Unidade>(model)).State = EntityState.Modified;
            _comprasCCBContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete(int id)
        {
            var unidade = _comprasCCBContext
               .Unidade
               .FirstOrDefault(w => w.Id == id);

            var model = _mapper.Map<UnidadeViewModel>(unidade);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var unidade = _comprasCCBContext.Unidade.FirstOrDefault(w => w.Id == id);
            _comprasCCBContext.Unidade.Remove(unidade);
            _comprasCCBContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}