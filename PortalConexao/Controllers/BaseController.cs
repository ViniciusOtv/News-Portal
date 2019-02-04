using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortalConexao.Models;
using System.Data.Entity;
using PortalConexao.DAL;

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