using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Financeiro_Pessoal.Model
{
    public class C2Lancamentos
    {
        [Key]
        public required int C2ID { get; set; }
        public required string C2Titulo_Lancamento { get; set; }
        public required decimal C2Valor { get; set; }
        public required DateTime C2Data_Prev_Pag { get; set; }
        public DateTime C2Data_Pag { get; set; }
        [ForeignKey("C1Usuario")]
        public required int C2FKC1ID_User { get; set; }
        [ForeignKey("C3Status_Lancamento")]
        public required int C2FKC3ID_Status { get; set; }
        [ForeignKey("C4Moeda")]
        public required int C2FKC4ID_Moeda { get; set; }
        [ForeignKey("C5Tipo_Lancamento")]
        public required int C2FKC5ID_Tipo_Lancamento { get; set; }
    }
}
