using CapaEntidad;
using CapaNegocio;
using PosLyon.Utilidades;
using ClosedXML.Excel;
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
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
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

            // Cargar en label comboCategoria las categorías de la base de datos
            List<Categoria> lista_categoria = new CN_Categoria().Listar();
            foreach (Categoria item_categoria in lista_categoria)
            {
                comboCategoria.Items.Add(new OpcionCombo() { valor = item_categoria.id_categoria, texto = item_categoria.descripcion });
            }
            comboCategoria.DisplayMember = "texto";
            comboCategoria.ValueMember = "valor";
            comboCategoria.SelectedIndex = 0;

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

            // Mostrar la lista de productos de la base de datos
            List<Producto> lista_producto = new CN_Producto().Listar();
            foreach (Producto item_producto in lista_producto)
            {
                dgvData.Rows.Add(new object[]
            {
                "",
                item_producto.id_producto,
                item_producto.codigo,
                item_producto.descripcion,
                item_producto.categoria.id_categoria,
                item_producto.categoria.descripcion,
                item_producto.stock,
                item_producto.precio_costo,
                item_producto.precio_venta,
                // Si el valor del estado es verdadero, retorna 1, sino 0
                item_producto.estado == true ? 1 : 0,
                // Si el valro del estado es verdadero, retorna "Activo", sino "Inactivo"
                item_producto.estado == true ? "Activo" : "Inactivo"
                });
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            // Se capturan los datos de los label y se guardan en un objeto de tipo Producto
            Producto producto = new Producto()
            {
                id_producto = Convert.ToInt32(txtid.Text),
                codigo = txtcodigo.Text,
                descripcion = txtdescripcion.Text,
                categoria = new Categoria() { id_categoria = Convert.ToInt32(((OpcionCombo)comboCategoria.SelectedItem).valor) },
                estado = Convert.ToInt32(((OpcionCombo)comboEstado.SelectedItem).valor) == 1 ? true : false
            };
            // Si no se está seleccionando ningún producto del DataGridView
            if (producto.id_producto == 0)
            {
                // CN_Producto retorna el id del producto si se generó correctamente
                int id_producto_generado = new CN_Producto().Registrar(producto, out mensaje);
                // Cuando se aprete el botón guardar, se mostrarán los datos en el data view grid de producto:
                // Si el producto se generó correctamente (que el id no sea cero), se muestra en el DataGridView
                if (id_producto_generado != 0)
                {
                    dgvData.Rows.Add(new object[]
                    {
                    "",
                    id_producto_generado,
                    txtcodigo.Text,
                    txtdescripcion.Text,
                    ((OpcionCombo)comboCategoria.SelectedItem).valor.ToString(),
                    ((OpcionCombo)comboCategoria.SelectedItem).texto.ToString(),
                    "0",
                    "0.00",
                    "0.00",
                    ((OpcionCombo)comboEstado.SelectedItem).valor.ToString(),
                    ((OpcionCombo)comboEstado.SelectedItem).texto.ToString()

                    });
                    this.Limpiar();
                }
                // Si el producto no se generó correctamente, muestra el mensaje de error del procedimiento de la BD
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            // Si se seleccionó un producto del DataGridView y se presiona guardar, se edita el producto
            else
            {
                bool resultado = new CN_Producto().Editar(producto, out mensaje);
                if (resultado)
                {
                    DataGridViewRow fila = dgvData.Rows[Convert.ToInt32(txtindice.Text)];
                    fila.Cells["id"].Value = txtid.Text;
                    fila.Cells["codigo"].Value = txtcodigo.Text;
                    fila.Cells["descripcion"].Value = txtdescripcion.Text;
                    fila.Cells["id_categoria"].Value = ((OpcionCombo)comboCategoria.SelectedItem).valor.ToString();
                    fila.Cells["categoria"].Value = ((OpcionCombo)comboCategoria.SelectedItem).texto.ToString();
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

        // Función que limpia los label del fornulario de usuario
        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtcodigo.Text = "";
            txtdescripcion.Text = "";
            txtcantidad.Text = "";
            comboCategoria.SelectedIndex = 0;
            comboEstado.SelectedIndex = 0;
            txtcodigo.Select();
        }

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
                    txtcodigo.Text = dgvData.Rows[indice_fila].Cells["codigo"].Value.ToString();
                    txtdescripcion.Text = dgvData.Rows[indice_fila].Cells["descripcion"].Value.ToString();
                    txtcantidad.Text = dgvData.Rows[indice_fila].Cells["stock"].Value.ToString();
                    foreach (OpcionCombo opcioncombo in comboCategoria.Items)
                    {
                        if (Convert.ToInt32(opcioncombo.valor) == Convert.ToInt32(dgvData.Rows[indice_fila].Cells["id_categoria"].Value))
                        {
                            int indice_combo = comboCategoria.Items.IndexOf(opcioncombo);
                            comboCategoria.SelectedIndex = indice_combo;
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

        // Funcion que elimina un producto de la BD
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Si seleccionó un producto de la lista de productos
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                // Si selecciona que si desea eliminar
                if (MessageBox.Show("¿Está seguro que desea eliminar este producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    // Se capturan los datos de los label y se guardan en un objeto de tipo Producto
                    Producto producto = new Producto()
                    {
                        id_producto = Convert.ToInt32(txtid.Text)
                    };
                    bool respuesta = new CN_Producto().Eliminar(producto, out mensaje);
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

        // Funcion para exportar a un Excel
        private void btnExportar_Click(object sender, EventArgs e)
        {
            // Si no hay ninguna fila o dato cargado, no se exporta
            if (dgvData.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                // Se crea un objeto DataTable para almacenar la información del DataGridView
                DataTable datatable = new DataTable();
                // Se recorren y se recuperan las columnas, a excepción del botón seleccionar y si la columna está visible en caso de aplicar filtros
                foreach (DataGridViewColumn columna in dgvData.Columns)
                {
                    if(columna.HeaderText != "" && columna.Visible)
                        datatable.Columns.Add(columna.HeaderText, typeof(string));
                }
                // Se recorren y se recuperan las filas,si la misma está visible en caso de aplicar filtros
                foreach (DataGridViewRow fila in dgvData.Rows)
                {
                    if (fila.Visible)
                        datatable.Rows.Add(new object[]
                        {
                            fila.Cells[2].Value.ToString(), // Codigo de barras
                            fila.Cells[3].Value.ToString(), // Descripcion
                            fila.Cells[5].Value.ToString(), // Categoria
                            fila.Cells[6].Value.ToString(), // Stock
                            fila.Cells[7].Value.ToString(), // Costo
                            fila.Cells[8].Value.ToString(), // Precio de venta
                            fila.Cells[10].Value.ToString() // Estado
                        });
                }
                // Se usa biblioteca XLWork.Excel para generar archivo Excel
                SaveFileDialog guardar_archivo = new SaveFileDialog();
                // Nombre del archivo con dia, mes, año, hora, minuto, segundo
                guardar_archivo.FileName = string.Format("ReporteProducto_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                // Muestra solo archivos xlsx en el buscador de Windows
                guardar_archivo.Filter = "Excel Files | *.xlsx";
                // Si se presiona el botón aceptar en el buscador de Windows, se genera el archivo Excel
                if(guardar_archivo.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        // Se crea una hoja en el Excel de nombre "informe"
                        var hoja = wb.Worksheets.Add(datatable, "Informe");
                        // Se ajustan las columnas del excel al tamaño del contenido de los registros
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(guardar_archivo.FileName);
                        MessageBox.Show("Reporte generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}
