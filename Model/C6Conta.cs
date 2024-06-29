using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle_Financeiro_Pessoal.Model
{
    public class C6Conta
    {
        [Key]
        public required int C6Id { get; set; }
        public required string C6Nome { get; set; }
        [DefaultValue(true)]
        public required bool C6Ativo { get; set; }
        [DefaultValue(true)]
        public float? C6Saldo { get; set; }
        [ForeignKey("C1Usuario")]
        public required int C6FKC1ID_User { get; set; }
        public required C1Usuario C1Usuario { get; set; }
    }
}
