
namespace Projeto_DA_BooKids
{
    partial class EventosForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label localLabel;
            System.Windows.Forms.Label dataHoraLabel;
            System.Windows.Forms.Label limiteParticipacaoLabel;
            System.Windows.Forms.Label idadeInferiorLabel;
            System.Windows.Forms.Label idadeSuperiorLabel;
            System.Windows.Forms.Label tipoEventoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventosForms));
            this.booKids_DataSet = new Projeto_DA_BooKids.BooKids_DataSet();
            this.eventoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventoSetTableAdapter = new Projeto_DA_BooKids.BooKids_DataSetTableAdapters.EventoSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_BooKids.BooKids_DataSetTableAdapters.TableAdapterManager();
            this.eventoSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.eventoSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eventoSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.localTextBox = new System.Windows.Forms.TextBox();
            this.dataHoraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.limiteParticipacaoTextBox = new System.Windows.Forms.TextBox();
            this.idadeInferiorTextBox = new System.Windows.Forms.TextBox();
            this.idadeSuperiorTextBox = new System.Windows.Forms.TextBox();
            this.tipoEventoTextBox = new System.Windows.Forms.TextBox();
            this.lbEventos = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            localLabel = new System.Windows.Forms.Label();
            dataHoraLabel = new System.Windows.Forms.Label();
            limiteParticipacaoLabel = new System.Windows.Forms.Label();
            idadeInferiorLabel = new System.Windows.Forms.Label();
            idadeSuperiorLabel = new System.Windows.Forms.Label();
            tipoEventoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoSetBindingNavigator)).BeginInit();
            this.eventoSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventoSetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(65, 191);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(75, 17);
            descricaoLabel.TabIndex = 4;
            descricaoLabel.Text = "Descricao:";
            // 
            // localLabel
            // 
            localLabel.AutoSize = true;
            localLabel.Location = new System.Drawing.Point(65, 221);
            localLabel.Name = "localLabel";
            localLabel.Size = new System.Drawing.Size(46, 17);
            localLabel.TabIndex = 6;
            localLabel.Text = "Local:";
            // 
            // dataHoraLabel
            // 
            dataHoraLabel.AutoSize = true;
            dataHoraLabel.Location = new System.Drawing.Point(62, 250);
            dataHoraLabel.Name = "dataHoraLabel";
            dataHoraLabel.Size = new System.Drawing.Size(77, 17);
            dataHoraLabel.TabIndex = 8;
            dataHoraLabel.Text = "Data Hora:";
            // 
            // limiteParticipacaoLabel
            // 
            limiteParticipacaoLabel.AutoSize = true;
            limiteParticipacaoLabel.Location = new System.Drawing.Point(62, 280);
            limiteParticipacaoLabel.Name = "limiteParticipacaoLabel";
            limiteParticipacaoLabel.Size = new System.Drawing.Size(131, 17);
            limiteParticipacaoLabel.TabIndex = 10;
            limiteParticipacaoLabel.Text = "Limite Participacao:";
            // 
            // idadeInferiorLabel
            // 
            idadeInferiorLabel.AutoSize = true;
            idadeInferiorLabel.Location = new System.Drawing.Point(62, 309);
            idadeInferiorLabel.Name = "idadeInferiorLabel";
            idadeInferiorLabel.Size = new System.Drawing.Size(95, 17);
            idadeInferiorLabel.TabIndex = 12;
            idadeInferiorLabel.Text = "Idade Inferior:";
            // 
            // idadeSuperiorLabel
            // 
            idadeSuperiorLabel.AutoSize = true;
            idadeSuperiorLabel.Location = new System.Drawing.Point(62, 339);
            idadeSuperiorLabel.Name = "idadeSuperiorLabel";
            idadeSuperiorLabel.Size = new System.Drawing.Size(105, 17);
            idadeSuperiorLabel.TabIndex = 14;
            idadeSuperiorLabel.Text = "Idade Superior:";
            // 
            // tipoEventoLabel
            // 
            tipoEventoLabel.AutoSize = true;
            tipoEventoLabel.Location = new System.Drawing.Point(62, 366);
            tipoEventoLabel.Name = "tipoEventoLabel";
            tipoEventoLabel.Size = new System.Drawing.Size(88, 17);
            tipoEventoLabel.TabIndex = 16;
            tipoEventoLabel.Text = "Tipo Evento:";
            // 
            // booKids_DataSet
            // 
            this.booKids_DataSet.DataSetName = "BooKids_DataSet";
            this.booKids_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventoSetBindingSource
            // 
            this.eventoSetBindingSource.DataMember = "EventoSet";
            this.eventoSetBindingSource.DataSource = this.booKids_DataSet;
            // 
            // eventoSetTableAdapter
            // 
            this.eventoSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColaboracaoSetTableAdapter = null;
            this.tableAdapterManager.CompraSetTableAdapter = null;
            this.tableAdapterManager.DetalheCompraSetTableAdapter = null;
            this.tableAdapterManager.EscolaSetTableAdapter = null;
            this.tableAdapterManager.EventoSetTableAdapter = this.eventoSetTableAdapter;
            this.tableAdapterManager.InscricaoSetTableAdapter = null;
            this.tableAdapterManager.ParticipacaoSetTableAdapter = null;
            this.tableAdapterManager.PessoaSet_AnimadorTableAdapter = null;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_FilhoTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.ProdutoSetTableAdapter = null;
            this.tableAdapterManager.TipoProdutoSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_BooKids.BooKids_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eventoSetBindingNavigator
            // 
            this.eventoSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eventoSetBindingNavigator.BindingSource = this.eventoSetBindingSource;
            this.eventoSetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eventoSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eventoSetBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.eventoSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.eventoSetBindingNavigatorSaveItem});
            this.eventoSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eventoSetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eventoSetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eventoSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eventoSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eventoSetBindingNavigator.Name = "eventoSetBindingNavigator";
            this.eventoSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eventoSetBindingNavigator.Size = new System.Drawing.Size(957, 27);
            this.eventoSetBindingNavigator.TabIndex = 0;
            this.eventoSetBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(49, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // eventoSetBindingNavigatorSaveItem
            // 
            this.eventoSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eventoSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eventoSetBindingNavigatorSaveItem.Image")));
            this.eventoSetBindingNavigatorSaveItem.Name = "eventoSetBindingNavigatorSaveItem";
            this.eventoSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.eventoSetBindingNavigatorSaveItem.Text = "Save Data";
            this.eventoSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.eventoSetBindingNavigatorSaveItem_Click);
            // 
            // eventoSetDataGridView
            // 
            this.eventoSetDataGridView.AllowUserToAddRows = false;
            this.eventoSetDataGridView.AllowUserToDeleteRows = false;
            this.eventoSetDataGridView.AutoGenerateColumns = false;
            this.eventoSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventoSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.eventoSetDataGridView.DataSource = this.eventoSetBindingSource;
            this.eventoSetDataGridView.Location = new System.Drawing.Point(65, 416);
            this.eventoSetDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eventoSetDataGridView.Name = "eventoSetDataGridView";
            this.eventoSetDataGridView.ReadOnly = true;
            this.eventoSetDataGridView.RowHeadersWidth = 51;
            this.eventoSetDataGridView.RowTemplate.Height = 24;
            this.eventoSetDataGridView.Size = new System.Drawing.Size(816, 335);
            this.eventoSetDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NrEvento";
            this.dataGridViewTextBoxColumn1.HeaderText = "NrEvento";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TipoEvento";
            this.dataGridViewTextBoxColumn8.HeaderText = "TipoEvento";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Local";
            this.dataGridViewTextBoxColumn3.HeaderText = "Local";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataHora";
            this.dataGridViewTextBoxColumn4.HeaderText = "DataHora";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LimiteParticipacao";
            this.dataGridViewTextBoxColumn5.HeaderText = "LimiteParticipacao";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdadeInferior";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdadeInferior";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdadeSuperior";
            this.dataGridViewTextBoxColumn7.HeaderText = "IdadeSuperior";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoSetBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(227, 186);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(287, 22);
            this.descricaoTextBox.TabIndex = 5;
            // 
            // localTextBox
            // 
            this.localTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoSetBindingSource, "Local", true));
            this.localTextBox.Location = new System.Drawing.Point(227, 216);
            this.localTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.localTextBox.Name = "localTextBox";
            this.localTextBox.Size = new System.Drawing.Size(200, 22);
            this.localTextBox.TabIndex = 7;
            // 
            // dataHoraDateTimePicker
            // 
            this.dataHoraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventoSetBindingSource, "DataHora", true));
            this.dataHoraDateTimePicker.Location = new System.Drawing.Point(227, 245);
            this.dataHoraDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataHoraDateTimePicker.Name = "dataHoraDateTimePicker";
            this.dataHoraDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dataHoraDateTimePicker.TabIndex = 9;
            // 
            // limiteParticipacaoTextBox
            // 
            this.limiteParticipacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoSetBindingSource, "LimiteParticipacao", true));
            this.limiteParticipacaoTextBox.Location = new System.Drawing.Point(227, 275);
            this.limiteParticipacaoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.limiteParticipacaoTextBox.Name = "limiteParticipacaoTextBox";
            this.limiteParticipacaoTextBox.Size = new System.Drawing.Size(76, 22);
            this.limiteParticipacaoTextBox.TabIndex = 11;
            // 
            // idadeInferiorTextBox
            // 
            this.idadeInferiorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoSetBindingSource, "IdadeInferior", true));
            this.idadeInferiorTextBox.Location = new System.Drawing.Point(227, 304);
            this.idadeInferiorTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idadeInferiorTextBox.Name = "idadeInferiorTextBox";
            this.idadeInferiorTextBox.Size = new System.Drawing.Size(76, 22);
            this.idadeInferiorTextBox.TabIndex = 13;
            // 
            // idadeSuperiorTextBox
            // 
            this.idadeSuperiorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoSetBindingSource, "IdadeSuperior", true));
            this.idadeSuperiorTextBox.Location = new System.Drawing.Point(227, 334);
            this.idadeSuperiorTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idadeSuperiorTextBox.Name = "idadeSuperiorTextBox";
            this.idadeSuperiorTextBox.Size = new System.Drawing.Size(76, 22);
            this.idadeSuperiorTextBox.TabIndex = 15;
            // 
            // tipoEventoTextBox
            // 
            this.tipoEventoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoSetBindingSource, "TipoEvento", true));
            this.tipoEventoTextBox.Location = new System.Drawing.Point(227, 363);
            this.tipoEventoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipoEventoTextBox.Name = "tipoEventoTextBox";
            this.tipoEventoTextBox.Size = new System.Drawing.Size(200, 22);
            this.tipoEventoTextBox.TabIndex = 17;
            // 
            // lbEventos
            // 
            this.lbEventos.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventos.Location = new System.Drawing.Point(0, 82);
            this.lbEventos.Name = "lbEventos";
            this.lbEventos.Size = new System.Drawing.Size(957, 57);
            this.lbEventos.TabIndex = 18;
            this.lbEventos.Text = "Eventos";
            this.lbEventos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventosForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 797);
            this.Controls.Add(this.lbEventos);
            this.Controls.Add(tipoEventoLabel);
            this.Controls.Add(this.tipoEventoTextBox);
            this.Controls.Add(idadeSuperiorLabel);
            this.Controls.Add(this.idadeSuperiorTextBox);
            this.Controls.Add(idadeInferiorLabel);
            this.Controls.Add(this.idadeInferiorTextBox);
            this.Controls.Add(limiteParticipacaoLabel);
            this.Controls.Add(this.limiteParticipacaoTextBox);
            this.Controls.Add(dataHoraLabel);
            this.Controls.Add(this.dataHoraDateTimePicker);
            this.Controls.Add(localLabel);
            this.Controls.Add(this.localTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.eventoSetDataGridView);
            this.Controls.Add(this.eventoSetBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EventosForms";
            this.Text = "EventosForms";
            this.Load += new System.EventHandler(this.EventosForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoSetBindingNavigator)).EndInit();
            this.eventoSetBindingNavigator.ResumeLayout(false);
            this.eventoSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventoSetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BooKids_DataSet booKids_DataSet;
        private System.Windows.Forms.BindingSource eventoSetBindingSource;
        private BooKids_DataSetTableAdapters.EventoSetTableAdapter eventoSetTableAdapter;
        private BooKids_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eventoSetBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton eventoSetBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView eventoSetDataGridView;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox localTextBox;
        private System.Windows.Forms.DateTimePicker dataHoraDateTimePicker;
        private System.Windows.Forms.TextBox limiteParticipacaoTextBox;
        private System.Windows.Forms.TextBox idadeInferiorTextBox;
        private System.Windows.Forms.TextBox idadeSuperiorTextBox;
        private System.Windows.Forms.TextBox tipoEventoTextBox;
        private System.Windows.Forms.Label lbEventos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}