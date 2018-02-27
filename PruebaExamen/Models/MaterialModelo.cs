
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaExamen.Models
{
    public class MaterialModelo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Peso { get; set; }
        public int AlmacenID { get; set; }
        public AlmacenModelo Almacen { get; set; }
    }
}