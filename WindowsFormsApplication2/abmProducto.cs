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
            limpia();
        }

        private void ctrlABM1_Cancelar(object sender)
        {
            switch(estado)
            {
                case ABM.Alta:
                    {
                        pnlEditaProducto.Enabled = false;
                        limpia();  
                    }break;
                case ABM.Modificacion:
                    {
                        pnlBuscaProducto.Enabled = false;
                        pnlEditaProducto.Enabled = false;
                        limpia();
                    } break;
                case ABM.Baja:
                    {
                        pnlBuscaProducto.Enabled = false;
                    } break;
                default: break;
            }
            estado = ABM.Nada;
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
                                limpia();
                                refresca();
                            }
                        }                        
                    } break;
                case ABM.Modificacion:
                    {
                        if (validaForm())
                        {
                                creaProducto();
                                Actualiza.Producto(auxProduct);
                                MessageBox.Show("Producto modificado satisfactoriamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cancela = true;
                                pnlBuscaProducto.Enabled = false;
                                pnlEditaProducto.Enabled = false;
                                refresca();
                        }
                        
                    } break;
                case ABM.Baja:
                    {
                        if (dgvProductosEdit.RowCount < 1 || dgvProductosEdit.CurrentRow == null)
                            MessageBox.Show("Debe selecionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            Elimina.Producto(Devuelve.Producto((int)dgvProductosEdit.CurrentRow.Cells["IdProducto"].Value));
                            refresca();
                            cancela = true;
                            pnlBuscaProducto.Enabled = false;
                            MessageBox.Show("Producto eliminardo satisfactoriamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    } break;
                default: break;
            }
            estado = ABM.Nada;
        }

        public bool validaForm()
        {
            bool estado = false;
            if (tbNombreProducto.Text != String.Empty && ntbPrecioCosto.Text != String.Empty)
            {
                if (cbProveedor.SelectedItem != null)
                {
                    if (cbCategoria.SelectedItem != null && cbTalle.SelectedItem != null)
                    {
                        estado = true;
                    }
                }
            }
            if(!estado)
                MessageBox.Show("Faltan campos por llenar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return estado;
        }

        public void creaProducto()
        {
            auxProduct.Descripcion = tbNombreProducto.Text;
            auxProduct.PrecioCosto = (float)Convert.ToDouble(ntbPrecioCosto.Text);
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
            if(ntbPrecioCosto.Text != String.Empty)
                tbPrecioVenta.Text = ((1 + Convert.ToDouble(nudGanancia.Value) / 100) * (Convert.ToDouble(ntbPrecioCosto.Text))).ToString();
        }

        private void ntbPrecioCosto_TextChanged(object sender, EventArgs e)
        {
            if (ntbPrecioCosto.Text != String.Empty)
                tbPrecioVenta.Text = ((1 + Convert.ToDouble(nudGanancia.Value) / 100) * (Convert.ToDouble(ntbPrecioCosto.Text))).ToString();
        }

        private void ctrlABM1_Baja(object sender)
        {
            estado = ABM.Baja;
            pnlBuscaProducto.Enabled = true;
        }

        private void cbTalleModificPr_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresca();
        }

        private void ctrlABM1_Modificacion(object sender)
        {
            estado = ABM.Modificacion;
            auxProduct = new Producto();
            pnlBuscaProducto.Enabled = true;
        }

        private void dgvProductosEdit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (estado == ABM.Modificacion)
            {
                pnlEditaProducto.Enabled = true;
                if (dgvProductosEdit.SelectedRows.Count != 0)
                {
                    auxProduct = Devuelve.Producto((int)dgvProductosEdit.CurrentRow.Cells["IdProducto"].Value);
                    if (auxProduct != null)
                    {
                        llenarCampos();
                    }
                }
            }
        }

        private void llenarCampos()
        {
            tbNombreProducto.Text = auxProduct.Descripcion;
            ntbPrecioCosto.Text = auxProduct.PrecioCosto.ToString();
            tbPrecioVenta.Text = ((1 + auxProduct.CoefUtil) * (auxProduct.PrecioCosto)).ToString();
            cbxEstado.Checked = auxProduct.Estado;

            nudStockMinimo.Value = auxProduct.StockMinimo;
            nudGanancia.Value = Convert.ToDecimal(auxProduct.CoefUtil * 100);

            cbCategoria.SelectedItem = Devuelve.Categoria(auxProduct.IdCategoria).Descripcion;
            cbTalle.SelectedItem = auxProduct.Talle;
            cbProveedor.SelectedItem = auxProduct.Proveedor.Nombre;
        }

        public void limpia()
        {
            tbNombreProducto.Text = String.Empty;
            ntbPrecioCosto.Text = String.Empty;
            nudGanancia.Value = 1;
            cbxEstado.Checked = true;
            tbPrecioVenta.Text = String.Empty;
            nudStockMinimo.Value = 1;
        }

        public void refresca()
        {
            dgvProductosEdit.DataSource = null;
            dgvProductosEdit.DataSource = Filtra.Filtro(cbTalleModificPr.Text, cbCatModifProd.Text, tbDescripModificP.Text);
            acomodaDGV();
        }

        private void acomodaDGV()
        {
            dgvProductosEdit.Columns[0].Visible = false;
            dgvProductosEdit.Columns["IdCategoria"].Visible = false;
            dgvProductosEdit.Columns["Estado"].Visible = false;
            dgvProductosEdit.Columns["IdCategoria1"].Visible = false;
            dgvProductosEdit.Columns["IdProveedor"].Visible = false;
            dgvProductosEdit.Columns["Descripcion1"].HeaderText = "Categoria";
            dgvProductosEdit.Columns["Estado1"].Visible = false;

            dgvProductosEdit.Columns["PrecioCosto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductosEdit.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductosEdit.Columns["StockMinimo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductosEdit.Columns["CoefUtil"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductosEdit.Columns["Talle"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProductosEdit.Columns["PrecioCosto"].DefaultCellStyle.Format = "c";

            dgvProductosEdit.Columns["PrecioCosto"].HeaderText = "Precio de Costo";
            dgvProductosEdit.Columns["StockMinimo"].HeaderText = "Stock Minimo";
            dgvProductosEdit.Columns["CoefUtil"].HeaderText = "Coeficiente de Utilidad";
            dgvProductosEdit.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewRow r in dgvProductosEdit.Rows)
            {
                int t = r.Index;
                if (t >= 0 && dgvProductosEdit.Rows[t].Cells["Stock"].Value != null)
                {
                    if (Convert.ToInt32(dgvProductosEdit.Rows[t].Cells["Stock"].Value) <= 0)
                    {
                        r.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (Convert.ToInt32(dgvProductosEdit.Rows[t].Cells["StockMinimo"].Value) >= Convert.ToInt32(dgvProductosEdit.Rows[t].Cells["Stock"].Value))
                    {
                        r.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
            }
        }
    }
}
