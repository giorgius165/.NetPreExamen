using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaExamen.Models
{
    public class AlmacenModelo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Tamanyo { get; set; }
        public List<MaterialModelo> Materiales { get; set; }
        public List<int> TrabajadoresSeleccionados { get; set; }
        public List<AlmacenTrabajadorModelo> AlmacenTrabajador { get; set; }
    }
}