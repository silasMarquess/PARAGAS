using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasProject.entidades
{
    class Item_venda
    {
        public int Id { get; set; }
        public int Qtde { get; set; }
        public Vasilhame Produto { get; set; }
        public Venda Venda_pai { get; set; }
        public decimal ValorPag { get; set; }
        public decimal SubTotal { get; set; }


        public decimal subTotalSemFrete()
        {
            decimal valor = 0;
            valor = Qtde * Produto.Valor_venda;
            return valor;
        }

        public decimal subTotalComFrete()
        {
            decimal valor = 0;
            valor = Qtde * Produto.CalcularValorComFrete();
            return valor;
        }
    }
}
