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
    public partial class FilhosForm : Form
    {
        public FilhosForm()
        {
            InitializeComponent();
        }

        private void pessoaSet_FilhoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoaSet_FilhoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booKids_DataSet);

        }

        private void FilhosForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booKids_DataSet.InscricaoSet' table. You can move, or remove it, as needed.
            this.inscricaoSetTableAdapter.Fill(this.booKids_DataSet.InscricaoSet);
            // TODO: This line of code loads data into the 'booKids_DataSet.PessoaSet_Filho' table. You can move, or remove it, as needed.
        }
    }
}
