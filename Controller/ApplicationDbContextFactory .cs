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
            optionsbuilder.UseNpgsql("User Id=postgres.svurdsjntoqabmebraeo;Password=Coxinha@932012;Server=aws-0-sa-east-1.pooler.supabase.com;Port=6543;Database=postgres;Pooling=false;");
            return new ApplicationDbContext(optionsbuilder.Options);
        }
    }
}