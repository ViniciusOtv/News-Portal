using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalConexao.Controllers
{
    public class CategoriaController : BaseController
    {
        // GET: Categoria
        public ActionResult Politica(int? id)
        {
            var model = new Models.HomeIndexViewModel();

            model.CategoriaSelecionada = id;
            model.Categorias = _dal.Categorias.ToArray();
            model.Noticias = _dal.Noticias.ToArray();

            if (id != null)
            {
                model.Noticias = model.Noticias
                    .Where(p => p.CategoriaId == id)
                    .ToArray();
            }

            return View(model);
        }

        public ActionResult Esportes(int? id)
        {
            var model = new Models.HomeIndexViewModel();

            model.CategoriaSelecionada = id;
            model.Categorias = _dal.Categorias.ToArray();
            model.Noticias = _dal.Noticias.ToArray();

            if (id != null)
            {
                model.Noticias = model.Noticias
                    .Where(p => p.CategoriaId == id)
                    .ToArray();
            }

            return View(model);
        }

        public ActionResult InfraEstrutura(int? id)
        {
            var model = new Models.HomeIndexViewModel();

            model.CategoriaSelecionada = id;
            model.Categorias = _dal.Categorias.ToArray();
            model.Noticias = _dal.Noticias.ToArray();

            if (id != null)
            {
                model.Noticias = model.Noticias
                    .Where(p => p.CategoriaId == id)
                    .ToArray();
            }

            return View(model);
        }
        public ActionResult Entretenimento(int? id)
        {
            var model = new Models.HomeIndexViewModel();

            model.CategoriaSelecionada = id;
            model.Categorias = _dal.Categorias.ToArray();
            model.Noticias = _dal.Noticias.ToArray();

            if (id != null)
            {
                model.Noticias = model.Noticias
                    .Where(p => p.CategoriaId == id)
                    .ToArray();
            }

            return View(model);
        }

        public ActionResult Saude(int? id)
        {
            var model = new Models.HomeIndexViewModel();

            model.CategoriaSelecionada = id;
            model.Categorias = _dal.Categorias.ToArray();
            model.Noticias = _dal.Noticias.ToArray();

            if (id != null)
            {
                model.Noticias = model.Noticias
                    .Where(p => p.CategoriaId == id)
                    .ToArray();
            }

            return View(model);
        }
    }
}