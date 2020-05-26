using System;
using System.Windows.Forms;

namespace Pre_Parcial
{
    public partial class NewInv : UserControl
    {
        public NewInv()
        {
            InitializeComponent();
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
                    Conexion.realizarAccion($"INSERT INTO INVENTARIO(nombre_art,descripcion," +
                                            $"precio,stock) VALUES(" +
                                            $"'{textBox1.Text}'," +
                                            $"'{textBox2.Text}'," +
                                            $"{textBox3.Text}," +
                                            $"{textBox4.Text})");

                    MessageBox.Show("Articulo Añadido");
                }
                catch (Exception esg)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}