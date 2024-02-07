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
        public string placa { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
        public List<Entrega> ListaEntregas { get; set; } = new List<Entrega>();

        public Entregador()
        {

        }
    }
}
