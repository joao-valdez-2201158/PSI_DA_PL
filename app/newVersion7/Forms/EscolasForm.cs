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
    public partial class EscolasForm : Form
    {
        public EscolasForm()
        {
            InitializeComponent();
        }

        private void escolaSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.nomeTextBox.TextLength == 0 || this.moradaTextBox.TextLength == 0 || this.codPostalTextBox.TextLength == 0 || this.localidadeTextBox.TextLength == 0 || this.telefoneTextBox.TextLength == 0 || this.emailTextBox.TextLength == 0)
                {
                    MessageBox.Show("Campos por Preencher !!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (this.codPostalTextBox.TextLength < 7)
                {
                    MessageBox.Show("Campo Cod-Postal tem que possuir 7 carateres", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (this.telefoneTextBox.TextLength < 9)
                {
                    MessageBox.Show("Campo Telefone tem que possuir 9 carateres", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    this.Validate();
                    this.escolaSetBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.booKids_DBDataSet);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao salvar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EscolasForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booKids_DBDataSet.EscolaSet' table. You can move, or remove it, as needed.
            this.escolaSetTableAdapter.Fill(this.booKids_DBDataSet.EscolaSet);

        }
    }
}
