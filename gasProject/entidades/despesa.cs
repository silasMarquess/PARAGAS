using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gasProject.entidades.enums;

namespace gasProject.entidades
{
    class Despesa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal ValorDespesa { get; set; }
        public tipoMov tipoSaida { get; set; }


        public Despesa()
        {

        }
    }
}
