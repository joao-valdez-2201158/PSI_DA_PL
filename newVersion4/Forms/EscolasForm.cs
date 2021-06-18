using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA_BooKids
{
    public partial class EscolasForm : Form
    {
        public EscolasForm()
        {
            InitializeComponent();
        }

        private void participacaoSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.participacaoSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booKids_DataSet);

        }

        private void EscolasForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booKids_DataSet.EscolaSet' table. You can move, or remove it, as needed.
            this.escolaSetTableAdapter.Fill(this.booKids_DataSet.EscolaSet);
            // TODO: This line of code loads data into the 'booKids_DataSet.PessoaSet_Filho' table. You can move, or remove it, as needed.
            this.pessoaSet_FilhoTableAdapter.Fill(this.booKids_DataSet.PessoaSet_Filho);
            // TODO: This line of code loads data into the 'booKids_DataSet.ParticipacaoSet' table. You can move, or remove it, as needed.
            this.participacaoSetTableAdapter.Fill(this.booKids_DataSet.ParticipacaoSet);

        }

        private void idEscolaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
