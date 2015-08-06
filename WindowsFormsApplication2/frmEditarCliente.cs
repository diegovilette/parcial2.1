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

namespace WindowsFormsApplication2
{
    public partial class frmEditarCliente : Form
    {
        public frmEditarCliente()
        {
            InitializeComponent();
        }

        Cliente cl;
        int id = -1;

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            dgvClientesEdit.DataSource = Devuelve.Clientes();
        }

        public void limpiarElementos()
        {
            tbApellido.Text = string.Empty;
            tbDomicilio.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbNombre.Text = string.Empty;
            cbEstado.Text = string.Empty;

        }


        private void btnActualiza_Click(object sender, EventArgs e)
        {

            if (id != -1 && controlCampos())
            {
                cl = Devuelve.Cliente(id);
                cl.Apellido = tbApellido.Text;
                cl.Domicilio = tbDomicilio.Text;
                cl.Email = tbEmail.Text;
                cl.Estado = Convert.ToBoolean(cbEstado.Text);
                cl.FechaAlta = dtFechaAlta.Value;
                cl.Nombre = tbNombre.Text;
                Actualiza.Cliente(cl);
                dgvClientesEdit.DataSource = Devuelve.Clientes();
                id = -1;
                MessageBox.Show("Se modificó satisfactoriamente", "ÉXITO");
                limpiarElementos();
            }
            else
            {
                MessageBox.Show("No has seleccionado ningún cliente", "ALERTA");
            }
        }

        

        public bool controlCampos()
        {
            if (tbApellido.Text != string.Empty && tbDomicilio.Text != string.Empty && tbEmail.Text != string.Empty && tbNombre.Text != string.Empty && cbEstado.Text != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void dgvClientesEdit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                    tbNombre.Text = dgvClientesEdit.CurrentRow.Cells["Nombre"].Value.ToString();
                    tbApellido.Text = dgvClientesEdit.CurrentRow.Cells["Apellido"].Value.ToString();
                    tbEmail.Text = dgvClientesEdit.CurrentRow.Cells["Email"].Value.ToString();
                    dtFechaAlta.Value = Convert.ToDateTime(dgvClientesEdit.CurrentRow.Cells["FechaAlta"].Value);
                    tbDomicilio.Text = dgvClientesEdit.CurrentRow.Cells["Domicilio"].Value.ToString();
                    id = Convert.ToInt32(dgvClientesEdit.CurrentRow.Cells["Id"].Value);
                    cbEstado.Text = dgvClientesEdit.CurrentRow.Cells["Estado"].Value.ToString();
        }




    }
}
