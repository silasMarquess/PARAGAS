using System;
using System.Collections.Generic;
using System.Linq;
using gasProject.entidades.enums;
using System.Text;
using System.Threading.Tasks;

namespace gasProject.entidades
{
    class Caixa
    {
        public string id_caixa { get; set; }
        public DateTime Data_Abertura { get; set; }
        public DateTime HoraAbertura { get; set; }
        public DateTime HoraFechamento { get; set; }
        public decimal Valor_inicial { get; set; }
        public decimal Total_entrada { get; set; }
        public decimal Total_Saida { get; set; }
        public decimal ValorFechamento { get; set; }
        public decimal ValorQuebra { get; set; }
        public decimal Estoque_inicial { get; set; }
        public statusCaixa Estoque_entrada { get; set; }
        public decimal Estoque_Saida { get; set; }
        public decimal Estoque_final { get; set; }
        public statusCaixa Status_caixa { get; set; }


    }

}
