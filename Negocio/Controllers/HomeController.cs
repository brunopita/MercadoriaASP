using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Negocio.Models.Banco;

namespace Negocio.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private Db db = new Db();
        public ActionResult Index()
        {
            var negocio = db.negocio;
            if (negocio.Count() == 0)
            {
                return View();
            }
            return View(negocio.ToList());
        }

    }
}
