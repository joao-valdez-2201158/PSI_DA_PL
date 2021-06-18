
namespace Projeto_DA_BooKids.Forms
{
    partial class AnimadoresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimadoresForm));
            System.Windows.Forms.Label especialidadeLabel;
            System.Windows.Forms.Label idPessoaLabel;
            this.booKids_DataSet = new Projeto_DA_BooKids.BooKids_DataSet();
            this.colaboracaoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colaboracaoSetTableAdapter = new Projeto_DA_BooKids.BooKids_DataSetTableAdapters.ColaboracaoSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_BooKids.BooKids_DataSetTableAdapters.TableAdapterManager();
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaSet_AnimadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaSet_AnimadorTableAdapter = new Projeto_DA_BooKids.BooKids_DataSetTableAdapters.PessoaSet_AnimadorTableAdapter();
            this.especialidadeTextBox = new System.Windows.Forms.TextBox();
            this.idPessoaTextBox = new System.Windows.Forms.TextBox();
            this.lbAnimadores = new System.Windows.Forms.Label();
            especialidadeLabel = new System.Windows.Forms.Label();
            idPessoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboracaoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboracaoSetBindingNavigator)).BeginInit();
            this.colaboracaoSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaboracaoSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_AnimadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // booKids_DataSet
            // 
            this.booKids_DataSet.DataSetName = "BooKids_DataSet";
            this.booKids_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colaboracaoSetBindingSource
            // 
            this.colaboracaoSetBindingSource.DataMember = "ColaboracaoSet";
            this.colaboracaoSetBindingSource.DataSource = this.booKids_DataSet;
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
            this.tableAdapterManager.PessoaSet_AnimadorTableAdapter = this.pessoaSet_AnimadorTableAdapter;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_FilhoTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.ProdutoSetTableAdapter = null;
            this.tableAdapterManager.TipoProdutoSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_BooKids.BooKids_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // colaboracaoSetBindingNavigator
            // 
            this.colaboracaoSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.colaboracaoSetBindingNavigator.BindingSource = this.colaboracaoSetBindingSource;
            this.colaboracaoSetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.colaboracaoSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.colaboracaoSetBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.colaboracaoSetBindingNavigator.Size = new System.Drawing.Size(695, 31);
            this.colaboracaoSetBindingNavigator.TabIndex = 0;
            this.colaboracaoSetBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // colaboracaoSetBindingNavigatorSaveItem
            // 
            this.colaboracaoSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colaboracaoSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("colaboracaoSetBindingNavigatorSaveItem.Image")));
            this.colaboracaoSetBindingNavigatorSaveItem.Name = "colaboracaoSetBindingNavigatorSaveItem";
            this.colaboracaoSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
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
            this.colaboracaoSetDataGridView.Location = new System.Drawing.Point(334, 202);
            this.colaboracaoSetDataGridView.Name = "colaboracaoSetDataGridView";
            this.colaboracaoSetDataGridView.ReadOnly = true;
            this.colaboracaoSetDataGridView.RowHeadersWidth = 51;
            this.colaboracaoSetDataGridView.RowTemplate.Height = 24;
            this.colaboracaoSetDataGridView.Size = new System.Drawing.Size(304, 220);
            this.colaboracaoSetDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NrEvento";
            this.dataGridViewTextBoxColumn1.HeaderText = "NrEvento";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AnimadorIdPessoa";
            this.dataGridViewTextBoxColumn2.HeaderText = "AnimadorIdPessoa";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // pessoaSet_AnimadorBindingSource
            // 
            this.pessoaSet_AnimadorBindingSource.DataMember = "PessoaSet_Animador";
            this.pessoaSet_AnimadorBindingSource.DataSource = this.booKids_DataSet;
            // 
            // pessoaSet_AnimadorTableAdapter
            // 
            this.pessoaSet_AnimadorTableAdapter.ClearBeforeFill = true;
            // 
            // especialidadeLabel
            // 
            especialidadeLabel.AutoSize = true;
            especialidadeLabel.Location = new System.Drawing.Point(50, 267);
            especialidadeLabel.Name = "especialidadeLabel";
            especialidadeLabel.Size = new System.Drawing.Size(100, 17);
            especialidadeLabel.TabIndex = 2;
            especialidadeLabel.Text = "Especialidade:";
            // 
            // especialidadeTextBox
            // 
            this.especialidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_AnimadorBindingSource, "Especialidade", true));
            this.especialidadeTextBox.Location = new System.Drawing.Point(156, 264);
            this.especialidadeTextBox.Name = "especialidadeTextBox";
            this.especialidadeTextBox.Size = new System.Drawing.Size(100, 22);
            this.especialidadeTextBox.TabIndex = 3;
            // 
            // idPessoaLabel
            // 
            idPessoaLabel.AutoSize = true;
            idPessoaLabel.Location = new System.Drawing.Point(70, 326);
            idPessoaLabel.Name = "idPessoaLabel";
            idPessoaLabel.Size = new System.Drawing.Size(74, 17);
            idPessoaLabel.TabIndex = 4;
            idPessoaLabel.Text = "Id Pessoa:";
            // 
            // idPessoaTextBox
            // 
            this.idPessoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_AnimadorBindingSource, "IdPessoa", true));
            this.idPessoaTextBox.Location = new System.Drawing.Point(150, 323);
            this.idPessoaTextBox.Name = "idPessoaTextBox";
            this.idPessoaTextBox.Size = new System.Drawing.Size(100, 22);
            this.idPessoaTextBox.TabIndex = 5;
            // 
            // lbAnimadores
            // 
            this.lbAnimadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimadores.Location = new System.Drawing.Point(0, 72);
            this.lbAnimadores.Name = "lbAnimadores";
            this.lbAnimadores.Size = new System.Drawing.Size(695, 53);
            this.lbAnimadores.TabIndex = 6;
            this.lbAnimadores.Text = "Animadores";
            this.lbAnimadores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAnimadores.Click += new System.EventHandler(this.lbAnimadores_Click);
            // 
            // AnimadoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 452);
            this.Controls.Add(this.lbAnimadores);
            this.Controls.Add(idPessoaLabel);
            this.Controls.Add(this.idPessoaTextBox);
            this.Controls.Add(especialidadeLabel);
            this.Controls.Add(this.especialidadeTextBox);
            this.Controls.Add(this.colaboracaoSetDataGridView);
            this.Controls.Add(this.colaboracaoSetBindingNavigator);
            this.Name = "AnimadoresForm";
            this.Text = "AnimadoresForm";
            this.Load += new System.EventHandler(this.AnimadoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboracaoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboracaoSetBindingNavigator)).EndInit();
            this.colaboracaoSetBindingNavigator.ResumeLayout(false);
            this.colaboracaoSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaboracaoSetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_AnimadorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BooKids_DataSet booKids_DataSet;
        private System.Windows.Forms.BindingSource colaboracaoSetBindingSource;
        private BooKids_DataSetTableAdapters.ColaboracaoSetTableAdapter colaboracaoSetTableAdapter;
        private BooKids_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private BooKids_DataSetTableAdapters.PessoaSet_AnimadorTableAdapter pessoaSet_AnimadorTableAdapter;
        private System.Windows.Forms.BindingSource pessoaSet_AnimadorBindingSource;
        private System.Windows.Forms.TextBox especialidadeTextBox;
        private System.Windows.Forms.TextBox idPessoaTextBox;
        private System.Windows.Forms.Label lbAnimadores;
    }
}