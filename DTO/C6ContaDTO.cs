using System.ComponentModel;

namespace Controle_Financeiro_Pessoal.DTO
{
    public class C6ContaDTO
    {
        public int C6ID { get; set; }
        public required string C6Nome { get; set; }
        [DefaultValue(0)]
        public string? C6Saldo { get; set; }
    }
}
