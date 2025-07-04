using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta_Empresa
{
  public class Pedidos
  {
    public int IdPedido { get; set; }
    public DateTime Fecha { get; set; }
    public decimal Monto { get; set; }
    public string NombreCliente { get; set; }
  }
}
