using ServempMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServempMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult GetClientes(Clientes cliente)
        {
            CreditosContext context = new CreditosContext();

            List<Clientes> clientes = context.Clientes.Where(x=> x.Codigo==cliente.Codigo || x.ApellidoyNombre==cliente.ApellidoyNombre).ToList();

            return View("ClientesListado", clientes);

        }
    }
}
