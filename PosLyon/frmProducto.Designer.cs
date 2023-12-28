namespace PosLyon
{
    partial class frmProducto
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
            this.txtindice = new System.Windows.Forms.TextBox();
            this.btnLimpiarBusqueda = new System.Windows.Forms.Button();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.comboBusqueda = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(166, 2);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(29, 20);
            this.txtindice.TabIndex = 55;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.BackColor = System.Drawing.Color.White;
            this.btnLimpiarBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(867, 16);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(55, 23);
            this.btnLimpiarBusqueda.TabIndex = 54;
            this.btnLimpiarBusqueda.Text = "Limpiar";
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(618, 18);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(182, 20);
            this.txtbusqueda.TabIndex = 52;
            // 
            // comboBusqueda
            // 
            this.comboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBusqueda.FormattingEnabled = true;
            this.comboBusqueda.Location = new System.Drawing.Point(473, 18);
            this.comboBusqueda.Name = "comboBusqueda";
            this.comboBusqueda.Size = new System.Drawing.Size(139, 21);
            this.comboBusqueda.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(406, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Buscar por:";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.BackColor = System.Drawing.Color.White;
            this.lblestado.ForeColor = System.Drawing.Color.Black;
            this.lblestado.Location = new System.Drawing.Point(14, 226);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 49;
            this.lblestado.Text = "Estado";
            // 
            // comboEstado
            // 
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(17, 245);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(177, 21);
            this.comboEstado.TabIndex = 48;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(166, 28);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(29, 20);
            this.txtid.TabIndex = 47;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(231, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(991, 40);
            this.label9.TabIndex = 46;
            this.label9.Text = "Lista de productos";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(806, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(55, 23);
            this.btnBuscar.TabIndex = 53;
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
            this.codigo,
            this.descripcion,
            this.id_categoria,
            this.categoria,
            this.stock,
            this.precio_costo,
            this.precio_venta,
            this.estado_valor,
            this.estado});
            this.dgvData.Location = new System.Drawing.Point(234, 52);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(988, 356);
            this.dgvData.TabIndex = 45;
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
            // codigo
            // 
            this.codigo.HeaderText = "Codigo de barras";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 200;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 200;
            // 
            // id_categoria
            // 
            this.id_categoria.HeaderText = "IdCategoria";
            this.id_categoria.Name = "id_categoria";
            this.id_categoria.ReadOnly = true;
            this.id_categoria.Visible = false;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // precio_costo
            // 
            this.precio_costo.HeaderText = "Costo";
            this.precio_costo.Name = "precio_costo";
            this.precio_costo.ReadOnly = true;
            // 
            // precio_venta
            // 
            this.precio_venta.HeaderText = "Precio de venta";
            this.precio_venta.Name = "precio_venta";
            this.precio_venta.ReadOnly = true;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(9, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 25);
            this.label7.TabIndex = 43;
            this.label7.Text = "Nuevo producto";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(17, 353);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(177, 23);
            this.btnEliminar.TabIndex = 42;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(17, 324);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(177, 23);
            this.btnLimpiar.TabIndex = 41;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(17, 295);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(177, 23);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.BackColor = System.Drawing.Color.White;
            this.lblcategoria.ForeColor = System.Drawing.Color.Black;
            this.lblcategoria.Location = new System.Drawing.Point(11, 183);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(54, 13);
            this.lblcategoria.TabIndex = 39;
            this.lblcategoria.Text = "Categoría";
            // 
            // comboCategoria
            // 
            this.comboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(14, 202);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(181, 21);
            this.comboCategoria.TabIndex = 38;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(12, 143);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(182, 20);
            this.txtcantidad.TabIndex = 37;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.BackColor = System.Drawing.Color.White;
            this.lblcantidad.ForeColor = System.Drawing.Color.Black;
            this.lblcantidad.Location = new System.Drawing.Point(9, 127);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(49, 13);
            this.lblcantidad.TabIndex = 36;
            this.lblcantidad.Text = "Cantidad";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(14, 93);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(182, 20);
            this.txtdescripcion.TabIndex = 31;
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.BackColor = System.Drawing.Color.White;
            this.lbldescripcion.ForeColor = System.Drawing.Color.Black;
            this.lbldescripcion.Location = new System.Drawing.Point(11, 77);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbldescripcion.TabIndex = 30;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(14, 52);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(182, 20);
            this.txtcodigo.TabIndex = 29;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.BackColor = System.Drawing.Color.White;
            this.lblcodigo.ForeColor = System.Drawing.Color.Black;
            this.lblcodigo.Location = new System.Drawing.Point(11, 36);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(87, 13);
            this.lblcodigo.TabIndex = 28;
            this.lblcodigo.Text = "Código de barras";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 416);
            this.label8.TabIndex = 44;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.White;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(928, 16);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(143, 23);
            this.btnExportar.TabIndex = 56;
            this.btnExportar.Text = "Exportar lista en Excel";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 416);
            this.Controls.Add(this.btnExportar);
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
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Name = "frmProducto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.Button btnLimpiarBusqueda;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox comboBusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Button btnExportar;
    }
}