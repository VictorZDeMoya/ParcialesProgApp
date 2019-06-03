using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PAParcial1_VictorZDeMoya.Entidades
{
    public class Producto
    {
        [Key]
        public float ValorInv { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public float Costo { get; set; }
        public int IdProducto { get; set; }

        public Producto()
        {
            ValorInv = 0;
            Descripcion = string.Empty;
            Existencia = 0;
            Costo = 0;
            IdProducto = 0;
        }
    }
}