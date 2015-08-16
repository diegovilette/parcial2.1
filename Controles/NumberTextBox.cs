using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public partial class NumberTextBox : TextBox
    {
        public delegate void EnterEventHandler();
        public event EnterEventHandler Enter;

        protected virtual void onEnter()
        {
            if (Enter != null)
            {
                Enter();
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyData == Keys.Enter)
            {
                onEnter();
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                 e.Handled = true;
            }
        }
    }
}
