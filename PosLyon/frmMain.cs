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
using System.Security.Cryptography;

namespace PosLyon
{
    public partial class frmMain : Form {

        private static Usuario usuario_actual;

        // Inicio sin logeo con permisos de administrador
        public frmMain(Usuario usuario = null) {
            if (usuario == null) usuario_actual = new Usuario() { nombre_completo = "ADMIN", id_usuario = 2 };
            else
                usuario_actual = usuario;
            //usuario_actual = usuario;
            InitializeComponent();
        }

        // Inicio normal con conexión a BD
        //public frmMain(Usuario usuario)
        //{
        //    usuario_actual = usuario;
        //    InitializeComponent();
        //}

        private void Inicio_Load(object sender, EventArgs e) {
            List<Permiso> listapermisos = new CN_Permiso().Listar(usuario_actual.id_usuario);
            // PENDIENTE: Construir una función para que muestre los menús según el rol del usuario y sus permisos
            lblusuario.Text = usuario_actual.nombre_completo;
        }

        // LINEA 43 A 104 NAVBAR
        private void menu_compra_Click(object sender, EventArgs e)
        {
            Form frmCompra = new frmCompra();
            frmCompra.Show();
        }

        private void menu_venta_Click(object sender, EventArgs e)
        {
            frmVenta frmVenta = new frmVenta();
            frmVenta.Show();
        }

        private void menu_stock_Click(object sender, EventArgs e)
        {
            frmReporte frmReporte = new frmReporte();
            frmReporte.Show();
        }

        private void menu_registro_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.Show();
        }

        private void menu_producto_Click(object sender, EventArgs e)
        {
            frmProducto frmProducto = new frmProducto();
            frmProducto.Show();
        }

        private void menu_categoria_Click(object sender, EventArgs e)
        {
            frmCategoria frmCategoria = new frmCategoria();
            frmCategoria.Show();
        }

        private void menu_cliente_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();
            frmCliente.Show();
        }


        private void menu_proveedor_Click(object sender, EventArgs e)
        {
            frmProveedor frmProveedor = new frmProveedor();
            frmProveedor.Show();
        }

        private void menu_config_Click(object sender, EventArgs e)
        {
            frmConfiguracion frmConfiguracion = new frmConfiguracion();
            frmConfiguracion.Show();
        }

        private void menu_usuario_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.Show();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Close();
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
                menu_producto.Visible = true;
                menu_categoria.Visible = true;
                menu_cliente.Visible = true;
                menu_proveedor.Visible = true;
                menu_usuario.Visible = true;
            }
            else
            {
                menu_compra.Visible = false;
                menu_venta.Visible = false;
                menu_registro.Visible = false;
                menu_stock.Visible = false;
                menu_config.Visible = false;
                menu_producto.Visible = false;
                menu_categoria.Visible = false;
                menu_cliente.Visible = false;
                menu_proveedor.Visible = false;
                menu_usuario.Visible = false;
            }
        }
    }
}
