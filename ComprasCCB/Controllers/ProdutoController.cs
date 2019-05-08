using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ComprasCCB.AcessoDados;
using ComprasCCB.AcessoDados.Dominio;
using ComprasCCB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ComprasCCB.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ComprasCCBContext _comprasCCBContext;
        private readonly IMapper _mapper;

        public ProdutoController(ComprasCCBContext comprasCCBContext, IMapper mapper)
        {
            _comprasCCBContext = comprasCCBContext;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            var produtos = _comprasCCBContext
                .Produto
                .Include(o => o.Unidade)
                .Include(o => o.Categoria)
                .Include(o => o.Fornecedor);

            var model = _mapper.Map<List<ProdutoViewModel>>(produtos);
            return View(model);
        }

        public ActionResult Create()
        {
            SelectLists();

            var model = new ProdutoViewModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel model)
        {
            _comprasCCBContext.Produto.Add(_mapper.Map<Produto>(model));
            _comprasCCBContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            SelectLists();

            var produto = _comprasCCBContext.Produto.FirstOrDefault(w => w.Id == id);
            var model = _mapper.Map<ProdutoViewModel>(produto);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoViewModel model)
        {
            _comprasCCBContext.Entry(_mapper.Map<Produto>(model)).State = EntityState.Modified;
            _comprasCCBContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete(int id)
        {
            var produto = _comprasCCBContext.Produto.FirstOrDefault(w => w.Id == id);
            var model = _mapper.Map<ProdutoViewModel>(produto);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var produto = _comprasCCBContext.Produto.FirstOrDefault(w => w.Id == id);
            _comprasCCBContext.Produto.Remove(produto);
            _comprasCCBContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        private void SelectLists()
        {
            ViewBag.UnidadeSelectList = _comprasCCBContext.Unidade.Select(s => new SelectListItem() { Text = s.Descricao, Value = s.Id.ToString() }).ToList();
            ViewBag.CategoriaSelectList = _comprasCCBContext.Categoria.Select(s => new SelectListItem() { Text = s.Descricao, Value = s.Id.ToString() }).ToList();
            ViewBag.FornecedorSelectList = _comprasCCBContext.Fornecedor.Select(s => new SelectListItem() { Text = s.Descricao, Value = s.Id.ToString() }).ToList();
        }
    }
}