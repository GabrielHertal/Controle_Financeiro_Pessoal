using Controle_Financeiro_Pessoal.Data;
using Controle_Financeiro_Pessoal.Model;
using Microsoft.EntityFrameworkCore;

namespace Controle_Financeiro_Pessoal.Controller
{
    public class C7RecebimentoController
    {
        private readonly ApplicationDbContext _Context;
        public C7RecebimentoController() => _Context = new ApplicationDbContext(options: new DbContextOptionsBuilder<ApplicationDbContext>()
            .Options);
        public async void AdicionarC7Recebimento(C7Recebimento C7Recebimento)
        {
            _Context.C7Recebimento.Add(C7Recebimento);
            await _Context.SaveChangesAsync();
        }
        public async Task<List<C7Recebimento>> ListarC7Recebimento()
        {
            return await _Context.C7Recebimento.ToListAsync();
        }
    }
}
