using System.Linq;
using System.Web.Mvc;

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

        public ActionResult NoticiaDetalhe(int id, int? Categoria)
        {
            var model = new Models.HomeIndexViewModel();
            model.Noticias = _dal.Noticias.ToArray();


            model.Noticias = model.Noticias
                .Where(p => p.Id == id)
                .ToArray();

            return View(model);
        }

    }
}