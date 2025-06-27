namespace Inventario_de_productos_electronicos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCodigo = new TextBox();
            txtNombreDelProducto = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            cbCategoria = new ComboBox();
            fechaDeIngreso = new DateTimePicker();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            listRegistro = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            toolStrip1 = new ToolStrip();
            nemuInicio = new ToolStripButton();
            menuStock = new ToolStripButton();
            menuIntegrantes = new ToolStripButton();
            menuSalir = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 147);
            label1.Name = "label1";
            label1.Size = new Size(84, 30);
            label1.TabIndex = 0;
            label1.Text = "Marca:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 213);
            label2.Name = "label2";
            label2.Size = new Size(120, 30);
            label2.TabIndex = 1;
            label2.Text = "Categoria:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 277);
            label3.Name = "label3";
            label3.Size = new Size(90, 30);
            label3.TabIndex = 2;
            label3.Text = "Precio: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 342);
            label4.Name = "label4";
            label4.Size = new Size(113, 30);
            label4.TabIndex = 3;
            label4.Text = "Cantidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 87);
            label5.Name = "label5";
            label5.Size = new Size(93, 30);
            label5.TabIndex = 4;
            label5.Text = "Codigo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(34, 402);
            label6.Name = "label6";
            label6.Size = new Size(78, 30);
            label6.TabIndex = 5;
            label6.Text = "Fecha:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(201, 83);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(183, 31);
            txtCodigo.TabIndex = 6;
            // 
            // txtNombreDelProducto
            // 
            txtNombreDelProducto.Location = new Point(201, 147);
            txtNombreDelProducto.Name = "txtNombreDelProducto";
            txtNombreDelProducto.Size = new Size(183, 31);
            txtNombreDelProducto.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(201, 270);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(183, 31);
            txtPrecio.TabIndex = 8;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(201, 335);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(183, 31);
            txtCantidad.TabIndex = 9;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Items.AddRange(new object[] { "Ultrabooks", "Mini PCs", "Monitores", "Teclados", "Mouses", "Webcams", "Processadores ", "Memória RAM", "Placas de vídeo (GPUs)", "HDs externos", "SSDs portáteis", "Modems", "Switches", "Tablets" });
            cbCategoria.Location = new Point(201, 213);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(183, 33);
            cbCategoria.TabIndex = 10;
            // 
            // fechaDeIngreso
            // 
            fechaDeIngreso.Location = new Point(201, 395);
            fechaDeIngreso.Name = "fechaDeIngreso";
            fechaDeIngreso.Size = new Size(183, 31);
            fechaDeIngreso.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(34, 522);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(124, 47);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(259, 522);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(126, 47);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // listRegistro
            // 
            listRegistro.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listRegistro.Location = new Point(409, 83);
            listRegistro.Name = "listRegistro";
            listRegistro.Size = new Size(955, 502);
            listRegistro.TabIndex = 14;
            listRegistro.UseCompatibleStateImageBehavior = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { nemuInicio, menuStock, menuIntegrantes, menuSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 3, 0);
            toolStrip1.Size = new Size(1401, 33);
            toolStrip1.TabIndex = 15;
            toolStrip1.Text = "toolStrip1";
            // 
            // nemuInicio
            // 
            nemuInicio.DisplayStyle = ToolStripItemDisplayStyle.Image;
            nemuInicio.Image = Properties.Resources.Inicio;
            nemuInicio.ImageTransparentColor = Color.Magenta;
            nemuInicio.Name = "nemuInicio";
            nemuInicio.Size = new Size(34, 28);
            nemuInicio.Text = "Inicio";
            // 
            // menuStock
            // 
            menuStock.DisplayStyle = ToolStripItemDisplayStyle.Image;
            menuStock.Image = Properties.Resources.Stock;
            menuStock.ImageTransparentColor = Color.Magenta;
            menuStock.Name = "menuStock";
            menuStock.Size = new Size(34, 28);
            menuStock.Text = "Stock";
            menuStock.Click += menuStock_Click;
            // 
            // menuIntegrantes
            // 
            menuIntegrantes.DisplayStyle = ToolStripItemDisplayStyle.Image;
            menuIntegrantes.Image = Properties.Resources.Integrantes;
            menuIntegrantes.ImageTransparentColor = Color.Magenta;
            menuIntegrantes.Name = "menuIntegrantes";
            menuIntegrantes.Size = new Size(34, 28);
            menuIntegrantes.Text = "Colaboradores";
            menuIntegrantes.Click += menuIntegrantes_Click;
            // 
            // menuSalir
            // 
            menuSalir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            menuSalir.Image = Properties.Resources.Salir;
            menuSalir.ImageTransparentColor = Color.Magenta;
            menuSalir.Name = "menuSalir";
            menuSalir.Size = new Size(34, 28);
            menuSalir.Text = "Salir";
            menuSalir.Click += menuSalir_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 704);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1401, 39);
            statusStrip1.TabIndex = 16;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = Color.PowderBlue;
            toolStripStatusLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(316, 32);
            toolStripStatusLabel1.Text = "Elaborado por : GRUPO 11";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1401, 743);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(listRegistro);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(fechaDeIngreso);
            Controls.Add(cbCategoria);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombreDelProducto);
            Controls.Add(txtCodigo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Inventario de produtos electronicos";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCodigo;
        private TextBox txtNombreDelProducto;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private ComboBox cbCategoria;
        private DateTimePicker fechaDeIngreso;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private ListView listRegistro;
        private ToolStrip toolStrip1;
        private ToolStripButton nemuInicio;
        private ToolStripButton menuStock;
        private ToolStripButton menuIntegrantes;
        private ToolStripButton menuSalir;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
