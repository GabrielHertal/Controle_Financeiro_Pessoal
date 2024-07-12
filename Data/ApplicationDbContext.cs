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
        public DbSet<C2Lancamento> C2Lancamento { get; set; }
        public DbSet<C3Status_Lancamento> C3Status_Lancamento { get; set; }
        public DbSet<C4Moeda> C4Moeda { get; set; }
        public DbSet<C5Tipo_Lancamento> C5Tipo_Lancamento { get; set; }
        public DbSet<C6Conta> C6Conta { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("User Id=postgres.svurdsjntoqabmebraeo;Password=Coxinha@932012;Server=aws-0-sa-east-1.pooler.supabase.com;Port=6543;Database=postgres;Pooling=false;");
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