using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gasProject.entidades.enums;

namespace gasProject.entidades
{
    class Venda
    {
        public string Id_venda { get; set; }
        public DateTime DataVenda { get; set; }
        public DateTime HorarioVenda { get; set; }
        public tipoMov formaPag { get; set; }
        public decimal Desconto { get; set; }
        public decimal Acrescimo { get; set; }
        public decimal TotalBruto { get; set; }
        public decimal TotalLiquidoVenda { get; set; }
        public statusVenda statusVenda { get; set; }
        public decimal ValorPago { get; set; }
        public decimal PendentePg { get; set; }

        public Cliente Cliente { get; set; }


        public List<Item_venda> Lista { get; set; } = new List<Item_venda>();

        public Caixa Caixa { get; set; }

        public decimal getTotalVenda_SFrente()
        {
            decimal soma = 0;
           foreach(Item_venda i in this.Lista)
            {
                soma += i.subTotalComFrete();
            }
            return soma;
        }

        public decimal getTotalVenda_CFrente()
        {
            decimal soma = 0;
            foreach (Item_venda i in this.Lista)
            {
                soma += i.subTotalSemFrete();
            }
            return soma;
        }


        public decimal getTotalLiquido()
        {
            decimal vl_liquido = 0;
            vl_liquido = (TotalBruto + Acrescimo) - Desconto;
            return vl_liquido;
        }

        public Venda()
        {

        }

    }
}
