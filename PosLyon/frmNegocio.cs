using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.IO;
using CapaEntidad;

namespace PosLyon
{
    public partial class frmNegocio : Form
    {
        public frmNegocio()
        {
            InitializeComponent();
        }

        private void frmNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] imagenbytes = new CN_Datos_Negocio().Obtener_Logo(out obtenido);
            if (obtenido)
                piclogo.Image = ByteToImage(imagenbytes);
            Datos_Negocio negocio = new CN_Datos_Negocio().Obtener_Datos();
            txtnombre.Text = negocio.nombre;
            txtcuit.Text = negocio.cuit;
            txtdireccion.Text = negocio.direccion;
        }

        // Metodo que convierte un array de bytes en una imagen
        public Image ByteToImage(byte[] imagenbytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imagenbytes, 0, imagenbytes.Length);
            Image imagen = new Bitmap(ms);
            return imagen;
        }

        private void btnSubir_Imagen_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "Files|*.jpg;*.jpeg;*.png";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] imagenbyte = File.ReadAllBytes(openFileDialog.FileName);
                bool respuesta = new CN_Datos_Negocio().Actualizar_Logo(imagenbyte, out mensaje);
                if (respuesta)
                    piclogo.Image = ByteToImage(imagenbyte);
                else
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Datos_Negocio negocio = new Datos_Negocio()
            {
                nombre = txtnombre.Text,
                cuit = txtcuit.Text,
                direccion = txtdireccion.Text
            };
            bool respuesta = new CN_Datos_Negocio().Guardar_Datos(negocio, out mensaje);
            if (respuesta)
                MessageBox.Show("Los cambios fueron guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudieron guardar los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
