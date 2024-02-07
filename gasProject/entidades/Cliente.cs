using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasProject.entidades
{
    class Cliente
    {
        public int  Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Rua   { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }

        public int QtdeVazilAgua { get; set; }
        public int QtdeVazilGas { get; set; }


        public Cliente()
        {

        }
    }
}
