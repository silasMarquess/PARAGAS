using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gasProject.views.venda
{
    public partial class FrmEntregaRapida : Form
    {
        public FrmEntregaRapida()
        {
            InitializeComponent();
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRetirada.SelectAll();
                txtRetirada.Select();
            }
        }

        private void CbEntregador_KeyDown(object sender, KeyEventArgs e)
        {
            txtNomeCliente.SelectAll();
            txtNomeCliente.Select();
        }

        private void txtVasilhameCompleto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CbEntregador.SelectAll();
                CbEntregador.Select();
                CbEntregador.DroppedDown = true;
            }
        }

        private void txtRetirada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtVasilhameCompleto.SelectAll();
                txtVasilhameCompleto.Select();
            }
        }
    }
}
