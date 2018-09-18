using Projeto_Implastic.DAO;
using Projeto_Implastic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto_Implastic.Controllers
{
    public class PaisController : Controller
    {
        // GET: Pais
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form()
        {
            ViewBag.Pais = new Pais();
            PaisesDAO dao = new PaisesDAO();
            IList<Pais> paises = dao.Lista();
            ViewBag.Paises = paises;
            return View(paises);
        }
    }
}