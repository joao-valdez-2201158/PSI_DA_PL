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
    public partial class ColaboracaoEventoForm : Form
    {
        public ColaboracaoEventoForm()
        {
            InitializeComponent();
        }

        private void colaboracaoSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.idAnimadorTextBox.TextLength == 0 || this.nrEventoTextBox.TextLength == 0)
                {
                    MessageBox.Show("Campos por Preencher !!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                /*
                else if (this.idAnimadorTextBox.Text)
                {
                    // PessoaSet_AnimadorIdPessoa
                }
                else if (this.nrEventoTextBox.Text)
                {
                    // EventoSet_NrEvemto
                }
                */
                else
                {
                    this.Validate();
                    this.colaboracaoSetBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.booKids_DBDataSet);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao salvar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ColaboracaoEventoForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booKids_DBDataSet.ColaboracaoSet' table. You can move, or remove it, as needed.
            this.colaboracaoSetTableAdapter.Fill(this.booKids_DBDataSet.ColaboracaoSet);

        }
    }
}
