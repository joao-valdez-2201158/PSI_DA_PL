using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA_BooKids.Forms
{
    public partial class FBooKids : Form
    {
        public FBooKids()
        {
            InitializeComponent();
        }

        private void BTN_GestaoClientes_Click(object sender, EventArgs e)
        {
            ClientesForm fClientes = new ClientesForm();
            fClientes.Show();
        }

        private void BTN_GestaoEventos_Click(object sender, EventArgs e)
        {
            EventosForm eventosForms = new EventosForm();
            eventosForms.Show();
        }

        private void BTN_GestaoEscolas_Click(object sender, EventArgs e)
        {
            EscolasForm escolasForm = new EscolasForm();
            escolasForm.Show();
        }

        private void BTN_GestaoProdutos_Click(object sender, EventArgs e)
        {
            CompraProdutosForm vendaProdutosForm = new CompraProdutosForm();
            vendaProdutosForm.Show();
        }

        private void BTN_ProdutosVendidos_Click(object sender, EventArgs e)
        {
            ProdutosVendidosForm produtosVendidosForm = new ProdutosVendidosForm();
            produtosVendidosForm.Show();
        }

        private void BTN_GestaoAnimadores_Click(object sender, EventArgs e)
        {
            AnimadoresForm animadoresForm = new AnimadoresForm();
            animadoresForm.Show();
        }

        private void BTN_GestaoFilhos_Click(object sender, EventArgs e)
        {
            FilhosForm filhosForm = new FilhosForm();
            filhosForm.Show();
        }

        private void BTN_GestaoPessoas_Click(object sender, EventArgs e)
        {
            PessoasForm pessoasForm = new PessoasForm();
            pessoasForm.Show();
        }

        private void FBooKids_Load(object sender, EventArgs e)
        {

        }
    }
}
