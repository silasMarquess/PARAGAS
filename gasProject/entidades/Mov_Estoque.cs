using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasProject.entidades.enums
{
    class Mov_Estoque
    {
        public  int Id { get; set; }
        public DateTime Data { get; set; }
        public TipoFluxoEstoque TipoFluxo { get; set; }
        public int Qtde_itens { get; set; }
        public OrigenMovEstoque Origem { get; set; }
        public conteudo_vazilhame TipoVazilhame { get; set; }
        public DateTime Horario { get; set; }

        public Caixa Caixa { get; set; }

        public Mov_Estoque()
        {

        }
    }
}
