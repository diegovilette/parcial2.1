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
    public partial class abmProveedor : Form
    {
        Proveedor auxProvee;
        ABM estado;

        public abmProveedor()
        {
            InitializeComponent();
        }

        private void abmProveedor_Load(object sender, EventArgs e)
        {
            estado = ABM.Nada;
            auxProvee = new Proveedor();
            refresca();
        }

        private void ctrlABM1_Alta(object sender)
        {
            auxProvee = new Proveedor();
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
                            if (controlaRep(tbCuit.Text))
                            {
                                creaCliente();
                                if (auxProvee.Telefonos.Count > 0)
                                {
                                    foreach (Telefono tel in auxProvee.Telefonos)
                                        Agrega.Telefono(tel);
                                }
                                else
                                    auxProvee.Telefonos.Clear();
                                Agrega.Proveedor(auxProvee);
                                MessageBox.Show("Proveedor creado satisfactoriamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            if (auxProvee.Telefonos.Count > 0)
                            {
                                foreach (Telefono tel in auxProvee.Telefonos)
                                    Agrega.Telefono(tel);
                            }
                            Actualiza.Proveedor(auxProvee);
                            MessageBox.Show("Proveedor modificado satisfactoriamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            MessageBox.Show("Debe selecionar un Proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            Elimina.Proveedor(Devuelve.Proveedor((int)dgvClientesEdit.CurrentRow.Cells["Id"].Value));
                            refresca();
                            cancela = true;
                            pnlBuscaProducto.Enabled = false;
                            MessageBox.Show("Proveedor eliminado satisfactoriamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    } break;
                default: break;
            }
            estado = ABM.Nada;
        }

        public bool validaForm()
        {
            bool estado = false;
            if (tbNombre.Text != String.Empty && tbCuit.Text != String.Empty)
            {
                estado = true;
            }
            if (!estado)
                MessageBox.Show("Faltan campos por llenar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return estado;
        }

        public void creaCliente()
        {
            auxProvee.Nombre = tbNombre.Text;
            auxProvee.Estado = cbxEstado.Checked;
            auxProvee.Cuit = tbCuit.Text;
            if (ntbTelefono.Text == String.Empty && ntbTelefono2.Text == String.Empty)
            {
                auxProvee.Telefonos.Clear();
            }
            else
            {
                if (ntbTelefono.Text != String.Empty && ntbTelefono2.Text == String.Empty)
                {
                    auxProvee.Telefonos.Clear();
                    Telefono auxTelefono = new Telefono();
                    auxTelefono.Numero = Convert.ToInt32(ntbTelefono.Text);
                    auxProvee.Telefonos.Add(auxTelefono);
                }
                else if (ntbTelefono.Text == String.Empty && ntbTelefono2.Text != String.Empty)
                {
                    auxProvee.Telefonos.Clear();
                    Telefono auxTelefono = new Telefono();
                    auxTelefono.Numero = Convert.ToInt32(ntbTelefono2.Text);
                    auxProvee.Telefonos.Add(auxTelefono);
                }
                else
                {
                    auxProvee.Telefonos.Clear();
                    Telefono auxTelefono = new Telefono();
                    Telefono auxTelefono2 = new Telefono();
                    auxTelefono.Numero = Convert.ToInt32(ntbTelefono.Text);
                    auxTelefono2.Numero = Convert.ToInt32(ntbTelefono2.Text);
                    auxProvee.Telefonos.Add(auxTelefono);
                    auxProvee.Telefonos.Add(auxTelefono2);
                }
            }
        }

        public bool controlaRep(string cuit)
        {
            foreach (Proveedor pr in Devuelve.Proveedores())
            {
                if (pr.Cuit == cuit)
                {
                    MessageBox.Show("Ya existe un proveedor con estos datos", "ALERTA");
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
            auxProvee = new Proveedor();
            pnlBuscaProducto.Enabled = true;
        }

        private void dgvProductosEdit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (estado == ABM.Modificacion)
            {
                pnlEditaProducto.Enabled = true;
                if (dgvClientesEdit.SelectedRows.Count != 0)
                {
                    auxProvee = Devuelve.Proveedor((int)dgvClientesEdit.CurrentRow.Cells["Id"].Value);
                    if (auxProvee != null)
                    {
                        limpia();
                        llenarCampos();
                    }
                }
            }
        }

        private void llenarCampos()
        {
            tbNombre.Text = auxProvee.Nombre;
            tbCuit.Text = auxProvee.Cuit;
            if (auxProvee.Telefonos.Count > 0)
                ntbTelefono.Text = auxProvee.Telefonos[0].Numero.ToString();
            if (auxProvee.Telefonos.Count > 1)
                ntbTelefono2.Text = auxProvee.Telefonos[1].Numero.ToString();
            cbxEstado.Checked = auxProvee.Estado;
        }

        public void limpia()
        {
            tbNombre.Text = String.Empty;
            ntbTelefono.Text = String.Empty;
            ntbTelefono2.Text = String.Empty;
            tbCuit.Text = String.Empty;
        }

        public void refresca()
        {
            dgvClientesEdit.DataSource = null;
            dgvClientesEdit.DataSource = Devuelve.Proveedores();
            acomodaDGV();
        }

        private void acomodaDGV()
        {
            dgvClientesEdit.Columns["Id"].Visible = false;
        }
    }
}
