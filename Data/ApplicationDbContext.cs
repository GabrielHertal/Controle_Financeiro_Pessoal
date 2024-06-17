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
        public DbSet<C3Status_Lancamento> C3Status_Lancamentos { get; set; }
        public DbSet<C4Moeda> C4Moeda { get; set; }
        public DbSet<C5Tipo_Lancamento> C5Tipo_Lancamentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("User Id=postgres.atfnoismzndhpzpynwes;Password=Coxinha@932012;Server=aws-0-sa-east-1.pooler.supabase.com;Port=6543;Database=postgres;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var table in modelBuilder.Model.GetEntityTypes())
            {
                table.SetTableName(table.GetTableName().ToLower());

                foreach (var prop in table.GetProperties())
                {
                    var name = (prop.GetColumnName(StoreObjectIdentifier.Table(table.Name, table.GetSchema())) ?? prop.Name).ToLower();
                    prop.SetColumnName(name);
                }
            }

        }
    }
}
