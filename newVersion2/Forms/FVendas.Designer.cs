﻿
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
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.utilizouCartaoTextBox = new System.Windows.Forms.TextBox();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.nrCompraTextBox = new System.Windows.Forms.TextBox();
            this.detalheCompraSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalheCompraSetTableAdapter = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.DetalheCompraSetTableAdapter();
            this.detalheCompraSetDataGridView = new System.Windows.Forms.DataGridView();
            this.LBVendaProdutos = new System.Windows.Forms.Label();
            this.produtoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoSetTableAdapter = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.ProdutoSetTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataLabel = new System.Windows.Forms.Label();
            utilizouCartaoLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            nrCompraLabel = new System.Windows.Forms.Label();
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
            dataLabel.Location = new System.Drawing.Point(29, 320);
            dataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 2;
            dataLabel.Text = "Data:";
            // 
            // utilizouCartaoLabel
            // 
            utilizouCartaoLabel.AutoSize = true;
            utilizouCartaoLabel.Location = new System.Drawing.Point(29, 366);
            utilizouCartaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            utilizouCartaoLabel.Name = "utilizouCartaoLabel";
            utilizouCartaoLabel.Size = new System.Drawing.Size(78, 13);
            utilizouCartaoLabel.TabIndex = 4;
            utilizouCartaoLabel.Text = "Utilizou Cartão:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(29, 236);
            idClienteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(54, 13);
            idClienteLabel.TabIndex = 8;
            idClienteLabel.Text = "Id Cliente:";
            // 
            // nrCompraLabel
            // 
            nrCompraLabel.AutoSize = true;
            nrCompraLabel.Location = new System.Drawing.Point(29, 284);
            nrCompraLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nrCompraLabel.Name = "nrCompraLabel";
            nrCompraLabel.Size = new System.Drawing.Size(60, 13);
            nrCompraLabel.TabIndex = 10;
            nrCompraLabel.Text = "Nr Compra:";
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
            this.compraSetBindingNavigator.Size = new System.Drawing.Size(964, 27);
            this.compraSetBindingNavigator.TabIndex = 0;
            this.compraSetBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // compraSetBindingNavigatorSaveItem
            // 
            this.compraSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.compraSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("compraSetBindingNavigatorSaveItem.Image")));
            this.compraSetBindingNavigatorSaveItem.Name = "compraSetBindingNavigatorSaveItem";
            this.compraSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.compraSetBindingNavigatorSaveItem.Text = "Save Data";
            this.compraSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.CompraSetBindingNavigatorSaveItem_Click);
            // 
            // compraSetDataGridView
            // 
            this.compraSetDataGridView.AutoGenerateColumns = false;
            this.compraSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compraSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.compraSetDataGridView.DataSource = this.compraSetBindingSource;
            this.compraSetDataGridView.Location = new System.Drawing.Point(314, 185);
            this.compraSetDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.compraSetDataGridView.Name = "compraSetDataGridView";
            this.compraSetDataGridView.RowHeadersWidth = 51;
            this.compraSetDataGridView.RowTemplate.Height = 24;
            this.compraSetDataGridView.Size = new System.Drawing.Size(344, 225);
            this.compraSetDataGridView.TabIndex = 1;
            this.compraSetDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CompraSetDataGridView_CellContentClick);
            // 
            // dataTextBox
            // 
            this.dataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraSetBindingSource, "Data", true));
            this.dataTextBox.Location = new System.Drawing.Point(154, 320);
            this.dataTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(134, 20);
            this.dataTextBox.TabIndex = 3;
            // 
            // utilizouCartaoTextBox
            // 
            this.utilizouCartaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraSetBindingSource, "UtilizouCartao", true));
            this.utilizouCartaoTextBox.Location = new System.Drawing.Point(154, 363);
            this.utilizouCartaoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.utilizouCartaoTextBox.Name = "utilizouCartaoTextBox";
            this.utilizouCartaoTextBox.Size = new System.Drawing.Size(134, 20);
            this.utilizouCartaoTextBox.TabIndex = 5;
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraSetBindingSource, "IdCliente", true));
            this.idClienteTextBox.Location = new System.Drawing.Point(154, 233);
            this.idClienteTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(66, 20);
            this.idClienteTextBox.TabIndex = 9;
            // 
            // nrCompraTextBox
            // 
            this.nrCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraSetBindingSource, "NrCompra", true));
            this.nrCompraTextBox.Location = new System.Drawing.Point(154, 281);
            this.nrCompraTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nrCompraTextBox.Name = "nrCompraTextBox";
            this.nrCompraTextBox.Size = new System.Drawing.Size(134, 20);
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
            this.dataGridViewTextBoxColumn7});
            this.detalheCompraSetDataGridView.DataSource = this.detalheCompraSetBindingSource;
            this.detalheCompraSetDataGridView.Location = new System.Drawing.Point(703, 187);
            this.detalheCompraSetDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.detalheCompraSetDataGridView.Name = "detalheCompraSetDataGridView";
            this.detalheCompraSetDataGridView.RowHeadersWidth = 51;
            this.detalheCompraSetDataGridView.RowTemplate.Height = 24;
            this.detalheCompraSetDataGridView.Size = new System.Drawing.Size(230, 223);
            this.detalheCompraSetDataGridView.TabIndex = 12;
            // 
            // LBVendaProdutos
            // 
            this.LBVendaProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBVendaProdutos.Location = new System.Drawing.Point(269, 67);
            this.LBVendaProdutos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBVendaProdutos.Name = "LBVendaProdutos";
            this.LBVendaProdutos.Size = new System.Drawing.Size(322, 48);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UtilizouCartao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cartão";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdCliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id Cliente";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NrCompra";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nr. Compra";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn6.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NrCompra";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nr. Compra";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // FVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 449);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.TextBox utilizouCartaoTextBox;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.TextBox nrCompraTextBox;
        private System.Windows.Forms.BindingSource detalheCompraSetBindingSource;
        private BooKids_DBDataSetTableAdapters.DetalheCompraSetTableAdapter detalheCompraSetTableAdapter;
        private System.Windows.Forms.DataGridView detalheCompraSetDataGridView;
        private System.Windows.Forms.Label LBVendaProdutos;
        private System.Windows.Forms.BindingSource produtoSetBindingSource;
        private BooKids_DBDataSetTableAdapters.ProdutoSetTableAdapter produtoSetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}