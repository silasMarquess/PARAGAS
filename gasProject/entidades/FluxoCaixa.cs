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
    }
}
