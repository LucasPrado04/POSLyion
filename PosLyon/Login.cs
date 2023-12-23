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
using CapaEntidad;

namespace PosLyon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e) {
            // List<Usuario> TEST = new CN_Usuario().Listar();
            // Creo un objeto de tipo Usuario que lista todos los usuarios de la base de datos y con método Lambda Where trae específicamente el que se indicó en el login
            Usuario usuario = new CN_Usuario().Listar().Where(u => u.dni == textBox1.Text && u.clave == textBox2.Text).FirstOrDefault();
            if(usuario == null) {
                MessageBox.Show("No se encontró el usuario?", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else {
                Main form = new Main();
                form.Show();
                this.Hide();
                form.FormClosing += frm_closing;
            }
        }

        private void frm_closing(object sender, FormClosingEventArgs e) {
            textBox1.Text = "";
            textBox2.Text = "";
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Ingrese nombre de usuario";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ingrese nombre de usuario")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Ingrese contraseña";
                textBox2.ForeColor = Color.Silver;
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Ingrese contraseña")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                
            }
            if (textBox2.Text != "Ingrese contraseña")
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

   

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
          if(checkBox2.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form registro = new registro();
            registro.Show();
        }
    }
}
