using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosLyon
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void minim_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void rest_Click(object sender, EventArgs e)
        {
            restauracion();
        }

        private void maxim_Click(object sender, EventArgs e)
        {
            restauracion();
        }

        private void restauracion()
        {
            if (rest.Visible == true)
            {
                rest.Visible = false;
                maximizar.Visible = true;
                WindowState = FormWindowState.Normal;
            }
            else
            {
                if (rest.Visible == false)
                {
                    rest.Visible = true;
                    maximizar.Visible = false;
                    WindowState = FormWindowState.Maximized;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cConfig.Visible == false)
            {
                cCompra.Visible = true;
                vVenta.Visible = true;
                rRegister.Visible = true;
                sStock.Visible = true;
                cConfig.Visible = true;
            }
            else
            {
                cCompra.Visible = false;
                vVenta.Visible = false;
                rRegister.Visible = false;
                sStock.Visible = false;
                cConfig.Visible = false;
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cCompra_Click(object sender, EventArgs e)
        {
            Form compra = new Compra();
            compra.Show();
        }
    }
}
