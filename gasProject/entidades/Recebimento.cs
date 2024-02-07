using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasProject.entidades
{
    class Recebimento
    {
        public int idReceb { get; set; }
        public DateTime Data { get; set; }
        public decimal valorRecebido { get; set; }
        public string descricao { get; set; }
        public int totalItens { get; set; }
        public decimal totalRecebido { get; set; }
        public decimal valorPendente { get; set; }
        public Venda Venda { get; set; }

        public Recebimento()
        {

        }
    }
}
