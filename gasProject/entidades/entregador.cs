using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasProject.entidades
{
    class Entregador
    {
        public int Id { get; set; }
        public string  nomeEntregador { get; set; }
        public string Veiculo { get; set; }
        public string Placa { get; set; }
        public string Renavan { get; set; }
        public decimal Salario { get; set; }
        public decimal Perc_comissao { get; set; }

        public List<Entrega> ListaEntregas { get; set; }

        public Entregador()
        {

        }

        public Entregador(int id, string nomeEntregador,
            string veiculo, string placa, string renavan)
        {
            Id = id;
            this.nomeEntregador = nomeEntregador;
            Veiculo = veiculo;
            Placa = placa;
            Renavan = renavan;
        }





    }
}
