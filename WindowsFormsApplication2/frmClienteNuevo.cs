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
    public partial class frmClienteNuevo : Form
    {
        public frmClienteNuevo()
        {
            InitializeComponent();
        }

        private string validar()
        {
            string res = string.Empty;
            if (tbNombre.Text == string.Empty)
            {
                res += "El Nombre no puede ser vacio";
            }
            if (tbApellido.Text == string.Empty)
            {
                res += "El Apellido no puede ser vacio";
            }
            if (tbDomicilio.Text == string.Empty)
            {
                res += "El Domicilio no puede ser vacio";
            }
            if (tbEmail.Text == string.Empty)
            {
                res += "El Email no puede ser vacio";
            }

            return res;
        }

        private void btnCreaCategoria_Click(object sender, EventArgs e)
        {
            string res = validar();
            if (res == string.Empty)
            {
                Cliente pro = new Cliente();
                pro.FechaAlta = dtFechaAlta.Value;
                pro.Apellido = tbApellido.Text;
                pro.Domicilio = tbDomicilio.Text;
                pro.Email = tbEmail.Text;
                pro.Nombre = tbNombre.Text;
                Agrega.Cliente(pro);
                Telefono x = new Telefono();
                x.Numero = Convert.ToInt32(tbTelefono.Text);
                pro.Telefonos.Add(x);
                if(Agrega.Cliente(pro)==true)
                {
                    MessageBox.Show("El email no puede ser repetido", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Se ingreso correctamente", "OK", MessageBoxButtons.OK);

                }
            }
            else
            {
                MessageBox.Show(res, "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dgvClienteNuevo.DataSource = Devuelve.Clientes();

        }

        private void frmClienteNuevo_Load(object sender, EventArgs e)
        {
            dgvClienteNuevo.DataSource = Devuelve.Clientes();
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbtelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar != ((char)Keys.NumLock)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
