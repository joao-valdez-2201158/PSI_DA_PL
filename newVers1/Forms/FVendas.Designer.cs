
namespace Projeto_DA_BooKids.Forms
{
    partial class FVendas
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
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label utilizouCartaoLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label nrCompraLabel;
            System.Windows.Forms.Label produtosCodPromocaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FVendas));
            this.booKids_DBDataSet = new Projeto_DA_BooKids.BooKids_DBDataSet();
            this.compraSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraSetTableAdapter = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.CompraSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager();
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.utilizouCartaoTextBox = new System.Windows.Forms.TextBox();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.nrCompraTextBox = new System.Windows.Forms.TextBox();
            this.detalheCompraSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalheCompraSetTableAdapter = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.DetalheCompraSetTableAdapter();
            this.detalheCompraSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBVendaProdutos = new System.Windows.Forms.Label();
            this.produtoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoSetTableAdapter = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.ProdutoSetTableAdapter();
            this.produtosCodPromocaoTextBox = new System.Windows.Forms.TextBox();
            dataLabel = new System.Windows.Forms.Label();
            utilizouCartaoLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            nrCompraLabel = new System.Windows.Forms.Label();
            produtosCodPromocaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraSetBindingNavigator)).BeginInit();
            this.compraSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compraSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheCompraSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheCompraSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(32, 361);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(42, 17);
            dataLabel.TabIndex = 2;
            dataLabel.Text = "Data:";
            // 
            // utilizouCartaoLabel
            // 
            utilizouCartaoLabel.AutoSize = true;
            utilizouCartaoLabel.Location = new System.Drawing.Point(32, 480);
            utilizouCartaoLabel.Name = "utilizouCartaoLabel";
            utilizouCartaoLabel.Size = new System.Drawing.Size(104, 17);
            utilizouCartaoLabel.TabIndex = 4;
            utilizouCartaoLabel.Text = "Utilizou Cartao:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(32, 259);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(70, 17);
            idClienteLabel.TabIndex = 8;
            idClienteLabel.Text = "Id Cliente:";
            // 
            // nrCompraLabel
            // 
            nrCompraLabel.AutoSize = true;
            nrCompraLabel.Location = new System.Drawing.Point(32, 316);
            nrCompraLabel.Name = "nrCompraLabel";
            nrCompraLabel.Size = new System.Drawing.Size(80, 17);
            nrCompraLabel.TabIndex = 10;
            nrCompraLabel.Text = "Nr Compra:";
            // 
            // produtosCodPromocaoLabel
            // 
            produtosCodPromocaoLabel.AutoSize = true;
            produtosCodPromocaoLabel.Location = new System.Drawing.Point(32, 423);
            produtosCodPromocaoLabel.Name = "produtosCodPromocaoLabel";
            produtosCodPromocaoLabel.Size = new System.Drawing.Size(166, 17);
            produtosCodPromocaoLabel.TabIndex = 24;
            produtosCodPromocaoLabel.Text = "Produtos Cod Promocao:";
            // 
            // booKids_DBDataSet
            // 
            this.booKids_DBDataSet.DataSetName = "BooKids_DBDataSet";
            this.booKids_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColaboracaoSetTableAdapter = null;
            this.tableAdapterManager.CompraSetTableAdapter = this.compraSetTableAdapter;
            this.tableAdapterManager.DetalheCompraSetTableAdapter = null;
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
            this.tableAdapterManager.UpdateOrder = Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.compraSetBindingNavigator.Size = new System.Drawing.Size(1148, 31);
            this.compraSetBindingNavigator.TabIndex = 0;
            this.compraSetBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // compraSetBindingNavigatorSaveItem
            // 
            this.compraSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.compraSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("compraSetBindingNavigatorSaveItem.Image")));
            this.compraSetBindingNavigatorSaveItem.Name = "compraSetBindingNavigatorSaveItem";
            this.compraSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.compraSetBindingNavigatorSaveItem.Text = "Save Data";
            this.compraSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.compraSetBindingNavigatorSaveItem_Click);
            // 
            // compraSetDataGridView
            // 
            this.compraSetDataGridView.AutoGenerateColumns = false;
            this.compraSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compraSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.compraSetDataGridView.DataSource = this.compraSetBindingSource;
            this.compraSetDataGridView.Location = new System.Drawing.Point(482, 228);
            this.compraSetDataGridView.Name = "compraSetDataGridView";
            this.compraSetDataGridView.RowHeadersWidth = 51;
            this.compraSetDataGridView.RowTemplate.Height = 24;
            this.compraSetDataGridView.Size = new System.Drawing.Size(306, 277);
            this.compraSetDataGridView.TabIndex = 1;
            this.compraSetDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.compraSetDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UtilizouCartao";
            this.dataGridViewTextBoxColumn2.HeaderText = "UtilizouCartao";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdCliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdCliente";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProdutosCodPromocao";
            this.dataGridViewTextBoxColumn4.HeaderText = "ProdutosCodPromocao";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NrCompra";
            this.dataGridViewTextBoxColumn5.HeaderText = "NrCompra";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataTextBox
            // 
            this.dataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraSetBindingSource, "Data", true));
            this.dataTextBox.Location = new System.Drawing.Point(270, 361);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(178, 22);
            this.dataTextBox.TabIndex = 3;
            // 
            // utilizouCartaoTextBox
            // 
            this.utilizouCartaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraSetBindingSource, "UtilizouCartao", true));
            this.utilizouCartaoTextBox.Location = new System.Drawing.Point(270, 480);
            this.utilizouCartaoTextBox.Name = "utilizouCartaoTextBox";
            this.utilizouCartaoTextBox.Size = new System.Drawing.Size(178, 22);
            this.utilizouCartaoTextBox.TabIndex = 5;
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraSetBindingSource, "IdCliente", true));
            this.idClienteTextBox.Location = new System.Drawing.Point(270, 259);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(178, 22);
            this.idClienteTextBox.TabIndex = 9;
            // 
            // nrCompraTextBox
            // 
            this.nrCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraSetBindingSource, "NrCompra", true));
            this.nrCompraTextBox.Location = new System.Drawing.Point(270, 316);
            this.nrCompraTextBox.Name = "nrCompraTextBox";
            this.nrCompraTextBox.Size = new System.Drawing.Size(178, 22);
            this.nrCompraTextBox.TabIndex = 11;
            // 
            // detalheCompraSetBindingSource
            // 
            this.detalheCompraSetBindingSource.DataMember = "DetalheCompraSet";
            this.detalheCompraSetBindingSource.DataSource = this.booKids_DBDataSet;
            // 
            // detalheCompraSetTableAdapter
            // 
            this.detalheCompraSetTableAdapter.ClearBeforeFill = true;
            // 
            // detalheCompraSetDataGridView
            // 
            this.detalheCompraSetDataGridView.AutoGenerateColumns = false;
            this.detalheCompraSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalheCompraSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.detalheCompraSetDataGridView.DataSource = this.detalheCompraSetBindingSource;
            this.detalheCompraSetDataGridView.Location = new System.Drawing.Point(817, 228);
            this.detalheCompraSetDataGridView.Name = "detalheCompraSetDataGridView";
            this.detalheCompraSetDataGridView.RowHeadersWidth = 51;
            this.detalheCompraSetDataGridView.RowTemplate.Height = 24;
            this.detalheCompraSetDataGridView.Size = new System.Drawing.Size(306, 274);
            this.detalheCompraSetDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn6.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NrCompra";
            this.dataGridViewTextBoxColumn7.HeaderText = "NrCompra";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ProdutoCodProduto";
            this.dataGridViewTextBoxColumn8.HeaderText = "ProdutoCodProduto";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // LBVendaProdutos
            // 
            this.LBVendaProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBVendaProdutos.Location = new System.Drawing.Point(359, 83);
            this.LBVendaProdutos.Name = "LBVendaProdutos";
            this.LBVendaProdutos.Size = new System.Drawing.Size(429, 59);
            this.LBVendaProdutos.TabIndex = 24;
            this.LBVendaProdutos.Text = "Venda de Produtos";
            this.LBVendaProdutos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // produtoSetBindingSource
            // 
            this.produtoSetBindingSource.DataMember = "ProdutoSet";
            this.produtoSetBindingSource.DataSource = this.booKids_DBDataSet;
            // 
            // produtoSetTableAdapter
            // 
            this.produtoSetTableAdapter.ClearBeforeFill = true;
            // 
            // produtosCodPromocaoTextBox
            // 
            this.produtosCodPromocaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.produtosCodPromocaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraSetBindingSource, "ProdutosCodPromocao", true));
            this.produtosCodPromocaoTextBox.Location = new System.Drawing.Point(270, 423);
            this.produtosCodPromocaoTextBox.Name = "produtosCodPromocaoTextBox";
            this.produtosCodPromocaoTextBox.Size = new System.Drawing.Size(178, 22);
            this.produtosCodPromocaoTextBox.TabIndex = 25;
            // 
            // FVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 536);
            this.Controls.Add(produtosCodPromocaoLabel);
            this.Controls.Add(this.produtosCodPromocaoTextBox);
            this.Controls.Add(this.LBVendaProdutos);
            this.Controls.Add(this.detalheCompraSetDataGridView);
            this.Controls.Add(nrCompraLabel);
            this.Controls.Add(this.nrCompraTextBox);
            this.Controls.Add(idClienteLabel);
            this.Controls.Add(this.idClienteTextBox);
            this.Controls.Add(utilizouCartaoLabel);
            this.Controls.Add(this.utilizouCartaoTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.compraSetDataGridView);
            this.Controls.Add(this.compraSetBindingNavigator);
            this.Name = "FVendas";
            this.Text = "Form Vendas";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraSetBindingNavigator)).EndInit();
            this.compraSetBindingNavigator.ResumeLayout(false);
            this.compraSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compraSetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheCompraSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheCompraSetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BooKids_DBDataSet booKids_DBDataSet;
        private System.Windows.Forms.BindingSource compraSetBindingSource;
        private BooKids_DBDataSetTableAdapters.CompraSetTableAdapter compraSetTableAdapter;
        private BooKids_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.TextBox utilizouCartaoTextBox;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.TextBox nrCompraTextBox;
        private System.Windows.Forms.BindingSource detalheCompraSetBindingSource;
        private BooKids_DBDataSetTableAdapters.DetalheCompraSetTableAdapter detalheCompraSetTableAdapter;
        private System.Windows.Forms.DataGridView detalheCompraSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label LBVendaProdutos;
        private System.Windows.Forms.BindingSource produtoSetBindingSource;
        private BooKids_DBDataSetTableAdapters.ProdutoSetTableAdapter produtoSetTableAdapter;
        private System.Windows.Forms.TextBox produtosCodPromocaoTextBox;
    }
}