using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto.Models;
namespace Proyecto.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            return View(Listado());
        }
    //Metodo retorna una lista
    public IEnumerable<Producto> Listado()
        {
            var productos = new List<Producto>()
            {
                new Producto(){IdProducto= 1, Nombre="Audifonos", Precio=Convert.ToDecimal("5000"),RutaImagen="../imagenes/parlantes.png"},
                new Producto(){IdProducto= 2, Nombre="Mouse", Precio=Convert.ToDecimal("6.800"),RutaImagen="../imagenes/mouse.png"}
            };
            return productos;
        }
    }

}