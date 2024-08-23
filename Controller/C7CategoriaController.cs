using Controle_Financeiro_Pessoal.Data;
using Controle_Financeiro_Pessoal.DTO;
using Controle_Financeiro_Pessoal.Model;
using Microsoft.EntityFrameworkCore;

namespace Controle_Financeiro_Pessoal.Controller
{
    public class C7CategoriaController
    {
        private readonly ApplicationDbContext _Context;
        public C7CategoriaController() => _Context = new ApplicationDbContext(options: new DbContextOptionsBuilder<ApplicationDbContext>()
            .Options);

        public async Task AdicionarC7Categoria(C7Categoria c7categoria)
        {
            _Context.C7Categoria.Add(c7categoria);
            await _Context.SaveChangesAsync();
        }
        public async Task<List<C7CategoriaDTO>> ListarC7Categorias(int id_usuario)
        {
            var categorias = await _Context.C7Categoria
                .Where(c => c.C7FKC1ID_Usuario == id_usuario || c.C7FKC1ID_Usuario == null)
                .Select(c => new C7CategoriaDTO
                {
                    C7Id = c.C7Id,
                    C7Nome = c.C7Nome,
                    C7Tipo_Categoria = c.C7Tipo_Categoria == 1 ? "Mensal" : c.C7Tipo_Categoria == 2 ? "Anual" : "Normal"
                })
                .ToListAsync();
                
            categorias.Insert(0, new C7CategoriaDTO { C7Id = 0, C7Nome = "", C7Tipo_Categoria = "" });
            return categorias;
        }
        public async Task DeletarC7Categorias(int id_categoria)
        {
            await _Context.C7Categoria
                .Where(c => c.C7Id == id_categoria)
                .ExecuteDeleteAsync();
            await _Context.SaveChangesAsync();
        }
        public async Task<int?> VerificarTipoC7Categoria(int? id_categoria)
        {
             return await _Context.C7Categoria
                .Where(c => c.C7Id == id_categoria)
                .Select(c => (int?)c.C7Tipo_Categoria)
                .FirstOrDefaultAsync();
        }
    }
}
