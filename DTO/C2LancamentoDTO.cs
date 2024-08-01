namespace Controle_Financeiro_Pessoal.DTO
{
    public class C2LancamentoDTO
    {
        public required int C2FKC1Id_Usuario { get; set; }
        public int C2LancamentoId { get; set; }
        public string? C2LancamentoNome { get; set; }
        public required string C2LancamentoValor { get; set; }
        public int C2Tipo_Lancamento { get; set; }
        public DateTime? C2DataLancamento { get; set; }
        public DateTime? C2Data_Prev_Pag { get; set; }
        public DateTime? C2Data_Pag { get; set; }
        public string C2FKC3Nome_Status_Lancamento { get; set; }
        public int C2FKC3Id_Status_Lancamento { get; set; }
        public int C2FKC4Id_Moeda { get; set; }
        public string? C2FKC4Nome_Moeda { get; set; }
        public string? C2FKC5Tipo_Lancamento { get; set; }
        public string? C2FKC6Nome_Conta { get; set; }
        public int? C2FKC6Id_Conta { get; set; }
        public string? C2Observacao { get; set; }
        public string? C2FKC6Nome_Conta_Transferencia { get; set; }
        public int? C2FKC6ID_Conta_Transferencia { get; set; }
        public int? C2FKC5ID_Tipo_Lancamento { get; set; }
        public int? C2FKC2ID_Lancamento_Pai { get; set; }
    }
}
