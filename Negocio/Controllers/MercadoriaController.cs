using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Negocio.Models.Banco;

namespace Negocio.Controllers
{
    public class MercadoriaController : Controller
    {
        //
        // GET: /Mercadoria/
        private Db db = new Db();
        public ActionResult Index()
        {
            var mercadorias = db.mercadoria;
            if (mercadorias.Count() == 0)
                return View();
            return View(mercadorias.ToList());
        }
        public ActionResult Create()
        {
            //ViewData é uma variavel dinamica que fica dentro da parte da view, com ela é possivel passar e acessar informações na View
            ViewData.Add("TipoMercadoria", db.GetTipoMercadoria());
            return View();
        }
        //quando recebe uma requisição post na rota de create, o sistema redireciona para essa função
        [HttpPost]
        public ActionResult Create(mercadoria m)
        {
            try
            {
                db.mercadoria.Add(m);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "EmployeeInfo", "Create"));
            }
            return RedirectToAction("Index");
        }
        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }

    }
}
