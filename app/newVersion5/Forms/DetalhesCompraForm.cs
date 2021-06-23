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
    public partial class DetalhesCompraForm : Form
    {
        public DetalhesCompraForm()
        {
            InitializeComponent();
        }

        private void detalheCompraSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.detalheCompraSetBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.booKids_DBDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex);
            }


        }

        private void DetalhesCompraForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booKids_DBDataSet.DetalheCompraSet' table. You can move, or remove it, as needed.
            this.detalheCompraSetTableAdapter.Fill(this.booKids_DBDataSet.DetalheCompraSet);

        }

        private void quantidadeLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void quantidadeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void compraNrCompraTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void compraNrCompraLabel_Click(object sender, EventArgs e)
        {

        }

        private void produtoCodProdutoLabel_Click(object sender, EventArgs e)
        {

        }

        private void produtoCodProdutoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
