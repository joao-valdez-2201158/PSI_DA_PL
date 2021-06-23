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
    public partial class EventosForms : Form
    {
        public EventosForms()
        {
            InitializeComponent();
        }

        private void eventoSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            /*
            if (idadeInferiorTextBox.Text <= (0.ToString()))
            {

            }
            */
            this.eventoSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booKids_DataSet);

        }

        private void EventosForms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booKids_DataSet.EventoSet' table. You can move, or remove it, as needed.
            this.eventoSetTableAdapter.Fill(this.booKids_DataSet.EventoSet);

        }
    }
}
