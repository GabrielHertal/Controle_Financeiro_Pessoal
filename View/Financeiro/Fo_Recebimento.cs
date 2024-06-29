using Controle_Financeiro_Pessoal.Controller;
using Controle_Financeiro_Pessoal.Model;
using Controle_Financeiro_Pessoal.View.Financeiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Financeiro_Pessoal.View.Recebimento
{
    public partial class Fo_Recebimento : Form
    {
        private readonly C7RecebimentoController _c7RecebimentoController;
        public bool _cadastrarecebimento = false;
        public Fo_Recebimento(C7RecebimentoController c7RecebimentoController)
        {
            _c7RecebimentoController = c7RecebimentoController;
            InitializeComponent();
        }
        private async void Fo_Recebimento_Load(object sender, EventArgs e)
        {
            grid_recebimentos.DataSource = await _c7RecebimentoController.ListarC7Recebimento();
        }
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            _cadastrarecebimento = true;
            Fo_Cadastra_Recebimento fo_Cadastra_Recebimento = new Fo_Cadastra_Recebimento(_c7RecebimentoController, _cadastrarecebimento);
            DialogResult result = fo_Cadastra_Recebimento.ShowDialog();
            if (result == DialogResult.OK)
            {
                grid_recebimentos.DataSource = _c7RecebimentoController.ListarC7Recebimento();
            }
        }
    }
}
