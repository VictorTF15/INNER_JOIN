using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace Consulta_Empresa
{
  public class PedidosDB
  {
    private ConexionDB conexion = new ConexionDB();
    public List<Pedidos> ObtenerPedidosConClientes() 
    {
      List<Pedidos> lista = new List<Pedidos>();

      using (var conn = conexion.ObtenerConexion()) 
      { 
        conn.Open();
        string sql = @"select p.id_pedido, p.fecha, p.monto, c.nombre from Pedidos p inner join Clientes c on p.id_cliente = c.id_cliente";

        SqlCommand cmd = new SqlCommand(sql,conn);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read()) 
        {
          Pedidos ped = new Pedidos()
          {
            IdPedido = reader.GetInt32(0),
            Fecha = reader.GetDateTime(1),
            Monto = reader.GetDecimal(2),
            NombreCliente = reader.GetString(3)
          };
          lista.Add(ped);
        }
      }
      return lista;
    }
  }
}
