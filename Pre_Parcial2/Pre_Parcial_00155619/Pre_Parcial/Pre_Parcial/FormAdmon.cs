using System;
using System.Windows.Forms;

namespace Pre_Parcial
{
    public partial class FormAdmon : Form
    {
        private UserControl current = null;
        public FormAdmon()
        {
            InitializeComponent();
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new NewUser();
            current.Dock = DockStyle.Fill;
           tableLayoutPanel1.Controls.Add(current,4,0);
           tableLayoutPanel1.SetRowSpan(current, 4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new DelInv();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,4,0);
            tableLayoutPanel1.SetRowSpan(current, 4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new ModUser();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,4,0);
            tableLayoutPanel1.SetRowSpan(current, 4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new DeleteUser();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,4,0);
            tableLayoutPanel1.SetRowSpan(current, 4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new NewInv();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,4,0);
            tableLayoutPanel1.SetRowSpan(current, 4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new ModInv();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,4,0);
            tableLayoutPanel1.SetRowSpan(current, 4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new HisotorialPedidos();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,4,0);
            tableLayoutPanel1.SetRowSpan(current, 4);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}