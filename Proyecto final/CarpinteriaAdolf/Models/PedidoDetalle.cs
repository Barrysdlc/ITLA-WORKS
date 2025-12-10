using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaAdolf.Models
{
    public class PedidoDetalle
    {
        public int IdPedidoMueble { get; set; }
        public int IdPedido { get; set; }
        public int IdMueble { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Subtotal { get; set; }
    }
}

