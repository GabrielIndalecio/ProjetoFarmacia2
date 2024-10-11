using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Produtos
    {
        public int id_produto {  get; set; }

        public string nome_medicamento { get; set; }

        public string setor_medicamento { get; set; }

        public string unidade_medicamento { get; set; }

        public int estoque_medicamento { get; set; }

        public string datavalidade_medicamento { get; set; }

        public int lote_medicamento { get; set; }

        public string data_fabricacao { get; set; }

        public string data_entrada {  get; set; }
    }
}
