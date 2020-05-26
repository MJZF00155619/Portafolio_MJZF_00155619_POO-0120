using System;
using System.Windows.Forms;

namespace Pre_Parcial
{
    public partial class HisotorialPedidos : UserControl
    {
        public HisotorialPedidos()
        {
            InitializeComponent();
        }

        private void HisotorialPedidos_Load(object sender, EventArgs e)
        {
            try
            {
                var dt = Conexion.realizarConsulta("SELECT id_pedido, codigo_articulo, nombre_user," 
                +"cantidad, nombre_art, precio FROM PEDIDO inner join INVENTARIO on codigo_articulo = id_articulo");
                dataGridView1.DataSource = dt;
            
            }
            catch (Exception esg)
            {
                MessageBox.Show("Ha cocurrido un problema");
            }

        }
    }
}