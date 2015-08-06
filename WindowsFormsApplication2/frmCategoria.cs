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
using Manejadores;
using Logica;

namespace WindowsFormsApplication2
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        Categoria ca;
        private void frmCategoria_Load(object sender, EventArgs e)
        {
            dgvCategoria.DataSource = Devuelve.Categorias();
        }

        private void btnCreaCategoria_Click(object sender, EventArgs e)
        {
            ca = new Categoria();
            ca.Descripcion = tbNuevaCategoria.Text;
            ca.Estado = true;
            Agrega.Categoria(ca);
            dgvCategoria.DataSource = Devuelve.Categorias();
        }

        private void btnEliminaCategoria_Click(object sender, EventArgs e)
        {
            ca = new Categoria();
            ca.Id = (int)dgvCategoria.CurrentRow.Cells["Id"].Value;
            ca.Descripcion = dgvCategoria.CurrentRow.Cells["Descripcion"].Value.ToString();
            Elimina.Categoria(ca);
            dgvCategoria.DataSource = Devuelve.Categorias();
        }
    }
}
