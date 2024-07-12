using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle_Financeiro_Pessoal.Model
{
    public class C6Conta
    {
        [Key]
        public int C6Id { get; set; }
        public required string C6Nome { get; set; }
        [DefaultValue(true)]
        public required bool C6Ativo { get; set; }
        [Description("C6Tipo_Conta 0 = Dinheiro Físico, 1 = Saldo em Banco")]
        public required int C6Tipo_Conta { get; set; }
        public DateTime C6Data_Criacao { get; set; }
        [ForeignKey("C1Usuario")]
        public required int C6FKC1ID_User { get; set; }
        public C1Usuario? C1Usuario { get; set; }
    }
}
