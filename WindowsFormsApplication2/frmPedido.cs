using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace WindowsFormsApplication2
{
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        DataTable dtPedido;
        DataTable dtStock;

        private void frmPedido2_Load(object sender, EventArgs e)
        {
            cbTalleStcok.Text = "Todo";
            cbCategoriaStock.Text = "Todo";
            //acomodaDGV();

            ////////////////////////////////////////////////
            dtPedido = new DataTable();
            DataColumn[] dcPedido = new DataColumn[6];
            dcPedido[0] = new DataColumn("IdProducto", typeof(int));
            dcPedido[1] = new DataColumn("Descripcion", typeof(String));
            dcPedido[2] = new DataColumn("PrecioCosto", typeof(float));
            dcPedido[3] = new DataColumn("Talle", typeof(String));
            dcPedido[4] = new DataColumn("Cantidad", typeof(int));
            dtPedido.Columns.AddRange(dcPedido);
            //dtPedido.NewRow();
            //dtPedido.Rows[0];
            ////////////////////////////////////////////////
            //dgvPedido.AutoGenerateColumns = false;
            dgvPedido.DataSource = dtPedido;
            foreach (Categoria c in Devuelve.Categorias())
            {
                cbCategoriaStock.Items.Add(c.Descripcion);
            }

            foreach (String p in Enum.GetNames(typeof(eTalle)))
            {
                cbTalleStcok.Items.Add(p);
            }

            List<Proveedor> provee = Devuelve.Proveedores();

            foreach (Proveedor p in provee)
            {
                cbProveedor.Items.Add(p.Nombre);
            }
            if (provee.Count > 0)
                cbProveedor.SelectedIndex = 0;
            dtStock = Filtra.FiltroProveedor("Todo", "Todo", "", cbProveedor.Text);
            //dtStock = Filtra.Filtro("Todo", "Todo", "");
            dgvStock.DataSource = dtStock;
            acomodaDGV();
        }

        private void acomodaDGV()
        {
            dgvStock.Columns[0].Visible = false;
            dgvStock.Columns[6].Visible = false;
            dgvStock.Columns["Estado"].Visible = false;
            dgvStock.Columns["IdCategoria1"].Visible = false;
            dgvStock.Columns["IdProveedor"].Visible = false;
            dgvStock.Columns["Descripcion1"].HeaderText = "Categoria";
            dgvStock.Columns["Estado1"].Visible = false;

            dgvStock.Columns["PrecioCosto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvStock.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvStock.Columns["StockMinimo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvStock.Columns["CoefUtil"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvStock.Columns["Talle"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvStock.Columns["PrecioCosto"].DefaultCellStyle.Format = "c";

            dgvStock.Columns["PrecioCosto"].HeaderText = "Precio de Costo";
            dgvStock.Columns["StockMinimo"].HeaderText = "Stock Minimo";
            dgvStock.Columns["CoefUtil"].HeaderText = "Coeficiente de Utilidad";
            dgvStock.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewRow r in dgvStock.Rows)
            {
                int t = r.Index;
                if (t >= 0 && dgvStock.Rows[t].Cells["Stock"].Value != null)
                {
                    if (Convert.ToInt32(dgvStock.Rows[t].Cells["Stock"].Value) <= 0)
                    {
                        r.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (Convert.ToInt32(dgvStock.Rows[t].Cells["StockMinimo"].Value) >= Convert.ToInt32(dgvStock.Rows[t].Cells["Stock"].Value))
                    {
                        r.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
            }
        }

        private void cbCategoriaStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dgvStock.DataSource = Filtra.FiltroProveedor(cbTalleStcok.Text, cbCategoriaStock.Text, tbDescripcionStock.Text,cbProveedor.SelectedText);
            if (dtStock != null)
            {
                dtStock.Rows.Clear();
                dtStock = Filtra.FiltroProveedor(cbTalleStcok.Text, cbCategoriaStock.Text, tbDescripcionStock.Text, cbProveedor.Text);
                dgvStock.DataSource = null;
                dgvStock.DataSource = dtStock;
            }

            if (dtPedido != null && dtPedido.Rows.Count > 0)
            {
                dtPedido.Rows.Clear();
            }
            acomodaDGV();
        }

        public void actualizaPedido()
        {
            int cuenta = 0;
            float total = 0;
            if (dtPedido.Rows.Count > 0)
            {
                for (int i = 0; i < dtPedido.Rows.Count; i++)
                {
                    cuenta += Convert.ToInt32(dtPedido.Rows[i]["Cantidad"]);
                    total += (float)dtPedido.Rows[i]["PrecioCosto"] * Convert.ToInt32(dtPedido.Rows[i]["Cantidad"]);
                }
            }
            tbNumeroDato.Text = cuenta.ToString();
            tbTotalDato.Text = total.ToString();
        }

        private void dgvStock_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvStock.RowCount < 1 || dgvStock.CurrentRow == null)
                MessageBox.Show("Debe selecionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int id = Convert.ToInt32(dgvStock.CurrentRow.Cells["IdProducto"].Value);
                DataRow row = dtPedido.NewRow();
                row["IdProducto"] = Convert.ToInt32(dgvStock.CurrentRow.Cells["IdProducto"].Value);
                row["Descripcion"] = dgvStock.CurrentRow.Cells["Descripcion"].Value.ToString();
                row["PrecioCosto"] = dgvStock.CurrentRow.Cells["PrecioCosto"].Value;
                row["Talle"] = dgvStock.CurrentRow.Cells["Talle"].Value.ToString();
                row["Cantidad"] = Convert.ToInt32(nudCantidad.Value);
                dtPedido.Rows.Add(row);
                actualizaPedido();

            }
        }

        private void dgvPedido_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvPedido.RowCount < 1 || dgvPedido.CurrentRow == null)
                MessageBox.Show("Debe selecionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int id = Convert.ToInt32(dgvPedido.CurrentRow.Cells["IdProducto"].Value);
                if (dtPedido.Rows.Count > 0)
                {
                    DataRow row = dtPedido.NewRow();
                    for (int i = 0; i < dtPedido.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dtPedido.Rows[i]["IdProducto"]) == id)
                        {
                            row = dtPedido.Rows[i];
                        }
                    }

                    dtPedido.Rows.Remove(row);
                    actualizaPedido();
                }
            }
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            if (dtPedido.Rows.Count <= 0)
            {
                MessageBox.Show("Debe selecionar al menos un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Pedido pedido = new Pedido();
                pedido.Fecha = System.DateTime.Today;
                pedido.Productos = new List<Producto>();
                for (int i = 0; i < dtPedido.Rows.Count; i++)
                {
                    Producto aux = new Producto();
                    aux = Devuelve.Producto((Convert.ToInt32(dtPedido.Rows[i]["IdProducto"])));
                    aux.Stock = Convert.ToInt32(dtPedido.Rows[i]["Cantidad"]);
                    pedido.Productos.Add(aux);
                    foreach (Proveedor p in Devuelve.Proveedores())
                    {
                        if (cbProveedor.Text == p.Nombre)
                            pedido.Proveedor = p;
                    }                                     
                }
                try
                {
                    Agrega.Pedido(pedido);
                    MessageBox.Show("Pedido registrado con exito", "Operacion completa");
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.Message, "Se produjo el siguiente error");
                }   
            }
        }
    }
}
