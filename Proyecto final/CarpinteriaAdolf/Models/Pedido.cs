using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pedido
{
    public int IdPedido { get; set; }
    public int IdCliente { get; set; }  // ← Referencia al cliente
    public DateTime FechaPedido { get; set; }
    public DateTime FechaEntrega { get; set; }
    public string Estado { get; set; }
    public decimal CostoTotal { get; set; }

}
