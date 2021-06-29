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
    public partial class CompraProdutosForm : Form
    {
        public CompraProdutosForm()
        {
            InitializeComponent();
        }

        private void detalheCompraSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.produtosCodProdutoTextBox.TextLength == 0|| this.nrCompraTextBox.TextLength == 0 || this.idClienteTextBox.TextLength == 0)
                {
                    MessageBox.Show("Campos por Preencher !!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (this.nrCompraTextBox.TextLength < 4)
                {
                    MessageBox.Show("Campo NrCompra tem que possuir 4 carateres", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                /*
                else if (this.idClienteTextBox.Text)
                {
                     // PessoaSet_ClienteIdPessoa
                }
                */
                else
                {
                    this.Validate();
                    this.compraSetBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.booKids_DBDataSet);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao salvar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VendaProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booKids_DBDataSet.CompraSet' table. You can move, or remove it, as needed.
            this.compraSetTableAdapter.Fill(this.booKids_DBDataSet.CompraSet);

        }

        private void compraSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.compraSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booKids_DBDataSet);

        }

        private void BTN_InserirDetalheCompra_Click(object sender, EventArgs e)
        {
            DetalhesCompraForm detalhecompra = new DetalhesCompraForm();
            detalhecompra.Show();
        }

        private void btnExpCom_Click(object sender, EventArgs e)
        {
            ExportToPdf.exportGridtoPDF(compraSetDataGridView, "text");
        }
    }
}
