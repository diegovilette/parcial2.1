using System;
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
using MySql.Data.MySqlClient;
using Logica;

namespace WindowsFormsApplication2
{

    public partial class frmConsultarStock : Form
    {
        

        public frmConsultarStock()
        {
            InitializeComponent();
        }

        private void frmConsultarStock_Load(object sender, EventArgs e)
        {

            
            dgvStock.DataSource = Filtra.Filtro("Todo", "Todo", "");
            cbTalleStcok.Text = "Todo";
            cbCategoriaStock.Text = "Todo";
            acomodaDGV();


            foreach (Categoria c in Devuelve.Categorias())
            {
                cbCategoriaStock.Items.Add(c.Descripcion);
            }

            foreach (String p in Enum.GetNames(typeof(eTalle)))
            {
                cbTalleStcok.Items.Add(p);
            }
            //string conex="Server=" + "sql5.freemysqlhosting.net" + ";Port=3306;Database=" + "sql580946" + ";Uid=" + "sql580946" + ";Pwd=" + "xQ9%qL6%" + "; Convert Zero DateTime=true;";
            /*ManejaProducto producto = new ManejaProducto();
            dgvStock.DataSource = producto.Todo();*/
            //dgvStock.DataSource = vent.Todo();

        }

        private void acomodaDGV()
        {
            dgvStock.Columns[0].Visible = false;
            dgvStock.Columns["IdCategoria"].Visible = false;
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
            //MessageBox.Show(Filtro(cbTalleStcok.Text,cbCategoriaStock.Text, tbDescripcionStock.Text));
            dgvStock.DataSource = Filtra.Filtro(cbTalleStcok.Text, cbCategoriaStock.Text, tbDescripcionStock.Text);
            acomodaDGV();
        }
       
    }    
            
}
