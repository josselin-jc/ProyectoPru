using Proyecto.Data;
using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Repositories
{
    public class RepositoryProducto
    {
        ContextoProducto contexto;
        public RepositoryProducto()
        {
            this.contexto = new ContextoProducto();
        }
        //Creamos metodos para obtener una lista de productos 
        //Primero obtenemos los datos 
        public List<Producto> GetProductos()
        {
            var consulta = from datos in contexto.Productos select datos;
            return consulta.ToList();
        }
        //Segundo obtenemos los id donde se guardan los productos donde  la consulta busca el espefifico id
        public List<Producto> BuscarProductos(List<int> id)
        {
            var consulta = from datos in contexto.Productos where id.Contains(datos.IdProducto) select datos;
            return consulta.ToList();
        }
    }
   
}
