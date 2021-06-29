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
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }



        private void pessoaSet_ClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.idPessoaTextBox.TextLength == 0 || this.nrCartaoTextBox.TextLength == 0 || this.valorOfertaTextBox.TextLength == 0)
                {
                    MessageBox.Show("Campos por Preencher !!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (this.nrCartaoTextBox.TextLength < 4)
                {
                    MessageBox.Show("Campo NrCartao tem que possuir 4 carateres", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
                    this.pessoaSet_ClienteBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.booKids_DBDataSet);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao salvar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booKids_DBDataSet.PessoaSet_Cliente' table. You can move, or remove it, as needed.
            this.pessoaSet_ClienteTableAdapter.Fill(this.booKids_DBDataSet.PessoaSet_Cliente);

        }

        private void BTN_InserirFilho_Click(object sender, EventArgs e)
        {
            FilhosForm filhos = new FilhosForm();
            filhos.Show();
        }
    }
}
