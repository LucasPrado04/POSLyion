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
            if (restaurar.Visible == true)
            {
                restaurar.Visible = false;
                maximizar.Visible = true;
                WindowState = FormWindowState.Normal;
            }
            else
            {
                if (restaurar.Visible == false)
                {
                    restaurar.Visible = true;
                    maximizar.Visible = false;
                    WindowState = FormWindowState.Maximized;
                }
            }
        }
    }
}
