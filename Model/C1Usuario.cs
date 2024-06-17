using System.ComponentModel.DataAnnotations;

namespace Controle_Financeiro_Pessoal.Model
{
    public class C1Usuario
    {
        [Key]
        public int? C1Id { get; set; }
        public string? C1Cpf { get; set; }
        public required string C1Email { get; set; }
        public required string C1Senha { get; set; }
        public required DateTime C1Data_Criacao { get; set; }
        public required decimal C1Renda_Mensal { get; set; }
    }
}
