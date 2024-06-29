using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Financeiro_Pessoal.Model
{
    public class C7Recebimento
    {
        [Key]
        public required int C7ID { get; set; }
        public required string C7Titulo_Recebimento { get; set; }
        public required float C7Valor_Recebimento { get; set; }
        public required DateTime C7Data_Recebimento { get; set; }
        [ForeignKey("C1Usuario")]
        public required int C7FKC1ID_Usuario { get; set; }
        public required C1Usuario C1Usuario { get; set; }
        [ForeignKey("C6Conta")]
        public required int C7FKC6ID_Conta { get; set; }
        public required C6Conta C6Conta { get; set; }
    }
}
