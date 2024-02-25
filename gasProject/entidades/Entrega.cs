using System;
using gasProject.entidades.enums;

namespace gasProject.entidades
{
    class Entrega
    {
        public int Id_entrega { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor_total { get; set; }
        public decimal Valor_desconto { get; set; }
        public decimal Valor_adicional { get; set; }
        public decimal Total_frete { get; set; }
        public decimal Valor_liqudido { get; set; }
        public tipoPagamento Tipo_pagamento { get; set; }
        public string Nome_cliente { get; set; }

        public Entrega()
        {

        }

        public Entrega(int id_entrega, DateTime data, decimal valor_total,
            decimal valor_desconto, decimal valor_adicional, decimal total_frete, decimal valor_liqudido,
            tipoPagamento tipo_pagamento, string nome_cliente)
        {
            Id_entrega = id_entrega;
            Data = data;
            Valor_total = valor_total;
            Valor_desconto = valor_desconto;
            Valor_adicional = valor_adicional;
            Total_frete = total_frete;
            Valor_liqudido = valor_liqudido;
            Tipo_pagamento = tipo_pagamento;
            Nome_cliente = nome_cliente;
        }

    }
}
