﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;
using Manejadores;
using Entidades;

namespace WindowsFormsApplication2
{
    public partial class frmDetallesVenta : Form
    {
        public frmDetallesVenta()
        {
            InitializeComponent();
        }

        private void frmDetallesVenta_Load(object sender, EventArgs e)
        {
            
            /*dgvFecha.Columns.Add("Fecha de Venta", "Fecha de Venta");
            dgvVentas.Columns.Add("Venta", "Venta");
            dgvVentas.Columns.Add("Total", "Total");
            dgvDetalleVenta.Columns.Add("Producto", "Producto");
            dgvDetalleVenta.Columns.Add("Precio Costo", "Precio Costo");
            dgvDetalleVenta.Columns.Add("Cantidad", "Cantidad");
            dgvDetalleVenta.Columns.Add("Coeficiente Util", "Coeficiente Util");*/
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value <= dtpHasta.Value)
            {
                dgvVentas.DataSource = null;

                dgvDetalleVenta.DataSource = null;
                String desde = dtpDesde.Value.Year.ToString() + "-" + dtpDesde.Value.Month.ToString() + "-" + dtpDesde.Value.Day.ToString();
                String hasta = dtpHasta.Value.Year.ToString() + "-" + dtpHasta.Value.Month.ToString() + "-" + dtpHasta.Value.Day.ToString();
                dgvFecha.DataSource = Filtra.filtraVenta(desde, hasta);
                if (dgvFecha.Rows.Count == 0)
                {
                    MessageBox.Show("No hay ventas realizadas en el rango elegido", "ADVERTENCIA");
                }
                
            }
            else 
            {
                MessageBox.Show("La venta inicial no puede superar a la final", "ADVERTENCIA");
            }

            


    
        }

        private void dgvFecha_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvFecha.Rows.Count == 0)
            {
                MessageBox.Show("No hay ventas realizadas en el rango elegido", "ADVERTENCIA");
            }
            else 
            {
                DateTime fecha = Convert.ToDateTime(dgvFecha.CurrentRow.Cells["Fecha"].Value);
                String formatoFecha = fecha.Year.ToString() + "-" + fecha.Month.ToString() + "-" + fecha.Day.ToString();
                dgvVentas.DataSource = Filtra.filtrafechas(formatoFecha);
                dgvDetalleVenta.DataSource = null;
            
            }
            
        }

        private void dgvVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVentas.Rows.Count == 0)
            {
                MessageBox.Show("No hay ventas realizadas en el rango elegido", "ADVERTENCIA");
            }
            else 
            {
                dgvDetalleVenta.DataSource = Filtra.detalleFiltrado(Convert.ToInt32(dgvVentas.CurrentRow.Cells["Venta"].Value));
            }
            
        }

        
    }
}
