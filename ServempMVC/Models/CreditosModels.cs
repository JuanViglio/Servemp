using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace ServempMVC.Models
{
    public class CreditosContext : DbContext
    {
        public CreditosContext() : base("DefaultConnection")
        {
            Database.SetInitializer<CreditosContext>(null);
        }

        public DbSet<Clientes> Clientes { get; set; }
    }

    [Table("clientes")]
    public class Clientes
    {
        [Key]
        public string Codigo { get; set; }
        public string ApellidoyNombre { get; set; }

    }
}
