using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Pre_Parcial
{
    public partial class ModInv : UserControl
    {
        public ModInv()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
                
            {
                MessageBox.Show("No puede dejar los campos vacios");
            }
            else
            {

               try
                {

                    string nonQuery = $"UPDATE INVENTARIO set stock={textBox1.Text}" +
                                      $"WHERE nombre_art='{comboBox1.SelectedItem.ToString()}'";

                    Conexion.realizarAccion(nonQuery);
                    MessageBox.Show("Stock Modificado");
               }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error!");
                }
            }
        }

        private void ModInv_Load(object sender, EventArgs e)
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