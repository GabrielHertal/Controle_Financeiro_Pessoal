using System.ComponentModel.DataAnnotations;

namespace Controle_Financeiro_Pessoal.Model
{
    public class C5Tipo_Lancamento
    {
        [Key]
        public required int C5ID { get; set; }
        public required string C5Nome_Tipo_Lancamento { get; set; }
    }
}
