namespace POSLyion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelWin = new Panel();
            maximizar = new Button();
            minimizar = new Button();
            restaurar = new Button();
            salir = new Button();
            panelMain = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panelWin.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelWin
            // 
            panelWin.BackColor = Color.FromArgb(35, 5, 33);
            panelWin.Controls.Add(maximizar);
            panelWin.Controls.Add(minimizar);
            panelWin.Controls.Add(restaurar);
            panelWin.Controls.Add(salir);
            panelWin.Dock = DockStyle.Top;
            panelWin.Location = new Point(0, 0);
            panelWin.Name = "panelWin";
            panelWin.Size = new Size(1100, 40);
            panelWin.TabIndex = 0;
            panelWin.Paint += panelWin_Paint;
            panelWin.MouseMove += panelWin_MouseMove;
            // 
            // maximizar
            // 
            maximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maximizar.BackgroundImage = Properties.Resources.cuadrado;
            maximizar.BackgroundImageLayout = ImageLayout.Stretch;
            maximizar.FlatAppearance.BorderSize = 0;
            maximizar.FlatStyle = FlatStyle.Flat;
            maximizar.Location = new Point(1016, 3);
            maximizar.Name = "maximizar";
            maximizar.Size = new Size(35, 34);
            maximizar.TabIndex = 3;
            maximizar.UseVisualStyleBackColor = true;
            maximizar.Click += maximizar_Click;
            // 
            // minimizar
            // 
            minimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizar.BackgroundImage = Properties.Resources.boton_menos;
            minimizar.BackgroundImageLayout = ImageLayout.Stretch;
            minimizar.FlatAppearance.BorderSize = 0;
            minimizar.FlatStyle = FlatStyle.Flat;
            minimizar.Location = new Point(971, 3);
            minimizar.Name = "minimizar";
            minimizar.Size = new Size(35, 34);
            minimizar.TabIndex = 2;
            minimizar.UseVisualStyleBackColor = true;
            minimizar.Click += button1_Click;
            // 
            // restaurar
            // 
            restaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            restaurar.BackgroundImage = Properties.Resources.menos__1_1;
            restaurar.BackgroundImageLayout = ImageLayout.Stretch;
            restaurar.FlatAppearance.BorderSize = 0;
            restaurar.FlatStyle = FlatStyle.Flat;
            restaurar.Location = new Point(1016, 3);
            restaurar.Name = "restaurar";
            restaurar.Size = new Size(35, 34);
            restaurar.TabIndex = 1;
            restaurar.UseVisualStyleBackColor = true;
            restaurar.Visible = false;
            restaurar.Click += restaurar_Click;
            // 
            // salir
            // 
            salir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            salir.BackgroundImage = Properties.Resources.cerrar;
            salir.BackgroundImageLayout = ImageLayout.Stretch;
            salir.FlatAppearance.BorderSize = 0;
            salir.FlatStyle = FlatStyle.Flat;
            salir.Location = new Point(1059, 3);
            salir.Name = "salir";
            salir.Size = new Size(35, 34);
            salir.TabIndex = 0;
            salir.UseVisualStyleBackColor = true;
            salir.Click += salir_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(127, 55, 161);
            panelMain.Controls.Add(panel1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 40);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1100, 540);
            panelMain.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 5, 33);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 540);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(100, 245, 176);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(812, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 540);
            panel2.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 580);
            Controls.Add(panel2);
            Controls.Add(panelMain);
            Controls.Add(panelWin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panelWin.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelWin;
        private Panel panelMain;
        private Button salir;
        private Panel panel1;
        private Panel panel2;
        private Button restaurar;
        private Button minimizar;
        private Button maximizar;
    }
}