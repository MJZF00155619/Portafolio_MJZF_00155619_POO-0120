using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pre_Parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                

                var dn = Conexion.realizarConsulta($"SELECT nombre FROM USUARIO WHERE nombre = '{textBox1.Text}'");
                var dr1 = dn.Rows[0];

                var dc2 = Conexion.realizarConsulta($"SELECT contraseña FROM USUARIO WHERE nombre = '{textBox1.Text}'");
                var dr2 = dc2.Rows[0];


                if (dr1[0].ToString().Equals(textBox1.Text) && dr2[0].ToString().Equals(textBox2.Text))
                {
                    var dt = Conexion.realizarConsulta($"SELECT ADMON FROM USUARIO WHERE nombre='{textBox1.Text}'");
                    var dr = dt.Rows[0];

                    if (dr[0].ToString() == "True")
                    {
                        FormAdmon frmA = new FormAdmon();
                        frmA.Show();
                    }
                    else if (dr[0].ToString() == "False")
                    {
                        string usuario = textBox1.Text;
                        FormNoAdmon frmN = new FormNoAdmon(usuario);
                        frmN.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos incorrectos");
            }
        }
    }
}