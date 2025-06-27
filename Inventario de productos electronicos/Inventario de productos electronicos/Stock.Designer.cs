namespace Inventario_de_productos_electronicos
{
    partial class Stock
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            menuInicio = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            btnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            listRegistroStock = new ListView();
            cbOrdenarPrecio = new ComboBox();
            cbCategoria = new ComboBox();
            btnStockTotal = new Button();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 704);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 20, 0);
            statusStrip1.Size = new Size(1401, 39);
            statusStrip1.TabIndex = 0;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = Color.FromArgb(128, 255, 255);
            toolStripStatusLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(316, 32);
            toolStripStatusLabel1.Text = "Elaborado por : GRUPO 11";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { menuInicio, toolStripButton2, toolStripButton3, toolStripButton4 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 3, 0);
            toolStrip1.Size = new Size(1401, 33);
            toolStrip1.TabIndex = 1;
            // 
            // menuInicio
            // 
            menuInicio.DisplayStyle = ToolStripItemDisplayStyle.Image;
            menuInicio.Image = Properties.Resources.Inicio;
            menuInicio.ImageTransparentColor = Color.Magenta;
            menuInicio.Name = "menuInicio";
            menuInicio.Size = new Size(34, 28);
            menuInicio.Text = "Inicio";
            menuInicio.Click += menuInicio_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.Stock;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(34, 28);
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.Integrantes;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(34, 28);
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = Properties.Resources.Salir;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(34, 28);
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEliminar.Location = new Point(1207, 68);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(111, 57);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(21, 67);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(234, 30);
            label1.TabIndex = 5;
            label1.Text = "Buscar por categoría:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(21, 145);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(218, 30);
            label2.TabIndex = 6;
            label2.Text = "Ordenar por precio:";
            // 
            // listRegistroStock
            // 
            listRegistroStock.Location = new Point(21, 198);
            listRegistroStock.Margin = new Padding(4, 5, 4, 5);
            listRegistroStock.Name = "listRegistroStock";
            listRegistroStock.Size = new Size(1295, 449);
            listRegistroStock.TabIndex = 8;
            listRegistroStock.UseCompatibleStateImageBehavior = false;
            // 
            // cbOrdenarPrecio
            // 
            cbOrdenarPrecio.FormattingEnabled = true;
            cbOrdenarPrecio.Items.AddRange(new object[] { "Ascendente", "Decreciente" });
            cbOrdenarPrecio.Location = new Point(257, 147);
            cbOrdenarPrecio.Margin = new Padding(4, 5, 4, 5);
            cbOrdenarPrecio.Name = "cbOrdenarPrecio";
            cbOrdenarPrecio.Size = new Size(183, 33);
            cbOrdenarPrecio.TabIndex = 9;
            cbOrdenarPrecio.SelectedIndexChanged += cbOrdenarPrecio_SelectedIndexChanged;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Items.AddRange(new object[] { "Ultrabooks", "Laptop", "Mini PCs", "Monitores", "Teclados", "Mouses", "Webcams", "Processadores ", "Memória RAM", "Placas de vídeo (GPUs)", "HDs externos", "SSDs portáteis", "Modems", "Switches", "Tablets" });
            cbCategoria.Location = new Point(257, 68);
            cbCategoria.Margin = new Padding(4, 5, 4, 5);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(183, 33);
            cbCategoria.TabIndex = 11;
            cbCategoria.SelectedIndexChanged += cbCategoria_SelectedIndexChanged;
            // 
            // btnStockTotal
            // 
            btnStockTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnStockTotal.Location = new Point(1143, 133);
            btnStockTotal.Margin = new Padding(4, 5, 4, 5);
            btnStockTotal.Name = "btnStockTotal";
            btnStockTotal.Size = new Size(229, 57);
            btnStockTotal.TabIndex = 12;
            btnStockTotal.Text = "Stock total categoría";
            btnStockTotal.UseVisualStyleBackColor = true;
            btnStockTotal.Click += btnStockTotal_Click;
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1401, 743);
            Controls.Add(btnStockTotal);
            Controls.Add(cbCategoria);
            Controls.Add(cbOrdenarPrecio);
            Controls.Add(listRegistroStock);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Stock";
            Text = "Stock";
            Load += Stock_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton menuInicio;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listRegistroStock;
        private System.Windows.Forms.ComboBox cbOrdenarPrecio;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnStockTotal;
    }
}

