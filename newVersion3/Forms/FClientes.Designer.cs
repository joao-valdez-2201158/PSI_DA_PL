
namespace Projeto_DA_BooKids.Forms
{
    partial class FClientes
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label moradaLabel;
            System.Windows.Forms.Label localidadeLabel;
            System.Windows.Forms.Label codPostalLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label telemovelLabel;
            System.Windows.Forms.Label mailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FClientes));
            this.booKids_DBDataSet = new Projeto_DA_BooKids.BooKids_DBDataSet();
            this.pessoaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaSetTableAdapter = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.PessoaSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager();
            this.pessoaSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pessoaSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.clientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.moradaTextBox = new System.Windows.Forms.TextBox();
            this.localidadeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.LBClientes = new System.Windows.Forms.Label();
            this.compraSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraSetTableAdapter = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.CompraSetTableAdapter();
            this.codPostalTextBox = new System.Windows.Forms.TextBox();
            this.telemovelTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            nomeLabel = new System.Windows.Forms.Label();
            moradaLabel = new System.Windows.Forms.Label();
            localidadeLabel = new System.Windows.Forms.Label();
            codPostalLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            telemovelLabel = new System.Windows.Forms.Label();
            mailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingNavigator)).BeginInit();
            this.pessoaSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(26, 174);
            nomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            nomeLabel.Click += new System.EventHandler(this.nomeLabel_Click);
            // 
            // moradaLabel
            // 
            moradaLabel.AutoSize = true;
            moradaLabel.Location = new System.Drawing.Point(26, 217);
            moradaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            moradaLabel.Name = "moradaLabel";
            moradaLabel.Size = new System.Drawing.Size(46, 13);
            moradaLabel.TabIndex = 4;
            moradaLabel.Text = "Morada:";
            // 
            // localidadeLabel
            // 
            localidadeLabel.AutoSize = true;
            localidadeLabel.Location = new System.Drawing.Point(26, 260);
            localidadeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            localidadeLabel.Name = "localidadeLabel";
            localidadeLabel.Size = new System.Drawing.Size(62, 13);
            localidadeLabel.TabIndex = 6;
            localidadeLabel.Text = "Localidade:";
            // 
            // codPostalLabel
            // 
            codPostalLabel.AutoSize = true;
            codPostalLabel.Location = new System.Drawing.Point(208, 260);
            codPostalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            codPostalLabel.Name = "codPostalLabel";
            codPostalLabel.Size = new System.Drawing.Size(61, 13);
            codPostalLabel.TabIndex = 8;
            codPostalLabel.Text = "Cod Postal:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(26, 303);
            telefoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 10;
            telefoneLabel.Text = "Telefone:";
            // 
            // telemovelLabel
            // 
            telemovelLabel.AutoSize = true;
            telemovelLabel.Location = new System.Drawing.Point(208, 303);
            telemovelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            telemovelLabel.Name = "telemovelLabel";
            telemovelLabel.Size = new System.Drawing.Size(59, 13);
            telemovelLabel.TabIndex = 12;
            telemovelLabel.Text = "Telemóvel:";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new System.Drawing.Point(26, 346);
            mailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new System.Drawing.Size(39, 13);
            mailLabel.TabIndex = 14;
            mailLabel.Text = "E-Mail:";
            mailLabel.Click += new System.EventHandler(this.mailLabel_Click);
            // 
            // booKids_DBDataSet
            // 
            this.booKids_DBDataSet.DataSetName = "BooKids_DBDataSet";
            this.booKids_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoaSetBindingSource
            // 
            this.pessoaSetBindingSource.DataMember = "PessoaSet";
            this.pessoaSetBindingSource.DataSource = this.booKids_DBDataSet;
            // 
            // pessoaSetTableAdapter
            // 
            this.pessoaSetTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PessoaSet_FilhoTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = this.pessoaSetTableAdapter;
            this.tableAdapterManager.ProdutoSetTableAdapter = null;
            this.tableAdapterManager.TipoProdutoSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pessoaSetBindingNavigator
            // 
            this.pessoaSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pessoaSetBindingNavigator.BindingSource = this.pessoaSetBindingSource;
            this.pessoaSetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pessoaSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pessoaSetBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pessoaSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pessoaSetBindingNavigatorSaveItem});
            this.pessoaSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pessoaSetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pessoaSetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pessoaSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pessoaSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pessoaSetBindingNavigator.Name = "pessoaSetBindingNavigator";
            this.pessoaSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pessoaSetBindingNavigator.Size = new System.Drawing.Size(957, 27);
            this.pessoaSetBindingNavigator.TabIndex = 0;
            this.pessoaSetBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.BindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // pessoaSetBindingNavigatorSaveItem
            // 
            this.pessoaSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pessoaSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pessoaSetBindingNavigatorSaveItem.Image")));
            this.pessoaSetBindingNavigatorSaveItem.Name = "pessoaSetBindingNavigatorSaveItem";
            this.pessoaSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.pessoaSetBindingNavigatorSaveItem.Text = "Save Data";
            this.pessoaSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.PessoaSetBindingNavigatorSaveItem_Click);
            // 
            // clientes
            // 
            this.clientes.AutoGenerateColumns = false;
            this.clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.clientes.DataSource = this.pessoaSetBindingSource;
            this.clientes.Location = new System.Drawing.Point(412, 137);
            this.clientes.Margin = new System.Windows.Forms.Padding(2);
            this.clientes.Name = "clientes";
            this.clientes.RowHeadersWidth = 51;
            this.clientes.RowTemplate.Height = 24;
            this.clientes.Size = new System.Drawing.Size(518, 267);
            this.clientes.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Morada";
            this.dataGridViewTextBoxColumn3.HeaderText = "Morada";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Localidade";
            this.dataGridViewTextBoxColumn4.HeaderText = "Localidade";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CodPostal";
            this.dataGridViewTextBoxColumn5.HeaderText = "Código Postal";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSetBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(106, 172);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(269, 20);
            this.nomeTextBox.TabIndex = 3;
            // 
            // moradaTextBox
            // 
            this.moradaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSetBindingSource, "Morada", true));
            this.moradaTextBox.Location = new System.Drawing.Point(106, 215);
            this.moradaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.moradaTextBox.Name = "moradaTextBox";
            this.moradaTextBox.Size = new System.Drawing.Size(267, 20);
            this.moradaTextBox.TabIndex = 5;
            // 
            // localidadeTextBox
            // 
            this.localidadeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.localidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSetBindingSource, "Localidade", true));
            this.localidadeTextBox.Location = new System.Drawing.Point(106, 258);
            this.localidadeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.localidadeTextBox.Name = "localidadeTextBox";
            this.localidadeTextBox.Size = new System.Drawing.Size(89, 20);
            this.localidadeTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSetBindingSource, "Mail", true));
            this.emailTextBox.Location = new System.Drawing.Point(106, 344);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(267, 20);
            this.emailTextBox.TabIndex = 15;
            // 
            // LBClientes
            // 
            this.LBClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBClientes.Location = new System.Drawing.Point(0, 59);
            this.LBClientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBClientes.Name = "LBClientes";
            this.LBClientes.Size = new System.Drawing.Size(957, 48);
            this.LBClientes.TabIndex = 24;
            this.LBClientes.Text = "Clientes";
            this.LBClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // compraSetBindingSource
            // 
            this.compraSetBindingSource.DataMember = "CompraSet";
            this.compraSetBindingSource.DataSource = this.booKids_DBDataSet;
            // 
            // compraSetTableAdapter
            // 
            this.compraSetTableAdapter.ClearBeforeFill = true;
            // 
            // codPostalTextBox
            // 
            this.codPostalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codPostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSetBindingSource, "CodPostal", true));
            this.codPostalTextBox.Location = new System.Drawing.Point(284, 258);
            this.codPostalTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.codPostalTextBox.Name = "codPostalTextBox";
            this.codPostalTextBox.Size = new System.Drawing.Size(89, 20);
            this.codPostalTextBox.TabIndex = 25;
            // 
            // telemovelTextBox
            // 
            this.telemovelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telemovelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSetBindingSource, "Telemovel", true));
            this.telemovelTextBox.Location = new System.Drawing.Point(284, 301);
            this.telemovelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.telemovelTextBox.Name = "telemovelTextBox";
            this.telemovelTextBox.Size = new System.Drawing.Size(89, 20);
            this.telemovelTextBox.TabIndex = 26;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSetBindingSource, "Telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(106, 301);
            this.telefoneTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(87, 20);
            this.telefoneTextBox.TabIndex = 27;
            // 
            // FClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 430);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.telemovelTextBox);
            this.Controls.Add(this.codPostalTextBox);
            this.Controls.Add(this.LBClientes);
            this.Controls.Add(mailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(telemovelLabel);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(codPostalLabel);
            this.Controls.Add(localidadeLabel);
            this.Controls.Add(this.localidadeTextBox);
            this.Controls.Add(moradaLabel);
            this.Controls.Add(this.moradaTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.clientes);
            this.Controls.Add(this.pessoaSetBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Pessoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingNavigator)).EndInit();
            this.pessoaSetBindingNavigator.ResumeLayout(false);
            this.pessoaSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BooKids_DBDataSet booKids_DBDataSet;
        private System.Windows.Forms.BindingSource pessoaSetBindingSource;
        private BooKids_DBDataSetTableAdapters.PessoaSetTableAdapter pessoaSetTableAdapter;
        private BooKids_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pessoaSetBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pessoaSetBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView clientes;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox moradaTextBox;
        private System.Windows.Forms.TextBox localidadeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label LBClientes;
        private System.Windows.Forms.BindingSource compraSetBindingSource;
        private BooKids_DBDataSetTableAdapters.CompraSetTableAdapter compraSetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox codPostalTextBox;
        private System.Windows.Forms.TextBox telemovelTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
    }
}