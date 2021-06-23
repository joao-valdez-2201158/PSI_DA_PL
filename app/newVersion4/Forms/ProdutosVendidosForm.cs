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
    public partial class ProdutosVendidosForm : Form
    {
        public ProdutosVendidosForm()
        {
            InitializeComponent();
        }

        private void produtoSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booKids_DataSet);

        }

        private void ProdutosVendidosForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booKids_DataSet.ProdutoSet' table. You can move, or remove it, as needed.
            this.produtoSetTableAdapter.Fill(this.booKids_DataSet.ProdutoSet);

        }
    }
}
