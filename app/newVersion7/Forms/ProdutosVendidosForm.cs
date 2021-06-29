using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Projeto_DA_BooKids.Forms
{
    public partial class ProdutosVendidosForm : Form
    {
        public ProdutosVendidosForm()
        {
            InitializeComponent();
        }

        private void produtoSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.designacaoTextBox.TextLength == 0 || this.precoTextBox.TextLength == 0 || this.stockExistenteTextBox.TextLength == 0 || this.codTipoProdutoTextBox.TextLength == 0)
                {
                    MessageBox.Show("Campos por Preencher !!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                /*
                else if (this.idPessoaTextBox.Text)
                {
                    // PessoaSet_IdPessoa
                }
                */
                else
                {
                    this.Validate();
                    this.produtoSetBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.booKids_DBDataSet);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao salvar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ProdutosVendidosForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booKids_DBDataSet.ProdutoSet' table. You can move, or remove it, as needed.
            this.produtoSetTableAdapter.Fill(this.booKids_DBDataSet.ProdutoSet);

        }

        private void BTN_InserirTipoProduto_Click(object sender, EventArgs e)
        {
            TipoProdutosForm tipoproduto = new TipoProdutosForm();
            tipoproduto.Show();
        }
        
    
    }
}
