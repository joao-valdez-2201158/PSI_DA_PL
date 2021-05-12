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
    public partial class FVendas : Form
    {
        public FVendas()
        {
            InitializeComponent();
        }

        private void compraSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.compraSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booKids_DBDataSet);

        }

        private void FormVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booKids_DBDataSet.ProdutoSet' table. You can move, or remove it, as needed.
            this.produtoSetTableAdapter.Fill(this.booKids_DBDataSet.ProdutoSet);
            // TODO: This line of code loads data into the 'booKids_DBDataSet.DetalheCompraSet' table. You can move, or remove it, as needed.
            this.detalheCompraSetTableAdapter.Fill(this.booKids_DBDataSet.DetalheCompraSet);
            // TODO: This line of code loads data into the 'booKids_DBDataSet.CompraSet' table. You can move, or remove it, as needed.
            this.compraSetTableAdapter.Fill(this.booKids_DBDataSet.CompraSet);

        }

        private void compraSetDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
