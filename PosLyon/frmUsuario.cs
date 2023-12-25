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

            // Mostrar la lista de usuarios de la base de datos
            List<Usuario> lista_usuario = new CN_Usuario().Listar();
            foreach (Usuario item_usuario in lista_usuario)
            {
                dgvData.Rows.Add(new object[]
            {
                "",
                item_usuario.id_usuario,
                item_usuario.dni,
                item_usuario.nombre_completo,
                item_usuario.email,
                item_usuario.clave,
                item_usuario.Rol.id_rol,
                item_usuario.Rol.descripcion,
                // Si el valor del estado es verdadero, retorna 1, sino 0
                item_usuario.estado == true ? 1 : 0,
                // Si el valro del estado es verdadero, retorna "Activo", sino "Inactivo"
                item_usuario.estado == true ? "Activo" : "Inactivo"
                });
            }
        }

        // Funcion que guarda o edita un usuario de la BD
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            // Se capturan los datos de los label y se guardan en un objeto de tipo Usuario
            Usuario usuario = new Usuario()
            {
                id_usuario = Convert.ToInt32(txtid.Text),
                dni = txtdni.Text,
                nombre_completo = txtnombre_completo.Text,
                email = txtemail.Text,
                clave = txtclave.Text,
                Rol = new Rol() { id_rol = Convert.ToInt32(((OpcionCombo)comboRol.SelectedItem).valor) },
                estado = Convert.ToInt32(((OpcionCombo)comboEstado.SelectedItem).valor) == 1 ? true : false
            };
            // Si no se está seleccionando ningún usuario del DataGridView
            if(usuario.id_usuario == 0)
            {
                // CN_Usuario retorna el id del usuario si se generó correctamente
                int id_usuario_generado = new CN_Usuario().Registrar(usuario, out mensaje);
                // Cuando se aprete el botón guardar, se mostrarán los datos en el data view grid de usuario:
                // Si el usuario se generó correctamente (que el id no sea cero)
                if (id_usuario_generado != 0)
                {
                    dgvData.Rows.Add(new object[]
                    {
                    "",
                    id_usuario_generado,
                    txtdni.Text,
                    txtnombre_completo.Text,
                    txtemail.Text,
                    txtclave.Text,
                    ((OpcionCombo)comboRol.SelectedItem).valor.ToString(),
                    ((OpcionCombo)comboRol.SelectedItem).texto.ToString(),
                    ((OpcionCombo)comboEstado.SelectedItem).valor.ToString(),
                    ((OpcionCombo)comboEstado.SelectedItem).texto.ToString()

                    });
                    this.Limpiar();
                    // Si el usuario no se generó correctamente, muestra el mensaje de error del procedimiento de la BD
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            // Si se seleccionó un usuario del DataGridView y se presiona guardar, se edita el usuario
            } else
            {
                bool resultado = new CN_Usuario().Editar(usuario, out mensaje);
                if (resultado)
                {
                    DataGridViewRow fila = dgvData.Rows[Convert.ToInt32(txtindice.Text)];
                    fila.Cells["id"].Value = txtid.Text;
                    fila.Cells["dni"].Value = txtdni.Text;
                    fila.Cells["nombre_completo"].Value = txtnombre_completo.Text;
                    fila.Cells["email"].Value = txtemail.Text;
                    fila.Cells["clave"].Value = txtclave.Text;
                    fila.Cells["id_rol"].Value = ((OpcionCombo)comboRol.SelectedItem).valor.ToString();
                    fila.Cells["rol"].Value = ((OpcionCombo)comboRol.SelectedItem).texto.ToString();
                    fila.Cells["estado_valor"].Value = ((OpcionCombo)comboEstado.SelectedItem).valor.ToString();
                    fila.Cells["estado"].Value = ((OpcionCombo)comboEstado.SelectedItem).texto.ToString();
                    this.Limpiar();
                } else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        // Función que limpia los label del fornulario de usuario
        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtdni.Text = "";
            txtnombre_completo.Text = "";
            txtemail.Text = "";
            txtclave.Text = "";
            txtconfirmar_clave.Text = "";
            comboRol.SelectedIndex = 0;
            comboEstado.SelectedIndex = 0;
            txtdni.Select();
        }

        // Funcion que elimina un usuario de la BD.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Si seleccionó un usuario de la lista de usuarios
            if(Convert.ToInt32(txtid.Text) != 0)
            {
                // Si selecciona que si desea eliminar
                if(MessageBox.Show("¿Está seguro que desea eliminar al usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    // Se capturan los datos de los label y se guardan en un objeto de tipo Usuario
                    Usuario usuario = new Usuario()
                    {
                        id_usuario = Convert.ToInt32(txtid.Text)
                    };
                    bool respuesta = new CN_Usuario().Eliminar(usuario, out mensaje);
                    if(respuesta)
                    {
                        dgvData.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        this.Limpiar();
                    } else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        // Función para mostrar datos de un registro en el formulario de usuario para guardar/editar
        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name != "btnSeleccionar")
            {

            }
            else
                {
                int indice_fila = e.RowIndex;
                // Si la fila donde se accionó el btnSeleccionar no es la cabecera, se copian los valores del DataGridView al formulario
                if (indice_fila >= 0)
                {
                    txtindice.Text = indice_fila.ToString();
                    txtid.Text = dgvData.Rows[indice_fila].Cells["id"].Value.ToString();
                    txtdni.Text = dgvData.Rows[indice_fila].Cells["dni"].Value.ToString();
                    txtnombre_completo.Text = dgvData.Rows[indice_fila].Cells["nombre_completo"].Value.ToString();
                    txtemail.Text = dgvData.Rows[indice_fila].Cells["email"].Value.ToString();
                    txtclave.Text = dgvData.Rows[indice_fila].Cells["clave"].Value.ToString();
                    txtconfirmar_clave.Text = dgvData.Rows[indice_fila].Cells["clave"].Value.ToString();
                    foreach (OpcionCombo opcioncombo in comboRol.Items)
                    {
                        if (Convert.ToInt32(opcioncombo.valor) == Convert.ToInt32(dgvData.Rows[indice_fila].Cells["id_rol"].Value))
                        {
                            int indice_combo = comboRol.Items.IndexOf(opcioncombo);
                            comboRol.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                    foreach (OpcionCombo opcioncombo in comboEstado.Items)
                    {
                        if (Convert.ToInt32(opcioncombo.valor) == Convert.ToInt32(dgvData.Rows[indice_fila].Cells["estado_valor"].Value))
                        {
                            int indice_combo = comboEstado.Items.IndexOf(opcioncombo);
                            comboEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columna_filtro = ((OpcionCombo)comboBusqueda.SelectedItem).valor.ToString();
            
            if(dgvData.Rows.Count == 0)
            {

            }
            // Si hay filas en el DataGridView
            else
            {
                // Comienza a filtrar por el item seleccionado en la lista desplegable
                foreach(DataGridViewRow fila in dgvData.Rows)
                {
                    if (fila.Cells[columna_filtro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        fila.Visible = true;
                    else
                        fila.Visible = false;
                }
            }
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow fila in dgvData.Rows)
            {
                fila.Visible = true;
            }
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
