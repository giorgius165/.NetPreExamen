using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaExamen.Models
{
    public class AlmacenTrabajadorModelo
    {
        public int ID { get; set; }
        public int AlmacenID { get; set; }
        public AlmacenModelo Almacen { get; set; }
        public int TrabajadorID { get; set; }
        public TrabajadorModelo Trabajador { get; set; }
    }
}