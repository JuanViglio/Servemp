﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace ServempMVC.Models
{
    public class BuscadorClientes
    {
        public string Codigo { get; set; }
        public string ApellidoyNombre { get; set; }
        public SelectListItem[] ListaTipoDocumento()
        {
            return new SelectListItem[4] {  new SelectListItem() { Text = "DNI" }, 
                                            new SelectListItem() { Text = "LIBRETA DE ENROLAMIENTO" },
                                            new SelectListItem() { Text = "LIBRETA CIVICA" },
                                            new SelectListItem() { Text = "CEDULA DE IDENTIDAD" }
                                        };
        }
        public string TipoDocumentoSeleccionado { get; set; }

        public string Legajo { get; set; }

        public string Financiera { get; set; }
    }

}
