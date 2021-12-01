using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class Producto
    {
        //Objetos que va a tener el producto

        public int IdProducto { get; set; }
        public string Nombre { get; set;}
        public decimal Precio { get; set; }
        public string RutaImagen { get; set; }
    }
}