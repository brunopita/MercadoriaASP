using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Negocio.Models.Banco;

namespace Negocio.Controllers
{
    public class NegociacaoController : Controller
    {
        //
        // GET: /Negociacao/
        private Db db = new Db();
        public ActionResult Index()
        {
            var negociacoes = db.negocio;
            if (negociacoes.Count() == 0)
                return RedirectToAction("Index","Home");
            return RedirectToAction("Index", "Home", negociacoes);
        }
        public ActionResult Create()
        {
            ViewData.Add("Mercadorias", db.GetMercadoria());
            ViewData.Add("TipoNegociacao", db.GetTipoNegociacao());
            return View();
        }
        [HttpPost]
        public ActionResult Create(negocio n)
        {
            try
            {
                n.CreateAt = DateTime.Now;
                n.UpdateAt = DateTime.Now;
                db.negocio.Add(n);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "EmployeeInfo", "Create"));
            }
           
            return RedirectToAction("Index");
        }

    }
}
