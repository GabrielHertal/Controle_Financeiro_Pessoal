using Controle_Financeiro_Pessoal.Data;
using Controle_Financeiro_Pessoal.DTO;
using Controle_Financeiro_Pessoal.Model;
using Microsoft.EntityFrameworkCore;

namespace Controle_Financeiro_Pessoal.Controller
{
    public class C1UsuarioController
    {
        public int usuariologado { get; private set;}
        private readonly ApplicationDbContext _Context;
        public bool visualizauserinativo;
        public C1UsuarioController() => _Context = new ApplicationDbContext(options: new DbContextOptionsBuilder<ApplicationDbContext>()
            .Options);

        public async Task AdicionarUsuário(C1Usuario C1usuario)
        {
             _Context.C1Usuario
                .Add(C1usuario);
            await _Context
                .SaveChangesAsync();
        }
        public async Task<int> VerificarExistenciaCadastro(string email, string senha)
            => await _Context.C1Usuario
                .Where(c => c.C1Ativo == true)
                .CountAsync(u => u.C1Email == email && u.C1Senha == senha);
        public async Task <int> SalvarUsuarioConectado(string email, string senha)
        {
             usuariologado = await _Context.C1Usuario
                .Where(u => u.C1Email == email && u.C1Senha == senha)
                .Select(u => u.C1ID)
                .FirstOrDefaultAsync();
            return usuariologado;
        }
        public async Task<List<C1UsuarioDTO>> ListarC1Usuario()
        {
            return await _Context.C1Usuario
                .Where(c => c.C1Ativo == true || c.C1Ativo == visualizauserinativo)
                .OrderBy(C1Usuario => C1Usuario.C1ID)
                .Select(c1 => new C1UsuarioDTO
                {
                    C1ID = c1.C1ID,
                    C1Nome = c1.C1Nome,
                    C1Email = c1.C1Email,
                    C1CPF = c1.C1Cpf,
                    C1RendaMensal = $"R$ {c1.C1Renda_Mensal}"
                })
                .ToListAsync();
        }
        public async Task<C1Usuario?> ObtemC1Usuario(int id)
        {
                return await _Context.C1Usuario
                            .Where(c => c.C1ID == id)
                            .FirstOrDefaultAsync();
        }
        public async void AtualizarC1Usuario(int id, C1Usuario C1usuario)
        {
            C1Usuario? userupdate = await _Context.C1Usuario
                                        .Where(c => c.C1ID == id)
                                        .FirstOrDefaultAsync();
            if (userupdate != null)
            {
                userupdate.C1Nome = C1usuario.C1Nome;
                userupdate.C1Email = C1usuario.C1Email;
                userupdate.C1Cpf = C1usuario.C1Cpf;
                userupdate.C1Renda_Mensal = C1usuario.C1Renda_Mensal;
                await _Context.SaveChangesAsync();
            }
            else
            {
                MessageBox.Show("Falha ao atualizar usuário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async void DeletarC1Usuario(int id)
        {
            var userupdate = await ObtemC1Usuario(id);
            if (userupdate != null)
            {
                userupdate.C1Ativo = false;
                await _Context.SaveChangesAsync();
            }
            else
            {
                MessageBox.Show("Falha ao inativar usuário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async Task<int> VerificarExistenciaEmailC1Usuario(string email)
        {
            return await _Context.C1Usuario
                        .Where(c => c.C1Email == email)
                        .CountAsync();
        }
        public async Task<int> VerificarExistenciaCPFC1Usuario(string? cpf)
        {
            return await _Context.C1Usuario
                        .Where(c => c.C1Cpf == cpf)
                        .CountAsync();
        }
    }
}