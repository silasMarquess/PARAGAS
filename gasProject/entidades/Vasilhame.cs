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
        public conteudo_vazilhame Conteudo { get; set; }
        public decimal  Valor_venda { get; set; }
        public decimal Valor_frete{ get; set; }
        public decimal QtdeEstoque { get; set; }



        public Vasilhame()
        {

        }

        public  decimal CalcularValorComFrete()
        {
            return Valor_venda + QtdeEstoque;
        }

    }
}
