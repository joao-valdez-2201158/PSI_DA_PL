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
    public partial class EventosForm : Form
    {
        public EventosForm()
        {
            InitializeComponent();
        }

        private void eventoSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.descricaoTextBox.TextLength == 0 || this.localTextBox.TextLength == 0 || this.limiteParticipacaoTextBox.TextLength == 0 || this.idadeInferiorTextBox.TextLength == 0 || this.idadeSuperiorTextBox.TextLength == 0 || this.tipoEventoTextBox.TextLength == 0)
                {
                    MessageBox.Show("Campos por Preencher !!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    this.Validate();
                    this.eventoSetBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.booKids_DBDataSet);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao salvar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EventosForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booKids_DBDataSet.EventoSet' table. You can move, or remove it, as needed.
            this.eventoSetTableAdapter.Fill(this.booKids_DBDataSet.EventoSet);

        }

        private void BTN_Colaboracao_Click(object sender, EventArgs e)
        {
            ColaboracaoEventoForm colab = new ColaboracaoEventoForm();
            colab.Show();
        }

        private void BTN_Inscricao_Click(object sender, EventArgs e)
        {
            InscricaoEventoForm inscricao = new InscricaoEventoForm();
            inscricao.Show();
        }

        private void BTN_Participacao_Click(object sender, EventArgs e)
        {
            ParticipacaoEventoForm participacao = new ParticipacaoEventoForm();
            participacao.Show();
        }

        private void BTN_Exportar_Click(object sender, EventArgs e)
        {
            ExportToPdf.exportGridtoPDF(eventoSetDataGridView, "eventos.pdf");
        }
    }
}
