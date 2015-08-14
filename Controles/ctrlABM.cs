using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class ctrlABM : UserControl
    {

        public delegate void uctrlABMEventHandler(Object sender, ref bool cancela);
        public delegate void uctrlABMEventHandler2(Object sender);

        public event uctrlABMEventHandler Aceptar;
        public event uctrlABMEventHandler2 Cancelar;
        public event uctrlABMEventHandler2 Alta;
        public event uctrlABMEventHandler2 Baja;
        public event uctrlABMEventHandler2 Modificacion;

        protected virtual void onModificacion()
        {
            if (Modificacion != null)
            {
                Modificacion(this);
                opcion(false);
            }
        }

        protected virtual void onBaja()
        {
            if (Baja != null)
            {
                Baja(this);
                opcion(false);
            }
        }

        protected virtual void onAlta()
        {
            if (Alta != null)
            {
                Alta(this);
                opcion(false);
            }
        }

        protected virtual void onCancelar()
        {
            if (Cancelar != null)
            {
                Cancelar(this);
                opcion(true);
            }
        }

        protected virtual void onAceptar()
        {
            bool x = false;
            if (Aceptar != null)
            {
                Aceptar(this, ref x);
                opcion(x);
            }
        }

        public ctrlABM()
        {
            InitializeComponent();
        }

        private void ctrlABM_Load(object sender, EventArgs e)
        {
            opcion(true);
        }

        private void opcion(bool x)
        {
            btnAlta.Visible = x;
            btnBaja.Visible = x;
            btnModificacion.Visible = x;
            btnAceptar.Visible = !x;
            btnCancelar.Visible = !x;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            onAlta();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            onAceptar();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            onBaja();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            onCancelar();
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            onModificacion();
        }

    }
}
