
namespace Projeto_DA_BooKids.Forms
{
    partial class CompraProdutosForm
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
            System.Windows.Forms.Label produtosCodProdutoLabel;
            System.Windows.Forms.Label nrCompraLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompraProdutosForm));
            this.lbVendaProdutos = new System.Windows.Forms.Label();
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
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.utilizouCartaoCheckBox = new System.Windows.Forms.CheckBox();
            this.produtosCodProdutoTextBox = new System.Windows.Forms.TextBox();
            this.nrCompraTextBox = new System.Windows.Forms.TextBox();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_InserirDetalheCompra = new System.Windows.Forms.Button();
            dataLabel = new System.Windows.Forms.Label();
            utilizouCartaoLabel = new System.Windows.Forms.Label();
            produtosCodProdutoLabel = new System.Windows.Forms.Label();
            nrCompraLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraSetBindingNavigator)).BeginInit();
            this.compraSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compraSetDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(96, 40);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 9;
            dataLabel.Text = "Data:";
            // 
            // utilizouCartaoLabel
            // 
            utilizouCartaoLabel.AutoSize = true;
            utilizouCartaoLabel.Location = new System.Drawing.Point(51, 65);
            utilizouCartaoLabel.Name = "utilizouCartaoLabel";
            utilizouCartaoLabel.Size = new System.Drawing.Size(78, 13);
            utilizouCartaoLabel.TabIndex = 10;
            utilizouCartaoLabel.Text = "Utilizou Cartao:";
            // 
            // produtosCodProdutoLabel
            // 
            produtosCodProdutoLabel.AutoSize = true;
            produtosCodProdutoLabel.Location = new System.Drawing.Point(17, 87);
            produtosCodProdutoLabel.Name = "produtosCodProdutoLabel";
            produtosCodProdutoLabel.Size = new System.Drawing.Size(114, 13);
            produtosCodProdutoLabel.TabIndex = 11;
            produtosCodProdutoLabel.Text = "Produtos Cod Produto:";
            // 
            // nrCompraLabel
            // 
            nrCompraLabel.AutoSize = true;
            nrCompraLabel.Location = new System.Drawing.Point(69, 113);
            nrCompraLabel.Name = "nrCompraLabel";
            nrCompraLabel.Size = new System.Drawing.Size(60, 13);
            nrCompraLabel.TabIndex = 12;
            nrCompraLabel.Text = "Nr Compra:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(75, 139);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(54, 13);
            idClienteLabel.TabIndex = 13;
            idClienteLabel.Text = "Id Cliente:";
            // 
            // lbVendaProdutos
            // 
            this.lbVendaProdutos.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVendaProdutos.Location = new System.Drawing.Point(11, 48);
            this.lbVendaProdutos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVendaProdutos.Name = "lbVendaProdutos";
            this.lbVendaProdutos.Size = new System.Drawing.Size(550, 50);
            this.lbVendaProdutos.TabIndex = 8;
            this.lbVendaProdutos.Text = "Compra";
            this.lbVendaProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.compraSetBindingNavigator.Size = new System.Drawing.Size(587, 25);
            this.compraSetBindingNavigator.TabIndex = 9;
            this.compraSetBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // compraSetBindingNavigatorSaveItem
            // 
            this.compraSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.compraSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("compraSetBindingNavigatorSaveItem.Image")));
            this.compraSetBindingNavigatorSaveItem.Name = "compraSetBindingNavigatorSaveItem";
            this.compraSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.compraSetBindingNavigatorSaveItem.Text = "Save Data";
            this.compraSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.compraSetBindingNavigatorSaveItem_Click);
            // 
            // compraSetDataGridView
            // 
            this.compraSetDataGridView.AutoGenerateColumns = false;
            this.compraSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compraSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.compraSetDataGridView.DataSource = this.compraSetBindingSource;
            this.compraSetDataGridView.Location = new System.Drawing.Point(18, 321);
            this.compraSetDataGridView.Name = "compraSetDataGridView";
            this.compraSetDataGridView.Size = new System.Drawing.Size(543, 220);
            this.compraSetDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "UtilizouCartao";
            this.dataGridViewCheckBoxColumn1.HeaderText = "UtilizouCartao";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProdutosCodProduto";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProdutosCodProduto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NrCompra";
            this.dataGridViewTextBoxColumn3.HeaderText = "NrCompra";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdCliente";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdCliente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.compraSetBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(135, 34);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 10;
            // 
            // utilizouCartaoCheckBox
            // 
            this.utilizouCartaoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.compraSetBindingSource, "UtilizouCartao", true));
            this.utilizouCartaoCheckBox.Location = new System.Drawing.Point(135, 60);
            this.utilizouCartaoCheckBox.Name = "utilizouCartaoCheckBox";
            this.utilizouCartaoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.utilizouCartaoCheckBox.TabIndex = 11;
            this.utilizouCartaoCheckBox.UseVisualStyleBackColor = true;
            // 
            // produtosCodProdutoTextBox
            // 
            this.produtosCodProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraSetBindingSource, "ProdutosCodProduto", true));
            this.produtosCodProdutoTextBox.Location = new System.Drawing.Point(135, 84);
            this.produtosCodProdutoTextBox.Name = "produtosCodProdutoTextBox";
            this.produtosCodProdutoTextBox.Size = new System.Drawing.Size(100, 20);
            this.produtosCodProdutoTextBox.TabIndex = 12;
            // 
            // nrCompraTextBox
            // 
            this.nrCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraSetBindingSource, "NrCompra", true));
            this.nrCompraTextBox.Location = new System.Drawing.Point(135, 110);
            this.nrCompraTextBox.Name = "nrCompraTextBox";
            this.nrCompraTextBox.Size = new System.Drawing.Size(100, 20);
            this.nrCompraTextBox.TabIndex = 13;
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraSetBindingSource, "IdCliente", true));
            this.idClienteTextBox.Location = new System.Drawing.Point(135, 136);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.idClienteTextBox.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idClienteLabel);
            this.groupBox1.Controls.Add(this.idClienteTextBox);
            this.groupBox1.Controls.Add(this.dataDateTimePicker);
            this.groupBox1.Controls.Add(nrCompraLabel);
            this.groupBox1.Controls.Add(dataLabel);
            this.groupBox1.Controls.Add(this.nrCompraTextBox);
            this.groupBox1.Controls.Add(this.utilizouCartaoCheckBox);
            this.groupBox1.Controls.Add(produtosCodProdutoLabel);
            this.groupBox1.Controls.Add(utilizouCartaoLabel);
            this.groupBox1.Controls.Add(this.produtosCodProdutoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(18, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 173);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir Compra";
            // 
            // BTN_InserirDetalheCompra
            // 
            this.BTN_InserirDetalheCompra.Location = new System.Drawing.Point(411, 212);
            this.BTN_InserirDetalheCompra.Name = "BTN_InserirDetalheCompra";
            this.BTN_InserirDetalheCompra.Size = new System.Drawing.Size(150, 47);
            this.BTN_InserirDetalheCompra.TabIndex = 17;
            this.BTN_InserirDetalheCompra.Text = "Inserir Detalhe de compra";
            this.BTN_InserirDetalheCompra.UseVisualStyleBackColor = true;
            this.BTN_InserirDetalheCompra.Click += new System.EventHandler(this.BTN_InserirDetalheCompra_Click);
            // 
            // CompraProdutosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 556);
            this.Controls.Add(this.BTN_InserirDetalheCompra);
            this.Controls.Add(this.compraSetDataGridView);
            this.Controls.Add(this.compraSetBindingNavigator);
            this.Controls.Add(this.lbVendaProdutos);
            this.Controls.Add(this.groupBox1);
            this.Name = "CompraProdutosForm";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.VendaProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraSetBindingNavigator)).EndInit();
            this.compraSetBindingNavigator.ResumeLayout(false);
            this.compraSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compraSetDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbVendaProdutos;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.CheckBox utilizouCartaoCheckBox;
        private System.Windows.Forms.TextBox produtosCodProdutoTextBox;
        private System.Windows.Forms.TextBox nrCompraTextBox;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_InserirDetalheCompra;
    }
}