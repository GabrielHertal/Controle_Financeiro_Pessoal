using Controle_Financeiro_Pessoal.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Financeiro_Pessoal.Controller
{
    public class UsuarioController
    {
        private readonly ApplicationDbContext _Context;

        public UsuarioController()
        {
            var optionsbuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsbuilder.UseNpgsql("User Id=postgres.atfnoismzndhpzpynwes;Password=Coxinha@932012;Server=aws-0-sa-east-1.pooler.supabase.com;Port=6543;Database=postgres");
            _Context = new ApplicationDbContext(optionsbuilder.Options);
        }
    }
}
