
namespace Projeto_DA_BooKids.Forms
{
    partial class TipoProdutosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoProdutosForm));
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label codTipoProdutoLabel;
            this.lbVendaProdutos = new System.Windows.Forms.Label();
            this.booKids_DBDataSet = new Projeto_DA_BooKids.BooKids_DBDataSet();
            this.tipoProdutoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoProdutoSetTableAdapter = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TipoProdutoSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager();
            this.tipoProdutoSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tipoProdutoSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tipoProdutoSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.codTipoProdutoTextBox = new System.Windows.Forms.TextBox();
            tipoLabel = new System.Windows.Forms.Label();
            codTipoProdutoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoSetBindingNavigator)).BeginInit();
            this.tipoProdutoSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoSetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbVendaProdutos
            // 
            this.lbVendaProdutos.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVendaProdutos.Location = new System.Drawing.Point(11, 41);
            this.lbVendaProdutos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVendaProdutos.Name = "lbVendaProdutos";
            this.lbVendaProdutos.Size = new System.Drawing.Size(251, 50);
            this.lbVendaProdutos.TabIndex = 9;
            this.lbVendaProdutos.Text = "Venda de Produtos";
            this.lbVendaProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // booKids_DBDataSet
            // 
            this.booKids_DBDataSet.DataSetName = "BooKids_DBDataSet";
            this.booKids_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoProdutoSetBindingSource
            // 
            this.tipoProdutoSetBindingSource.DataMember = "TipoProdutoSet";
            this.tipoProdutoSetBindingSource.DataSource = this.booKids_DBDataSet;
            // 
            // tipoProdutoSetTableAdapter
            // 
            this.tipoProdutoSetTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ProdutoSetTableAdapter = null;
            this.tableAdapterManager.TipoProdutoSetTableAdapter = this.tipoProdutoSetTableAdapter;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tipoProdutoSetBindingNavigator
            // 
            this.tipoProdutoSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tipoProdutoSetBindingNavigator.BindingSource = this.tipoProdutoSetBindingSource;
            this.tipoProdutoSetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tipoProdutoSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tipoProdutoSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tipoProdutoSetBindingNavigatorSaveItem});
            this.tipoProdutoSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tipoProdutoSetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tipoProdutoSetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tipoProdutoSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tipoProdutoSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tipoProdutoSetBindingNavigator.Name = "tipoProdutoSetBindingNavigator";
            this.tipoProdutoSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tipoProdutoSetBindingNavigator.Size = new System.Drawing.Size(304, 25);
            this.tipoProdutoSetBindingNavigator.TabIndex = 10;
            this.tipoProdutoSetBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tipoProdutoSetBindingNavigatorSaveItem
            // 
            this.tipoProdutoSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tipoProdutoSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tipoProdutoSetBindingNavigatorSaveItem.Image")));
            this.tipoProdutoSetBindingNavigatorSaveItem.Name = "tipoProdutoSetBindingNavigatorSaveItem";
            this.tipoProdutoSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tipoProdutoSetBindingNavigatorSaveItem.Text = "Save Data";
            this.tipoProdutoSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.tipoProdutoSetBindingNavigatorSaveItem_Click);
            // 
            // tipoProdutoSetDataGridView
            // 
            this.tipoProdutoSetDataGridView.AutoGenerateColumns = false;
            this.tipoProdutoSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipoProdutoSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tipoProdutoSetDataGridView.DataSource = this.tipoProdutoSetBindingSource;
            this.tipoProdutoSetDataGridView.Location = new System.Drawing.Point(18, 274);
            this.tipoProdutoSetDataGridView.Name = "tipoProdutoSetDataGridView";
            this.tipoProdutoSetDataGridView.Size = new System.Drawing.Size(244, 220);
            this.tipoProdutoSetDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodTipoProduto";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodTipoProduto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(93, 172);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 10;
            tipoLabel.Text = "Tipo:";
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoProdutoSetBindingSource, "Tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(130, 165);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(100, 20);
            this.tipoTextBox.TabIndex = 11;
            // 
            // codTipoProdutoLabel
            // 
            codTipoProdutoLabel.AutoSize = true;
            codTipoProdutoLabel.Location = new System.Drawing.Point(31, 133);
            codTipoProdutoLabel.Name = "codTipoProdutoLabel";
            codTipoProdutoLabel.Size = new System.Drawing.Size(93, 13);
            codTipoProdutoLabel.TabIndex = 11;
            codTipoProdutoLabel.Text = "Cod Tipo Produto:";
            // 
            // codTipoProdutoTextBox
            // 
            this.codTipoProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoProdutoSetBindingSource, "CodTipoProduto", true));
            this.codTipoProdutoTextBox.Location = new System.Drawing.Point(130, 130);
            this.codTipoProdutoTextBox.Name = "codTipoProdutoTextBox";
            this.codTipoProdutoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codTipoProdutoTextBox.TabIndex = 12;
            // 
            // TipoProdutosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 514);
            this.Controls.Add(codTipoProdutoLabel);
            this.Controls.Add(this.codTipoProdutoTextBox);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(this.tipoProdutoSetDataGridView);
            this.Controls.Add(this.tipoProdutoSetBindingNavigator);
            this.Controls.Add(this.lbVendaProdutos);
            this.Name = "TipoProdutosForm";
            this.Text = "TipoProdutosForm";
            this.Load += new System.EventHandler(this.TipoProdutosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoSetBindingNavigator)).EndInit();
            this.tipoProdutoSetBindingNavigator.ResumeLayout(false);
            this.tipoProdutoSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoSetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVendaProdutos;
        private BooKids_DBDataSet booKids_DBDataSet;
        private System.Windows.Forms.BindingSource tipoProdutoSetBindingSource;
        private BooKids_DBDataSetTableAdapters.TipoProdutoSetTableAdapter tipoProdutoSetTableAdapter;
        private BooKids_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tipoProdutoSetBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tipoProdutoSetBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tipoProdutoSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.TextBox codTipoProdutoTextBox;
    }
}