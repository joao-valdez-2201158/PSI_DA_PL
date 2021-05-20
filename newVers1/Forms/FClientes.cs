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
    public partial class FClientes : Form
    {
        public FClientes()
        {
            InitializeComponent();
        }

        private void PessoaSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoaSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booKids_DBDataSet);

        }

        private void Pessoas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booKids_DBDataSet.CompraSet' table. You can move, or remove it, as needed.
            this.compraSetTableAdapter.Fill(this.booKids_DBDataSet.CompraSet);
            // TODO: This line of code loads data into the 'booKids_DBDataSet.PessoaSet' table. You can move, or remove it, as needed.
            this.pessoaSetTableAdapter.Fill(this.booKids_DBDataSet.PessoaSet);

        }

 
        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

    }
}
