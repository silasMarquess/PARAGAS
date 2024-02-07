using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasProject.entidades
{
    class Entrega
    {
        public int Id_entrega { get; set; }
        public DateTime HorarioEntrega { get; set; }
        public DateTime Data_entrega { get; set; }
        public int QtdeItens { get; set; }
        public decimal TotalVenda { get; set;}
        public Entregador Entregador { get; set; }

        public Entrega()
        {

        }
    }
}
