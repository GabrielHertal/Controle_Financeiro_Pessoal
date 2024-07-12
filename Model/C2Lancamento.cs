using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle_Financeiro_Pessoal.Model
{
    public class C2Lancamento
    {
        [Key]
        public int C2ID { get; set; }
        public string C2Titulo_Lancamento { get; set; }
        public decimal C2Valor { get; set; }
        public string? C2Observacao { get; set; }
        public required DateTime C2Data_Lancamento { get; set; }
        public required DateTime C2Data_Previa_Pagamento { get; set; }
        public DateTime? C2Data_Pagamento { get; set; }
        [ForeignKey("C1Usuario")]
        public required int C2FKC1ID_User { get; set; }
        public C1Usuario? C1Usuario { get; set; }
        [ForeignKey("C3Status_Lancamento")]
        public required int C2FKC3ID_Status { get; set; }
        public C3Status_Lancamento? C3Status_Lancamento { get; set; }
        [ForeignKey("C4Moeda")]
        public required int C2FKC4ID_Moeda { get; set; }
        public C4Moeda? C4Moeda { get; set; }
        [ForeignKey("C5Tipo_Lancamento")]
        public required int C2FKC5ID_Tipo_Lancamento { get; set; }
        public C5Tipo_Lancamento? C5Tipo_Lancamento { get; set; }
        [ForeignKey("C6Conta")]
        public required int C2FKC6ID_Conta { get; set; }
        public C6Conta? C6Conta { get; set; }
    }
}
