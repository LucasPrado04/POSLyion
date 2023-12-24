namespace PosLyon
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.rest = new System.Windows.Forms.Button();
            this.minim = new System.Windows.Forms.Button();
            this.maxim = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.minimizar = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.maximizar = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.restaurar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.menu_producto = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_categoria = new System.Windows.Forms.Button();
            this.menu_cliente = new System.Windows.Forms.Button();
            this.menu_proveedor = new System.Windows.Forms.Button();
            this.menu_usuario = new System.Windows.Forms.Button();
            this.menu_config = new System.Windows.Forms.Button();
            this.menu_registro = new System.Windows.Forms.Button();
            this.menu_stock = new System.Windows.Forms.Button();
            this.menu_venta = new System.Windows.Forms.Button();
            this.menu_compra = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(5)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.rest);
            this.panel1.Controls.Add(this.minim);
            this.panel1.Controls.Add(this.maxim);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.minimizar);
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Controls.Add(this.maximizar);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.restaurar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 44);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::PosLyon.Properties.Resources.desplegable__1_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 32);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rest
            // 
            this.rest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rest.BackgroundImage = global::PosLyon.Properties.Resources.menos__1_;
            this.rest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rest.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.rest.FlatAppearance.BorderSize = 0;
            this.rest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.rest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.rest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rest.Location = new System.Drawing.Point(718, 4);
            this.rest.Name = "rest";
            this.rest.Size = new System.Drawing.Size(35, 34);
            this.rest.TabIndex = 11;
            this.rest.UseVisualStyleBackColor = true;
            this.rest.Visible = false;
            this.rest.Click += new System.EventHandler(this.rest_Click);
            // 
            // minim
            // 
            this.minim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minim.BackgroundImage = global::PosLyon.Properties.Resources.boton_menos;
            this.minim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minim.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.minim.FlatAppearance.BorderSize = 0;
            this.minim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.minim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.minim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minim.Location = new System.Drawing.Point(677, 4);
            this.minim.Name = "minim";
            this.minim.Size = new System.Drawing.Size(35, 34);
            this.minim.TabIndex = 10;
            this.minim.UseVisualStyleBackColor = true;
            this.minim.Click += new System.EventHandler(this.minim_Click);
            // 
            // maxim
            // 
            this.maxim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxim.BackgroundImage = global::PosLyon.Properties.Resources.cuadrado;
            this.maxim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maxim.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.maxim.FlatAppearance.BorderSize = 0;
            this.maxim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.maxim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.maxim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxim.Location = new System.Drawing.Point(718, 4);
            this.maxim.Name = "maxim";
            this.maxim.Size = new System.Drawing.Size(35, 34);
            this.maxim.TabIndex = 9;
            this.maxim.UseVisualStyleBackColor = true;
            this.maxim.Visible = false;
            this.maxim.Click += new System.EventHandler(this.maxim_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(5)))), ((int)(((byte)(33)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(151)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 31);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.minimizar.FlatAppearance.BorderSize = 0;
            this.minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizar.Location = new System.Drawing.Point(681, 6);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(35, 34);
            this.minimizar.TabIndex = 3;
            this.minimizar.UseVisualStyleBackColor = true;
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cerrar.BackgroundImage")));
            this.cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Location = new System.Drawing.Point(759, 4);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(35, 34);
            this.cerrar.TabIndex = 8;
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.maximizar.FlatAppearance.BorderSize = 0;
            this.maximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.maximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizar.Location = new System.Drawing.Point(722, 6);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(35, 34);
            this.maximizar.TabIndex = 2;
            this.maximizar.UseVisualStyleBackColor = true;
            this.maximizar.Visible = false;
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(763, 6);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(35, 34);
            this.exit.TabIndex = 1;
            this.exit.UseVisualStyleBackColor = true;
            // 
            // restaurar
            // 
            this.restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.restaurar.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.restaurar.FlatAppearance.BorderSize = 0;
            this.restaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.restaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restaurar.Location = new System.Drawing.Point(722, 6);
            this.restaurar.Name = "restaurar";
            this.restaurar.Size = new System.Drawing.Size(35, 34);
            this.restaurar.TabIndex = 0;
            this.restaurar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(640, 65);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(76, 20);
            this.lblusuario.TabIndex = 8;
            this.lblusuario.Text = "lblusuario";
            // 
            // menu_producto
            // 
            this.menu_producto.AutoSize = true;
            this.menu_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(5)))), ((int)(((byte)(33)))));
            this.menu_producto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_producto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.menu_producto.FlatAppearance.BorderSize = 0;
            this.menu_producto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(151)))));
            this.menu_producto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.menu_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_producto.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.menu_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menu_producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_producto.Location = new System.Drawing.Point(0, 283);
            this.menu_producto.Name = "menu_producto";
            this.menu_producto.Size = new System.Drawing.Size(276, 60);
            this.menu_producto.TabIndex = 7;
            this.menu_producto.Text = "Producto";
            this.menu_producto.UseVisualStyleBackColor = false;
            this.menu_producto.Visible = false;
            this.menu_producto.Click += new System.EventHandler(this.menu_producto_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 44);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 25);
            this.bindingNavigator1.TabIndex = 9;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // menu_categoria
            // 
            this.menu_categoria.AutoSize = true;
            this.menu_categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(5)))), ((int)(((byte)(33)))));
            this.menu_categoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_categoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.menu_categoria.FlatAppearance.BorderSize = 0;
            this.menu_categoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(151)))));
            this.menu_categoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.menu_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_categoria.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.menu_categoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menu_categoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_categoria.Location = new System.Drawing.Point(275, 304);
            this.menu_categoria.Name = "menu_categoria";
            this.menu_categoria.Size = new System.Drawing.Size(161, 39);
            this.menu_categoria.TabIndex = 10;
            this.menu_categoria.Text = "Categoria";
            this.menu_categoria.UseVisualStyleBackColor = false;
            this.menu_categoria.Visible = false;
            this.menu_categoria.Click += new System.EventHandler(this.menu_categoria_Click);
            // 
            // menu_cliente
            // 
            this.menu_cliente.AutoSize = true;
            this.menu_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(5)))), ((int)(((byte)(33)))));
            this.menu_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_cliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.menu_cliente.FlatAppearance.BorderSize = 0;
            this.menu_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(151)))));
            this.menu_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.menu_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_cliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.menu_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menu_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_cliente.Location = new System.Drawing.Point(0, 343);
            this.menu_cliente.Name = "menu_cliente";
            this.menu_cliente.Size = new System.Drawing.Size(276, 60);
            this.menu_cliente.TabIndex = 11;
            this.menu_cliente.Text = "Cliente";
            this.menu_cliente.UseVisualStyleBackColor = false;
            this.menu_cliente.Visible = false;
            this.menu_cliente.Click += new System.EventHandler(this.menu_cliente_Click);
            // 
            // menu_proveedor
            // 
            this.menu_proveedor.AutoSize = true;
            this.menu_proveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(5)))), ((int)(((byte)(33)))));
            this.menu_proveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_proveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.menu_proveedor.FlatAppearance.BorderSize = 0;
            this.menu_proveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(151)))));
            this.menu_proveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.menu_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_proveedor.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.menu_proveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menu_proveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_proveedor.Location = new System.Drawing.Point(0, 403);
            this.menu_proveedor.Name = "menu_proveedor";
            this.menu_proveedor.Size = new System.Drawing.Size(276, 60);
            this.menu_proveedor.TabIndex = 12;
            this.menu_proveedor.Text = "Proveedor";
            this.menu_proveedor.UseVisualStyleBackColor = false;
            this.menu_proveedor.Visible = false;
            this.menu_proveedor.Click += new System.EventHandler(this.menu_proveedor_Click);
            // 
            // menu_usuario
            // 
            this.menu_usuario.AutoSize = true;
            this.menu_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(5)))), ((int)(((byte)(33)))));
            this.menu_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_usuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.menu_usuario.FlatAppearance.BorderSize = 0;
            this.menu_usuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(151)))));
            this.menu_usuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.menu_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_usuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.menu_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menu_usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_usuario.Location = new System.Drawing.Point(275, 484);
            this.menu_usuario.Name = "menu_usuario";
            this.menu_usuario.Size = new System.Drawing.Size(161, 39);
            this.menu_usuario.TabIndex = 13;
            this.menu_usuario.Text = "Usuario";
            this.menu_usuario.UseVisualStyleBackColor = false;
            this.menu_usuario.Visible = false;
            this.menu_usuario.Click += new System.EventHandler(this.menu_usuario_Click);
            // 
            // menu_config
            // 
            this.menu_config.AutoSize = true;
            this.menu_config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(5)))), ((int)(((byte)(33)))));
            this.menu_config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_config.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.menu_config.FlatAppearance.BorderSize = 0;
            this.menu_config.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(151)))));
            this.menu_config.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.menu_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_config.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.menu_config.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menu_config.Image = global::PosLyon.Properties.Resources.config;
            this.menu_config.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_config.Location = new System.Drawing.Point(0, 463);
            this.menu_config.Name = "menu_config";
            this.menu_config.Size = new System.Drawing.Size(276, 60);
            this.menu_config.TabIndex = 6;
            this.menu_config.Text = "Config.";
            this.menu_config.UseVisualStyleBackColor = false;
            this.menu_config.Visible = false;
            this.menu_config.Click += new System.EventHandler(this.menu_config_Click);
            // 
            // menu_registro
            // 
            this.menu_registro.AutoSize = true;
            this.menu_registro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(5)))), ((int)(((byte)(33)))));
            this.menu_registro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_registro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.menu_registro.FlatAppearance.BorderSize = 0;
            this.menu_registro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(151)))));
            this.menu_registro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.menu_registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_registro.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.menu_registro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menu_registro.Image = global::PosLyon.Properties.Resources.regede;
            this.menu_registro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_registro.Location = new System.Drawing.Point(0, 223);
            this.menu_registro.Name = "menu_registro";
            this.menu_registro.Size = new System.Drawing.Size(276, 60);
            this.menu_registro.TabIndex = 5;
            this.menu_registro.Text = "Registro";
            this.menu_registro.UseVisualStyleBackColor = false;
            this.menu_registro.Visible = false;
            this.menu_registro.Click += new System.EventHandler(this.menu_registro_Click);
            // 
            // menu_stock
            // 
            this.menu_stock.AutoSize = true;
            this.menu_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(5)))), ((int)(((byte)(33)))));
            this.menu_stock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_stock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.menu_stock.FlatAppearance.BorderSize = 0;
            this.menu_stock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(151)))));
            this.menu_stock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.menu_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_stock.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.menu_stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menu_stock.Image = global::PosLyon.Properties.Resources.stock;
            this.menu_stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_stock.Location = new System.Drawing.Point(0, 163);
            this.menu_stock.Name = "menu_stock";
            this.menu_stock.Size = new System.Drawing.Size(276, 60);
            this.menu_stock.TabIndex = 4;
            this.menu_stock.Text = "Stock";
            this.menu_stock.UseVisualStyleBackColor = false;
            this.menu_stock.Visible = false;
            this.menu_stock.Click += new System.EventHandler(this.menu_stock_Click);
            // 
            // menu_venta
            // 
            this.menu_venta.AutoSize = true;
            this.menu_venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(5)))), ((int)(((byte)(33)))));
            this.menu_venta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_venta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.menu_venta.FlatAppearance.BorderSize = 0;
            this.menu_venta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(151)))));
            this.menu_venta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.menu_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_venta.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.menu_venta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menu_venta.Image = global::PosLyon.Properties.Resources.vventa;
            this.menu_venta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_venta.Location = new System.Drawing.Point(0, 103);
            this.menu_venta.Name = "menu_venta";
            this.menu_venta.Size = new System.Drawing.Size(276, 60);
            this.menu_venta.TabIndex = 3;
            this.menu_venta.Text = "Venta";
            this.menu_venta.UseVisualStyleBackColor = false;
            this.menu_venta.Visible = false;
            this.menu_venta.Click += new System.EventHandler(this.menu_venta_Click);
            // 
            // menu_compra
            // 
            this.menu_compra.AutoSize = true;
            this.menu_compra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(5)))), ((int)(((byte)(33)))));
            this.menu_compra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_compra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.menu_compra.FlatAppearance.BorderSize = 0;
            this.menu_compra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(151)))));
            this.menu_compra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(75)))));
            this.menu_compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_compra.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.menu_compra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menu_compra.Image = global::PosLyon.Properties.Resources.carrito_de_compras;
            this.menu_compra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_compra.Location = new System.Drawing.Point(0, 43);
            this.menu_compra.Name = "menu_compra";
            this.menu_compra.Size = new System.Drawing.Size(276, 60);
            this.menu_compra.TabIndex = 2;
            this.menu_compra.Text = "Compra";
            this.menu_compra.UseVisualStyleBackColor = false;
            this.menu_compra.Visible = false;
            this.menu_compra.Click += new System.EventHandler(this.menu_compra_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.menu_usuario);
            this.Controls.Add(this.menu_proveedor);
            this.Controls.Add(this.menu_cliente);
            this.Controls.Add(this.menu_categoria);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menu_producto);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu_config);
            this.Controls.Add(this.menu_registro);
            this.Controls.Add(this.menu_stock);
            this.Controls.Add(this.menu_venta);
            this.Controls.Add(this.menu_compra);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minim;
        private System.Windows.Forms.Button maxim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button minimizar;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button maximizar;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button restaurar;
        private System.Windows.Forms.Button rest;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button menu_compra;
        private System.Windows.Forms.Button menu_venta;
        private System.Windows.Forms.Button menu_stock;
        private System.Windows.Forms.Button menu_registro;
        private System.Windows.Forms.Button menu_config;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Button menu_producto;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button menu_categoria;
        private System.Windows.Forms.Button menu_cliente;
        private System.Windows.Forms.Button menu_proveedor;
        private System.Windows.Forms.Button menu_usuario;
    }
}