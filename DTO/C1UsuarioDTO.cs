namespace Controle_Financeiro_Pessoal.DTO
{
    public class C1UsuarioDTO
    {
        public int C1ID { get; set; }
        public required string C1Nome { get; set; }
        public string? C1CPF { get; set; }
        public required string C1Email { get; set; }
        public required string C1RendaMensal { get; set; }
    }
}
