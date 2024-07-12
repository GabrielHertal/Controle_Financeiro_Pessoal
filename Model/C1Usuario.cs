using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle_Financeiro_Pessoal.Model
{
    public class C1Usuario
    {
        [Key]
        public int C1ID { get; set; }
        public required string C1Nome { get; set; }
        public string? C1Cpf { get; set; }
        public required string C1Email { get; set; }
        public required string C1Senha { get; set; }
        public required DateTime C1Data_Criacao { get; set; }
        public required float C1Renda_Mensal { get; set; }
        [DefaultValue(true)]
        public required bool C1Ativo { get; set; }
    }
}