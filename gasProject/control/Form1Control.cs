using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gasProject.views;
using gasProject.entidades;
using System.Windows.Forms;

namespace gasProject.control
{
    class Form1Control
    {

        private Form1 _form;

        public Form1Control(Form1 form)
        {
            _form = form;
        }


        public void AddPainelBase(Form painel, string nomePainel)
        {
            if (_form.Pn_Base.Controls.Count > 0)
            {
                _form.Pn_Base.Controls.Clear();
            }

            painel.TopLevel = false;
            _form.Pn_Base.Controls.Add(painel);
            painel.Dock = DockStyle.Fill;
            painel.Visible = true;
            _form.lb_NomePainel.Text = nomePainel;
            
        }

    }
}
