using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proyecto.Data
{
    //realiza la conexion con la base de datos
    public class ContextoProducto: DbContext 
    {
        public ContextoProducto(): base("conexionproductos") { }
        public DbSet<Producto> Productos { get; set; }
    }
}