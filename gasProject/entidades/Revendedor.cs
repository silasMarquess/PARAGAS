using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasProject.entidades
{
    class Revendedor
    {
        public int Id_revendedor { get; set; }
        public string Razao_social { get; set; }
        public string Cnpj { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public decimal Estoque_gas { get; set; }
        public decimal Estoque_agua { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }

        public Revendedor(int id_revendedor, string razao_social, string cnpj, string cpf, string telefone,
            decimal estoque_gas, decimal estoque_agua, string rua,
            string bairro, string cidade)
        {
            Id_revendedor = id_revendedor;
            Razao_social = razao_social;
            Cnpj = cnpj;
            Cpf = cpf;
            Telefone = telefone;
            Estoque_gas = estoque_gas;
            Estoque_agua = estoque_agua;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
        }

        public Revendedor()
        {
                
        }
    }
}
