using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consulta_Empresa
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {
      PedidosDB pedidosDB = new PedidosDB();
      var pedidos = pedidosDB.ObtenerPedidosConClientes();
      dgvPedidos.DataSource = pedidos;

    }

    private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
  }
}
