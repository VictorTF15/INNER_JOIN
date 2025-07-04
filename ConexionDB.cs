using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Consulta_Empresa
{
  public class ConexionDB
  {
    private string cadenaConexion = "Data Source = localhost \\SQLEXPRESS2019;Initial Catalog= Empresa;Integrated Security= True;";

    public SqlConnection ObtenerConexion() 
    {
      return new SqlConnection(cadenaConexion);
    }
  }
}
