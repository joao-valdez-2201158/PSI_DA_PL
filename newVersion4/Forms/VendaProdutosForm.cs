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
    public partial class VendaProdutosForm : Form
    {
        public VendaProdutosForm()
        {
            InitializeComponent();
        }

        private void compraSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.compraSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booKids_DataSet);
            MessageBox.Show("Save Successfull");

        }

        private void VendaProdutosForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booKids_DataSet.DetalheCompraSet' table. You can move, or remove it, as needed.
            this.detalheCompraSetTableAdapter.Fill(this.booKids_DataSet.DetalheCompraSet);
            // TODO: This line of code loads data into the 'booKids_DataSet.CompraSet' table. You can move, or remove it, as needed.
            this.compraSetTableAdapter.Fill(this.booKids_DataSet.CompraSet);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

       
      
    }
}
