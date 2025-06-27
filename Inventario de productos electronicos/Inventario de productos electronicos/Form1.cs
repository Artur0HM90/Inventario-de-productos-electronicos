using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Inventario_de_productos_electronicos.Modelos;

namespace Inventario_de_productos_electronicos
{
    public partial class Form1 : Form
    {
        int contadorProductos = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listRegistro.View = View.Details;
            listRegistro.Columns.Clear();

            listRegistro.Columns.Add("Codigo", 100);
            listRegistro.Columns.Add("Nombre", 220);
            listRegistro.Columns.Add("Categoria", 150);
            listRegistro.Columns.Add("Precio unitario", 150);
            listRegistro.Columns.Add("Cantidad", 120);
            listRegistro.Columns.Add("Fecha", 180);

            foreach (var producto in BaseDeDatosTemporal.ListaProductos)
            {
                listRegistro.Items.Add((ListViewItem)producto.Clone());
            }

            txtCodigo.Text = $"PRD{contadorProductos.ToString("D3")}";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string G11_codigo = txtCodigo.Text.Trim();
            string G11_nombre = txtNombreDelProducto.Text.Trim();
            string G11_categoria = cbCategoria.Text.Trim();
            string G11_precio = txtPrecio.Text.Trim();
            string G11_cantidad = txtCantidad.Text.Trim();
            string G11_fecha = fechaDeIngreso.Value.ToShortDateString();

            if (string.IsNullOrWhiteSpace(G11_nombre) ||
                string.IsNullOrWhiteSpace(G11_categoria) ||
                string.IsNullOrWhiteSpace(G11_precio) ||
                string.IsNullOrWhiteSpace(G11_cantidad))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de registrar.");
                return;
            }

            // Verificar duplicado por código
            if (BaseDeDatosTemporal.ListaProductos.Any(p => p.SubItems[0].Text == G11_codigo))
            {
                MessageBox.Show("Ya existe un producto con ese código.");
                return;
            }

            ListViewItem item = new ListViewItem(G11_codigo);
            item.SubItems.Add(G11_nombre);
            item.SubItems.Add(G11_categoria);
            item.SubItems.Add("S/ " + G11_precio);
            item.SubItems.Add(G11_cantidad);
            item.SubItems.Add(G11_fecha);

            listRegistro.Items.Add(item);
            BaseDeDatosTemporal.ListaProductos.Add(item);

            contadorProductos++;
            txtCodigo.Text = $"PRD{contadorProductos.ToString("D3")}";

            txtNombreDelProducto.Clear();
            cbCategoria.SelectedIndex = -1;
            txtPrecio.Clear();
            txtCantidad.Clear();
            fechaDeIngreso.Value = DateTime.Now;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreDelProducto.Clear();
            cbCategoria.SelectedIndex = -1;
            txtPrecio.Clear();
            txtCantidad.Clear();
            fechaDeIngreso.Value = DateTime.Now;
        }

        private void menuStock_Click(object sender, EventArgs e)
        {
            Stock stockForm = new Stock();
            stockForm.Show();
            this.Hide();
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show(
                "¿Estás seguro de que quieres salir de la aplicación?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void menuIntegrantes_Click(object sender, EventArgs e)
        {
            string mensaje =
            "Agradecimiento:\n" +
            "El esfuerzo de cada uno de los compañeros que integraron el Grupo 11 fue fundamental para el desarrollo de este proyecto.\n\n" +
            "Integrantes del proyecto:\n" +
            "- Bruce Williams Barrera Neyra\n" +
            "- Arturo Miguel Hurtado Méndez\n" +
            "- Ana Claribeth Rojas Vásquez\n" +
            "- Miguel Enrique Vásquez Andrés";

            MessageBox.Show(mensaje, "Integrantes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

