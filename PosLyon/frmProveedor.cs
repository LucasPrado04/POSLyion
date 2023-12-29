using CapaEntidad;
using CapaNegocio;
using PosLyon.Utilidades;
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
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
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

            // Mostrar la lista de proveedores de la base de datos
            List<Proveedor> lista_proveedor = new CN_Proveedor().Listar();
            foreach (Proveedor item_proveedor in lista_proveedor)
            {
                dgvData.Rows.Add(new object[]
            {
                "",
                item_proveedor.id_proveedor,
                item_proveedor.cuit,
                item_proveedor.razon_social,
                item_proveedor.email,
                item_proveedor.telefono,
                // Si el valor del estado es verdadero, retorna 1, sino 0
                item_proveedor.estado == true ? 1 : 0,
                // Si el valro del estado es verdadero, retorna "Activo", sino "Inactivo"
                item_proveedor.estado == true ? "Activo" : "Inactivo"
                });
            }
        }

        // Funcion que guarda o edita un proveedor de la BD
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            // Se capturan los datos de los label y se guardan en un objeto de tipo Proveedor
            Proveedor proveedor = new Proveedor()
            {
                id_proveedor = Convert.ToInt32(txtid.Text),
                cuit = txtcuit.Text,
                razon_social = txtrazon_social.Text,
                email = txtemail.Text,
                telefono = txttelefono.Text,
                estado = Convert.ToInt32(((OpcionCombo)comboEstado.SelectedItem).valor) == 1 ? true : false
            };
            // Si no se está seleccionando ningún proveedor del DataGridView
            if (proveedor.id_proveedor == 0)
            {
                // CN_Proveedor retorna el id del proveedor si se generó correctamente
                int id_proveedor_generado = new CN_Proveedor().Registrar(proveedor, out mensaje);
                // Cuando se aprete el botón guardar, se mostrarán los datos en el data view grid de proveedor:
                // Si el proveedor se generó correctamente (que el id no sea cero), se añade a la lista
                if (id_proveedor_generado != 0)
                {
                    dgvData.Rows.Add(new object[]
                    {
                    "",
                    id_proveedor_generado,
                    txtcuit.Text,
                    txtrazon_social.Text,
                    txtemail.Text,
                    txttelefono.Text,
                    ((OpcionCombo)comboEstado.SelectedItem).valor.ToString(),
                    ((OpcionCombo)comboEstado.SelectedItem).texto.ToString()

                    });
                    this.Limpiar();
                }
                // Si el proveedor no se generó correctamente, muestra el mensaje de error del procedimiento de la BD
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            // Si se seleccionó un proveedor del DataGridView y se presiona guardar, se edita el proveedor
            else
            {
                bool resultado = new CN_Proveedor().Editar(proveedor, out mensaje);
                if (resultado)
                {
                    DataGridViewRow fila = dgvData.Rows[Convert.ToInt32(txtindice.Text)];
                    fila.Cells["id"].Value = txtid.Text;
                    fila.Cells["cuit"].Value = txtcuit.Text;
                    fila.Cells["razon_social"].Value = txtrazon_social.Text;
                    fila.Cells["email"].Value = txtemail.Text;
                    fila.Cells["telefono"].Value = txttelefono.Text;
                    fila.Cells["estado_valor"].Value = ((OpcionCombo)comboEstado.SelectedItem).valor.ToString();
                    fila.Cells["estado"].Value = ((OpcionCombo)comboEstado.SelectedItem).texto.ToString();
                    this.Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        // Función que limpia los label del fornulario de proveedor
        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtcuit.Text = "";
            txtrazon_social.Text = "";
            txtemail.Text = "";
            txttelefono.Text = "";
            comboEstado.SelectedIndex = 0;
            txtcuit.Select();
        }

        // Funcion que elimina un proveedor de la BD.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Si seleccionó un proveedor de la lista de proveedores
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                // Si selecciona que si desea eliminar
                if (MessageBox.Show("¿Está seguro que desea eliminar al proveedor?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    // Se capturan los datos de los label y se guardan en un objeto de tipo Proveedor
                    Proveedor proveedor = new Proveedor()
                    {
                        id_proveedor = Convert.ToInt32(txtid.Text)
                    };
                    bool respuesta = new CN_Proveedor().Eliminar(proveedor, out mensaje);
                    if (respuesta)
                    {
                        dgvData.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        this.Limpiar();
                    }
                    else
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
                    txtcuit.Text = dgvData.Rows[indice_fila].Cells["cuit"].Value.ToString();
                    txtrazon_social.Text = dgvData.Rows[indice_fila].Cells["razon_social"].Value.ToString();
                    txtemail.Text = dgvData.Rows[indice_fila].Cells["email"].Value.ToString();
                    txttelefono.Text = dgvData.Rows[indice_fila].Cells["telefono"].Value.ToString();
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
            if (dgvData.Rows.Count == 0)
            {

            }
            // Si hay filas en el DataGridView
            else
            {
                // Comienza a filtrar por el item seleccionado en la lista desplegable
                foreach (DataGridViewRow fila in dgvData.Rows)
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
    }
}
