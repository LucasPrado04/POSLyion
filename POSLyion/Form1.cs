using System.Runtime.InteropServices;

namespace POSLyion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int posX = 0;
        int posY = 0;
        private void equis_Click(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            restaurar.Visible = false;
            maximizar.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            maximizar.Visible = false;
            restaurar.Visible = true;
            WindowState = FormWindowState.Maximized;
        }

        private void panelWin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelWin_MouseMove(object sender, MouseEventArgs e)
        {
                if(e.Button != MouseButtons.Left) {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
    }
}