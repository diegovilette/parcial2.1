using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;
using Entidades;
using System.Windows.Forms.DataVisualization.Charting;
namespace WindowsFormsApplication2
{
    public partial class frmGraficas : Form
    {
        public frmGraficas()
        {
            InitializeComponent();
        }

        private void frmGraficas_Load(object sender, EventArgs e)
        {
            cbxSucursal.Items.Add("Esta sucursal");
            cbxSucursal.Items.Add("Todas las sucursales");
            cbxSucursal.SelectedIndex = 0;
            calcular();
        }

        private void calGrafica_DateChanged(object sender, DateRangeEventArgs e)
        {
            calcular();

        }

        public void calcular()
        {
            gCategorias.Titles.Clear();
            gVentas.Titles.Clear();
            //grafica torta
            List<Categoria> listaCategoria = Devuelve.Categorias();
            List<string> xValores = new List<string>();
            List<int> yValores = new List<int>();
            foreach (Categoria x in listaCategoria)
            {
                int cantidad = Devuelve.CantVendido(calGrafica.SelectionStart, x.Id, flagsucursal);
                if (cantidad != 0)
                {
                    xValores.Add(x.Descripcion);
                    yValores.Add(cantidad);
                }
            }
            gCategorias.Series["Series1"].Points.DataBindXY(xValores, yValores);
            gCategorias.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            gCategorias.Titles.Add("Porcentajes de productos Vendidos del Mes: " + calGrafica.SelectionStart.ToString("MMMM"));
            //grafica money
            gVentas.Series.Clear();
            Series series = this.gVentas.Series.Add("Plata");

            List<int> dias = new List<int>();
            List<double> vendido = new List<double>();

            for (int i = 1; i <= DateTime.DaysInMonth(calGrafica.SelectionStart.Year, calGrafica.SelectionStart.Month); i++)
            {
                double cantidad = Devuelve.CantVendidoDia(i, calGrafica.SelectionStart.Month, flagsucursal);
                dias.Add(i);
                vendido.Add(cantidad);
            }
            gVentas.Series["Plata"].Points.DataBindXY(dias, vendido);
            gVentas.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            gVentas.Titles.Add("Total Ventas del Mes: " + calGrafica.SelectionStart.ToString("MMMM"));

        }

        bool flagsucursal = true;
        private void cbxSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSucursal.SelectedIndex != 0)
            {
                flagsucursal = false;
            }
            else
            {
                flagsucursal = true;
            }
            calcular();
        }
    }
}
