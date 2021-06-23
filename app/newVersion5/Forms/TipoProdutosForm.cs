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
    public partial class TipoProdutosForm : Form
    {
        public TipoProdutosForm()
        {
            InitializeComponent();
        }

        private void tipoProdutoSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tipoProdutoSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booKids_DBDataSet);

        }

        private void TipoProdutosForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booKids_DBDataSet.TipoProdutoSet' table. You can move, or remove it, as needed.
            this.tipoProdutoSetTableAdapter.Fill(this.booKids_DBDataSet.TipoProdutoSet);

        }
    }
}
