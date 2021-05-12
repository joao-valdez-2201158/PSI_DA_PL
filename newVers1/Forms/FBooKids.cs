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

        private void FBooKids_Load(object sender, EventArgs e)
        {

        }

        private void BTN_GestaoClientes_Click(object sender, EventArgs e)
        {
            FClientes fClientes = new FClientes();
            fClientes.Show();
        }

        private void BTN_GestaoEventos_Click(object sender, EventArgs e)
        {
            FEventos fEventos = new FEventos();
            fEventos.Show();
        }

        private void BTN_GestaoEscolas_Click(object sender, EventArgs e)
        {
            FEscolas fEscolas = new FEscolas();
            fEscolas.Show();
        }

        private void BTN_GestaoProdutos_Click(object sender, EventArgs e)
        {
            FVendas fVendas = new FVendas();
            fVendas.Show();
        }

        private void BTN_ProdutosVendidos_Click(object sender, EventArgs e)
        {
            FProdutosVendidos fProdutosVendidos = new FProdutosVendidos();
            fProdutosVendidos.Show();
        }

        private void BTN_GestaoAnimadores_Click(object sender, EventArgs e)
        {
            FAnimadores fAnimadores = new FAnimadores();
            fAnimadores.Show();
        }
    }
}
