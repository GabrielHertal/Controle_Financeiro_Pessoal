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
                .OrderBy(c2 => c2.C2Data_Previa_Pagamento)
                .Select(c2 => new C2LancamentoDTO
                {
                    C2LancamentoId = c2.C2ID,
                    C2LancamentoNome = c2.C2Titulo_Lancamento,
                    C2LancamentoValor = $"R$ {c2.C2Valor}",
                    C2DataLancamento = c2.C2Data_Previa_Pagamento,
                    C2Data_Prev_Pag = c2.C2Data_Previa_Pagamento,
                    C2Data_Pag = c2.C2Data_Pagamento,
                    C2FKC3Nome_Status_Lancamento = c2.C3Status_Lancamento != null ? c2.C3Status_Lancamento.C3Nome_Status : null,
                    C2FKC4Nome_Moeda = c2.C4Moeda.C4Nome_Moeda != null ? c2.C4Moeda.C4Nome_Moeda : c2.C4Moeda.C4Nome_Moeda,
                    C2FKC4Id_Moeda = c2.C2FKC4ID_Moeda,
                    C2FKC5Tipo_Lancamento = c2.C5Tipo_Lancamento != null ? c2.C5Tipo_Lancamento.C5Nome_Tipo_Lancamento : null,
                    C2FKC6Nome_Conta = c2.C6Conta_Transferencia != null ? c2.C6Conta_Transferencia.C6Nome : c2.C6Conta.C6Nome,
                    C2FKC5ID_Tipo_Lancamento = c2.C2FKC5ID_Tipo_Lancamento,
                    C2FKC1Id_Usuario = c2.C2FKC1ID_User,
                    C2FKC3Id_Status_Lancamento = c2.C2FKC3ID_Status,
                    C2FKC7ID_Categoria = c2.C2FKC7ID_Categoria
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
                    C2FKC5Tipo_Lancamento = c.C5Tipo_Lancamento != null ? c.C5Tipo_Lancamento.C5Nome_Tipo_Lancamento : null,
                    C2FKC6Nome_Conta = c.C6Conta.C6Nome,
                    C2Observacao = c.C2Observacao,
                    C2Tipo_Lancamento = c.C2FKC5ID_Tipo_Lancamento,
                    C2FKC4Id_Moeda = c.C4Moeda.C4ID,
                    C2FKC6Id_Conta = c.C6Conta.C6Id,
                    C2FKC6Nome_Conta_Transferencia = c.C6Conta_Transferencia != null ? c.C6Conta_Transferencia.C6Nome : null,
                    C2FKC6ID_Conta_Transferencia = c.C6Conta_Transferencia != null ? c.C6Conta_Transferencia.C6Id : 0,
                    C2FKC1Id_Usuario = c.C2FKC1ID_User,
                    C2FKC2ID_Lancamento_Pai = c.C2FKC2ID_Lancamento_Pai,
                    C2FKC7ID_Categoria = c.C2FKC7ID_Categoria,
                    C2FKC7Nome_Categoria = c.C7Categoria.C7Nome != null ? c.C7Categoria.C7Nome : c.C7Categoria.C7Nome
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
                }
                else
                {
                    MessageBox.Show("Falha ao realizar pagamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public async Task<List<C2Lancamento>> ListarC2Lancamento_Filhos(int _id_lancamento_pai)
        {
            return await _Context.C2Lancamento
                .Where(c => c.C2FKC2ID_Lancamento_Pai == _id_lancamento_pai)
                .ToListAsync();
        }
        public async Task<int> QtdParcelasC2Lancamentos_Filho(int id_lancamento)
        {
             return await _Context.C2Lancamento
                .CountAsync(c => c.C2FKC2ID_Lancamento_Pai == id_lancamento);
        }
        public async Task AtualizarC2LancamentoFilho(C2Lancamento c2lancamento)
        {
            var existingLancamento = await _Context.C2Lancamento
                                        .FindAsync(c2lancamento.C2ID);
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
            int TotalLancamentos;
            int TotaLancamentosPagos;
            TotalLancamentos = await _Context.C2Lancamento
                                        .CountAsync(c => c.C2FKC2ID_Lancamento_Pai == id_lancamento_pai);
            TotaLancamentosPagos = await _Context.C2Lancamento
                                            .CountAsync(c => c.C2FKC2ID_Lancamento_Pai == id_lancamento_pai 
                                                        && c.C2FKC3ID_Status == 2);
            if (TotalLancamentos == TotaLancamentosPagos)
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
        public async Task<List<C2Lancamento>> VerificarC2LancamentosCategoria(int? id_categoria)
        {
            return await _Context.C2Lancamento
.               Where(c => c.C2FKC7ID_Categoria == id_categoria
                    && c.C2FKC3ID_Status == 1)
                    .ToListAsync();
        }
        public async Task VerificarRecriarParcelaFixas(int id_lancamento, int? id_categoria, int? tipo_categoria)
        {
            var count_total = await _Context.C2Lancamento
                                    .CountAsync(c => c.C2FKC7ID_Categoria == id_categoria);
            var count_pagos = await _Context.C2Lancamento
                                    .CountAsync(c => c.C2FKC7ID_Categoria == id_categoria && c.C2FKC3ID_Status == 2);
            var datamaxima = await _Context.C2Lancamento
                                    .Where(c => c.C2FKC7ID_Categoria == id_categoria)
                                    .MaxAsync(c => c.C2Data_Previa_Pagamento);
            C2Lancamento? lancamento = await _Context.C2Lancamento
                                        .FirstOrDefaultAsync(c => c.C2FKC7ID_Categoria == id_categoria && c.C2Data_Previa_Pagamento == datamaxima); 
            if (lancamento == null)
            {
                MessageBox.Show("Lançamento não encontrado!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (count_pagos == count_total)
            {
                switch (tipo_categoria) 
                {
                    case 1: //Caso for parcela MENSAL
                        DialogResult result = MessageBox.Show("Deseja recriar mais 6 parcelas?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(result == DialogResult.Yes)
                        {
                            for (int i = 1; i <= 6; i++)
                            {
                                var recriarMENSAl = new C2Lancamento
                                {
                                    C2FKC6ID_Conta = lancamento.C2FKC6ID_Conta != null ? lancamento.C2FKC6ID_Conta : 0,
                                    C2FKC4ID_Moeda = lancamento.C2FKC4ID_Moeda,
                                    C2FKC1ID_User = lancamento.C2FKC1ID_User,
                                    C2Data_Lancamento = DateTime.UtcNow.AddHours(-3),
                                    C2Data_Previa_Pagamento = lancamento.C2FKC7ID_Categoria == 1 ? lancamento.C2Data_Previa_Pagamento.AddMonths(i) : lancamento.C2Data_Previa_Pagamento.AddMonths(i),
                                    C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                                    C2Observacao = lancamento.C2Observacao,
                                    C2Titulo_Lancamento = lancamento.C2Titulo_Lancamento,
                                    C2FKC3ID_Status = 1, //Pendente Pagamento
                                    C2Valor = lancamento.C2Valor,
                                    C2FKC5ID_Tipo_Lancamento = lancamento.C2FKC5ID_Tipo_Lancamento,
                                    C2FKC7ID_Categoria = lancamento.C2FKC7ID_Categoria
                                };
                                await AdicionarC2Lancamento(recriarMENSAl);
                            }
                            MessageBox.Show("Parcelas criadas com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    break;
                    case 2: //Caso for parcela ANUAL
                        DialogResult resultado = MessageBox.Show("Deseja recriar mais 2 parcelas?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(resultado == DialogResult.Yes)   
                        {
                            for (int i = 1; i <= 2; i++)
                            {
                                var recriarANUAL = new C2Lancamento
                                {
                                    C2FKC6ID_Conta = lancamento.C2FKC6ID_Conta != null ? lancamento.C2FKC6ID_Conta : 0,
                                    C2FKC4ID_Moeda = lancamento.C2FKC4ID_Moeda,
                                    C2FKC1ID_User = lancamento.C2FKC1ID_User,
                                    C2Data_Lancamento = DateTime.UtcNow.AddHours(-3),
                                    C2Data_Previa_Pagamento = lancamento.C2FKC7ID_Categoria == 1 ? lancamento.C2Data_Previa_Pagamento.AddYears(i) : lancamento.C2Data_Previa_Pagamento.AddYears(i),
                                    C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                                    C2Observacao = lancamento.C2Observacao,
                                    C2Titulo_Lancamento = lancamento.C2Titulo_Lancamento,
                                    C2FKC3ID_Status = 1, //Pendente Pagamento
                                    C2Valor = lancamento.C2Valor,
                                    C2FKC5ID_Tipo_Lancamento = lancamento.C2FKC5ID_Tipo_Lancamento,
                                    C2FKC7ID_Categoria = lancamento.C2FKC7ID_Categoria
                                };
                                await AdicionarC2Lancamento(recriarANUAL);
                            }
                            MessageBox.Show("Parcelas criadas com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } 
                    break;
                }
            }
        }
        public async Task<bool> VerificarSeLancamentoEstaPago(int id_lancamento)
        {
            var total_lancamento = await _Context.C2Lancamento
                                            .CountAsync(c => c.C2ID == id_lancamento);
            var total_pagos = await _Context.C2Lancamento
                                            .CountAsync(c => c.C2ID == id_lancamento && c.C2FKC3ID_Status == 2);
            if (total_lancamento == total_pagos)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task VerificaeAtualizaValorLancamentoParcelado(int id_lancamento, int? id_lancamento_pai, float valor_origi, float valor_novo)
        {
            if (valor_novo != valor_origi)
            {
                DialogResult result = MessageBox.Show("Deseja atualizar o valor total do Lancamento PAI?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    var atualizar_lacamentopai = await _Context.C2Lancamento
                                                .Where(c => c.C2ID == id_lancamento_pai)
                                                .FirstOrDefaultAsync();
                    var total_lancamento_PAI = await _Context.C2Lancamento
                                                .Where(c => c.C2FKC2ID_Lancamento_Pai == id_lancamento_pai)
                                                .SumAsync(c => c.C2Valor);
                    if (atualizar_lacamentopai != null)
                    {
                        atualizar_lacamentopai.C2Valor = total_lancamento_PAI;
                        await _Context.SaveChangesAsync();
                    }
                }
            }
        }
    }
}