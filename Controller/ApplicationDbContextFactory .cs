using Controle_Financeiro_Pessoal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Controle_Financeiro_Pessoal.Controller
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsbuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsbuilder.UseNpgsql("User Id=postgres;Password=Coxinha@932012;Server=db.svurdsjntoqabmebraeo.supabase.co;Port=5432;Database=postgres;");
            return new ApplicationDbContext(optionsbuilder.Options);
        }
    }
}