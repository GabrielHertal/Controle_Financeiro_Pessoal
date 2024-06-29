using Controle_Financeiro_Pessoal.Data;
using Controle_Financeiro_Pessoal.Model;
using Microsoft.EntityFrameworkCore;

namespace Controle_Financeiro_Pessoal.Controller
{
    public class C1UsuarioController
    {
        private readonly ApplicationDbContext _Context;
        public bool visualizauserinativo;
        public C1UsuarioController() => _Context = new ApplicationDbContext(options: new DbContextOptionsBuilder<ApplicationDbContext>()
            .Options);

        public async void AdicionarUsuário(C1Usuario C1usuario)
        {
            _Context.C1Usuario.Add(C1usuario);
            await _Context.SaveChangesAsync();
        }
        public int VerificarExistenciaCadastro(string email, string senha)
            => _Context.C1Usuario.Where(c => c.C1Ativo == true).Count(u => u.C1Email == email && u.C1Senha == senha);

        public async Task<List<C1Usuario>> ListarC1Usuario()
        {
            return await _Context.C1Usuario.Where(c => c.C1Ativo == true || c.C1Ativo == visualizauserinativo).OrderBy(C1Usuario => C1Usuario.C1ID).ToListAsync();
        }
        public async Task<C1Usuario> ObtemC1Usuario(int id)
        {
            return await _Context.C1Usuario.Where(c => c.C1ID == id).FirstOrDefaultAsync();
        }
        public async void AtualizarC1Usuario(int id, C1Usuario C1usuario)
        {
            C1Usuario userupdate = await _Context.C1Usuario.Where(c => c.C1ID == id).FirstOrDefaultAsync();
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
    }
}