using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pre_Parcial
{
    public partial class NewUser : UserControl
    {
        public NewUser()
        {
            InitializeComponent();
            var user = new List<bool>{true,false};
            comboBox1.DataSource = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Equals("") ||
                textBox2.Equals(""))

            {
                MessageBox.Show("No puede dejar los campos vacios!");
            }
            else
            {
                try
                {
                    Conexion.realizarAccion($"INSERT INTO USUARIO(nombre,contraseña,admon) VALUES(" +
                                              $"'{textBox1.Text}'," +
                                              $"'{textBox2.Text}'," +
                                              $"{comboBox1.SelectedItem})");

                                              MessageBox.Show("USUARIO ANADIDO");
                }
                catch (Exception esg)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}