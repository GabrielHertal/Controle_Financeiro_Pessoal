using Controle_Financeiro_Pessoal.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Controle_Financeiro_Pessoal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<C1Usuario> C1Usuario { get; set; }
        public DbSet<C2Lancamentos> C2Lancamentos { get; set; }
        public DbSet<C3Status_Lancamento> C3Status_Lancamento { get; set; }
        public DbSet<C4Moeda> C4Moeda { get; set; }
        public DbSet<C5Tipo_Lancamento> C5Tipo_Lancamento { get; set; }
        public DbSet<C6Conta> C6Contas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("User Id=postgres;Password=Coxinha@932012;Server=db.svurdsjntoqabmebraeo.supabase.co;Port=5432;Database=postgres;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var table in modelBuilder.Model.GetEntityTypes())
            {
                table.SetTableName(table.GetTableName());

                foreach (var prop in table.GetProperties())
                {
                    var name = (prop.GetColumnName(StoreObjectIdentifier.Table(table.Name, table.GetSchema())) ?? prop.Name);
                    prop.SetColumnName(name);
                }
            }

        }
    }
}