using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gasProject.entidades.enums;

namespace gasProject.entidades
{
    class Pedido
    {
        public int Id_pedido {get; set;}
        public decimal Qtde_pegada { get; set; }
        public decimal Qtde_devolvida { get; set; }
        public decimal pendente_devolvida { get; set; }
        public decimal Valor_total { get; set; }
        public decimal Valor_acrescimo { get; set; }
        public decimal Valor_desconto { get; set; }
        public decimal Valor_liquido { get; set; }
        public decimal Valor_acertado { get; set; }
        public decimal Valor_devendo { get; set; }
        public  statusPedido  StatusPedido { get; set; }

        public Pedido()
        {

        }

        public Pedido(int id_pedido, decimal qtde_pegada, decimal qtde_devolvida, decimal pendente_devolvida,
            decimal valor_total, decimal valor_acrescimo, decimal valor_desconto, decimal valor_liquido, 
            decimal valor_acertado, decimal valor_devendo, statusPedido statusPedido)
        {
            Id_pedido = id_pedido;
            Qtde_pegada = qtde_pegada;
            Qtde_devolvida = qtde_devolvida;
            this.pendente_devolvida = pendente_devolvida;
            Valor_total = valor_total;
            Valor_acrescimo = valor_acrescimo;
            Valor_desconto = valor_desconto;
            Valor_liquido = valor_liquido;
            Valor_acertado = valor_acertado;
            Valor_devendo = valor_devendo;
            StatusPedido = statusPedido;
        }
    }
}
