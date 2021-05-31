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
    public partial class FAnimadores : Form
    {
        public FAnimadores()
        {
            InitializeComponent();
        }

        private void FormAnimadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booKids_DBDataSet.PessoaSet_Animador' table. You can move, or remove it, as needed.
            this.pessoaSet_AnimadorTableAdapter.Fill(this.booKids_DBDataSet.PessoaSet_Animador);

        }

        private void PessoaSet_AnimadorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoaSet_AnimadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booKids_DBDataSet);

        }

        private void EspecialidadeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void especialidadeLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void idPessoaLabel_Click(object sender, EventArgs e)
        {

        }

        private void pessoaSet_AnimadorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void idPessoaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
