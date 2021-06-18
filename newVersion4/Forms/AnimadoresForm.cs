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
    public partial class AnimadoresForm : Form
    {
        public AnimadoresForm()
        {
            InitializeComponent();
        }

        private void colaboracaoSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.colaboracaoSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booKids_DataSet);

        }

        private void AnimadoresForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booKids_DataSet.PessoaSet_Animador' table. You can move, or remove it, as needed.
            this.pessoaSet_AnimadorTableAdapter.Fill(this.booKids_DataSet.PessoaSet_Animador);
            // TODO: This line of code loads data into the 'booKids_DataSet.ColaboracaoSet' table. You can move, or remove it, as needed.
            this.colaboracaoSetTableAdapter.Fill(this.booKids_DataSet.ColaboracaoSet);

        }

        private void lbAnimadores_Click(object sender, EventArgs e)
        {

        }
    }
}
