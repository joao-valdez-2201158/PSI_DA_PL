
namespace Projeto_DA_BooKids
{
    partial class EscolasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EscolasForm));
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label moradaLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label codPostalLabel;
            System.Windows.Forms.Label localidadeLabel;
            this.booKids_DataSet = new Projeto_DA_BooKids.BooKids_DataSet();
            this.participacaoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.participacaoSetTableAdapter = new Projeto_DA_BooKids.BooKids_DataSetTableAdapters.ParticipacaoSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_BooKids.BooKids_DataSetTableAdapters.TableAdapterManager();
            this.participacaoSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.participacaoSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pessoaSet_FilhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaSet_FilhoTableAdapter = new Projeto_DA_BooKids.BooKids_DataSetTableAdapters.PessoaSet_FilhoTableAdapter();
            this.escolaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.escolaSetTableAdapter = new Projeto_DA_BooKids.BooKids_DataSetTableAdapters.EscolaSetTableAdapter();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.moradaTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.codPostalTextBox = new System.Windows.Forms.TextBox();
            this.localidadeTextBox = new System.Windows.Forms.TextBox();
            this.escolaSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            moradaLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            codPostalLabel = new System.Windows.Forms.Label();
            localidadeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participacaoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participacaoSetBindingNavigator)).BeginInit();
            this.participacaoSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_FilhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolaSetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // booKids_DataSet
            // 
            this.booKids_DataSet.DataSetName = "BooKids_DataSet";
            this.booKids_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // participacaoSetBindingSource
            // 
            this.participacaoSetBindingSource.DataMember = "ParticipacaoSet";
            this.participacaoSetBindingSource.DataSource = this.booKids_DataSet;
            // 
            // participacaoSetTableAdapter
            // 
            this.participacaoSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColaboracaoSetTableAdapter = null;
            this.tableAdapterManager.CompraSetTableAdapter = null;
            this.tableAdapterManager.DetalheCompraSetTableAdapter = null;
            this.tableAdapterManager.EscolaSetTableAdapter = this.escolaSetTableAdapter;
            this.tableAdapterManager.EventoSetTableAdapter = null;
            this.tableAdapterManager.InscricaoSetTableAdapter = null;
            this.tableAdapterManager.ParticipacaoSetTableAdapter = this.participacaoSetTableAdapter;
            this.tableAdapterManager.PessoaSet_AnimadorTableAdapter = null;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_FilhoTableAdapter = this.pessoaSet_FilhoTableAdapter;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.ProdutoSetTableAdapter = null;
            this.tableAdapterManager.TipoProdutoSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_BooKids.BooKids_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // participacaoSetBindingNavigator
            // 
            this.participacaoSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.participacaoSetBindingNavigator.BindingSource = this.participacaoSetBindingSource;
            this.participacaoSetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.participacaoSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.participacaoSetBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.participacaoSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.participacaoSetBindingNavigatorSaveItem});
            this.participacaoSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.participacaoSetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.participacaoSetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.participacaoSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.participacaoSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.participacaoSetBindingNavigator.Name = "participacaoSetBindingNavigator";
            this.participacaoSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.participacaoSetBindingNavigator.Size = new System.Drawing.Size(1168, 27);
            this.participacaoSetBindingNavigator.TabIndex = 0;
            this.participacaoSetBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // participacaoSetBindingNavigatorSaveItem
            // 
            this.participacaoSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.participacaoSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("participacaoSetBindingNavigatorSaveItem.Image")));
            this.participacaoSetBindingNavigatorSaveItem.Name = "participacaoSetBindingNavigatorSaveItem";
            this.participacaoSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.participacaoSetBindingNavigatorSaveItem.Text = "Save Data";
            this.participacaoSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.participacaoSetBindingNavigatorSaveItem_Click);
            // 
            // pessoaSet_FilhoBindingSource
            // 
            this.pessoaSet_FilhoBindingSource.DataMember = "PessoaSet_Filho";
            this.pessoaSet_FilhoBindingSource.DataSource = this.booKids_DataSet;
            // 
            // pessoaSet_FilhoTableAdapter
            // 
            this.pessoaSet_FilhoTableAdapter.ClearBeforeFill = true;
            // 
            // escolaSetBindingSource
            // 
            this.escolaSetBindingSource.DataMember = "EscolaSet";
            this.escolaSetBindingSource.DataSource = this.booKids_DataSet;
            // 
            // escolaSetTableAdapter
            // 
            this.escolaSetTableAdapter.ClearBeforeFill = true;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(38, 244);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(49, 17);
            nomeLabel.TabIndex = 5;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaSetBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(159, 239);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(237, 22);
            this.nomeTextBox.TabIndex = 6;
            // 
            // moradaLabel
            // 
            moradaLabel.AutoSize = true;
            moradaLabel.Location = new System.Drawing.Point(37, 307);
            moradaLabel.Name = "moradaLabel";
            moradaLabel.Size = new System.Drawing.Size(60, 17);
            moradaLabel.TabIndex = 7;
            moradaLabel.Text = "Morada:";
            // 
            // moradaTextBox
            // 
            this.moradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaSetBindingSource, "Morada", true));
            this.moradaTextBox.Location = new System.Drawing.Point(159, 302);
            this.moradaTextBox.Name = "moradaTextBox";
            this.moradaTextBox.Size = new System.Drawing.Size(237, 22);
            this.moradaTextBox.TabIndex = 8;
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(37, 370);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(68, 17);
            telefoneLabel.TabIndex = 9;
            telefoneLabel.Text = "Telefone:";
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaSetBindingSource, "Telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(159, 365);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(128, 22);
            this.telefoneTextBox.TabIndex = 10;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(38, 437);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaSetBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(159, 432);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(237, 22);
            this.emailTextBox.TabIndex = 12;
            // 
            // codPostalLabel
            // 
            codPostalLabel.AutoSize = true;
            codPostalLabel.Location = new System.Drawing.Point(38, 505);
            codPostalLabel.Name = "codPostalLabel";
            codPostalLabel.Size = new System.Drawing.Size(80, 17);
            codPostalLabel.TabIndex = 13;
            codPostalLabel.Text = "Cod Postal:";
            // 
            // codPostalTextBox
            // 
            this.codPostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaSetBindingSource, "CodPostal", true));
            this.codPostalTextBox.Location = new System.Drawing.Point(159, 500);
            this.codPostalTextBox.Name = "codPostalTextBox";
            this.codPostalTextBox.Size = new System.Drawing.Size(128, 22);
            this.codPostalTextBox.TabIndex = 14;
            // 
            // localidadeLabel
            // 
            localidadeLabel.AutoSize = true;
            localidadeLabel.Location = new System.Drawing.Point(37, 571);
            localidadeLabel.Name = "localidadeLabel";
            localidadeLabel.Size = new System.Drawing.Size(81, 17);
            localidadeLabel.TabIndex = 15;
            localidadeLabel.Text = "Localidade:";
            // 
            // localidadeTextBox
            // 
            this.localidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaSetBindingSource, "Localidade", true));
            this.localidadeTextBox.Location = new System.Drawing.Point(159, 566);
            this.localidadeTextBox.Name = "localidadeTextBox";
            this.localidadeTextBox.Size = new System.Drawing.Size(128, 22);
            this.localidadeTextBox.TabIndex = 16;
            // 
            // escolaSetDataGridView
            // 
            this.escolaSetDataGridView.AllowUserToAddRows = false;
            this.escolaSetDataGridView.AllowUserToDeleteRows = false;
            this.escolaSetDataGridView.AutoGenerateColumns = false;
            this.escolaSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.escolaSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.escolaSetDataGridView.DataSource = this.escolaSetBindingSource;
            this.escolaSetDataGridView.Location = new System.Drawing.Point(434, 195);
            this.escolaSetDataGridView.Name = "escolaSetDataGridView";
            this.escolaSetDataGridView.ReadOnly = true;
            this.escolaSetDataGridView.RowHeadersWidth = 51;
            this.escolaSetDataGridView.RowTemplate.Height = 24;
            this.escolaSetDataGridView.Size = new System.Drawing.Size(676, 427);
            this.escolaSetDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdEscola";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdEscola";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Morada";
            this.dataGridViewTextBoxColumn3.HeaderText = "Morada";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CodPostal";
            this.dataGridViewTextBoxColumn6.HeaderText = "CodPostal";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Localidade";
            this.dataGridViewTextBoxColumn7.HeaderText = "Localidade";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1168, 66);
            this.label1.TabIndex = 17;
            this.label1.Text = "Escolas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EscolasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 688);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.escolaSetDataGridView);
            this.Controls.Add(localidadeLabel);
            this.Controls.Add(this.localidadeTextBox);
            this.Controls.Add(codPostalLabel);
            this.Controls.Add(this.codPostalTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(moradaLabel);
            this.Controls.Add(this.moradaTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.participacaoSetBindingNavigator);
            this.Name = "EscolasForm";
            this.Text = "EscolasForm";
            this.Load += new System.EventHandler(this.EscolasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participacaoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participacaoSetBindingNavigator)).EndInit();
            this.participacaoSetBindingNavigator.ResumeLayout(false);
            this.participacaoSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_FilhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolaSetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BooKids_DataSet booKids_DataSet;
        private System.Windows.Forms.BindingSource participacaoSetBindingSource;
        private BooKids_DataSetTableAdapters.ParticipacaoSetTableAdapter participacaoSetTableAdapter;
        private BooKids_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator participacaoSetBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton participacaoSetBindingNavigatorSaveItem;
        private BooKids_DataSetTableAdapters.PessoaSet_FilhoTableAdapter pessoaSet_FilhoTableAdapter;
        private System.Windows.Forms.BindingSource pessoaSet_FilhoBindingSource;
        private BooKids_DataSetTableAdapters.EscolaSetTableAdapter escolaSetTableAdapter;
        private System.Windows.Forms.BindingSource escolaSetBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox moradaTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox codPostalTextBox;
        private System.Windows.Forms.TextBox localidadeTextBox;
        private System.Windows.Forms.DataGridView escolaSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label1;
    }
}