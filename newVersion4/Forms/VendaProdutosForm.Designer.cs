
namespace Projeto_DA_BooKids.Forms
{
    partial class VendaProdutosForm
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
            System.Windows.Forms.Label idPessoaLabel;
            System.Windows.Forms.Label nrCompraLabel;
            System.Windows.Forms.Label produtosCodProdutoLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label utilizouCartaoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendaProdutosForm));
            this.booKids_DataSet = new Projeto_DA_BooKids.BooKids_DataSet();
            this.compraSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraSetTableAdapter = new Projeto_DA_BooKids.BooKids_DataSetTableAdapters.CompraSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_BooKids.BooKids_DataSetTableAdapters.TableAdapterManager();
            this.detalheCompraSetTableAdapter = new Projeto_DA_BooKids.BooKids_DataSetTableAdapters.DetalheCompraSetTableAdapter();
            this.compraSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.compraSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.compraSetDataGridView = new System.Windows.Forms.DataGridView();
            this.detalheCompraSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalheCompraSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPessoaTextBox = new System.Windows.Forms.TextBox();
            this.nrCompraTextBox = new System.Windows.Forms.TextBox();
            this.produtosCodProdutoTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.utilizouCartaoCheckBox = new System.Windows.Forms.CheckBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.lbVendaProdutos = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            idPessoaLabel = new System.Windows.Forms.Label();
            nrCompraLabel = new System.Windows.Forms.Label();
            produtosCodProdutoLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            utilizouCartaoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraSetBindingNavigator)).BeginInit();
            this.compraSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compraSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheCompraSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheCompraSetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idPessoaLabel
            // 
            idPessoaLabel.AutoSize = true;
            idPessoaLabel.Location = new System.Drawing.Point(95, 205);
            idPessoaLabel.Name = "idPessoaLabel";
            idPessoaLabel.Size = new System.Drawing.Size(74, 17);
            idPessoaLabel.TabIndex = 3;
            idPessoaLabel.Text = "Id Pessoa:";
            // 
            // nrCompraLabel
            // 
            nrCompraLabel.AutoSize = true;
            nrCompraLabel.Location = new System.Drawing.Point(95, 243);
            nrCompraLabel.Name = "nrCompraLabel";
            nrCompraLabel.Size = new System.Drawing.Size(80, 17);
            nrCompraLabel.TabIndex = 5;
            nrCompraLabel.Text = "Nr Compra:";
            // 
            // produtosCodProdutoLabel
            // 
            produtosCodProdutoLabel.AutoSize = true;
            produtosCodProdutoLabel.Location = new System.Drawing.Point(95, 334);
            produtosCodProdutoLabel.Name = "produtosCodProdutoLabel";
            produtosCodProdutoLabel.Size = new System.Drawing.Size(152, 17);
            produtosCodProdutoLabel.TabIndex = 7;
            produtosCodProdutoLabel.Text = "Produtos Cod Produto:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(95, 384);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(42, 17);
            dataLabel.TabIndex = 9;
            dataLabel.Text = "Data:";
            // 
            // utilizouCartaoLabel
            // 
            utilizouCartaoLabel.AutoSize = true;
            utilizouCartaoLabel.Location = new System.Drawing.Point(95, 430);
            utilizouCartaoLabel.Name = "utilizouCartaoLabel";
            utilizouCartaoLabel.Size = new System.Drawing.Size(104, 17);
            utilizouCartaoLabel.TabIndex = 11;
            utilizouCartaoLabel.Text = "Utilizou Cartao:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(95, 288);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(86, 17);
            quantidadeLabel.TabIndex = 13;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // booKids_DataSet
            // 
            this.booKids_DataSet.DataSetName = "BooKids_DataSet";
            this.booKids_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compraSetBindingSource
            // 
            this.compraSetBindingSource.DataMember = "CompraSet";
            this.compraSetBindingSource.DataSource = this.booKids_DataSet;
            // 
            // compraSetTableAdapter
            // 
            this.compraSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColaboracaoSetTableAdapter = null;
            this.tableAdapterManager.CompraSetTableAdapter = this.compraSetTableAdapter;
            this.tableAdapterManager.DetalheCompraSetTableAdapter = this.detalheCompraSetTableAdapter;
            this.tableAdapterManager.EscolaSetTableAdapter = null;
            this.tableAdapterManager.EventoSetTableAdapter = null;
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
            // detalheCompraSetTableAdapter
            // 
            this.detalheCompraSetTableAdapter.ClearBeforeFill = true;
            // 
            // compraSetBindingNavigator
            // 
            this.compraSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.compraSetBindingNavigator.BindingSource = this.compraSetBindingSource;
            this.compraSetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.compraSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.compraSetBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.compraSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.compraSetBindingNavigatorSaveItem});
            this.compraSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.compraSetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.compraSetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.compraSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.compraSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.compraSetBindingNavigator.Name = "compraSetBindingNavigator";
            this.compraSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.compraSetBindingNavigator.Size = new System.Drawing.Size(750, 27);
            this.compraSetBindingNavigator.TabIndex = 0;
            this.compraSetBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
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
            // compraSetBindingNavigatorSaveItem
            // 
            this.compraSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.compraSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("compraSetBindingNavigatorSaveItem.Image")));
            this.compraSetBindingNavigatorSaveItem.Name = "compraSetBindingNavigatorSaveItem";
            this.compraSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.compraSetBindingNavigatorSaveItem.Text = "Save Data";
            this.compraSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.compraSetBindingNavigatorSaveItem_Click);
            // 
            // compraSetDataGridView
            // 
            this.compraSetDataGridView.AllowUserToAddRows = false;
            this.compraSetDataGridView.AllowUserToDeleteRows = false;
            this.compraSetDataGridView.AutoGenerateColumns = false;
            this.compraSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compraSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.compraSetDataGridView.DataSource = this.compraSetBindingSource;
            this.compraSetDataGridView.Location = new System.Drawing.Point(91, 688);
            this.compraSetDataGridView.Name = "compraSetDataGridView";
            this.compraSetDataGridView.ReadOnly = true;
            this.compraSetDataGridView.RowHeadersWidth = 51;
            this.compraSetDataGridView.RowTemplate.Height = 24;
            this.compraSetDataGridView.Size = new System.Drawing.Size(561, 171);
            this.compraSetDataGridView.TabIndex = 1;
            // 
            // detalheCompraSetBindingSource
            // 
            this.detalheCompraSetBindingSource.DataMember = "FK_DetalheCompraCompra";
            this.detalheCompraSetBindingSource.DataSource = this.compraSetBindingSource;
            // 
            // detalheCompraSetDataGridView
            // 
            this.detalheCompraSetDataGridView.AllowUserToAddRows = false;
            this.detalheCompraSetDataGridView.AllowUserToDeleteRows = false;
            this.detalheCompraSetDataGridView.AutoGenerateColumns = false;
            this.detalheCompraSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalheCompraSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.detalheCompraSetDataGridView.DataSource = this.detalheCompraSetBindingSource;
            this.detalheCompraSetDataGridView.Location = new System.Drawing.Point(91, 476);
            this.detalheCompraSetDataGridView.Name = "detalheCompraSetDataGridView";
            this.detalheCompraSetDataGridView.ReadOnly = true;
            this.detalheCompraSetDataGridView.RowHeadersWidth = 51;
            this.detalheCompraSetDataGridView.RowTemplate.Height = 24;
            this.detalheCompraSetDataGridView.Size = new System.Drawing.Size(561, 175);
            this.detalheCompraSetDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NrCompra";
            this.dataGridViewTextBoxColumn6.HeaderText = "NrCompra";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ProdutoCodProduto";
            this.dataGridViewTextBoxColumn7.HeaderText = "ProdutoCodProduto";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // idPessoaTextBox
            // 
            this.idPessoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraSetBindingSource, "IdPessoa", true));
            this.idPessoaTextBox.Location = new System.Drawing.Point(197, 200);
            this.idPessoaTextBox.Name = "idPessoaTextBox";
            this.idPessoaTextBox.Size = new System.Drawing.Size(100, 22);
            this.idPessoaTextBox.TabIndex = 4;
            // 
            // nrCompraTextBox
            // 
            this.nrCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraSetBindingSource, "NrCompra", true));
            this.nrCompraTextBox.Location = new System.Drawing.Point(197, 240);
            this.nrCompraTextBox.Name = "nrCompraTextBox";
            this.nrCompraTextBox.Size = new System.Drawing.Size(100, 22);
            this.nrCompraTextBox.TabIndex = 6;
            // 
            // produtosCodProdutoTextBox
            // 
            this.produtosCodProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraSetBindingSource, "ProdutosCodProduto", true));
            this.produtosCodProdutoTextBox.Location = new System.Drawing.Point(260, 329);
            this.produtosCodProdutoTextBox.Name = "produtosCodProdutoTextBox";
            this.produtosCodProdutoTextBox.Size = new System.Drawing.Size(100, 22);
            this.produtosCodProdutoTextBox.TabIndex = 8;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.compraSetBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(150, 379);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(210, 22);
            this.dataDateTimePicker.TabIndex = 10;
            // 
            // utilizouCartaoCheckBox
            // 
            this.utilizouCartaoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.compraSetBindingSource, "UtilizouCartao", true));
            this.utilizouCartaoCheckBox.Location = new System.Drawing.Point(205, 427);
            this.utilizouCartaoCheckBox.Name = "utilizouCartaoCheckBox";
            this.utilizouCartaoCheckBox.Size = new System.Drawing.Size(110, 28);
            this.utilizouCartaoCheckBox.TabIndex = 12;
            this.utilizouCartaoCheckBox.Text = "checkBox1";
            this.utilizouCartaoCheckBox.UseVisualStyleBackColor = true;
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalheCompraSetBindingSource, "Quantidade", true));
            this.quantidadeTextBox.Location = new System.Drawing.Point(197, 283);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(100, 22);
            this.quantidadeTextBox.TabIndex = 14;
            // 
            // lbVendaProdutos
            // 
            this.lbVendaProdutos.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVendaProdutos.Location = new System.Drawing.Point(0, 68);
            this.lbVendaProdutos.Name = "lbVendaProdutos";
            this.lbVendaProdutos.Size = new System.Drawing.Size(748, 71);
            this.lbVendaProdutos.TabIndex = 15;
            this.lbVendaProdutos.Text = "Venda de Produtos";
            this.lbVendaProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdPessoa";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdPessoa";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NrCompra";
            this.dataGridViewTextBoxColumn3.HeaderText = "NrCompra";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProdutosCodProduto";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProdutosCodProduto";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "UtilizouCartao";
            this.dataGridViewCheckBoxColumn1.HeaderText = "UtilizouCartao";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // VendaProdutosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 904);
            this.Controls.Add(this.lbVendaProdutos);
            this.Controls.Add(quantidadeLabel);
            this.Controls.Add(this.quantidadeTextBox);
            this.Controls.Add(utilizouCartaoLabel);
            this.Controls.Add(this.utilizouCartaoCheckBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(produtosCodProdutoLabel);
            this.Controls.Add(this.produtosCodProdutoTextBox);
            this.Controls.Add(nrCompraLabel);
            this.Controls.Add(this.nrCompraTextBox);
            this.Controls.Add(idPessoaLabel);
            this.Controls.Add(this.idPessoaTextBox);
            this.Controls.Add(this.compraSetBindingNavigator);
            this.Controls.Add(this.detalheCompraSetDataGridView);
            this.Controls.Add(this.compraSetDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VendaProdutosForm";
            this.Text = "VendaProdutosForm";
            this.Load += new System.EventHandler(this.VendaProdutosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraSetBindingNavigator)).EndInit();
            this.compraSetBindingNavigator.ResumeLayout(false);
            this.compraSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compraSetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheCompraSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheCompraSetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BooKids_DataSet booKids_DataSet;
        private System.Windows.Forms.BindingSource compraSetBindingSource;
        private BooKids_DataSetTableAdapters.CompraSetTableAdapter compraSetTableAdapter;
        private BooKids_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator compraSetBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton compraSetBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView compraSetDataGridView;
        private BooKids_DataSetTableAdapters.DetalheCompraSetTableAdapter detalheCompraSetTableAdapter;
        private System.Windows.Forms.BindingSource detalheCompraSetBindingSource;
        private System.Windows.Forms.DataGridView detalheCompraSetDataGridView;
        private System.Windows.Forms.TextBox idPessoaTextBox;
        private System.Windows.Forms.TextBox nrCompraTextBox;
        private System.Windows.Forms.TextBox produtosCodProdutoTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.CheckBox utilizouCartaoCheckBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.Label lbVendaProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}