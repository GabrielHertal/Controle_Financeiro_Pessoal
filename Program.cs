using Controle_Financeiro_Pessoal.Controller;
using Controle_Financeiro_Pessoal.Data;
using Controle_Financeiro_Pessoal.View;
using Microsoft.EntityFrameworkCore;
namespace Controle_Financeiro_Pessoal
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            C1UsuarioController c1usuariocontroller = new C1UsuarioController();
            ApplicationConfiguration.Initialize();
            Application.Run(new Fo_Login(c1usuariocontroller));
        }
    }
}