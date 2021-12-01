using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class Pedido
    {


        //Objetos que va a tener el pedido

        public int IdPedido { get; set; }
        public Producto NomProducto { get; set; }
        public int Cantidad { get;set; }
        private decimal _Monto { get; set; }
        //Nos permite obtener la cantidad que debe pagar
        private decimal Monto
        {
            get
            {
                _Monto = (NomProducto.Precio = Cantidad);
                return _Monto;
            }
            set
            {
                _Monto = value;
            }
        }
        public decimal total { get; set; }
    }
}