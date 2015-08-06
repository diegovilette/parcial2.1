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
using Manejadores;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication2
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        public int devuelveCateria(string descripcion)
        {
            foreach (Categoria c in Devuelve.Categorias())
            {
                if (c.Descripcion == descripcion)
                {
                    return c.Id;
                }
            }

            return -1; //Nunca va a llegar aquí
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

        public bool controlaCamp()
        {
            if (tbNombreArticulo.Text != string.Empty && tbPrecioCosto.Text != string.Empty && cbCategoria.Text != string.Empty && cbProveedor.Text != string.Empty && cbTalle.Text != string.Empty)
            {

                return true;
            }
            else
            {
                MessageBox.Show("Hay campos sin completar", "ALERTA");
                return false;
            }

        }
      

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            frmCategoria cat = new frmCategoria();
            cat.ShowDialog();
            if (cbCategoria.Items.Count >0)
                cbCategoria.Items.Clear();
            foreach (Categoria ca in Devuelve.Categorias())
            {
                cbCategoria.Items.Add(ca.Descripcion);
            }
        }

        private void btnProveedorCrea_Click_1(object sender, EventArgs e)
        {
            frmProveedor prov = new frmProveedor();
            prov.ShowDialog();
        }
        public Proveedor obtenerProveedor()
        {
            foreach (Proveedor pr in Devuelve.Proveedores())
            {
                if (cbProveedor.Text == pr.Nombre)
                {
                    return pr;
                }
            }
            return null; //Nunca va llegar a esta instancia, siempre habrá un proveedor
        }
        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            if (controlaRep(tbNombreArticulo.Text, cbTalle.Text) && controlaCamp())
            {
                Producto pr = new Producto();
                pr.Descripcion = tbNombreArticulo.Text;
                pr.IdCategoria = devuelveCateria(cbCategoria.Text);
                pr.PrecioCosto = Convert.ToInt32(tbPrecioCosto.Text);
                pr.Stock = 0;
               
                pr.StockMinimo = Convert.ToInt32(nudStockMinimo.Value);
                pr.Talle = cbTalle.Text;
                pr.CoefUtil =(float)Convert.ToDouble((nudGanancia.Value)/100);
                pr.Estado = true;
                pr.Proveedor = obtenerProveedor();
                
                Agrega.Producto(pr);
                MessageBox.Show("Producto creado satisfactoriamente", "EXITO");
            }
        }

        private void tbPrecioCosto_TextChanged_1(object sender, EventArgs e)
        {
            tbPrecioVenta.Text = "0";
            nudGanancia.Value = 0;
            
           
        }

        private void tbPrecioCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
                        char ch = e.KeyChar;
                        if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
                        {
                            e.Handled = true;
                        }
        }

        private void nudGanancia_ValueChanged_1(object sender, EventArgs e)
        {
            if (tbPrecioCosto.Text == string.Empty)
            {
            }
            else
            {
                double cuenta = Convert.ToDouble(tbPrecioCosto.Text);
                cuenta += (cuenta * Convert.ToDouble(nudGanancia.Value)) / 100;
                tbPrecioVenta.Text = cuenta.ToString();
            }
        }

        private void frmProducto_Load_1(object sender, EventArgs e)
        {
            tbPrecioCosto.Text = "0";
            foreach (Categoria ca in Devuelve.Categorias())
            {
                cbCategoria.Items.Add(ca.Descripcion);
            }

            foreach (Proveedor pr in Devuelve.Proveedores())
            {
                cbProveedor.Items.Add(pr.Nombre);
            }

            foreach (String p in Enum.GetNames(typeof(eTalle)))
            {

                cbTalle.Items.Add(p);
                }
            
        }

        


    }
}
