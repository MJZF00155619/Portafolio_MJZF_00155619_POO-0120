using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Pre_Parcial
{
    public partial class ModUser : UserControl
    {
        public ModUser()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ModUser_Load(object sender, EventArgs e)
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
            if (textBox1.Text.Equals(""))
                
            {
                MessageBox.Show("No puede dejar los campos vacios");
            }
            else
            {

                try
                {

                    string nonQuery = $"UPDATE USUARIO set nombre='{textBox1.Text}',contraseña='{textBox2.Text}'" +
                                      $"WHERE nombre='{comboBox1.SelectedItem.ToString()}'";

                   Conexion.realizarAccion(nonQuery);
                    MessageBox.Show("Usuario Modificado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error!");
                }
            }
        }
    }
    }
