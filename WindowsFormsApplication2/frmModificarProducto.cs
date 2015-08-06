using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidades;

namespace WindowsFormsApplication2
{
    public partial class frmModificarProducto : Form
    {
        public frmModificarProducto()
        {
            InitializeComponent();
        }

        List<Categoria> categorias;
        List<Proveedor> proveedores;

        private void frmModificarProducto_Load(object sender, EventArgs e)
        {
           //dgvProductosEdit.DataSource = Filtra.Filtro("Todo", "Todo", "");

            categorias=Devuelve.Categorias();
            proveedores = Devuelve.Proveedores();
            foreach (Proveedor pr in proveedores)
            {
                cbProveedor.Items.Add(pr.Nombre);
            }

            cbCatModifProd.Items.Add("Todo");
            foreach (Categoria c in categorias)
            {
                cbCatModifProd.Items.Add(c.Descripcion);
                cbCategoria.Items.Add(c.Descripcion);
            }

            cbTalleModificPr.Items.Add("Todo");
            foreach (String p in Enum.GetNames(typeof(eTalle)))
            {
                cbTalleModificPr.Items.Add(p);
                cbTalle.Items.Add(p);
            }

            cbTalleModificPr.SelectedIndex = 0;
            cbCatModifProd.SelectedIndex = 0;

        }
        Producto seleccionado = null;

        

        private void llenarCampos()
        {
            tbNombreProducto.Text = seleccionado.Descripcion;
            tbPrecioCosto.Text = seleccionado.PrecioCosto.ToString();
            tbPrecioVenta.Text = ((1 + seleccionado.CoefUtil) * (seleccionado.PrecioCosto)).ToString();
            cbxEstado.Checked = seleccionado.Estado;
            
            nudStockMinimo.Value = seleccionado.StockMinimo;
            nudGanancia.Value = Convert.ToDecimal(seleccionado.CoefUtil*100);
            
            cbCategoria.SelectedItem = Devuelve.Categoria(seleccionado.IdCategoria).Descripcion;
            cbTalle.SelectedItem = seleccionado.Talle;
            cbProveedor.SelectedItem = seleccionado.Proveedor.Nombre;

        }

        private void cbCategoriaStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(Filtro(cbTalleStcok.Text,cbCategoriaStock.Text, tbDescripcionStock.Text));
            dgvProductosEdit.DataSource = Filtra.Filtro(cbTalleModificPr.Text, cbCatModifProd.Text, tbDescripModificP.Text);
  
        }

        private void dgvProductosEdit_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCambiar_Click_1(object sender, EventArgs e)
        {
            if(seleccionado != null)
            {
                seleccionado.Descripcion = tbNombreProducto.Text;
                seleccionado.PrecioCosto = (float)Convert.ToDouble(tbPrecioCosto.Text)/100;
                tbPrecioVenta.Text = ((1 + seleccionado.CoefUtil) * (seleccionado.PrecioCosto)).ToString();
                seleccionado.Estado = cbxEstado.Checked;

                seleccionado.StockMinimo = (int)nudStockMinimo.Value;
                seleccionado.CoefUtil = (float)Convert.ToDouble(nudGanancia.Value);

                seleccionado.IdCategoria = categorias[cbCategoria.SelectedIndex].Id;
                seleccionado.Talle = cbTalle.SelectedItem.ToString();
                seleccionado.Proveedor = Devuelve.Proveedor(proveedores[cbProveedor.SelectedIndex].Id);

                Actualiza.Producto(seleccionado);
            }
        }

        private void dgvProductosEdit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductosEdit.SelectedRows.Count != 0)
            {
                Producto cust = Devuelve.Producto((int)dgvProductosEdit.CurrentRow.Cells["IdProducto"].Value);
                if (cust != null)
                {
                    seleccionado = cust;
                    llenarCampos();
                }
            }
        }

    }
}
