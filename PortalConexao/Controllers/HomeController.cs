using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortalConexao.DAL;

namespace PortalConexao.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index(int? id)
        {
            var model = new Models.HomeIndexViewModel();

            model.CidadeSelecionada = id;
            model.Cidades = _dal.Cidades.ToArray();
            model.Noticias = _dal.Noticias.ToArray();

            if (id != null)
            {
                model.Noticias = model.Noticias
                    .Where(p => p.CidadeId == id)
                    .ToArray();
            }
            
            return View(model);
        }

        public ActionResult About()
        {
           
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}