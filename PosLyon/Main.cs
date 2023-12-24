using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace PosLyon
{
    public partial class Main : Form {

        private static Usuario usuario_actual;

        public Main(Usuario usuario) {
            usuario_actual = usuario;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e) {
            List<Permiso> listapermisos = new CN_Permiso().Listar(usuario_actual.id_usuario);
            // PENDIENTE: Construir una función para que muestre los menús según el rol del usuario y sus permisos
            lblusuario.Text = usuario_actual.nombre_completo;
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
            if (menu_config.Visible == false)
            {
                menu_compra.Visible = true;
                menu_venta.Visible = true;
                menu_registro.Visible = true;
                menu_stock.Visible = true;
                menu_config.Visible = true;
                // NO FUNCIONA:
                menu_producto.Visible = true;
            }
            else
            {
                menu_compra.Visible = false;
                menu_venta.Visible = false;
                menu_registro.Visible = false;
                menu_stock.Visible = false;
                menu_config.Visible = false;
                // NO FUNCIONA: 
                menu_producto.Visible = false;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rRegister_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void menu_config_Click(object sender, EventArgs e)
        {

        }
    }
}
