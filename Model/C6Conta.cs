using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle_Financeiro_Pessoal.Model
{
    public class C6Conta
    {
        [Key]
        public required int C6Id { get; set; }
        public required string C6Nome { get; set; }
        [ForeignKey("C1Usuario")]
        public required int C6FKC1ID_User { get; set; }
        public C1Usuario? C1Usuario { get; set; }
    }
}
