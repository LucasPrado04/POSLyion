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
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void btnDatos_Negocio_Click(object sender, EventArgs e)
        {
            frmNegocio frmNegocio = new frmNegocio();
            frmNegocio.Show();
        }
    }
}
