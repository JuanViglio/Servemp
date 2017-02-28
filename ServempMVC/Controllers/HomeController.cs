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
            BuscadorClientes modelo = new BuscadorClientes();

            return View(modelo);
        }       

        [HttpPost]
        public ActionResult GetClientes(BuscadorClientes cliente)
        {
            CreditosContext context = new CreditosContext();
            string codigo="";

            if (cliente.Codigo != null)
            {
                switch (cliente.TipoDocumentoSeleccionado)
                {
                    case "DNI":
                        codigo = "1-" + cliente.Codigo;
                        break;       
                                 
                    case "LIBRETA DE ENROLAMIENTO":
                        codigo = "2-" + cliente.Codigo;
                        break;

                    case "LIBRETA CIVICA":
                        codigo = "3-" + cliente.Codigo;
                        break;

                    case "CEDULA DE IDENTIDAD":
                        codigo = "4-" + cliente.Codigo;
                        break;

                    default:
                        break;
                }
            }


            List<Clientes> clientes = context.Clientes.Where(x=> x.Codigo==codigo || x.ApellidoyNombre==cliente.ApellidoyNombre).ToList();

            return View("ClientesListado", clientes);

        }
    }
}
