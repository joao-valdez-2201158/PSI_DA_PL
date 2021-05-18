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
    public partial class FEscolas : Form
    {
        public FEscolas()
        {
            InitializeComponent();
        }

        private void FormEscolas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booKids_DBDataSet.EscolaSet' table. You can move, or remove it, as needed.
            this.escolaSetTableAdapter.Fill(this.booKids_DBDataSet.EscolaSet);

        }

        private void EscolaSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.escolaSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booKids_DBDataSet);

        }

        private void LocalidadeLabel_Click(object sender, EventArgs e)
        {

        }

        private void localidadeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
