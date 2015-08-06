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
    public partial class frmRemito : Form
    {
        public frmRemito()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtRemito.Rows.Count <= 0)
            {
                MessageBox.Show("Debe selecionar al menos un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Remito remito = new Remito();
                remito.Fecha = System.DateTime.Today;
                remito.Productos = new List<Producto>();
                for (int i = 0; i < dtRemito.Rows.Count; i++)
                {
                    Producto aux = new Producto();
                    aux = Devuelve.Producto((Convert.ToInt32(dtRemito.Rows[i]["IdProducto"])));
                    aux.Stock = Convert.ToInt32(dtRemito.Rows[i]["Cantidad"]);
                    remito.Productos.Add(aux);
                    foreach (Proveedor p in Devuelve.Proveedores())
                    {
                        if (cbProveedor.Text == p.Nombre)
                            remito.IdProveedor = p.Id;
                    }                                      
                }
                remito.IdPedido = Convert.ToInt32(cbPedido.Text); 
                try
                {
                    Agrega.Remito(remito);
                    MessageBox.Show("Remito registrado con exito", "Operacion completa");
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.Message, "Se produjo el siguiente error");
                }
            }
        }

        DataTable dtPedido;
        DataTable dtRemito;

        private void frmRemito_Load(object sender, EventArgs e)
        {
            dtPedido = new DataTable();
            dtRemito = new DataTable();
            DataColumn[] dcPedido = new DataColumn[6];
            dcPedido[0] = new DataColumn("IdProducto", typeof(int));
            dcPedido[1] = new DataColumn("Descripcion", typeof(String));
            dcPedido[2] = new DataColumn("PrecioCosto", typeof(float));
            dcPedido[3] = new DataColumn("Talle", typeof(String));
            dcPedido[4] = new DataColumn("Cantidad", typeof(int));

            DataColumn[] dcRemito = new DataColumn[6];
            dcRemito[0] = new DataColumn("IdProducto", typeof(int));
            dcRemito[1] = new DataColumn("Descripcion", typeof(String));
            dcRemito[2] = new DataColumn("PrecioCosto", typeof(float));
            dcRemito[3] = new DataColumn("Talle", typeof(String));
            dcRemito[4] = new DataColumn("Cantidad", typeof(int));

            dtPedido.Columns.AddRange(dcPedido);
            dtRemito.Columns.AddRange(dcRemito);
            dgvProductos.DataSource = dtPedido;
            dgvRemito.DataSource = dtRemito;

            foreach (Proveedor p in Devuelve.Proveedores())
            {
                cbProveedor.Items.Add(p.Nombre);
            }
            if (cbProveedor.Items.Count > 0)
            {
                cbProveedor.SelectedIndex = 0;
                foreach (Pedido p in Devuelve.Pedidos())
                {
                    if (p.Proveedor.Nombre == cbProveedor.Text)
                    {
                        cbPedido.Items.Add(p.Id);
                    }
                }
            }
            if (cbPedido.Items.Count > 0)
            {
                cbPedido.SelectedIndex = 0;
                cargaPedido(Convert.ToInt32(cbPedido.Text));
            }
        }

        private void cargaPedido(int i)
        {
            if (dtPedido != null)
            {
                dtPedido.Rows.Clear();
                Pedido aux = Devuelve.Pedido(i);
                if (aux != null)
                {
                    foreach (Producto p in aux.Productos)
                    {
                        DataRow row = dtPedido.NewRow();
                        row["IdProducto"] = p.Id;
                        row["Descripcion"] = p.Descripcion;
                        row["PrecioCosto"] = p.PrecioCosto;
                        row["Talle"] = p.Talle;
                        row["Cantidad"] = p.Stock;
                        dtPedido.Rows.Add(row);
                    }
                }
            }
        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProveedor.Items.Count > 0)
            {
                cbPedido.Items.Clear();
                foreach (Pedido p in Devuelve.Pedidos())
                {
                    if (p.Proveedor.Nombre == cbProveedor.Text)
                    {
                        cbPedido.Items.Add(p.Id);
                    }
                }
            }
            if (cbPedido.Items.Count > 0)
            {
                cbPedido.SelectedIndex = 0;
                cargaPedido(Convert.ToInt32(cbPedido.Text));
            }

        }

        private void cbPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPedido.Items.Count > 0)
            {
                cargaPedido(Convert.ToInt32(cbPedido.Text));
            }
        }

        private void dgvProductos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvProductos.RowCount < 1 || dgvProductos.CurrentRow == null)
                MessageBox.Show("Debe selecionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataRow row = dtRemito.NewRow();
                row["IdProducto"] = Convert.ToInt32(dgvProductos.CurrentRow.Cells["IdProducto"].Value);
                row["Descripcion"] = dgvProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                row["PrecioCosto"] = dgvProductos.CurrentRow.Cells["PrecioCosto"].Value;
                row["Talle"] = dgvProductos.CurrentRow.Cells["Talle"].Value.ToString();
                row["Cantidad"] = Convert.ToInt32(nudCantidad.Value);
                dtRemito.Rows.Add(row);
            }
        }

        private void dgvRemito_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvProductos.RowCount < 1 || dgvProductos.CurrentRow == null)
                MessageBox.Show("Debe selecionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int id = Convert.ToInt32(dgvRemito.CurrentRow.Cells["IdProducto"].Value);
                if (dtRemito.Rows.Count > 0)
                {
                    DataRow row = dtRemito.NewRow();
                    for (int i = 0; i < dtRemito.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dtRemito.Rows[i]["IdProducto"]) == id)
                        {
                            row = dtRemito.Rows[i];
                        }
                    }
                    dtRemito.Rows.Remove(row);
                }
            }
        }
      
    }
}
