using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Financeiro_Pessoal.Model
{
    public class C3Status_Lancamento
    {
        [Key]
        public required int C3ID { get; set; }
        public required string C3Nome_Status { get; set; }
    }
}
