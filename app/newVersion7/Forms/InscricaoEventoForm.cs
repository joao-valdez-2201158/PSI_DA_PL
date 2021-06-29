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
    public partial class InscricaoEventoForm : Form
    {
        public InscricaoEventoForm()
        {
            InitializeComponent();
        }

        private void inscricaoSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.filhoIdPessoaTextBox.TextLength == 0 || this.eventoNrEventoTextBox.TextLength == 0)
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
                    this.inscricaoSetBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.booKids_DBDataSet);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao salvar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InscricaoEvento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booKids_DBDataSet.InscricaoSet' table. You can move, or remove it, as needed.
            this.inscricaoSetTableAdapter.Fill(this.booKids_DBDataSet.InscricaoSet);

        }
    }
}
