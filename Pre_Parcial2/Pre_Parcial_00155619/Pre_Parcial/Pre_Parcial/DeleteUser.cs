using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Pre_Parcial
{
    public partial class DeleteUser : UserControl
    {
        public DeleteUser()
        {
            InitializeComponent();
        }
        private void DeleteUser_Load(object sender, EventArgs e)
        {
            var names = Conexion.realizarConsulta("SELECT nombre FROM usuario");
            var namesCombo = new List<string>();
            foreach (DataRow dr in names.Rows)
            {
                namesCombo.Add(dr[0].ToString());
            }

            comboBox1.DataSource = namesCombo;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{

                string nonQuery = $"DELETE FROM USUARIO WHERE nombre='{comboBox1.SelectedItem.ToString()}'";

                Conexion.realizarAccion(nonQuery);
                MessageBox.Show("Usuario Eliminado");
            //}
          /*  catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error!");
            }*/

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        
    }
}