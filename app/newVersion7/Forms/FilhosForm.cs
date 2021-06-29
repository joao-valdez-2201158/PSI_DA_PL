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
            try
            {
                if (this.idPessoaTextBox.TextLength == 0 || this.sexoTextBox.TextLength == 0 || this.idEscolaTextBox.TextLength == 0 || this.idProgenitorTextBox.TextLength == 0)
                {
                    MessageBox.Show("Campos por Preencher !!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                /*
                else if (this.idEscolaTextBox.Text)
                {
                    // EscolaSet_IdEscola
                }
                else if (this.idProgenitorTextBox.Text)
                {
                    // PessoaSet_ClienteIdPessoa
                }
                else if (this.idPessoaTextBox.Text)
                {
                    // PessoaSet_IdPessoa
                }
                */
                else
                {
                    this.Validate();
                    this.pessoaSet_FilhoBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.booKids_DBDataSet);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao salvar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void FilhosForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booKids_DBDataSet.PessoaSet_Filho' table. You can move, or remove it, as needed.
            this.pessoaSet_FilhoTableAdapter.Fill(this.booKids_DBDataSet.PessoaSet_Filho);

        }
    }
}
