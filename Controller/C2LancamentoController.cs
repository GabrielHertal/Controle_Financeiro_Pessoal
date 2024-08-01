using Controle_Financeiro_Pessoal.Data;
using Controle_Financeiro_Pessoal.DTO;
using Controle_Financeiro_Pessoal.Model;
using Microsoft.EntityFrameworkCore;
using System.Formats.Asn1;

namespace Controle_Financeiro_Pessoal.Controller
{
    public class C2LancamentoController
    {
        private readonly ApplicationDbContext _Context;
        public C2LancamentoController() => _Context = new ApplicationDbContext(options: new DbContextOptionsBuilder<ApplicationDbContext>()
            .Options);
        public async Task<List<C2LancamentoDTO>> ListarC2Lancamento(int usuariologado)
        {
            return await _Context.C2Lancamento
                .Where(c2 => c2.C2FKC1ID_User == usuariologado)
                .Include(c2 => c2.C6Conta)
                .Include(c2 => c2.C4Moeda)
                .Include(c2 => c2.C5Tipo_Lancamento)
                .Include(c2 => c2.C3Status_Lancamento)
                .OrderBy(c2 => c2.C2ID)
                .Select(c2 => new C2LancamentoDTO
                {
                    C2LancamentoId = c2.C2ID,
                    C2LancamentoNome = c2.C2Titulo_Lancamento,
                    C2LancamentoValor = $"R$ {c2.C2Valor}",
                    C2DataLancamento = c2.C2Data_Previa_Pagamento,
                    C2Data_Prev_Pag = c2.C2Data_Previa_Pagamento,
                    C2Data_Pag = c2.C2Data_Pagamento,
                    C2FKC3Nome_Status_Lancamento = c2.C3Status_Lancamento.C3Nome_Status,
                    C2FKC4Nome_Moeda = c2.C4Moeda.C4Nome_Moeda,
                    C2FKC4Id_Moeda = c2.C2FKC4ID_Moeda,
                    C2FKC5Tipo_Lancamento = c2.C5Tipo_Lancamento.C5Nome_Tipo_Lancamento,
                    C2FKC6Nome_Conta = c2.C6Conta_Transferencia.C6Nome ?? c2.C6Conta.C6Nome,
                    C2FKC5ID_Tipo_Lancamento = c2.C2FKC5ID_Tipo_Lancamento,
                    C2FKC1Id_Usuario = c2.C2FKC1ID_User,
                    C2FKC3Id_Status_Lancamento = c2.C2FKC3ID_Status
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
        public async Task<C2LancamentoDTO?> ObterC2Lancamento(int id)
        {
            return await _Context.C2Lancamento
                .Include(c2 => c2.C6Conta)
                .Include(c2 => c2.C4Moeda)
                .Where(c => c.C2ID == id)
                .Select(c => new C2LancamentoDTO
                {
                    C2DataLancamento = c.C2Data_Previa_Pagamento,
                    C2Data_Prev_Pag = c.C2Data_Previa_Pagamento,
                    C2Data_Pag = c.C2Data_Pagamento,
                    C2LancamentoId = c.C2ID,
                    C2LancamentoNome = c.C2Titulo_Lancamento,
                    C2LancamentoValor = c.C2Valor.ToString(),
                    C2FKC3Nome_Status_Lancamento = c.C3Status_Lancamento.C3Nome_Status,
                    C2FKC3Id_Status_Lancamento = c.C3Status_Lancamento.C3ID,
                    C2FKC4Nome_Moeda = c.C4Moeda.C4Nome_Moeda,
                    C2FKC5Tipo_Lancamento = c.C5Tipo_Lancamento.C5Nome_Tipo_Lancamento,
                    C2FKC6Nome_Conta = c.C6Conta.C6Nome,
                    C2Observacao = c.C2Observacao,
                    C2Tipo_Lancamento = c.C2FKC5ID_Tipo_Lancamento,
                    C2FKC4Id_Moeda = c.C4Moeda.C4ID,
                    C2FKC6Id_Conta = c.C6Conta.C6Id,
                    C2FKC6Nome_Conta_Transferencia = c.C6Conta_Transferencia.C6Nome,
                    C2FKC6ID_Conta_Transferencia = c.C6Conta_Transferencia.C6Id,
                    C2FKC1Id_Usuario = c.C2FKC1ID_User,
                    C2FKC2ID_Lancamento_Pai = c.C2FKC2ID_Lancamento_Pai
                })
                .FirstOrDefaultAsync();
        }
        public async Task AtualizarC2Lancamento(C2Lancamento c2lancamento)
        {
            var existingLancamento = await _Context.C2Lancamento.FindAsync(c2lancamento.C2ID);
            if (existingLancamento != null)
            {
                _Context.Entry(existingLancamento).CurrentValues.SetValues(c2lancamento);
            }
            else
            {
                _Context.C2Lancamento.Update(c2lancamento);
            }
            await _Context.SaveChangesAsync();
        }
        public async Task RealizarC2Lancamento(int id_lancamento, int id_moeda)
        {
            if (id_moeda == 2 || id_moeda == 6)
            {
                C2Lancamento? c2Lancamento = await _Context.C2Lancamento
                    .Where(c => c.C2ID == id_lancamento && c.C2FKC4ID_Moeda == id_moeda)
                    .FirstOrDefaultAsync();
                if (c2Lancamento != null)
                {
                    c2Lancamento.C2Data_Pagamento = DateTime.UtcNow.AddHours(-3);
                    c2Lancamento.C2FKC3ID_Status = 2;
                    var lancamentosFilhos = await _Context.C2Lancamento
                        .Where(c => c.C2FKC2ID_Lancamento_Pai == id_lancamento && c.C2FKC3ID_Status == 1)
                        .ToListAsync();
                    foreach (var filho in lancamentosFilhos)
                    {
                        filho.C2Data_Pagamento = DateTime.UtcNow.AddHours(-3);
                        filho.C2FKC3ID_Status = 2;
                    }
                    await _Context.SaveChangesAsync();
                }
                else
                {
                    MessageBox.Show("Falha ao realizar pagamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                C2Lancamento? c2Lancamento = await _Context.C2Lancamento
                    .Where(c => c.C2ID == id_lancamento)
                    .FirstOrDefaultAsync();
                if (c2Lancamento != null)
                {
                    c2Lancamento.C2Data_Pagamento = DateTime.UtcNow.AddHours(-3);
                    c2Lancamento.C2FKC3ID_Status = 2;
                    await _Context.SaveChangesAsync();
                    MessageBox.Show("Lançamento atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Falha ao realizar pagamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public async Task<List<C2Lancamento>> ListarC2Lancamento_Filhos(int _id_lancamento_pai)
        {
            var batata = await _Context.C2Lancamento
                .Where(c => c.C2FKC2ID_Lancamento_Pai == _id_lancamento_pai)
                .ToListAsync();
            return batata;
        }
        public async Task<int> QtdParcelasC2Lancamentos_Filho(int id_lancamento)
        {
             return await _Context.C2Lancamento
                .CountAsync(c => c.C2FKC2ID_Lancamento_Pai == id_lancamento);
        }
        public async Task AtualizarC2LancamentoFilho(C2Lancamento c2lancamento)
        {
            var existingLancamento = await _Context.C2Lancamento.FindAsync(c2lancamento.C2ID);
            if (existingLancamento != null)
            {
                _Context.Entry(existingLancamento).CurrentValues.SetValues(c2lancamento);
            }
            else
            {
                _Context.C2Lancamento.Update(c2lancamento);
            }
            await _Context.SaveChangesAsync();
        }
        public async Task DeletarC2LancamentosFilhos(int? id_lancamentopai)
        {
            await _Context.C2Lancamento
                .Where(c2 => c2.C2FKC2ID_Lancamento_Pai == id_lancamentopai)
                .ExecuteDeleteAsync();
        }
        public async Task AtualizarStatusC2Lancamento(int? id_lancamento_pai)
        {
            int totallancamentos;
            int totallancamentospagos;
            totallancamentos = await _Context.C2Lancamento
                .CountAsync(c => c.C2FKC2ID_Lancamento_Pai == id_lancamento_pai);
            totallancamentospagos = await _Context.C2Lancamento
                .CountAsync(c => c.C2FKC2ID_Lancamento_Pai == id_lancamento_pai && c.C2FKC3ID_Status == 2);
            if (totallancamentos == totallancamentospagos)
            {
                C2Lancamento? c2lancamento_update = await _Context.C2Lancamento
                    .Where(c => c.C2ID == id_lancamento_pai)
                    .FirstOrDefaultAsync();
                if (c2lancamento_update != null)
                {
                    c2lancamento_update.C2Data_Pagamento = DateTime.UtcNow.AddHours(-3);
                    c2lancamento_update.C2FKC3ID_Status = 2;
                    await _Context.SaveChangesAsync();
                }
                else
                {
                    MessageBox.Show("Falha ao realizar pagamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public async Task EstornarC2Lancamento(int id_lancamento)
        {
            C2Lancamento? c2lancamento = await _Context.C2Lancamento
                .Where(c => c.C2ID == id_lancamento)
                .FirstOrDefaultAsync();
            if (c2lancamento != null)
            {
                c2lancamento.C2Data_Pagamento = null;
                c2lancamento.C2FKC3ID_Status = 1;
                await _Context.SaveChangesAsync();
            }
        }
        public async Task<int> VerificaC2LancamentosPagos(int? id_lancamento_pai) => 
            await _Context.C2Lancamento
                .CountAsync(c => c.C2FKC2ID_Lancamento_Pai == id_lancamento_pai && c.C2FKC3ID_Status == 2);
    }
}