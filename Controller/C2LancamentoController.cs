using Controle_Financeiro_Pessoal.Data;
using Controle_Financeiro_Pessoal.DTO;
using Controle_Financeiro_Pessoal.Model;
using Microsoft.EntityFrameworkCore;

namespace Controle_Financeiro_Pessoal.Controller
{
    public class C2LancamentoController
    {
        private readonly ApplicationDbContext _Context;
        public C2LancamentoController() => _Context = new ApplicationDbContext(options: new DbContextOptionsBuilder<ApplicationDbContext>()
            .Options);
        public async Task<List<C2LancamentoDTO>> ListaC2Lancamento(int usuariologado)
        {
            return await _Context.C2Lancamento
                .Where(c2 => c2.C2FKC1ID_User == usuariologado)
                .Include(c2 => c2.C6Conta)
                .Include(c2 => c2.C4Moeda)
                .Include(c2 => c2.C5Tipo_Lancamento)
                .Include(c2 => c2.C3Status_Lancamento)
                .Select(c2 => new C2LancamentoDTO
                {
                    C2LancamentoId = c2.C2ID,
                    C2LancamentoNome = c2.C2Titulo_Lancamento,
                    C2LancamentoValor = $"R$ {c2.C2Valor}",
                    C2DataLancamento = c2.C2Data_Lancamento,
                    C2Data_Prev_Pag = c2.C2Data_Previa_Pagamento,
                    C2Data_Pag = c2.C2Data_Pagamento,
                    C2FKC3Status_Lancamento = c2.C3Status_Lancamento.C3Nome_Status,
                    C2FKC4Nome_Moeda = c2.C4Moeda.C4Nome_Moeda,
                    C2FKC5Tipo_Lancamento = c2.C5Tipo_Lancamento.C5Nome_Tipo_Lancamento,
                    C2FKC6Nome_Conta = c2.C6Conta.C6Nome
                })
                .ToListAsync();
        }
        public async Task AdicionarC2Lancamento(C2Lancamento c2lancamento)
        {
            _Context.C2Lancamento.Add(c2lancamento);
            await _Context.SaveChangesAsync();
        }
        public async Task DeletarC2Lancamento(int id_lancamento)
        {
            await _Context.C2Lancamento.Where(c2 => c2.C2ID == id_lancamento).ExecuteDeleteAsync();
            await _Context.SaveChangesAsync();
        }
    }
}