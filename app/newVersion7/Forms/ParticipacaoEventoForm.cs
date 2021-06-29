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
    public partial class ParticipacaoEventoForm : Form
    {
        public ParticipacaoEventoForm()
        {
            InitializeComponent();
        }

        private void participacaoSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.idEscolaTextBox.TextLength == 0 || this.nrEventoTextBox.TextLength == 0)
                {
                    MessageBox.Show("Campos por Preencher !!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                /*
                else if (this.idPessoaTextBox.Text)
                {
                    // PessoaSet_IdPessoa
                }
                */
                else
                {
                    this.Validate();
                    this.participacaoSetBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.booKids_DBDataSet);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao salvar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ParticipacaoEventoForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booKids_DBDataSet.ParticipacaoSet' table. You can move, or remove it, as needed.
            this.participacaoSetTableAdapter.Fill(this.booKids_DBDataSet.ParticipacaoSet);

        }
    }
}
