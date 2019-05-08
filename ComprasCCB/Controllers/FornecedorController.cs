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
    public class FornecedorController : Controller
    {
        private readonly ComprasCCBContext _comprasCCBContext;
        private readonly IMapper _mapper;

        public FornecedorController(ComprasCCBContext comprasCCBContext, IMapper mapper)
        {
            _comprasCCBContext = comprasCCBContext;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            var model = _mapper.Map<List<FornecedorViewModel>>(_comprasCCBContext.Fornecedor);
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
        public ActionResult Create(FornecedorViewModel model)
        {
            _comprasCCBContext.Fornecedor.Add(_mapper.Map<Fornecedor>(model));
            _comprasCCBContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            var fornecedor = _comprasCCBContext
                .Fornecedor
                .FirstOrDefault(w => w.Id == id);

            var model = _mapper.Map<FornecedorViewModel>(fornecedor);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FornecedorViewModel model)
        {
            _comprasCCBContext.Entry(_mapper.Map<Fornecedor>(model)).State = EntityState.Modified;
            _comprasCCBContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete(int id)
        {
            var fornecedor = _comprasCCBContext
                .Fornecedor
                .FirstOrDefault(w => w.Id == id);

            var model = _mapper.Map<FornecedorViewModel>(fornecedor);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var fornecedor = _comprasCCBContext.Fornecedor.FirstOrDefault(w => w.Id == id);
            _comprasCCBContext.Fornecedor.Remove(fornecedor);
            _comprasCCBContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}