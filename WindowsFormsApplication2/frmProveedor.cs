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
using Manejadores;

namespace WindowsFormsApplication2
{
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
        }
        Proveedor pr;
        Telefono te;
        List<Proveedor> lPr;
        private void frmProveedor_Load(object sender, EventArgs e)
        {
            lPr = Devuelve.Proveedores();
            CargaDGVProveedor();
        }

        private void btnCrearProveedor_Click(object sender, EventArgs e)
        {
            pr = new Proveedor();
            pr.Nombre = tbNombreMarcaNuevo.Text;
            pr.Estado = true;
            Agrega.Proveedor(pr);
            lPr.Add(pr);
            CargaDGVProveedor();
            tbNombreMarcaNuevo.Clear();
        }

        private void btnCargaTelefono_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.RowCount < 1 || dgvProveedor.CurrentRow == null)
                MessageBox.Show("Debe selecionar un proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                pr = new Proveedor();
                pr.Id = (int)dgvProveedor.CurrentRow.Cells["Id"].Value;
                pr.Nombre = dgvProveedor.CurrentRow.Cells["Nombre"].Value.ToString();
                te = new Telefono();
                te.Numero = Convert.ToInt32(tbTelefono.Text);
                Agrega.Telefono(te);
                Agrega.TelefonoProveedor(te, pr);
                lPr = Devuelve.Proveedores();
                CargaDGVTelefonos();
            }
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.RowCount < 1 || dgvProveedor.CurrentRow == null)
                MessageBox.Show("Debe selecionar un proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                pr = new Proveedor();
                pr.Id = (int)dgvProveedor.CurrentRow.Cells["Id"].Value;
                pr.Nombre = dgvProveedor.CurrentRow.Cells["Nombre"].Value.ToString();
                Elimina.Proveedor(pr);
                lPr = Devuelve.Proveedores();
                CargaDGVProveedor();
            }
        }

        public void CargaDGVProveedor()
        {
            dgvProveedor.DataSource = null;
            dgvProveedor.DataSource = lPr;
            dgvProveedor.Columns["Id"].Visible = false;
        }

        public void CargaDGVTelefonos()
        {            
            foreach (Proveedor p in lPr)
            {
                if (p.Id == (int)dgvProveedor.CurrentRow.Cells["Id"].Value)
                {
                    dgvTelefonoProveedor.DataSource = p.Telefonos;
                    dgvTelefonoProveedor.Columns["Id"].Visible = false;
                    break;
                }
            }
        }

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargaDGVTelefonos();
        }

        private void btnEliminaTel_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.RowCount < 1 || dgvProveedor.CurrentRow == null)
                MessageBox.Show("Debe selecionar un proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (dgvTelefonoProveedor.RowCount < 1 || dgvTelefonoProveedor.CurrentRow == null)
                    MessageBox.Show("Debe selecionar un telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    pr = new Proveedor();
                    pr.Id = (int)dgvProveedor.CurrentRow.Cells["Id"].Value;
                    te = new Telefono();
                    te.Id = (int)dgvTelefonoProveedor.CurrentRow.Cells["Id"].Value;
                    Elimina.TelefonoProveedor(te, pr);
                    lPr = Devuelve.Proveedores();
                    CargaDGVProveedor();
                    CargaDGVTelefonos();
                }
            }
        }
    }
}
