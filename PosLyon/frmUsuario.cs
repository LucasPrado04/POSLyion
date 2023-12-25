using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosLyon.Utilidades;
using CapaEntidad;
using CapaNegocio;

namespace PosLyon
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            // Agrego los valores que debe tener la lista desplegable de tipo booleano
            comboEstado.Items.Add(new OpcionCombo() { valor = 1, texto = "Activo" });
            comboEstado.Items.Add(new OpcionCombo() { valor = 0, texto = "Inactivo" });
            // DisplayMember (el valor que debe mostrar)
            comboEstado.DisplayMember = "texto";
            // ValueMember (el valor que va a manejar internamente)
            comboEstado.ValueMember = "valor";
            // SelectedIndex (el valor que va a mostrar primero)
            comboEstado.SelectedIndex = 0;

            // Cargar en label comboRol los roles de la base de datos
            List<Rol> lista_rol = new CN_Rol().Listar();
            foreach (Rol item_rol in lista_rol)
            {
                comboRol.Items.Add(new OpcionCombo() { valor = item_rol.id_rol, texto = item_rol.descripcion });
            }
            comboRol.DisplayMember = "texto";
            comboRol.ValueMember = "valor";
            comboRol.SelectedIndex = 0;

            // Cargar en label comboBusqueda las columnas permitidas del data grid view
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    comboBusqueda.Items.Add(new OpcionCombo() { valor = columna.Name, texto = columna.HeaderText });
                }
            }
            comboBusqueda.DisplayMember = "texto";
            comboBusqueda.ValueMember = "valor";
            comboBusqueda.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Cuando se aprete el botón guardar, se mostrarán los datos en el data view grid de usuario:
            dgvData.Rows.Add(new object[] 
            {
                "", 
                txtid.Text, 
                txtdni.Text, 
                txtinombre_completo.Text,
                txtemail.Text, 
                txtclave.Text, 
                ((OpcionCombo)comboRol.SelectedItem).valor.ToString(), 
                ((OpcionCombo)comboRol.SelectedItem).texto.ToString(),
                ((OpcionCombo)comboEstado.SelectedItem).valor.ToString(),
                ((OpcionCombo)comboEstado.SelectedItem).texto.ToString()
            });
            this.Limpiar();
        }

        private void Limpiar()
        {
            txtid.Text = "0";
            txtdni.Text = "";
            txtinombre_completo.Text = "";
            txtemail.Text = "";
            txtclave.Text = "";
            txtconfirmar_clave.Text = "";
            comboRol.SelectedIndex = 0;
            comboEstado.SelectedIndex = 0;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
