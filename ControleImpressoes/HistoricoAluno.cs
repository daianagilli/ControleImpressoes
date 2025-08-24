using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleImpressoes
{
    public class HistoricoAluno
    {
        public DateTime Data { get; set; }
        public string TipoMovimentacao { get; set; }
        public int SaldoAntes { get; set; }
        public int SaldoDepois { get; set; }
    }
}
