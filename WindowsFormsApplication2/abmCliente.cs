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
    public partial class abmCliente : Form
    {
        Cliente auxCliente;
        ABM estado;

        public abmCliente()
        {
            InitializeComponent();
        }

        private void abmCliente_Load(object sender, EventArgs e)
        {
            estado = ABM.Nada;
            auxCliente = new Cliente();
            refresca();
        }

        private void ctrlABM1_Alta(object sender)
        {
            auxCliente = new Cliente();
            estado = ABM.Alta;
            pnlBuscaProducto.Enabled = false;
            pnlEditaProducto.Enabled = true;
            limpia();
        }

        private void ctrlABM1_Cancelar(object sender)
        {
            switch (estado)
            {
                case ABM.Alta:
                    {
                        pnlEditaProducto.Enabled = false;
                        limpia();
                    } break;
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
            switch (estado)
            {
                case ABM.Alta:
                    {
                        if (validaForm())
                        {
                            if (controlaRep(tbNombre.Text, tbApellido.Text, tbEmail.Text, tbDomicilio.Text))
                            {
                                creaCliente();
                                if (auxCliente.Telefonos.Count > 0)
                                    Agrega.Telefono(auxCliente.Telefonos[0]);
                                else
                                    auxCliente.Telefonos.Clear();
                                Agrega.Cliente(auxCliente);
                                MessageBox.Show("Cliente creado satisfactoriamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            creaCliente();
                            if (auxCliente.Telefonos.Count > 0)
                                Agrega.Telefono(auxCliente.Telefonos[0]);
                            Actualiza.Cliente(auxCliente);
                            MessageBox.Show("Cliente modificado satisfactoriamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cancela = true;
                            pnlBuscaProducto.Enabled = false;
                            pnlEditaProducto.Enabled = false;
                            limpia();
                            refresca();
                        }

                    } break;
                case ABM.Baja:
                    {
                        if (dgvClientesEdit.RowCount < 1 || dgvClientesEdit.CurrentRow == null)
                            MessageBox.Show("Debe selecionar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            Elimina.Cliente(Devuelve.Cliente((int)dgvClientesEdit.CurrentRow.Cells["Id"].Value));
                            refresca();
                            cancela = true;
                            pnlBuscaProducto.Enabled = false;
                            MessageBox.Show("Cliente eliminado satisfactoriamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    } break;
                default: break;
            }
            estado = ABM.Nada;
        }

        public bool validaForm()
        {
            bool estado = false;
            if (tbNombre.Text != String.Empty && tbApellido.Text != String.Empty)
            {
                if (tbEmail.Text != String.Empty && tbDomicilio.Text != String.Empty)
                {
                        estado = true;
                }
            }
            if (!estado)
                MessageBox.Show("Faltan campos por llenar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return estado;
        }

        public void creaCliente()
        {
            auxCliente.Nombre = tbNombre.Text;
            auxCliente.Apellido = tbApellido.Text;
            auxCliente.Domicilio = tbDomicilio.Text;
            auxCliente.Email = tbEmail.Text;
            auxCliente.Estado = cbxEstado.Checked;
            auxCliente.FechaAlta = dtFechaAlta.Value;
            auxCliente.Tipo = cbTipo.SelectedIndex;
            if (tbCuit.Text != String.Empty)
                auxCliente.Cuit = tbCuit.Text;
            else
                auxCliente.Cuit = "";
            if (tbTelefono.Text != String.Empty)
            {
                auxCliente.Telefonos.Clear();
                Telefono auxTelefono = new Telefono();
                auxTelefono.Numero = Convert.ToInt32(tbTelefono.Text);
                auxCliente.Telefonos.Add(auxTelefono);
            }
            else
                auxCliente.Telefonos.Clear();
        }

        public bool controlaRep(string nombre, string apellido, string mail, string domicilio)
        {
            foreach (Cliente pr in Devuelve.Clientes())
            {
                if (pr.Nombre == nombre && pr.Apellido == apellido && pr.Email == mail && pr.Domicilio == domicilio && pr.Estado)
                {
                    MessageBox.Show("Ya existe un cliente con estos datos", "ALERTA");
                    return false;
                }
            }
            return true;
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
            auxCliente = new Cliente();
            pnlBuscaProducto.Enabled = true;
        }

        private void dgvProductosEdit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (estado == ABM.Modificacion)
            {
                pnlEditaProducto.Enabled = true;
                if (dgvClientesEdit.SelectedRows.Count != 0)
                {
                    auxCliente = Devuelve.Cliente((int)dgvClientesEdit.CurrentRow.Cells["Id"].Value);
                    if (auxCliente != null)
                    {
                        limpia();
                        llenarCampos();
                    }
                }
            }
        }

        private void llenarCampos()
        {
            tbNombre.Text = auxCliente.Nombre;
            tbApellido.Text = auxCliente.Apellido;
            tbEmail.Text = auxCliente.Email;
            tbCuit.Text = auxCliente.Cuit;
            cbTipo.SelectedIndex = auxCliente.Tipo;
            if (auxCliente.Telefonos.Count > 0)
                tbTelefono.Text = auxCliente.Telefonos[0].Numero.ToString();
            dtFechaAlta.Value = Convert.ToDateTime(auxCliente.FechaAlta);
            tbDomicilio.Text = auxCliente.Domicilio;
            cbxEstado.Checked = auxCliente.Estado;
        }

        public void limpia()
        {
            tbNombre.Text = String.Empty;
            tbApellido.Text = String.Empty;            
            tbEmail.Text = String.Empty;
            tbDomicilio.Text = String.Empty;
            tbTelefono.Text = String.Empty;
            tbCuit.Text = String.Empty;
        }

        public void refresca()
        {
            dgvClientesEdit.DataSource = null;
            dgvClientesEdit.DataSource = Devuelve.Clientes();
            acomodaDGV();
        }

        private void acomodaDGV()
        {
            dgvClientesEdit.Columns["Id"].Visible = false;
            dgvClientesEdit.Columns["Tipo"].Visible = false;
            foreach (DataGridViewRow r in dgvClientesEdit.Rows)
            {
                int t = r.Index;
                if (t >= 0 && dgvClientesEdit.Rows[t].Cells["Tipo"].Value != null)
                {
                    if (Convert.ToInt32(dgvClientesEdit.Rows[t].Cells["Tipo"].Value) == 0)
                    {
                        r.DefaultCellStyle.BackColor = Color.LimeGreen;
                    }
                    else 
                    {
                        r.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
            }
        }

        private void ctrlABM1_Load(object sender, EventArgs e)
        {

        }
    }
}
