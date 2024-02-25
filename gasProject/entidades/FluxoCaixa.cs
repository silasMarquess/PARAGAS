using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gasProject.entidades.enums;

namespace gasProject.entidades
{
    class FluxoCaixa
    {
        public int id_fluxo { get; set; }
        public Entregador Entregador { get; set; }
        public decimal Valor_total { get; set; }
        public string Descricao { get; set; }
        public tipoFluxo Tipo { get; set; }

        public FluxoCaixa()
        {

        }

        public FluxoCaixa(int id_fluxo, Entregador entregador, decimal valor_total,
            string descricao, tipoFluxo tipo)
        {
            this.id_fluxo = id_fluxo;
            Entregador = entregador;
            Valor_total = valor_total;
            Descricao = descricao;
            Tipo = tipo;
        }




    }
}
