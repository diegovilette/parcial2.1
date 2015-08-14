using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace WindowsFormsApplication2
{
    public enum ABM { Alta, Baja, Modificacion, Nada };

    public partial class abmProducto : Form
    {
        ABM estado;
        List<Categoria> categorias;
        List<Proveedor> proveedores;
        Producto auxProduct;

        public abmProducto()
        {
            InitializeComponent();
        }

        private void abmProducto_Load(object sender, EventArgs e)
        {
            estado = ABM.Nada;
            categorias = Devuelve.Categorias();
            proveedores = Devuelve.Proveedores();
            auxProduct = new Producto();

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

        private void ctrlABM1_Alta(object sender)
        {
            auxProduct = new Producto();
            estado = ABM.Alta;
            pnlBuscaProducto.Enabled = false;
            pnlEditaProducto.Enabled = true;
            tbNombreProducto.Text = String.Empty;
            tbPrecioCosto.Text = String.Empty;
            nudGanancia.Value = 1;
            cbxEstado.Checked = true;
            tbPrecioVenta.Text = String.Empty;
            //cbCategoria
            //cbTalle
            nudStockMinimo.Value = 1;
            //cbProveedor
        }

        private void ctrlABM1_Cancelar(object sender)
        {
            switch(estado)
            {
                case ABM.Alta:
                    {
                        pnlEditaProducto.Enabled = false;
                        tbNombreProducto.Text = String.Empty;
                        tbPrecioCosto.Text = String.Empty;
                        nudGanancia.Value = 1;
                        cbxEstado.Checked = true;
                        tbPrecioVenta.Text = String.Empty;
                        nudStockMinimo.Value = 1;
                    }break;
                case ABM.Modificacion:
                    {
                        pnlEditaProducto.Enabled = false;
                        tbNombreProducto.Text = String.Empty;
                        tbPrecioCosto.Text = String.Empty;
                        nudGanancia.Value = 1;
                        cbxEstado.Checked = true;
                        tbPrecioVenta.Text = String.Empty;
                        nudStockMinimo.Value = 1;
                    } break;
                case ABM.Baja:
                    {

                    } break;
                default: break;
            }
        }

        private void ctrlABM1_Aceptar(object sender, ref bool cancela)
        {
            switch(estado)
            {
                case ABM.Alta:
                    {
                        if (validaForm())
                        {
                            if (controlaRep(tbNombreProducto.Text, cbTalle.Text))
                            {
                                creaProducto();
                                Agrega.Producto(auxProduct);
                                MessageBox.Show("Producto creado satisfactoriamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cancela = true;
                                pnlEditaProducto.Enabled = false;
                                tbNombreProducto.Text = String.Empty;
                                tbPrecioCosto.Text = String.Empty;
                                nudGanancia.Value = 1;
                                cbxEstado.Checked = true;
                                tbPrecioVenta.Text = String.Empty;
                                nudStockMinimo.Value = 1;
                            }
                        }                        
                    } break;
                case ABM.Modificacion:
                    {
                        
                    } break;
                case ABM.Baja:
                    {

                    } break;
                default: break;
            }
        }

        public bool validaForm()
        {
            bool estado = false;
            if (tbNombreProducto.Text != String.Empty && tbPrecioCosto.Text != String.Empty)
            {
                if (cbProveedor.SelectedIndex != null)
                {
                    if (cbCategoria.SelectedIndex != null && cbTalle.SelectedIndex != null)
                    {
                        estado = true;
                    }
                }
            }
            return estado;
        }

        public void creaProducto()
        {
            auxProduct.Descripcion = tbNombreProducto.Text;
            auxProduct.PrecioCosto = (float)Convert.ToDouble(tbPrecioCosto.Text);
            auxProduct.CoefUtil = (float)Convert.ToDouble(nudGanancia.Value) / 100;
            tbPrecioVenta.Text = ((1 + auxProduct.CoefUtil) * (auxProduct.PrecioCosto)).ToString();
            auxProduct.Estado = cbxEstado.Checked;

            auxProduct.StockMinimo = (int)nudStockMinimo.Value;

            auxProduct.IdCategoria = categorias[cbCategoria.SelectedIndex].Id;
            auxProduct.Talle = cbTalle.SelectedItem.ToString();
            auxProduct.Proveedor = Devuelve.Proveedor(proveedores[cbProveedor.SelectedIndex].Id);
        }

        public bool controlaRep(string descripcion, string talle)
        {
            foreach (Producto pr in Devuelve.Productos())
            {
                if (pr.Descripcion == descripcion && pr.Talle == talle)
                {
                    MessageBox.Show("Ya existe un producto con estas características", "ALERTA");
                    return false;
                }
            }
            return true;
        }

        private void nudGanancia_ValueChanged(object sender, EventArgs e)
        {
            if(tbPrecioCosto.Text != String.Empty)
                tbPrecioVenta.Text = ((1 + Convert.ToDouble(nudGanancia.Value) / 100) * (Convert.ToDouble(tbPrecioCosto.Text))).ToString();
        }

        private void tbPrecioCosto_TextChanged(object sender, EventArgs e)
        {
            if (tbPrecioCosto.Text != String.Empty)
                tbPrecioVenta.Text = ((1 + Convert.ToDouble(nudGanancia.Value) / 100) * (Convert.ToDouble(tbPrecioCosto.Text))).ToString();
        }
    }
}
