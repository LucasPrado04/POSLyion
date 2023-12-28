using CapaEntidad;
using CapaNegocio;
using PosLyon.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosLyon
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
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

            // Mostrar la lista de clientes de la base de datos
            List<Cliente> lista_cliente = new CN_Cliente().Listar();
            foreach (Cliente item_cliente in lista_cliente)
            {
                dgvData.Rows.Add(new object[]
            {
                "",
                item_cliente.id_cliente,
                item_cliente.dni,
                item_cliente.nombre_completo,
                item_cliente.email,
                item_cliente.telefono,
                // Si el valor del estado es verdadero, retorna 1, sino 0
                item_cliente.estado == true ? 1 : 0,
                // Si el valro del estado es verdadero, retorna "Activo", sino "Inactivo"
                item_cliente.estado == true ? "Activo" : "Inactivo"
                });
            }
        }

        // Funcion que guarda o edita un cliente de la BD
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            // Se capturan los datos de los label y se guardan en un objeto de tipo Cliente
            Cliente cliente = new Cliente()
            {
                id_cliente = Convert.ToInt32(txtid.Text),
                dni = txtdni.Text,
                nombre_completo = txtnombre_completo.Text,
                email = txtemail.Text,
                telefono = txttelefono.Text,
                estado = Convert.ToInt32(((OpcionCombo)comboEstado.SelectedItem).valor) == 1 ? true : false
            };
            // Si no se está seleccionando ningún cliente del DataGridView
            if (cliente.id_cliente == 0)
            {
                // CN_Cliente retorna el id del cliente si se generó correctamente
                int id_cliente_generado = new CN_Cliente().Registrar(cliente, out mensaje);
                // Cuando se aprete el botón guardar, se mostrarán los datos en el data view grid de cliente:
                // Si el cliente se generó correctamente (que el id no sea cero), se añade a la lista
                if (id_cliente_generado != 0)
                {
                    dgvData.Rows.Add(new object[]
                    {
                    "",
                    id_cliente_generado,
                    txtdni.Text,
                    txtnombre_completo.Text,
                    txtemail.Text,
                    txttelefono.Text,
                    ((OpcionCombo)comboEstado.SelectedItem).valor.ToString(),
                    ((OpcionCombo)comboEstado.SelectedItem).texto.ToString()

                    });
                    this.Limpiar();
                }
                // Si el cliente no se generó correctamente, muestra el mensaje de error del procedimiento de la BD
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            // Si se seleccionó un cliente del DataGridView y se presiona guardar, se edita el cliente
            else
            {
                bool resultado = new CN_Cliente().Editar(cliente, out mensaje);
                if (resultado)
                {
                    DataGridViewRow fila = dgvData.Rows[Convert.ToInt32(txtindice.Text)];
                    fila.Cells["id"].Value = txtid.Text;
                    fila.Cells["dni"].Value = txtdni.Text;
                    fila.Cells["nombre_completo"].Value = txtnombre_completo.Text;
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

        // Función que limpia los label del fornulario de cliente
        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtdni.Text = "";
            txtnombre_completo.Text = "";
            txtemail.Text = "";
            txttelefono.Text = "";
            comboEstado.SelectedIndex = 0;
            txtdni.Select();
        }

        // Funcion que elimina un cliente de la BD.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Si seleccionó un cliente de la lista de clientes
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                // Si selecciona que si desea eliminar
                if (MessageBox.Show("¿Está seguro que desea eliminar al cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    // Se capturan los datos de los label y se guardan en un objeto de tipo Cliente
                    Cliente cliente = new Cliente()
                    {
                        id_cliente = Convert.ToInt32(txtid.Text)
                    };
                    bool respuesta = new CN_Cliente().Eliminar(cliente, out mensaje);
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
                    txtdni.Text = dgvData.Rows[indice_fila].Cells["dni"].Value.ToString();
                    txtnombre_completo.Text = dgvData.Rows[indice_fila].Cells["nombre_completo"].Value.ToString();
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
