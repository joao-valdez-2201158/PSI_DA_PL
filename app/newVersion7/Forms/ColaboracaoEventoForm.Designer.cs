
namespace Projeto_DA_BooKids.Forms
{
    partial class ColaboracaoEventoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColaboracaoEventoForm));
            System.Windows.Forms.Label idAnimadorLabel;
            System.Windows.Forms.Label nrEventoLabel;
            this.lbAnimadorEvento = new System.Windows.Forms.Label();
            this.booKids_DBDataSet = new Projeto_DA_BooKids.BooKids_DBDataSet();
            this.colaboracaoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colaboracaoSetTableAdapter = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.ColaboracaoSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager();
            this.colaboracaoSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.colaboracaoSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.colaboracaoSetDataGridView = new System.Windows.Forms.DataGridView();
            this.idAnimadorTextBox = new System.Windows.Forms.TextBox();
            this.nrEventoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idAnimadorLabel = new System.Windows.Forms.Label();
            nrEventoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboracaoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboracaoSetBindingNavigator)).BeginInit();
            this.colaboracaoSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaboracaoSetDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAnimadorEvento
            // 
            this.lbAnimadorEvento.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimadorEvento.Location = new System.Drawing.Point(11, 46);
            this.lbAnimadorEvento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAnimadorEvento.Name = "lbAnimadorEvento";
            this.lbAnimadorEvento.Size = new System.Drawing.Size(411, 50);
            this.lbAnimadorEvento.TabIndex = 13;
            this.lbAnimadorEvento.Text = "Colaboração | Animador - Evento";
            this.lbAnimadorEvento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // booKids_DBDataSet
            // 
            this.booKids_DBDataSet.DataSetName = "BooKids_DBDataSet";
            this.booKids_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colaboracaoSetBindingSource
            // 
            this.colaboracaoSetBindingSource.DataMember = "ColaboracaoSet";
            this.colaboracaoSetBindingSource.DataSource = this.booKids_DBDataSet;
            // 
            // colaboracaoSetTableAdapter
            // 
            this.colaboracaoSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColaboracaoSetTableAdapter = this.colaboracaoSetTableAdapter;
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
            this.tableAdapterManager.TipoProdutoSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // colaboracaoSetBindingNavigator
            // 
            this.colaboracaoSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.colaboracaoSetBindingNavigator.BindingSource = this.colaboracaoSetBindingSource;
            this.colaboracaoSetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.colaboracaoSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.colaboracaoSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.colaboracaoSetBindingNavigatorSaveItem});
            this.colaboracaoSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.colaboracaoSetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.colaboracaoSetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.colaboracaoSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.colaboracaoSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.colaboracaoSetBindingNavigator.Name = "colaboracaoSetBindingNavigator";
            this.colaboracaoSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.colaboracaoSetBindingNavigator.Size = new System.Drawing.Size(442, 25);
            this.colaboracaoSetBindingNavigator.TabIndex = 14;
            this.colaboracaoSetBindingNavigator.Text = "bindingNavigator1";
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
            // colaboracaoSetBindingNavigatorSaveItem
            // 
            this.colaboracaoSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colaboracaoSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("colaboracaoSetBindingNavigatorSaveItem.Image")));
            this.colaboracaoSetBindingNavigatorSaveItem.Name = "colaboracaoSetBindingNavigatorSaveItem";
            this.colaboracaoSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.colaboracaoSetBindingNavigatorSaveItem.Text = "Save Data";
            this.colaboracaoSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.colaboracaoSetBindingNavigatorSaveItem_Click);
            // 
            // colaboracaoSetDataGridView
            // 
            this.colaboracaoSetDataGridView.AllowUserToAddRows = false;
            this.colaboracaoSetDataGridView.AllowUserToDeleteRows = false;
            this.colaboracaoSetDataGridView.AutoGenerateColumns = false;
            this.colaboracaoSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.colaboracaoSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.colaboracaoSetDataGridView.DataSource = this.colaboracaoSetBindingSource;
            this.colaboracaoSetDataGridView.Location = new System.Drawing.Point(97, 244);
            this.colaboracaoSetDataGridView.Name = "colaboracaoSetDataGridView";
            this.colaboracaoSetDataGridView.ReadOnly = true;
            this.colaboracaoSetDataGridView.Size = new System.Drawing.Size(245, 220);
            this.colaboracaoSetDataGridView.TabIndex = 14;
            // 
            // idAnimadorLabel
            // 
            idAnimadorLabel.AutoSize = true;
            idAnimadorLabel.Location = new System.Drawing.Point(32, 30);
            idAnimadorLabel.Name = "idAnimadorLabel";
            idAnimadorLabel.Size = new System.Drawing.Size(66, 13);
            idAnimadorLabel.TabIndex = 14;
            idAnimadorLabel.Text = "Id Animador:";
            // 
            // idAnimadorTextBox
            // 
            this.idAnimadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboracaoSetBindingSource, "IdAnimador", true));
            this.idAnimadorTextBox.Location = new System.Drawing.Point(104, 27);
            this.idAnimadorTextBox.Name = "idAnimadorTextBox";
            this.idAnimadorTextBox.Size = new System.Drawing.Size(100, 20);
            this.idAnimadorTextBox.TabIndex = 15;
            // 
            // nrEventoLabel
            // 
            nrEventoLabel.AutoSize = true;
            nrEventoLabel.Location = new System.Drawing.Point(40, 56);
            nrEventoLabel.Name = "nrEventoLabel";
            nrEventoLabel.Size = new System.Drawing.Size(58, 13);
            nrEventoLabel.TabIndex = 15;
            nrEventoLabel.Text = "Nr Evento:";
            // 
            // nrEventoTextBox
            // 
            this.nrEventoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboracaoSetBindingSource, "NrEvento", true));
            this.nrEventoTextBox.Location = new System.Drawing.Point(104, 53);
            this.nrEventoTextBox.Name = "nrEventoTextBox";
            this.nrEventoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nrEventoTextBox.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(nrEventoLabel);
            this.groupBox1.Controls.Add(this.nrEventoTextBox);
            this.groupBox1.Controls.Add(this.idAnimadorTextBox);
            this.groupBox1.Controls.Add(idAnimadorLabel);
            this.groupBox1.Location = new System.Drawing.Point(97, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 91);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir Colaboração";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdAnimador";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdAnimador";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NrEvento";
            this.dataGridViewTextBoxColumn2.HeaderText = "NrEvento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ColaboracaoEventoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 484);
            this.Controls.Add(this.colaboracaoSetDataGridView);
            this.Controls.Add(this.colaboracaoSetBindingNavigator);
            this.Controls.Add(this.lbAnimadorEvento);
            this.Controls.Add(this.groupBox1);
            this.Name = "ColaboracaoEventoForm";
            this.Text = "Colaboracao";
            this.Load += new System.EventHandler(this.ColaboracaoEventoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboracaoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboracaoSetBindingNavigator)).EndInit();
            this.colaboracaoSetBindingNavigator.ResumeLayout(false);
            this.colaboracaoSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaboracaoSetDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAnimadorEvento;
        private BooKids_DBDataSet booKids_DBDataSet;
        private System.Windows.Forms.BindingSource colaboracaoSetBindingSource;
        private BooKids_DBDataSetTableAdapters.ColaboracaoSetTableAdapter colaboracaoSetTableAdapter;
        private BooKids_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator colaboracaoSetBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton colaboracaoSetBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView colaboracaoSetDataGridView;
        private System.Windows.Forms.TextBox idAnimadorTextBox;
        private System.Windows.Forms.TextBox nrEventoTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}