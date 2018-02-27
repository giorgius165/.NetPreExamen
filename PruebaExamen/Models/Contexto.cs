using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PruebaExamen.Models
{
    public class Contexto: DbContext
    {
        public DbSet<AlmacenModelo> Almacenes { get; set; }
        public DbSet<MaterialModelo> Materiales { get; set; }
        public DbSet<TrabajadorModelo> Trabajadores { get; set; }
        public DbSet<AlmacenTrabajadorModelo> AlmacenesTrabajadores { get; set; }
    }
}