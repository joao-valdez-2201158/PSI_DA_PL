
namespace Projeto_DA_BooKids.Forms
{
    partial class DetalhesCompraForm
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
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label compraNrCompraLabel;
            System.Windows.Forms.Label produtoCodProdutoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalhesCompraForm));
            this.booKids_DBDataSet = new Projeto_DA_BooKids.BooKids_DBDataSet();
            this.detalheCompraSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalheCompraSetTableAdapter = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.DetalheCompraSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager();
            this.detalheCompraSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.detalheCompraSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.detalheCompraSetDataGridView = new System.Windows.Forms.DataGridView();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.compraNrCompraTextBox = new System.Windows.Forms.TextBox();
            this.produtoCodProdutoTextBox = new System.Windows.Forms.TextBox();
            this.lbVendaProdutos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            quantidadeLabel = new System.Windows.Forms.Label();
            compraNrCompraLabel = new System.Windows.Forms.Label();
            produtoCodProdutoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheCompraSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheCompraSetBindingNavigator)).BeginInit();
            this.detalheCompraSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalheCompraSetDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(83, 41);
            quantidadeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(86, 17);
            quantidadeLabel.TabIndex = 2;
            quantidadeLabel.Text = "Quantidade:";
            quantidadeLabel.Click += new System.EventHandler(this.quantidadeLabel_Click);
            // 
            // compraNrCompraLabel
            // 
            compraNrCompraLabel.AutoSize = true;
            compraNrCompraLabel.Location = new System.Drawing.Point(37, 73);
            compraNrCompraLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            compraNrCompraLabel.Name = "compraNrCompraLabel";
            compraNrCompraLabel.Size = new System.Drawing.Size(133, 17);
            compraNrCompraLabel.TabIndex = 4;
            compraNrCompraLabel.Text = "Compra Nr Compra:";
            compraNrCompraLabel.Click += new System.EventHandler(this.compraNrCompraLabel_Click);
            // 
            // produtoCodProdutoLabel
            // 
            produtoCodProdutoLabel.AutoSize = true;
            produtoCodProdutoLabel.Location = new System.Drawing.Point(24, 105);
            produtoCodProdutoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            produtoCodProdutoLabel.Name = "produtoCodProdutoLabel";
            produtoCodProdutoLabel.Size = new System.Drawing.Size(145, 17);
            produtoCodProdutoLabel.TabIndex = 6;
            produtoCodProdutoLabel.Text = "Produto Cod Produto:";
            produtoCodProdutoLabel.Click += new System.EventHandler(this.produtoCodProdutoLabel_Click);
            // 
            // booKids_DBDataSet
            // 
            this.booKids_DBDataSet.DataSetName = "BooKids_DBDataSet";
            this.booKids_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColaboracaoSetTableAdapter = null;
            this.tableAdapterManager.CompraSetTableAdapter = null;
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
            this.tableAdapterManager.UpdateOrder = Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // detalheCompraSetBindingNavigator
            // 
            this.detalheCompraSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.detalheCompraSetBindingNavigator.BindingSource = this.detalheCompraSetBindingSource;
            this.detalheCompraSetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.detalheCompraSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.detalheCompraSetBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.detalheCompraSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.detalheCompraSetBindingNavigatorSaveItem});
            this.detalheCompraSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.detalheCompraSetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.detalheCompraSetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.detalheCompraSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.detalheCompraSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.detalheCompraSetBindingNavigator.Name = "detalheCompraSetBindingNavigator";
            this.detalheCompraSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.detalheCompraSetBindingNavigator.Size = new System.Drawing.Size(496, 27);
            this.detalheCompraSetBindingNavigator.TabIndex = 0;
            this.detalheCompraSetBindingNavigator.Text = "bindingNavigator1";
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
            // detalheCompraSetBindingNavigatorSaveItem
            // 
            this.detalheCompraSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.detalheCompraSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("detalheCompraSetBindingNavigatorSaveItem.Image")));
            this.detalheCompraSetBindingNavigatorSaveItem.Name = "detalheCompraSetBindingNavigatorSaveItem";
            this.detalheCompraSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.detalheCompraSetBindingNavigatorSaveItem.Text = "Save Data";
            this.detalheCompraSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.detalheCompraSetBindingNavigatorSaveItem_Click);
            // 
            // detalheCompraSetDataGridView
            // 
            this.detalheCompraSetDataGridView.AllowUserToAddRows = false;
            this.detalheCompraSetDataGridView.AllowUserToDeleteRows = false;
            this.detalheCompraSetDataGridView.AutoGenerateColumns = false;
            this.detalheCompraSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalheCompraSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.detalheCompraSetDataGridView.DataSource = this.detalheCompraSetBindingSource;
            this.detalheCompraSetDataGridView.Location = new System.Drawing.Point(16, 268);
            this.detalheCompraSetDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detalheCompraSetDataGridView.Name = "detalheCompraSetDataGridView";
            this.detalheCompraSetDataGridView.ReadOnly = true;
            this.detalheCompraSetDataGridView.RowHeadersWidth = 51;
            this.detalheCompraSetDataGridView.Size = new System.Drawing.Size(456, 271);
            this.detalheCompraSetDataGridView.TabIndex = 1;
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalheCompraSetBindingSource, "Quantidade", true));
            this.quantidadeTextBox.Location = new System.Drawing.Point(191, 37);
            this.quantidadeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(132, 22);
            this.quantidadeTextBox.TabIndex = 3;
            this.quantidadeTextBox.TextChanged += new System.EventHandler(this.quantidadeTextBox_TextChanged);
            // 
            // compraNrCompraTextBox
            // 
            this.compraNrCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalheCompraSetBindingSource, "CompraNrCompra", true));
            this.compraNrCompraTextBox.Location = new System.Drawing.Point(191, 69);
            this.compraNrCompraTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.compraNrCompraTextBox.Name = "compraNrCompraTextBox";
            this.compraNrCompraTextBox.Size = new System.Drawing.Size(132, 22);
            this.compraNrCompraTextBox.TabIndex = 5;
            this.compraNrCompraTextBox.TextChanged += new System.EventHandler(this.compraNrCompraTextBox_TextChanged);
            // 
            // produtoCodProdutoTextBox
            // 
            this.produtoCodProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalheCompraSetBindingSource, "ProdutoCodProduto", true));
            this.produtoCodProdutoTextBox.Location = new System.Drawing.Point(191, 101);
            this.produtoCodProdutoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.produtoCodProdutoTextBox.Name = "produtoCodProdutoTextBox";
            this.produtoCodProdutoTextBox.Size = new System.Drawing.Size(132, 22);
            this.produtoCodProdutoTextBox.TabIndex = 7;
            this.produtoCodProdutoTextBox.TextChanged += new System.EventHandler(this.produtoCodProdutoTextBox_TextChanged);
            // 
            // lbVendaProdutos
            // 
            this.lbVendaProdutos.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVendaProdutos.Location = new System.Drawing.Point(15, 50);
            this.lbVendaProdutos.Name = "lbVendaProdutos";
            this.lbVendaProdutos.Size = new System.Drawing.Size(463, 62);
            this.lbVendaProdutos.TabIndex = 10;
            this.lbVendaProdutos.Text = "Compra Detalhada";
            this.lbVendaProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quantidadeTextBox);
            this.groupBox1.Controls.Add(produtoCodProdutoLabel);
            this.groupBox1.Controls.Add(quantidadeLabel);
            this.groupBox1.Controls.Add(this.produtoCodProdutoTextBox);
            this.groupBox1.Controls.Add(this.compraNrCompraTextBox);
            this.groupBox1.Controls.Add(compraNrCompraLabel);
            this.groupBox1.Location = new System.Drawing.Point(16, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(359, 145);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir Detalhe da Compra";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CompraNrCompra";
            this.dataGridViewTextBoxColumn2.HeaderText = "CompraNrCompra";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProdutoCodProduto";
            this.dataGridViewTextBoxColumn3.HeaderText = "ProdutoCodProduto";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // DetalhesCompraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 564);
            this.Controls.Add(this.lbVendaProdutos);
            this.Controls.Add(this.detalheCompraSetDataGridView);
            this.Controls.Add(this.detalheCompraSetBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DetalhesCompraForm";
            this.Text = "DetalhesCompra";
            this.Load += new System.EventHandler(this.DetalhesCompraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheCompraSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheCompraSetBindingNavigator)).EndInit();
            this.detalheCompraSetBindingNavigator.ResumeLayout(false);
            this.detalheCompraSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalheCompraSetDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BooKids_DBDataSet booKids_DBDataSet;
        private System.Windows.Forms.BindingSource detalheCompraSetBindingSource;
        private BooKids_DBDataSetTableAdapters.DetalheCompraSetTableAdapter detalheCompraSetTableAdapter;
        private BooKids_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator detalheCompraSetBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton detalheCompraSetBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView detalheCompraSetDataGridView;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.TextBox compraNrCompraTextBox;
        private System.Windows.Forms.TextBox produtoCodProdutoTextBox;
        private System.Windows.Forms.Label lbVendaProdutos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}