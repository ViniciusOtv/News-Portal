using PortalConexao.DAL;
using System.Linq;
using System.Web.Mvc;

namespace PortalConexao.Controllers
{
    public class BaseController : Controller
    {
        protected DatabaseDB _dal = new DatabaseDB();

        protected override void OnActionExecuting(
            ActionExecutingContext filterContext)
        {
            ViewBag.Cidades = _dal.Cidades.ToArray();

            base.OnActionExecuting(filterContext);
        }

    }
}