using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gasProject.views;
using gasProject.views.entregas_forms;

namespace gasProject.views.entregas_forms
{
    public partial class FormGerenteEntregas : Form
    {
        public FormGerenteEntregas()
        {
            InitializeComponent();
        }

        private void btn_CadastrarNovoEntregador_Click(object sender, EventArgs e)
        {

            FrmEntregas form = new FrmEntregas();
            form.ShowDialog();

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
