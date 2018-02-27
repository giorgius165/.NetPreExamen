using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaExamen.Models
{
    public class TrabajadorModelo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public List<int> AlmacenesSeleccionados { get; set; }
        public List<AlmacenTrabajadorModelo> AlmacenTrabajador { get; set; }
    }
}