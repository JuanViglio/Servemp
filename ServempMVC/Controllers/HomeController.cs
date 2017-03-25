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
            creditosEntities context = new creditosEntities();            
            List<legajos> legajos = new List<legajos>();

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
                }

                legajos = context.legajos.Where(x => x.clientes.Codigo == codigo).ToList();
            }
            else if (cliente.ApellidoyNombre != null)
	        {
		        legajos = context.legajos.Where (x => x.clientes.ApellidoyNombre.Contains(cliente.ApellidoyNombre)).ToList();
	        }
            else if (cliente.Financiera != "" && cliente.Legajo != "")
            {
                try 
	            {	        
                    long codigoEmpresa = Convert.ToInt64(cliente.Financiera);
                    long numeroEmpresa = Convert.ToInt64(cliente.Legajo);

                    legajos = context.legajos.Where(x => x.CodigoEmpresa == codigoEmpresa && x.NumeroEmpresa == numeroEmpresa).ToList();
                    
	            }
	            catch (Exception)
	            {
                    return View("ClientesListado");
	            }
            }

            return View("ClientesListado",legajos);

        }

        [HttpPost]
        public ActionResult GetDatosCliente()
        {
            return View();
        }
    }
}
