using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Pre_Parcial
{
    public partial class DelInv : UserControl
    {
        public DelInv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nonQuery = $"DELETE FROM INVENTARIO WHERE nombre_art='{comboBox1.SelectedItem.ToString()}'";
                Conexion.realizarAccion(nonQuery);
                MessageBox.Show("Articulo Eliminado");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void DelInv_Load(object sender, EventArgs e)
        {
            var names = Conexion.realizarConsulta("SELECT nombre_art FROM inventario");
            var namesCombo = new List<string>();
            foreach (DataRow dr in names.Rows)
            {
                namesCombo.Add(dr[0].ToString());
            }

            comboBox1.DataSource = namesCombo;
        }
    }
}