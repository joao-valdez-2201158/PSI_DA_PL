﻿
namespace Projeto_DA_BooKids.Forms
{
    partial class FEventos
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
            System.Windows.Forms.Label nrEventoLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label localLabel;
            System.Windows.Forms.Label dataHoraLabel;
            System.Windows.Forms.Label limiteParticipacaoLabel;
            System.Windows.Forms.Label idadeInferiorLabel;
            System.Windows.Forms.Label idadeSuperiorLabel;
            System.Windows.Forms.Label tipoEventoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEventos));
            this.booKids_DBDataSet = new Projeto_DA_BooKids.BooKids_DBDataSet();
            this.eventoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventoSetTableAdapter = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.EventoSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager();
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
            this.nrEventoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.localTextBox = new System.Windows.Forms.TextBox();
            this.dataHoraTextBox = new System.Windows.Forms.TextBox();
            this.limiteParticipacaoTextBox = new System.Windows.Forms.TextBox();
            this.idadeInferiorTextBox = new System.Windows.Forms.TextBox();
            this.idadeSuperiorTextBox = new System.Windows.Forms.TextBox();
            this.tipoEventoTextBox = new System.Windows.Forms.TextBox();
            this.LBEventos = new System.Windows.Forms.Label();
            this.eventoSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nrEventoLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            localLabel = new System.Windows.Forms.Label();
            dataHoraLabel = new System.Windows.Forms.Label();
            limiteParticipacaoLabel = new System.Windows.Forms.Label();
            idadeInferiorLabel = new System.Windows.Forms.Label();
            idadeSuperiorLabel = new System.Windows.Forms.Label();
            tipoEventoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoSetBindingNavigator)).BeginInit();
            this.eventoSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventoSetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nrEventoLabel
            // 
            nrEventoLabel.AutoSize = true;
            nrEventoLabel.Location = new System.Drawing.Point(56, 256);
            nrEventoLabel.Name = "nrEventoLabel";
            nrEventoLabel.Size = new System.Drawing.Size(75, 17);
            nrEventoLabel.TabIndex = 2;
            nrEventoLabel.Text = "Nr Evento:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(56, 316);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(75, 17);
            descricaoLabel.TabIndex = 4;
            descricaoLabel.Text = "Descricao:";
            // 
            // localLabel
            // 
            localLabel.AutoSize = true;
            localLabel.Location = new System.Drawing.Point(52, 380);
            localLabel.Name = "localLabel";
            localLabel.Size = new System.Drawing.Size(46, 17);
            localLabel.TabIndex = 6;
            localLabel.Text = "Local:";
            // 
            // dataHoraLabel
            // 
            dataHoraLabel.AutoSize = true;
            dataHoraLabel.Location = new System.Drawing.Point(54, 444);
            dataHoraLabel.Name = "dataHoraLabel";
            dataHoraLabel.Size = new System.Drawing.Size(77, 17);
            dataHoraLabel.TabIndex = 8;
            dataHoraLabel.Text = "Data Hora:";
            // 
            // limiteParticipacaoLabel
            // 
            limiteParticipacaoLabel.AutoSize = true;
            limiteParticipacaoLabel.Location = new System.Drawing.Point(52, 511);
            limiteParticipacaoLabel.Name = "limiteParticipacaoLabel";
            limiteParticipacaoLabel.Size = new System.Drawing.Size(131, 17);
            limiteParticipacaoLabel.TabIndex = 10;
            limiteParticipacaoLabel.Text = "Limite Participacao:";
            // 
            // idadeInferiorLabel
            // 
            idadeInferiorLabel.AutoSize = true;
            idadeInferiorLabel.Location = new System.Drawing.Point(54, 564);
            idadeInferiorLabel.Name = "idadeInferiorLabel";
            idadeInferiorLabel.Size = new System.Drawing.Size(95, 17);
            idadeInferiorLabel.TabIndex = 12;
            idadeInferiorLabel.Text = "Idade Inferior:";
            // 
            // idadeSuperiorLabel
            // 
            idadeSuperiorLabel.AutoSize = true;
            idadeSuperiorLabel.Location = new System.Drawing.Point(52, 627);
            idadeSuperiorLabel.Name = "idadeSuperiorLabel";
            idadeSuperiorLabel.Size = new System.Drawing.Size(105, 17);
            idadeSuperiorLabel.TabIndex = 14;
            idadeSuperiorLabel.Text = "Idade Superior:";
            // 
            // tipoEventoLabel
            // 
            tipoEventoLabel.AutoSize = true;
            tipoEventoLabel.Location = new System.Drawing.Point(55, 698);
            tipoEventoLabel.Name = "tipoEventoLabel";
            tipoEventoLabel.Size = new System.Drawing.Size(88, 17);
            tipoEventoLabel.TabIndex = 16;
            tipoEventoLabel.Text = "Tipo Evento:";
            // 
            // booKids_DBDataSet
            // 
            this.booKids_DBDataSet.DataSetName = "BooKids_DBDataSet";
            this.booKids_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventoSetBindingSource
            // 
            this.eventoSetBindingSource.DataMember = "EventoSet";
            this.eventoSetBindingSource.DataSource = this.booKids_DBDataSet;
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
            this.tableAdapterManager.UpdateOrder = Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.eventoSetBindingNavigator.Size = new System.Drawing.Size(1323, 39);
            this.eventoSetBindingNavigator.TabIndex = 0;
            this.eventoSetBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 36);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // eventoSetBindingNavigatorSaveItem
            // 
            this.eventoSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eventoSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eventoSetBindingNavigatorSaveItem.Image")));
            this.eventoSetBindingNavigatorSaveItem.Name = "eventoSetBindingNavigatorSaveItem";
            this.eventoSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 36);
            this.eventoSetBindingNavigatorSaveItem.Text = "Save Data";
            this.eventoSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.eventoSetBindingNavigatorSaveItem_Click);
            // 
            // nrEventoTextBox
            // 
            this.nrEventoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nrEventoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoSetBindingSource, "NrEvento", true));
            this.nrEventoTextBox.Location = new System.Drawing.Point(185, 256);
            this.nrEventoTextBox.Name = "nrEventoTextBox";
            this.nrEventoTextBox.Size = new System.Drawing.Size(185, 22);
            this.nrEventoTextBox.TabIndex = 3;
            this.nrEventoTextBox.TextChanged += new System.EventHandler(this.nrEventoTextBox_TextChanged);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoSetBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(185, 316);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(185, 22);
            this.descricaoTextBox.TabIndex = 5;
            // 
            // localTextBox
            // 
            this.localTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.localTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoSetBindingSource, "Local", true));
            this.localTextBox.Location = new System.Drawing.Point(185, 380);
            this.localTextBox.Name = "localTextBox";
            this.localTextBox.Size = new System.Drawing.Size(185, 22);
            this.localTextBox.TabIndex = 7;
            // 
            // dataHoraTextBox
            // 
            this.dataHoraTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataHoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoSetBindingSource, "DataHora", true));
            this.dataHoraTextBox.Location = new System.Drawing.Point(185, 444);
            this.dataHoraTextBox.Name = "dataHoraTextBox";
            this.dataHoraTextBox.Size = new System.Drawing.Size(185, 22);
            this.dataHoraTextBox.TabIndex = 9;
            // 
            // limiteParticipacaoTextBox
            // 
            this.limiteParticipacaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.limiteParticipacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoSetBindingSource, "LimiteParticipacao", true));
            this.limiteParticipacaoTextBox.Location = new System.Drawing.Point(185, 506);
            this.limiteParticipacaoTextBox.Name = "limiteParticipacaoTextBox";
            this.limiteParticipacaoTextBox.Size = new System.Drawing.Size(185, 22);
            this.limiteParticipacaoTextBox.TabIndex = 11;
            // 
            // idadeInferiorTextBox
            // 
            this.idadeInferiorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idadeInferiorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoSetBindingSource, "IdadeInferior", true));
            this.idadeInferiorTextBox.Location = new System.Drawing.Point(185, 562);
            this.idadeInferiorTextBox.Name = "idadeInferiorTextBox";
            this.idadeInferiorTextBox.Size = new System.Drawing.Size(100, 22);
            this.idadeInferiorTextBox.TabIndex = 13;
            // 
            // idadeSuperiorTextBox
            // 
            this.idadeSuperiorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idadeSuperiorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoSetBindingSource, "IdadeSuperior", true));
            this.idadeSuperiorTextBox.Location = new System.Drawing.Point(185, 625);
            this.idadeSuperiorTextBox.Name = "idadeSuperiorTextBox";
            this.idadeSuperiorTextBox.Size = new System.Drawing.Size(100, 22);
            this.idadeSuperiorTextBox.TabIndex = 15;
            // 
            // tipoEventoTextBox
            // 
            this.tipoEventoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipoEventoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoSetBindingSource, "TipoEvento", true));
            this.tipoEventoTextBox.Location = new System.Drawing.Point(185, 693);
            this.tipoEventoTextBox.Name = "tipoEventoTextBox";
            this.tipoEventoTextBox.Size = new System.Drawing.Size(185, 22);
            this.tipoEventoTextBox.TabIndex = 17;
            // 
            // LBEventos
            // 
            this.LBEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBEventos.Location = new System.Drawing.Point(321, 70);
            this.LBEventos.Name = "LBEventos";
            this.LBEventos.Size = new System.Drawing.Size(429, 59);
            this.LBEventos.TabIndex = 24;
            this.LBEventos.Text = "Eventos";
            this.LBEventos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // eventoSetDataGridView
            // 
            this.eventoSetDataGridView.AutoGenerateColumns = false;
            this.eventoSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventoSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.eventoSetDataGridView.DataSource = this.eventoSetBindingSource;
            this.eventoSetDataGridView.Location = new System.Drawing.Point(558, 256);
            this.eventoSetDataGridView.Name = "eventoSetDataGridView";
            this.eventoSetDataGridView.RowHeadersWidth = 51;
            this.eventoSetDataGridView.RowTemplate.Height = 24;
            this.eventoSetDataGridView.Size = new System.Drawing.Size(434, 416);
            this.eventoSetDataGridView.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NrEvento";
            this.dataGridViewTextBoxColumn1.HeaderText = "NrEvento";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Local";
            this.dataGridViewTextBoxColumn3.HeaderText = "Local";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataHora";
            this.dataGridViewTextBoxColumn4.HeaderText = "DataHora";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LimiteParticipacao";
            this.dataGridViewTextBoxColumn5.HeaderText = "LimiteParticipacao";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdadeInferior";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdadeInferior";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdadeSuperior";
            this.dataGridViewTextBoxColumn7.HeaderText = "IdadeSuperior";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TipoEvento";
            this.dataGridViewTextBoxColumn8.HeaderText = "TipoEvento";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // FEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 790);
            this.Controls.Add(this.eventoSetDataGridView);
            this.Controls.Add(this.LBEventos);
            this.Controls.Add(tipoEventoLabel);
            this.Controls.Add(this.tipoEventoTextBox);
            this.Controls.Add(idadeSuperiorLabel);
            this.Controls.Add(this.idadeSuperiorTextBox);
            this.Controls.Add(idadeInferiorLabel);
            this.Controls.Add(this.idadeInferiorTextBox);
            this.Controls.Add(limiteParticipacaoLabel);
            this.Controls.Add(this.limiteParticipacaoTextBox);
            this.Controls.Add(dataHoraLabel);
            this.Controls.Add(this.dataHoraTextBox);
            this.Controls.Add(localLabel);
            this.Controls.Add(this.localTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(nrEventoLabel);
            this.Controls.Add(this.nrEventoTextBox);
            this.Controls.Add(this.eventoSetBindingNavigator);
            this.Name = "FEventos";
            this.Text = "FormEventos";
            this.Load += new System.EventHandler(this.FormEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoSetBindingNavigator)).EndInit();
            this.eventoSetBindingNavigator.ResumeLayout(false);
            this.eventoSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventoSetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BooKids_DBDataSet booKids_DBDataSet;
        private System.Windows.Forms.BindingSource eventoSetBindingSource;
        private BooKids_DBDataSetTableAdapters.EventoSetTableAdapter eventoSetTableAdapter;
        private BooKids_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.TextBox nrEventoTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox localTextBox;
        private System.Windows.Forms.TextBox dataHoraTextBox;
        private System.Windows.Forms.TextBox limiteParticipacaoTextBox;
        private System.Windows.Forms.TextBox idadeInferiorTextBox;
        private System.Windows.Forms.TextBox idadeSuperiorTextBox;
        private System.Windows.Forms.TextBox tipoEventoTextBox;
        private System.Windows.Forms.Label LBEventos;
        private System.Windows.Forms.DataGridView eventoSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}