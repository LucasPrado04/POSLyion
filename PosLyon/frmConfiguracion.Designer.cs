namespace PosLyon
{
    partial class frmConfiguracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDatos_Negocio = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnDatos_Negocio
            // 
            this.btnDatos_Negocio.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDatos_Negocio.IconColor = System.Drawing.Color.Black;
            this.btnDatos_Negocio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDatos_Negocio.Location = new System.Drawing.Point(329, 202);
            this.btnDatos_Negocio.Name = "btnDatos_Negocio";
            this.btnDatos_Negocio.Size = new System.Drawing.Size(122, 23);
            this.btnDatos_Negocio.TabIndex = 0;
            this.btnDatos_Negocio.Text = "Datos de negocio";
            this.btnDatos_Negocio.UseVisualStyleBackColor = true;
            this.btnDatos_Negocio.Click += new System.EventHandler(this.btnDatos_Negocio_Click);
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDatos_Negocio);
            this.Name = "frmConfiguracion";
            this.Text = "frmConfiguracion";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnDatos_Negocio;
    }
}