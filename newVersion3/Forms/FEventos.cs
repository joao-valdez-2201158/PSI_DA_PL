﻿using System;
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
    public partial class FEventos : Form
    {
        public FEventos()
        {
            InitializeComponent();
        }

        private void FormEventos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booKids_DBDataSet.EventoSet' table. You can move, or remove it, as needed.
            this.eventoSetTableAdapter.Fill(this.booKids_DBDataSet.EventoSet);

        }

        private void EventoSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventoSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booKids_DBDataSet);

        }

        private void descricaoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
