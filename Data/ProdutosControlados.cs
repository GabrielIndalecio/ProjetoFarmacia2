using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ProdutosControlados
    {
        public int id_produto_controlado { get; set; }
        public string nome_medicamento_controlado { get; set; }
        public string setor_medicamento_controlado { get; set; }
        public string unidade_medicamento_controlado { get; set; }
        public int estoque_medicamento_controlado { get; set; }
        public string datavalidade_medicamento_controlado { get; set; }
        public int lote_medicamento_controlado { get; set; }
        public string data_fabricacao_controlado { get; set; }
        public string data_entrada_controlado { get; set; }
        public string responsavel_medicamento_controlado { get; set; }
        public string local_medicamento_controlado { get; set; }
        public string temperatura_medicamento_controlado { get; set; }
    }
}
