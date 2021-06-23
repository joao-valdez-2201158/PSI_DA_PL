
namespace Projeto_DA_BooKids.Forms
{
    partial class ProdutosVendidosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutosVendidosForm));
            System.Windows.Forms.Label designacaoLabel;
            System.Windows.Forms.Label precoLabel;
            System.Windows.Forms.Label stockExistenteLabel;
            System.Windows.Forms.Label codTipoProdutoLabel;
            this.lbProdutosVendidos = new System.Windows.Forms.Label();
            this.booKids_DBDataSet = new Projeto_DA_BooKids.BooKids_DBDataSet();
            this.produtoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoSetTableAdapter = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.ProdutoSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager();
            this.produtoSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.produtoSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.produtoSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designacaoTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.stockExistenteTextBox = new System.Windows.Forms.TextBox();
            this.codTipoProdutoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_InserirTipoProduto = new System.Windows.Forms.Button();
            designacaoLabel = new System.Windows.Forms.Label();
            precoLabel = new System.Windows.Forms.Label();
            stockExistenteLabel = new System.Windows.Forms.Label();
            codTipoProdutoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoSetBindingNavigator)).BeginInit();
            this.produtoSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoSetDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProdutosVendidos
            // 
            this.lbProdutosVendidos.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProdutosVendidos.Location = new System.Drawing.Point(11, 49);
            this.lbProdutosVendidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProdutosVendidos.Name = "lbProdutosVendidos";
            this.lbProdutosVendidos.Size = new System.Drawing.Size(544, 50);
            this.lbProdutosVendidos.TabIndex = 8;
            this.lbProdutosVendidos.Text = "Produtos Vendidos da Loja";
            this.lbProdutosVendidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // booKids_DBDataSet
            // 
            this.booKids_DBDataSet.DataSetName = "BooKids_DBDataSet";
            this.booKids_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.ProdutoSetTableAdapter = this.produtoSetTableAdapter;
            this.tableAdapterManager.TipoProdutoSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produtoSetBindingNavigator
            // 
            this.produtoSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.produtoSetBindingNavigator.BindingSource = this.produtoSetBindingSource;
            this.produtoSetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produtoSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produtoSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.produtoSetBindingNavigatorSaveItem});
            this.produtoSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produtoSetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produtoSetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produtoSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produtoSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produtoSetBindingNavigator.Name = "produtoSetBindingNavigator";
            this.produtoSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produtoSetBindingNavigator.Size = new System.Drawing.Size(575, 25);
            this.produtoSetBindingNavigator.TabIndex = 9;
            this.produtoSetBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // produtoSetBindingNavigatorSaveItem
            // 
            this.produtoSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produtoSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produtoSetBindingNavigatorSaveItem.Image")));
            this.produtoSetBindingNavigatorSaveItem.Name = "produtoSetBindingNavigatorSaveItem";
            this.produtoSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.produtoSetBindingNavigatorSaveItem.Text = "Save Data";
            this.produtoSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.produtoSetBindingNavigatorSaveItem_Click);
            // 
            // produtoSetDataGridView
            // 
            this.produtoSetDataGridView.AutoGenerateColumns = false;
            this.produtoSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtoSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.produtoSetDataGridView.DataSource = this.produtoSetBindingSource;
            this.produtoSetDataGridView.Location = new System.Drawing.Point(18, 310);
            this.produtoSetDataGridView.Name = "produtoSetDataGridView";
            this.produtoSetDataGridView.Size = new System.Drawing.Size(537, 220);
            this.produtoSetDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodProduto";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodProduto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Designacao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Designacao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Preco";
            this.dataGridViewTextBoxColumn3.HeaderText = "Preco";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StockExistente";
            this.dataGridViewTextBoxColumn4.HeaderText = "StockExistente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CodTipoProduto";
            this.dataGridViewTextBoxColumn5.HeaderText = "CodTipoProduto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // designacaoLabel
            // 
            designacaoLabel.AutoSize = true;
            designacaoLabel.Location = new System.Drawing.Point(40, 44);
            designacaoLabel.Name = "designacaoLabel";
            designacaoLabel.Size = new System.Drawing.Size(67, 13);
            designacaoLabel.TabIndex = 10;
            designacaoLabel.Text = "Designacao:";
            // 
            // designacaoTextBox
            // 
            this.designacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoSetBindingSource, "Designacao", true));
            this.designacaoTextBox.Location = new System.Drawing.Point(113, 41);
            this.designacaoTextBox.Name = "designacaoTextBox";
            this.designacaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.designacaoTextBox.TabIndex = 11;
            // 
            // precoLabel
            // 
            precoLabel.AutoSize = true;
            precoLabel.Location = new System.Drawing.Point(69, 70);
            precoLabel.Name = "precoLabel";
            precoLabel.Size = new System.Drawing.Size(38, 13);
            precoLabel.TabIndex = 11;
            precoLabel.Text = "Preço:";
            // 
            // precoTextBox
            // 
            this.precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoSetBindingSource, "Preco", true));
            this.precoTextBox.Location = new System.Drawing.Point(113, 67);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(100, 20);
            this.precoTextBox.TabIndex = 12;
            // 
            // stockExistenteLabel
            // 
            stockExistenteLabel.AutoSize = true;
            stockExistenteLabel.Location = new System.Drawing.Point(23, 96);
            stockExistenteLabel.Name = "stockExistenteLabel";
            stockExistenteLabel.Size = new System.Drawing.Size(84, 13);
            stockExistenteLabel.TabIndex = 12;
            stockExistenteLabel.Text = "Stock Existente:";
            // 
            // stockExistenteTextBox
            // 
            this.stockExistenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoSetBindingSource, "StockExistente", true));
            this.stockExistenteTextBox.Location = new System.Drawing.Point(113, 93);
            this.stockExistenteTextBox.Name = "stockExistenteTextBox";
            this.stockExistenteTextBox.Size = new System.Drawing.Size(100, 20);
            this.stockExistenteTextBox.TabIndex = 13;
            // 
            // codTipoProdutoLabel
            // 
            codTipoProdutoLabel.AutoSize = true;
            codTipoProdutoLabel.Location = new System.Drawing.Point(14, 122);
            codTipoProdutoLabel.Name = "codTipoProdutoLabel";
            codTipoProdutoLabel.Size = new System.Drawing.Size(93, 13);
            codTipoProdutoLabel.TabIndex = 13;
            codTipoProdutoLabel.Text = "Cod Tipo Produto:";
            // 
            // codTipoProdutoTextBox
            // 
            this.codTipoProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoSetBindingSource, "CodTipoProduto", true));
            this.codTipoProdutoTextBox.Location = new System.Drawing.Point(113, 119);
            this.codTipoProdutoTextBox.Name = "codTipoProdutoTextBox";
            this.codTipoProdutoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codTipoProdutoTextBox.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(codTipoProdutoLabel);
            this.groupBox1.Controls.Add(this.designacaoTextBox);
            this.groupBox1.Controls.Add(this.codTipoProdutoTextBox);
            this.groupBox1.Controls.Add(designacaoLabel);
            this.groupBox1.Controls.Add(stockExistenteLabel);
            this.groupBox1.Controls.Add(this.precoTextBox);
            this.groupBox1.Controls.Add(this.stockExistenteTextBox);
            this.groupBox1.Controls.Add(precoLabel);
            this.groupBox1.Location = new System.Drawing.Point(18, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 169);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir Produto Vendido";
            // 
            // BTN_InserirTipoProduto
            // 
            this.BTN_InserirTipoProduto.Location = new System.Drawing.Point(297, 182);
            this.BTN_InserirTipoProduto.Name = "BTN_InserirTipoProduto";
            this.BTN_InserirTipoProduto.Size = new System.Drawing.Size(231, 47);
            this.BTN_InserirTipoProduto.TabIndex = 16;
            this.BTN_InserirTipoProduto.Text = "Inserir novo tipo de produto";
            this.BTN_InserirTipoProduto.UseVisualStyleBackColor = true;
            this.BTN_InserirTipoProduto.Click += new System.EventHandler(this.BTN_InserirTipoProduto_Click);
            // 
            // ProdutosVendidosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 550);
            this.Controls.Add(this.BTN_InserirTipoProduto);
            this.Controls.Add(this.produtoSetDataGridView);
            this.Controls.Add(this.produtoSetBindingNavigator);
            this.Controls.Add(this.lbProdutosVendidos);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProdutosVendidosForm";
            this.Text = "ProdutosVendidos";
            this.Load += new System.EventHandler(this.ProdutosVendidosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoSetBindingNavigator)).EndInit();
            this.produtoSetBindingNavigator.ResumeLayout(false);
            this.produtoSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoSetDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProdutosVendidos;
        private BooKids_DBDataSet booKids_DBDataSet;
        private System.Windows.Forms.BindingSource produtoSetBindingSource;
        private BooKids_DBDataSetTableAdapters.ProdutoSetTableAdapter produtoSetTableAdapter;
        private BooKids_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator produtoSetBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton produtoSetBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView produtoSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox designacaoTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.TextBox stockExistenteTextBox;
        private System.Windows.Forms.TextBox codTipoProdutoTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_InserirTipoProduto;
    }
}