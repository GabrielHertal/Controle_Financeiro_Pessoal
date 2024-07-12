namespace Controle_Financeiro_Pessoal.DTO
{
    public class C2LancamentoDTO
    {
        public int C2LancamentoId { get; set; }
        public string? C2LancamentoNome { get; set; }
        public string C2LancamentoValor { get; set; }
        public DateTime C2DataLancamento { get; set; }
        public DateTime C2Data_Prev_Pag { get; set; }
        public DateTime? C2Data_Pag { get; set; }
        public string? C2FKC3Status_Lancamento { get; set; }
        public string? C2FKC4Nome_Moeda { get; set; }
        public string? C2FKC5Tipo_Lancamento { get; set; }
        public string? C2FKC6Nome_Conta { get; set; }
    }
}
