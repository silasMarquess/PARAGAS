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
        public string codigoCaixa { get; set; }
        public DateTime Data { get; set; }
        public DateTime HoraAbertura { get; set; }
        public DateTime HoraFechamento { get; set; }
        public decimal ValorAbertura { get; set; }
        public decimal valorEntrada { get; set; }
        public decimal valorSaida { get; set; }
        public decimal ValorFechamento { get; set; }
        public decimal ValorQuebra { get; set; }
        public decimal saldoFinal { get; set; }
        public statusCaixa statusCaixa { get; set; }
        public List<Despesa> ListaDespesa { get; set; }
        public List<Venda> ListaVenda { get; set; }

        public List<Mov_Estoque> ListaMovEstoque { get; set; } = new List<Mov_Estoque>();


        public Caixa()
        {

        }

        public Caixa(string codigoCaixa, DateTime data, DateTime horaAbertura, DateTime horaFechamento, decimal valorAbertura, decimal valorEntrada, decimal valorSaida, decimal valorFechamento, decimal valorQuebra, decimal saldoFinal, statusCaixa statusCaixa)
        {
            this.codigoCaixa = codigoCaixa;
            Data = data;
            HoraAbertura = horaAbertura;
            HoraFechamento = horaFechamento;
            ValorAbertura = valorAbertura;
            this.valorEntrada = valorEntrada;
            this.valorSaida = valorSaida;
            ValorFechamento = valorFechamento;
            ValorQuebra = valorQuebra;
            this.saldoFinal = saldoFinal;
            this.statusCaixa = statusCaixa;
        }
    }

}
