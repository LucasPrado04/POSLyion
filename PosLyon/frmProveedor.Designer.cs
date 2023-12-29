namespace PosLyon
{
    partial class frmProveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.txtrazon_social = new System.Windows.Forms.TextBox();
            this.lblrazon_social = new System.Windows.Forms.Label();
            this.txtcuit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.btnLimpiarBusqueda = new System.Windows.Forms.Button();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.comboBusqueda = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblcuit = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(9, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 25);
            this.label7.TabIndex = 67;
            this.label7.Text = "Nuevo proveedor";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(14, 358);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(181, 23);
            this.btnEliminar.TabIndex = 66;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(14, 329);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(181, 23);
            this.btnLimpiar.TabIndex = 65;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(14, 300);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(181, 23);
            this.btnGuardar.TabIndex = 64;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(14, 190);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(182, 20);
            this.txttelefono.TabIndex = 63;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.BackColor = System.Drawing.Color.White;
            this.lbltelefono.ForeColor = System.Drawing.Color.Black;
            this.lbltelefono.Location = new System.Drawing.Point(11, 174);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(49, 13);
            this.lbltelefono.TabIndex = 62;
            this.lbltelefono.Text = "Telefono";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(14, 142);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(182, 20);
            this.txtemail.TabIndex = 61;
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.BackColor = System.Drawing.Color.White;
            this.lblcorreo.ForeColor = System.Drawing.Color.Black;
            this.lblcorreo.Location = new System.Drawing.Point(11, 126);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(155, 13);
            this.lblcorreo.TabIndex = 60;
            this.lblcorreo.Text = "Dirección de correo electrónico";
            // 
            // txtrazon_social
            // 
            this.txtrazon_social.Location = new System.Drawing.Point(14, 94);
            this.txtrazon_social.Name = "txtrazon_social";
            this.txtrazon_social.Size = new System.Drawing.Size(182, 20);
            this.txtrazon_social.TabIndex = 59;
            // 
            // lblrazon_social
            // 
            this.lblrazon_social.AutoSize = true;
            this.lblrazon_social.BackColor = System.Drawing.Color.White;
            this.lblrazon_social.ForeColor = System.Drawing.Color.Black;
            this.lblrazon_social.Location = new System.Drawing.Point(11, 78);
            this.lblrazon_social.Name = "lblrazon_social";
            this.lblrazon_social.Size = new System.Drawing.Size(68, 13);
            this.lblrazon_social.TabIndex = 58;
            this.lblrazon_social.Text = "Razon social";
            // 
            // txtcuit
            // 
            this.txtcuit.Location = new System.Drawing.Point(14, 53);
            this.txtcuit.Name = "txtcuit";
            this.txtcuit.Size = new System.Drawing.Size(182, 20);
            this.txtcuit.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 403);
            this.label8.TabIndex = 68;
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(192, 0);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(29, 20);
            this.txtindice.TabIndex = 79;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.BackColor = System.Drawing.Color.White;
            this.btnLimpiarBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(914, 16);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(55, 23);
            this.btnLimpiarBusqueda.TabIndex = 78;
            this.btnLimpiarBusqueda.Text = "Limpiar";
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(665, 19);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(182, 20);
            this.txtbusqueda.TabIndex = 76;
            // 
            // comboBusqueda
            // 
            this.comboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBusqueda.FormattingEnabled = true;
            this.comboBusqueda.Location = new System.Drawing.Point(520, 19);
            this.comboBusqueda.Name = "comboBusqueda";
            this.comboBusqueda.Size = new System.Drawing.Size(139, 21);
            this.comboBusqueda.TabIndex = 75;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(453, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Buscar por:";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.BackColor = System.Drawing.Color.White;
            this.lblestado.ForeColor = System.Drawing.Color.Black;
            this.lblestado.Location = new System.Drawing.Point(14, 231);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 73;
            this.lblestado.Text = "Estado";
            // 
            // comboEstado
            // 
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(17, 256);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(139, 21);
            this.comboEstado.TabIndex = 72;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(192, 29);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(29, 20);
            this.txtid.TabIndex = 71;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(853, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(55, 23);
            this.btnBuscar.TabIndex = 77;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.id,
            this.cuit,
            this.razon_social,
            this.email,
            this.telefono,
            this.estado_valor,
            this.estado});
            this.dgvData.Location = new System.Drawing.Point(234, 53);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(739, 328);
            this.dgvData.TabIndex = 69;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 45;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // cuit
            // 
            this.cuit.HeaderText = "CUIT";
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            // 
            // razon_social
            // 
            this.razon_social.HeaderText = "Razon social";
            this.razon_social.Name = "razon_social";
            this.razon_social.ReadOnly = true;
            this.razon_social.Width = 150;
            // 
            // email
            // 
            this.email.HeaderText = "Correo";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 150;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 150;
            // 
            // estado_valor
            // 
            this.estado_valor.HeaderText = "EstadoValor";
            this.estado_valor.Name = "estado_valor";
            this.estado_valor.ReadOnly = true;
            this.estado_valor.Visible = false;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // lblcuit
            // 
            this.lblcuit.AutoSize = true;
            this.lblcuit.BackColor = System.Drawing.Color.White;
            this.lblcuit.ForeColor = System.Drawing.Color.Black;
            this.lblcuit.Location = new System.Drawing.Point(11, 37);
            this.lblcuit.Name = "lblcuit";
            this.lblcuit.Size = new System.Drawing.Size(32, 13);
            this.lblcuit.TabIndex = 56;
            this.lblcuit.Text = "CUIT";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(231, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(742, 40);
            this.label9.TabIndex = 70;
            this.label9.Text = "Lista de proveedores";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 403);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblcorreo);
            this.Controls.Add(this.txtrazon_social);
            this.Controls.Add(this.lblrazon_social);
            this.Controls.Add(this.txtcuit);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.btnLimpiarBusqueda);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.comboBusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lblcuit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "frmProveedor";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.frmProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.TextBox txtrazon_social;
        private System.Windows.Forms.Label lblrazon_social;
        private System.Windows.Forms.TextBox txtcuit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.Button btnLimpiarBusqueda;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox comboBusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblcuit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}