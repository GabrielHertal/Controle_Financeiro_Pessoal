using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Financeiro_Pessoal.Model
{
    public class C4Moeda
    {
        [Key]
        public required int C4ID { get; set; }
        public required string C4Nome_Moeda { get; set; }
    }
}
