﻿using Controle_Financeiro_Pessoal.Data;
using Controle_Financeiro_Pessoal.DTO;
using Controle_Financeiro_Pessoal.Model;
using Microsoft.EntityFrameworkCore;

namespace Controle_Financeiro_Pessoal.Controller
{
    public class C6ContaController
    {
        private readonly C1UsuarioController? _c1usuariocontroller;
        private readonly ApplicationDbContext _Context;
        public C6ContaController() => _Context = new ApplicationDbContext(options: new DbContextOptionsBuilder<ApplicationDbContext>()
            .Options);
        public async Task<List<C6Conta>> PreencheComboBoxC6Conta(int usuariologado)
        {
            return await _Context.C6Conta
                .Where(C6 => C6.C6Ativo == true && C6.C6FKC1ID_User == usuariologado)
                .ToListAsync();
        }
        public async Task AdicionarC6Conta(C6Conta c6conta)
        {
            _Context.C6Conta.Add(c6conta);
            await _Context.SaveChangesAsync();
        }
        public async Task<List<C6ContaDTO>> ListarC6Contas(int usuariologado)
        {
            decimal valorrecebido = _Context.C2Lancamento
                .Where(c6 => c6.C6Conta.C6Ativo == true && c6.C6Conta.C6FKC1ID_User == usuariologado && c6.C2FKC3ID_Status == 2 && c6.C2FKC5ID_Tipo_Lancamento == 2)
                .Select(c6 => c6.C2Valor).Sum();

            decimal valorapagar = _Context.C2Lancamento
                .Where(c6 => c6.C6Conta.C6Ativo == true && c6.C6Conta.C6FKC1ID_User == usuariologado && c6.C2FKC3ID_Status == 2 && c6.C2FKC5ID_Tipo_Lancamento == 1)
                .Select(c6 => c6.C2Valor).Sum();

            decimal saldo = valorrecebido - valorapagar;
            
            return await _Context.C2Lancamento
                .Where(c6 => c6.C6Conta.C6Ativo == true && c6.C6Conta.C6FKC1ID_User == usuariologado)
                .GroupBy(c6 => c6.C6Conta)
                .Select(group => new C6ContaDTO
                {
                    C6ID = group.Key.C6Id,
                    C6Nome = group.Key.C6Nome,
                    C6Saldo = $"R$ {saldo}"
                })
                .ToListAsync();
        }
        public async Task<C6Conta?> ObtemC6Recebimento(int id_conta)
        {
            try
            {
                return await _Context.C6Conta.Where(c6 => c6.C6Id == id_conta).FirstOrDefaultAsync();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        public async void AtualizarC6Conta(int id, C6Conta C6conta)
        {
            C6Conta? c6conta_update = await _Context.C6Conta.Where(c => c.C6Id == id).FirstOrDefaultAsync();
            if (c6conta_update != null)
            {
                c6conta_update.C6Nome = C6conta.C6Nome;
                c6conta_update.C6FKC1ID_User = C6conta.C6FKC1ID_User;
                c6conta_update.C6Ativo = C6conta.C6Ativo;
                await _Context.SaveChangesAsync();
            }
            else
            {
                MessageBox.Show("Falha ao atualizar conta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async Task DeletarC6Conta(int id_conta)
        {
            await _Context.C6Conta.Where(c6 => c6.C6Id == id_conta).ExecuteDeleteAsync();
            await _Context.SaveChangesAsync();
        }
        public async Task<List<C4Moeda>> ListarC4Moeda()
        {
            return await _Context.C4Moeda.ToListAsync();
        }
    }
}