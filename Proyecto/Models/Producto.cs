using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Bibliotecas necesarias
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models
{
    [Table("Productos")]
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        
        [Column("IdProducto")]
        public int IdProducto { get; set; }

        [Column("Nombre")]
        public string Nombre { get; set; }

        [Column("Precio")]
        public int Precio { get; set; }

        [Column("Imagen")]
        public string Imagen { get; set; }

    }
}