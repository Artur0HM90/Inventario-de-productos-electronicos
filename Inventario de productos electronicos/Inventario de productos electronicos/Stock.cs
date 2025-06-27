using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Inventario_de_productos_electronicos.Modelos;

namespace Inventario_de_productos_electronicos
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            listRegistroStock.View = View.Details;
            listRegistroStock.Columns.Clear();

            listRegistroStock.Columns.Add("Codigo", 100);
            listRegistroStock.Columns.Add("Nombre", 220);
            listRegistroStock.Columns.Add("Categoria", 150);
            listRegistroStock.Columns.Add("Precio unitario", 150);
            listRegistroStock.Columns.Add("Cantidad", 120);
            listRegistroStock.Columns.Add("Fecha", 180);

            if (!cbCategoria.Items.Contains("TODAS"))
                cbCategoria.Items.Insert(0, "TODAS");

            cbCategoria.SelectedIndex = 0;

            foreach (var producto in BaseDeDatosTemporal.ListaProductos)
            {
                listRegistroStock.Items.Add((ListViewItem)producto.Clone());
            }
        }

        private void menuInicio_Click(object sender, EventArgs e)
        {
            Form1 nuevoForm1 = new Form1();
            nuevoForm1.Show();
            this.Close();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoriaSeleccionada = cbCategoria.Text.ToLower();

            listRegistroStock.Items.Clear();

            foreach (var producto in BaseDeDatosTemporal.ListaProductos)
            {
                string categoriaProducto = producto.SubItems[2].Text.ToLower();
                if (categoriaProducto == categoriaSeleccionada || categoriaSeleccionada == "todas")
                {
                    listRegistroStock.Items.Add((ListViewItem)producto.Clone());
                }
            }
        }

        private void cbOrdenarPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string G11_orden = cbOrdenarPrecio.Text.ToLower();

            // Clonar la lista original para no modificar la fuente
            var G11_productosOrdenados = new List<ListViewItem>();

            foreach (var G11_producto in BaseDeDatosTemporal.ListaProductos)
            {
                G11_productosOrdenados.Add((ListViewItem)G11_producto.Clone());
            }

            // Extraer el valor numérico del precio para ordenar
            if (G11_orden == "ascendente")
            {
                // Ordenar en orden ascendente
                G11_productosOrdenados = G11_productosOrdenados.OrderBy(p =>
                {
                    string G11_precioTexto = p.SubItems[3].Text.Replace("S/ ", "").Trim();
                    decimal.TryParse(G11_precioTexto, out decimal G11_precio);
                    return G11_precio;
                }).ToList();
            }
            else if (G11_orden == "descendente")
            {
                // Ordenar en orden descendente
                G11_productosOrdenados = G11_productosOrdenados.OrderByDescending(p =>
                {
                    string G11_precioTexto = p.SubItems[3].Text.Replace("S/ ", "").Trim();
                    decimal.TryParse(G11_precioTexto, out decimal G11_precio);
                    return G11_precio;
                }).ToList();
            }

            // Mostrar en la lista
            listRegistroStock.Items.Clear();
            foreach (var G11_producto in G11_productosOrdenados)
            {
                listRegistroStock.Items.Add((ListViewItem)G11_producto.Clone());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listRegistroStock.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar el producto seleccionado?",
                                                        "Confirmar Eliminación",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                ListViewItem seleccionado = listRegistroStock.SelectedItems[0];
                string codigoAEliminar = seleccionado.SubItems[0].Text;

                listRegistroStock.Items.Remove(seleccionado);

                var itemEnMemoria = BaseDeDatosTemporal.ListaProductos
                    .FirstOrDefault(i => i.SubItems[0].Text == codigoAEliminar);

                if (itemEnMemoria != null)
                {
                    BaseDeDatosTemporal.ListaProductos.Remove(itemEnMemoria);
                }

                MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStockTotal_Click(object sender, EventArgs e)
        {
            string categoria = cbCategoria.Text;
            int total = CalcularStockPorCategoriaRecursivo(categoria, BaseDeDatosTemporal.ListaProductos);
            MessageBox.Show($"Stock total en categoría '{categoria}': {total} unidades.");
        }

        // Método recursivo
        private int CalcularStockPorCategoriaRecursivo(string categoria, List<ListViewItem> productos, int index = 0, int acumulador = 0)
        {
            if (index >= productos.Count) return acumulador;

            var item = productos[index];
            string cat = item.SubItems[2].Text.ToLower();
            int.TryParse(item.SubItems[4].Text, out int cantidad);

            if (categoria.ToLower() == "todas" || cat == categoria.ToLower())
            {
                acumulador += cantidad;
            }

            return CalcularStockPorCategoriaRecursivo(categoria, productos, index + 1, acumulador);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
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

