﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;

using Entidades;
using Logica;
namespace WindowsFormsApplication2
{
    public partial class frmRegistrarVenta : Form
    {
        public frmRegistrarVenta()
        {
            InitializeComponent();
        }
        Venta venta;
        Factura factura;
        Producto pr;
        List<Producto> lpr;
        List<Producto> lista;
        float total;
        Cliente cliente;


        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {          


        }



        private void frmRegistrarVenta_Load(object sender, EventArgs e)
        {
            total = 0;
            lista = new List<Producto>();
            lpr = Devuelve.Productos();
            dgvProductos.DataSource = lpr;
         
            cargarCombo();

        }

        public void cargarCombo() 
        {

            cbFiltroCategoria.Items.Add("Todo");
            
            cbFiltroCategoria.Text = "Todo";
            
            foreach (Categoria c in Devuelve.Categorias())
            {
                cbFiltroCategoria.Items.Add(c.Descripcion);
            }

            foreach (String p in Enum.GetNames(typeof(eTalle)))
            {
                cbFiltroTalle.Items.Add(p);
            }

            cbFiltroTalle.Items.Add("Todo");
            cbFiltroTalle.Text = "Todo";

        }

        private void cbFiltroTalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            refrescar();
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            if (dgvProductos.RowCount < 1 || dgvProductos.CurrentRow == null)
                MessageBox.Show("Debe selecionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //consigo el producto
                pr = Devuelve.Producto((int)dgvProductos.CurrentRow.Cells["IdProducto"].Value);
                //me fijo que alla suficiente stock
                if (pr.Stock >= nudCantidad.Value)
                {

                    bool existe = false;
                    int pos = 0;
                    foreach (Producto da in lista)
                    {
                        if (da.Id == pr.Id)
                        {
                            existe = true;
                            break;
                        }
                        pos++;
                    }

                    if (!existe)
                    {
                        int n = dgvVentas.Rows.Add();
                        dgvVentas.Rows[n].Cells["Descripcion"].Value = pr.Descripcion;
                        dgvVentas.Rows[n].Cells["Cant"].Value = nudCantidad.Value;
                        dgvVentas.Rows[n].Cells["Precio"].Value = pr.PrecioCosto * (1 + pr.CoefUtil);
                        dgvVentas.Rows[n].Cells["all"].Value = (pr.PrecioCosto * (1 + pr.CoefUtil)) * (int)nudCantidad.Value;

                        //Alineacion de campos numericos
                        dgvVentas.Rows[n].Cells["Precio"].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgvVentas.Rows[n].Cells["Cant"].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgvVentas.Rows[n].Cells["all"].Style.Alignment = DataGridViewContentAlignment.MiddleRight;

                        total += (pr.PrecioCosto * (1 + pr.CoefUtil)) * (int)nudCantidad.Value;

                        tbTotal.Text = total.ToString("#00.00#");

                        if (pr.StockMinimo > pr.Stock)
                            MessageBox.Show("Stock bajo de " + pr.Descripcion + "\ncantidad restante " + pr.Stock, "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        pr.Stock = (int)nudCantidad.Value;
                        
                        lista.Add(pr);

                    }
                    else
                    {
                        lista[pos].Stock += Convert.ToInt32(nudCantidad.Value);
                        dgvVentas.Rows[pos].Cells["Cant"].Value = lista[pos].Stock;
                        dgvVentas.Rows[pos].Cells["all"].Value = (pr.PrecioCosto * (1 + pr.CoefUtil)) * lista[pos].Stock;
                        total += (pr.PrecioCosto * (1 + pr.CoefUtil)) * Convert.ToInt32(nudCantidad.Value);
                        tbTotal.Text = total.ToString("#00.00#");
                    }
                }


                else
                {
                    MessageBox.Show("Stock insuficiente \nPorfavor actualize el stock", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (cliente.Tipo == 1)
                {
                    tbSubTotal.Text = (total - (total * (Convert.ToInt32(tbIva.Text)) / 100)).ToString("#00.00#");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lista.Count > 0)
            {
                factura = new Factura();
                venta = new Venta();
                venta.Total = total;
                venta.Fecha = DateTime.Now;
                factura.Venta = venta;
                factura.Cliente = cliente;
                factura.Iva = 0;
                
                    if (cliente.Tipo == 1)
                    {
                        // factura.Estado = true;
                        factura.Iva = (float)Convert.ToDouble(tbIva.Text);
                        if (Agrega.Venta(venta, lista, factura, true))
                        {
                            //imprime
                            frmTicket tic = new frmTicket(lista, venta.Id, cliente, factura);
                            tic.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Stock insuficiente para realizar la venta.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        
                            
                        
                    }
                    else
                    {
                        if (Agrega.Venta(venta, lista, factura, false))
                        {
                            //imprime
                            frmTicket tic = new frmTicket(lista, venta.Id, cliente, factura);
                            tic.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("En este momento el Stock es insuficiente\npara realizar la venta.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        
                    }

                    limpia();
                    refrescar();

            }else
                {
                    MessageBox.Show("Debe agregar al menos un producto.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            

        }

        

        private void btnQuitar_Click(object sender, EventArgs e)
        {

            Borrar();

        }

        private void Borrar()
        {
            if (dgvVentas.RowCount < 1 || dgvVentas.CurrentRow == null)
                MessageBox.Show("Debe selecionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int x = dgvVentas.CurrentRow.Index;
                dgvVentas.Rows.RemoveAt(x);
                total -= ((pr.PrecioCosto * pr.CoefUtil) * lista[x].Stock);
                tbTotal.Text = total.ToString("#00.00#");
                tbSubTotal.Text = (total - (total * (Convert.ToInt32(tbIva.Text)) / 100)).ToString("#00.00#");
                lista.RemoveAt(x);
            }
        }

        //arreglar esto DIego es para discriminar el iva
        private void rbTipoB_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void tbSubTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbIva_TextChanged(object sender, EventArgs e)
        {
           if (Convert.ToInt32(tbIva.Text)<0)
            {
                tbSubTotal.Text = (total - (total * (Convert.ToInt32(tbIva.Text)) / 100)).ToString("#00.00#");
            }
            else
            {
                tbIva.Text = (21).ToString();
            }           
        }

        private void btnValidarCuit_Click(object sender, EventArgs e)
        {
            cliente = Devuelve.Cliente(tbCuit.Text);

            if(cliente == null)
            {
                MessageBox.Show("El cuit introducido es invalido\npor favor ingrese uno valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnCancelarCuit.Enabled = true;
                btnValidarCuit.Enabled = false;
                btnAgregarCarrito.Enabled = true;
                btnQuitar.Enabled = true;
                dgvProductos.Enabled = true;
                btnVender.Enabled = true;
                btnAnularVenta.Enabled = true;
                tbCuit.Text = cliente.Apellido +" "+ cliente.Nombre; 
                tbCuit.Enabled = false;


                if(cliente.Tipo == 1)
                {
                    pnlTotal.Top = 504;
                    lbliva.Visible = true;
                    lblsubtotal.Visible = true;
                    tbIva.Visible = true;
                    tbSubTotal.Visible = true;

                    tbSubTotal.Text = (total - (total * (Convert.ToInt32(tbIva.Text)) / 100)).ToString("#00.00#");
                }
                else
                {
                    pnlTotal.Top = 433;
                    lbliva.Visible = false;
                    lblsubtotal.Visible = false;
                    tbIva.Visible = false;
                    tbSubTotal.Visible = false;
                }

                refrescar();
            }
        }

        private void btnCancelarCuit_Click(object sender, EventArgs e)
        {
            limpia();
        }

        private void limpia()
        {
            btnCancelarCuit.Enabled = false;
            btnValidarCuit.Enabled = true;
            btnAgregarCarrito.Enabled = false;
            btnQuitar.Enabled = false;
            dgvProductos.Enabled = false;
            btnVender.Enabled = false;
            btnAnularVenta.Enabled = false;
            tbCuit.Text = string.Empty;
            tbCuit.Enabled = true;
            dgvVentas.Rows.Clear();

            lista.Clear();
            total = 0;
            tbTotal.Text = total.ToString("#00.00#");
            tbSubTotal.Text = total.ToString("#00.00#");
            cliente = null;
        }

        private void refrescar()
        {
            dgvProductos.DataSource = Filtra.Filtro(cbFiltroTalle.Text, cbFiltroCategoria.Text, tbDescripcion.Text);
            acomodaDGV();
        }

        private void acomodaDGV()
        {
            dgvProductos.Columns[0].Visible = false;
            dgvProductos.Columns[6].Visible = false;
            dgvProductos.Columns["Estado"].Visible = false;
            dgvProductos.Columns["IdCategoria1"].Visible = false;
            dgvProductos.Columns["IdProveedor"].Visible = false;
            dgvProductos.Columns["Descripcion1"].HeaderText = "Categoria";
            dgvProductos.Columns["Estado1"].Visible = false;

            dgvProductos.Columns["PrecioCosto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns["StockMinimo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns["CoefUtil"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns["Talle"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProductos.Columns["PrecioCosto"].DefaultCellStyle.Format = "c";

            dgvProductos.Columns["PrecioCosto"].HeaderText = "Precio de Costo";
            dgvProductos.Columns["StockMinimo"].HeaderText = "Stock Minimo";
            dgvProductos.Columns["CoefUtil"].HeaderText = "Coeficiente de Utilidad";
            dgvProductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewRow r in dgvProductos.Rows)
            {
                int t = r.Index;
                if (t >= 0 && dgvProductos.Rows[t].Cells["Stock"].Value != null)
                {
                    if (Convert.ToInt32(dgvProductos.Rows[t].Cells["Stock"].Value) <= 0)
                    {
                        r.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (Convert.ToInt32(dgvProductos.Rows[t].Cells["StockMinimo"].Value) >= Convert.ToInt32(dgvProductos.Rows[t].Cells["Stock"].Value))
                    {
                        r.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
            }
        }
    }
}
