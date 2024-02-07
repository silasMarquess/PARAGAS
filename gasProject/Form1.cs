using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gasProject.entidades;
using gasProject.control;
using gasProject.views;
using gasProject.views.entregas_forms;
using gasProject.views.venda;

namespace gasProject
{
    public partial class Form1 : Form
    {
        private Form1Control _control;
        public Form1()
        {
            InitializeComponent();
            _control = new Form1Control(this);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmTelaVenda venda = new FrmTelaVenda();
            _control.AddPainelBase(venda, "TELA DE VENDAS");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormGerenteEntregas form = new FormGerenteEntregas();
            _control.AddPainelBase(form, "GERENTE DE ENTREGADORES E ENTREGAS");
        }
    }
}
