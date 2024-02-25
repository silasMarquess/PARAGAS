using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gasProject.entidades.enums;
using System.Threading.Tasks;

namespace gasProject.entidades
{
    class Vasilhame
    {
        public int id_vazilhame { get; set; }
        public string Descricao { get; set; }
        public conteudo_vazilhame Tipo_conteudo { get; set; }
        public decimal Valor_conteudo { get; set; }
        public decimal Valor_casco { get; set; }
        public decimal Valor_frete { get; set; }
        public decimal Valor_total { get; set; }
        public decimal Estoque_deposito { get; set; }

        public Vasilhame(int id_vazilhame, string descricao, conteudo_vazilhame tipo_conteudo, 
            decimal valor_conteudo, decimal valor_casco, decimal valor_frete,
            decimal valor_total, decimal estoque_deposito)
        {
            this.id_vazilhame = id_vazilhame;
            Descricao = descricao;
            Tipo_conteudo = tipo_conteudo;
            Valor_conteudo = valor_conteudo;
            Valor_casco = valor_casco;
            Valor_frete = valor_frete;
            Valor_total = valor_total;
            Estoque_deposito = estoque_deposito;
        }

        public Vasilhame()
        {

        }

    }
}
