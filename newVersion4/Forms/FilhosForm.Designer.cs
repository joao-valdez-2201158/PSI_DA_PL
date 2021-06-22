
namespace Projeto_DA_BooKids.Forms
{
    partial class FilhosForm
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
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label dataNascimentoLabel;
            System.Windows.Forms.Label idEscolaLabel;
            System.Windows.Forms.Label idProgenitorLabel;
            System.Windows.Forms.Label idPessoaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilhosForm));
            this.booKids_DataSet = new Projeto_DA_BooKids.BooKids_DataSet();
            this.pessoaSet_FilhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaSet_FilhoTableAdapter = new Projeto_DA_BooKids.BooKids_DataSetTableAdapters.PessoaSet_FilhoTableAdapter();
            this.tableAdapterManager = new Projeto_DA_BooKids.BooKids_DataSetTableAdapters.TableAdapterManager();
            this.pessoaSet_FilhoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pessoaSet_FilhoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pessoaSet_FilhoDataGridView = new System.Windows.Forms.DataGridView();
            this.sexoTextBox = new System.Windows.Forms.TextBox();
            this.dataNascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idEscolaTextBox = new System.Windows.Forms.TextBox();
            this.idProgenitorTextBox = new System.Windows.Forms.TextBox();
            this.idPessoaTextBox = new System.Windows.Forms.TextBox();
            this.lbFilhos = new System.Windows.Forms.Label();
            this.fKFilhoInscricaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inscricaoSetTableAdapter = new Projeto_DA_BooKids.BooKids_DataSetTableAdapters.InscricaoSetTableAdapter();
            this.idPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProgenitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEscolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            sexoLabel = new System.Windows.Forms.Label();
            dataNascimentoLabel = new System.Windows.Forms.Label();
            idEscolaLabel = new System.Windows.Forms.Label();
            idProgenitorLabel = new System.Windows.Forms.Label();
            idPessoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_FilhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_FilhoBindingNavigator)).BeginInit();
            this.pessoaSet_FilhoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_FilhoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilhoInscricaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filhoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(39, 193);
            sexoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(43, 17);
            sexoLabel.TabIndex = 2;
            sexoLabel.Text = "Sexo:";
            // 
            // dataNascimentoLabel
            // 
            dataNascimentoLabel.AutoSize = true;
            dataNascimentoLabel.Location = new System.Drawing.Point(39, 225);
            dataNascimentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataNascimentoLabel.Name = "dataNascimentoLabel";
            dataNascimentoLabel.Size = new System.Drawing.Size(120, 17);
            dataNascimentoLabel.TabIndex = 4;
            dataNascimentoLabel.Text = "Data Nascimento:";
            // 
            // idEscolaLabel
            // 
            idEscolaLabel.AutoSize = true;
            idEscolaLabel.Location = new System.Drawing.Point(39, 257);
            idEscolaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idEscolaLabel.Name = "idEscolaLabel";
            idEscolaLabel.Size = new System.Drawing.Size(69, 17);
            idEscolaLabel.TabIndex = 6;
            idEscolaLabel.Text = "Id Escola:";
            // 
            // idProgenitorLabel
            // 
            idProgenitorLabel.AutoSize = true;
            idProgenitorLabel.Location = new System.Drawing.Point(39, 289);
            idProgenitorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idProgenitorLabel.Name = "idProgenitorLabel";
            idProgenitorLabel.Size = new System.Drawing.Size(93, 17);
            idProgenitorLabel.TabIndex = 8;
            idProgenitorLabel.Text = "Id Progenitor:";
            // 
            // idPessoaLabel
            // 
            idPessoaLabel.AutoSize = true;
            idPessoaLabel.Location = new System.Drawing.Point(39, 321);
            idPessoaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idPessoaLabel.Name = "idPessoaLabel";
            idPessoaLabel.Size = new System.Drawing.Size(74, 17);
            idPessoaLabel.TabIndex = 10;
            idPessoaLabel.Text = "Id Pessoa:";
            // 
            // booKids_DataSet
            // 
            this.booKids_DataSet.DataSetName = "BooKids_DataSet";
            this.booKids_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColaboracaoSetTableAdapter = null;
            this.tableAdapterManager.CompraSetTableAdapter = null;
            this.tableAdapterManager.DetalheCompraSetTableAdapter = null;
            this.tableAdapterManager.EscolaSetTableAdapter = null;
            this.tableAdapterManager.EventoSetTableAdapter = null;
            this.tableAdapterManager.InscricaoSetTableAdapter = null;
            this.tableAdapterManager.ParticipacaoSetTableAdapter = null;
            this.tableAdapterManager.PessoaSet_AnimadorTableAdapter = null;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_FilhoTableAdapter = this.pessoaSet_FilhoTableAdapter;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.ProdutoSetTableAdapter = null;
            this.tableAdapterManager.TipoProdutoSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_BooKids.BooKids_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pessoaSet_FilhoBindingNavigator
            // 
            this.pessoaSet_FilhoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pessoaSet_FilhoBindingNavigator.BindingSource = this.pessoaSet_FilhoBindingSource;
            this.pessoaSet_FilhoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pessoaSet_FilhoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pessoaSet_FilhoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pessoaSet_FilhoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pessoaSet_FilhoBindingNavigatorSaveItem});
            this.pessoaSet_FilhoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pessoaSet_FilhoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pessoaSet_FilhoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pessoaSet_FilhoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pessoaSet_FilhoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pessoaSet_FilhoBindingNavigator.Name = "pessoaSet_FilhoBindingNavigator";
            this.pessoaSet_FilhoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pessoaSet_FilhoBindingNavigator.Size = new System.Drawing.Size(755, 27);
            this.pessoaSet_FilhoBindingNavigator.TabIndex = 0;
            this.pessoaSet_FilhoBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
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
            // pessoaSet_FilhoBindingNavigatorSaveItem
            // 
            this.pessoaSet_FilhoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pessoaSet_FilhoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pessoaSet_FilhoBindingNavigatorSaveItem.Image")));
            this.pessoaSet_FilhoBindingNavigatorSaveItem.Name = "pessoaSet_FilhoBindingNavigatorSaveItem";
            this.pessoaSet_FilhoBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.pessoaSet_FilhoBindingNavigatorSaveItem.Text = "Save Data";
            this.pessoaSet_FilhoBindingNavigatorSaveItem.Click += new System.EventHandler(this.pessoaSet_FilhoBindingNavigatorSaveItem_Click);
            // 
            // pessoaSet_FilhoDataGridView
            // 
            this.pessoaSet_FilhoDataGridView.AutoGenerateColumns = false;
            this.pessoaSet_FilhoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pessoaSet_FilhoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPessoaDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.idProgenitorDataGridViewTextBoxColumn,
            this.idEscolaDataGridViewTextBoxColumn});
            this.pessoaSet_FilhoDataGridView.DataSource = this.filhoBindingSource;
            this.pessoaSet_FilhoDataGridView.Location = new System.Drawing.Point(30, 386);
            this.pessoaSet_FilhoDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pessoaSet_FilhoDataGridView.Name = "pessoaSet_FilhoDataGridView";
            this.pessoaSet_FilhoDataGridView.RowHeadersWidth = 51;
            this.pessoaSet_FilhoDataGridView.Size = new System.Drawing.Size(670, 287);
            this.pessoaSet_FilhoDataGridView.TabIndex = 1;
            // 
            // sexoTextBox
            // 
            this.sexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_FilhoBindingSource, "Sexo", true));
            this.sexoTextBox.Location = new System.Drawing.Point(169, 188);
            this.sexoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sexoTextBox.Name = "sexoTextBox";
            this.sexoTextBox.Size = new System.Drawing.Size(86, 22);
            this.sexoTextBox.TabIndex = 3;
            // 
            // dataNascimentoDateTimePicker
            // 
            this.dataNascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pessoaSet_FilhoBindingSource, "DataNascimento", true));
            this.dataNascimentoDateTimePicker.Location = new System.Drawing.Point(169, 220);
            this.dataNascimentoDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataNascimentoDateTimePicker.Name = "dataNascimentoDateTimePicker";
            this.dataNascimentoDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.dataNascimentoDateTimePicker.TabIndex = 5;
            // 
            // idEscolaTextBox
            // 
            this.idEscolaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_FilhoBindingSource, "IdEscola", true));
            this.idEscolaTextBox.Location = new System.Drawing.Point(169, 252);
            this.idEscolaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idEscolaTextBox.Name = "idEscolaTextBox";
            this.idEscolaTextBox.Size = new System.Drawing.Size(86, 22);
            this.idEscolaTextBox.TabIndex = 7;
            // 
            // idProgenitorTextBox
            // 
            this.idProgenitorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_FilhoBindingSource, "IdProgenitor", true));
            this.idProgenitorTextBox.Location = new System.Drawing.Point(169, 284);
            this.idProgenitorTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idProgenitorTextBox.Name = "idProgenitorTextBox";
            this.idProgenitorTextBox.Size = new System.Drawing.Size(86, 22);
            this.idProgenitorTextBox.TabIndex = 9;
            // 
            // idPessoaTextBox
            // 
            this.idPessoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_FilhoBindingSource, "IdPessoa", true));
            this.idPessoaTextBox.Location = new System.Drawing.Point(169, 316);
            this.idPessoaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idPessoaTextBox.Name = "idPessoaTextBox";
            this.idPessoaTextBox.Size = new System.Drawing.Size(86, 22);
            this.idPessoaTextBox.TabIndex = 11;
            // 
            // lbFilhos
            // 
            this.lbFilhos.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilhos.Location = new System.Drawing.Point(-8, 73);
            this.lbFilhos.Name = "lbFilhos";
            this.lbFilhos.Size = new System.Drawing.Size(780, 66);
            this.lbFilhos.TabIndex = 17;
            this.lbFilhos.Text = "Filhos";
            this.lbFilhos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fKFilhoInscricaoBindingSource
            // 
            this.fKFilhoInscricaoBindingSource.DataMember = "FK_FilhoInscricao";
            this.fKFilhoInscricaoBindingSource.DataSource = this.pessoaSet_FilhoBindingSource;
            // 
            // inscricaoSetTableAdapter
            // 
            this.inscricaoSetTableAdapter.ClearBeforeFill = true;
            // 
            // idPessoaDataGridViewTextBoxColumn
            // 
            this.idPessoaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idPessoaDataGridViewTextBoxColumn.DataPropertyName = "IdPessoa";
            this.idPessoaDataGridViewTextBoxColumn.HeaderText = "IdPessoa";
            this.idPessoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPessoaDataGridViewTextBoxColumn.Name = "idPessoaDataGridViewTextBoxColumn";
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            // 
            // idProgenitorDataGridViewTextBoxColumn
            // 
            this.idProgenitorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idProgenitorDataGridViewTextBoxColumn.DataPropertyName = "IdProgenitor";
            this.idProgenitorDataGridViewTextBoxColumn.HeaderText = "IdProgenitor";
            this.idProgenitorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProgenitorDataGridViewTextBoxColumn.Name = "idProgenitorDataGridViewTextBoxColumn";
            // 
            // idEscolaDataGridViewTextBoxColumn
            // 
            this.idEscolaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idEscolaDataGridViewTextBoxColumn.DataPropertyName = "IdEscola";
            this.idEscolaDataGridViewTextBoxColumn.HeaderText = "IdEscola";
            this.idEscolaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idEscolaDataGridViewTextBoxColumn.Name = "idEscolaDataGridViewTextBoxColumn";
            // 
            // filhoBindingSource
            // 
            this.filhoBindingSource.DataSource = typeof(Projeto_DA_BooKids.Filho);
            // 
            // FilhosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 723);
            this.Controls.Add(this.lbFilhos);
            this.Controls.Add(idPessoaLabel);
            this.Controls.Add(this.idPessoaTextBox);
            this.Controls.Add(idProgenitorLabel);
            this.Controls.Add(this.idProgenitorTextBox);
            this.Controls.Add(idEscolaLabel);
            this.Controls.Add(this.idEscolaTextBox);
            this.Controls.Add(dataNascimentoLabel);
            this.Controls.Add(this.dataNascimentoDateTimePicker);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoTextBox);
            this.Controls.Add(this.pessoaSet_FilhoDataGridView);
            this.Controls.Add(this.pessoaSet_FilhoBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FilhosForm";
            this.Text = "FilhosForm";
            this.Load += new System.EventHandler(this.FilhosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_FilhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_FilhoBindingNavigator)).EndInit();
            this.pessoaSet_FilhoBindingNavigator.ResumeLayout(false);
            this.pessoaSet_FilhoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_FilhoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilhoInscricaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filhoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BooKids_DataSet booKids_DataSet;
        private System.Windows.Forms.BindingSource pessoaSet_FilhoBindingSource;
        private BooKids_DataSetTableAdapters.PessoaSet_FilhoTableAdapter pessoaSet_FilhoTableAdapter;
        private BooKids_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pessoaSet_FilhoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pessoaSet_FilhoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pessoaSet_FilhoDataGridView;
        private System.Windows.Forms.TextBox sexoTextBox;
        private System.Windows.Forms.DateTimePicker dataNascimentoDateTimePicker;
        private System.Windows.Forms.TextBox idEscolaTextBox;
        private System.Windows.Forms.TextBox idProgenitorTextBox;
        private System.Windows.Forms.TextBox idPessoaTextBox;
        private System.Windows.Forms.Label lbFilhos;
        private System.Windows.Forms.BindingSource fKFilhoInscricaoBindingSource;
        private BooKids_DataSetTableAdapters.InscricaoSetTableAdapter inscricaoSetTableAdapter;
        private System.Windows.Forms.BindingSource filhoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProgenitorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEscolaDataGridViewTextBoxColumn;
    }
}