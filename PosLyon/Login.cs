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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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

        private void btningresar_Click(object sender, EventArgs e)
        {
            // Cuando se presione el botón "Entrar", se oculta el formulario Login y se muestra el formulario Inicio o la pantalla principal.
            Inicio form = new Inicio();
            form.Show();
            this.Hide();
            //if (textBox1.Text == "Ingrese nombre de usuario" || textBox2.Text == "Ingrese contraseña")
            //{
            //    textBox3.Visible = true;
            //    return;
            //}
            //else
            //{
            //    textBox3.Visible = false;
            //    return;
            //}
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
    }
}
