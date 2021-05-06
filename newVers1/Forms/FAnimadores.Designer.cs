
namespace Projeto_DA_BooKids.Forms
{
    partial class FAnimadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAnimadores));
            System.Windows.Forms.Label especialidadeLabel;
            System.Windows.Forms.Label idPessoaLabel;
            this.booKids_DBDataSet = new Projeto_DA_BooKids.BooKids_DBDataSet();
            this.pessoaSet_AnimadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaSet_AnimadorTableAdapter = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.PessoaSet_AnimadorTableAdapter();
            this.tableAdapterManager = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager();
            this.pessoaSet_AnimadorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pessoaSet_AnimadorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pessoaSet_AnimadorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadeTextBox = new System.Windows.Forms.TextBox();
            this.idPessoaTextBox = new System.Windows.Forms.TextBox();
            especialidadeLabel = new System.Windows.Forms.Label();
            idPessoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_AnimadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_AnimadorBindingNavigator)).BeginInit();
            this.pessoaSet_AnimadorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_AnimadorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // booKids_DBDataSet
            // 
            this.booKids_DBDataSet.DataSetName = "BooKids_DBDataSet";
            this.booKids_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoaSet_AnimadorBindingSource
            // 
            this.pessoaSet_AnimadorBindingSource.DataMember = "PessoaSet_Animador";
            this.pessoaSet_AnimadorBindingSource.DataSource = this.booKids_DBDataSet;
            // 
            // pessoaSet_AnimadorTableAdapter
            // 
            this.pessoaSet_AnimadorTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PessoaSet_AnimadorTableAdapter = this.pessoaSet_AnimadorTableAdapter;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_FilhoTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.ProdutoSetTableAdapter = null;
            this.tableAdapterManager.TipoProdutoSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pessoaSet_AnimadorBindingNavigator
            // 
            this.pessoaSet_AnimadorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pessoaSet_AnimadorBindingNavigator.BindingSource = this.pessoaSet_AnimadorBindingSource;
            this.pessoaSet_AnimadorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pessoaSet_AnimadorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pessoaSet_AnimadorBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pessoaSet_AnimadorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pessoaSet_AnimadorBindingNavigatorSaveItem});
            this.pessoaSet_AnimadorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pessoaSet_AnimadorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pessoaSet_AnimadorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pessoaSet_AnimadorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pessoaSet_AnimadorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pessoaSet_AnimadorBindingNavigator.Name = "pessoaSet_AnimadorBindingNavigator";
            this.pessoaSet_AnimadorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pessoaSet_AnimadorBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.pessoaSet_AnimadorBindingNavigator.TabIndex = 0;
            this.pessoaSet_AnimadorBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // pessoaSet_AnimadorBindingNavigatorSaveItem
            // 
            this.pessoaSet_AnimadorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pessoaSet_AnimadorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pessoaSet_AnimadorBindingNavigatorSaveItem.Image")));
            this.pessoaSet_AnimadorBindingNavigatorSaveItem.Name = "pessoaSet_AnimadorBindingNavigatorSaveItem";
            this.pessoaSet_AnimadorBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.pessoaSet_AnimadorBindingNavigatorSaveItem.Text = "Save Data";
            this.pessoaSet_AnimadorBindingNavigatorSaveItem.Click += new System.EventHandler(this.pessoaSet_AnimadorBindingNavigatorSaveItem_Click);
            // 
            // pessoaSet_AnimadorDataGridView
            // 
            this.pessoaSet_AnimadorDataGridView.AutoGenerateColumns = false;
            this.pessoaSet_AnimadorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pessoaSet_AnimadorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.pessoaSet_AnimadorDataGridView.DataSource = this.pessoaSet_AnimadorBindingSource;
            this.pessoaSet_AnimadorDataGridView.Location = new System.Drawing.Point(454, 81);
            this.pessoaSet_AnimadorDataGridView.Name = "pessoaSet_AnimadorDataGridView";
            this.pessoaSet_AnimadorDataGridView.RowHeadersWidth = 51;
            this.pessoaSet_AnimadorDataGridView.RowTemplate.Height = 24;
            this.pessoaSet_AnimadorDataGridView.Size = new System.Drawing.Size(300, 220);
            this.pessoaSet_AnimadorDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Especialidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Especialidade";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdPessoa";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdPessoa";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // especialidadeLabel
            // 
            especialidadeLabel.AutoSize = true;
            especialidadeLabel.Location = new System.Drawing.Point(12, 119);
            especialidadeLabel.Name = "especialidadeLabel";
            especialidadeLabel.Size = new System.Drawing.Size(100, 17);
            especialidadeLabel.TabIndex = 2;
            especialidadeLabel.Text = "Especialidade:";
            // 
            // especialidadeTextBox
            // 
            this.especialidadeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.especialidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_AnimadorBindingSource, "Especialidade", true));
            this.especialidadeTextBox.Location = new System.Drawing.Point(154, 114);
            this.especialidadeTextBox.Name = "especialidadeTextBox";
            this.especialidadeTextBox.Size = new System.Drawing.Size(243, 22);
            this.especialidadeTextBox.TabIndex = 3;
            this.especialidadeTextBox.TextChanged += new System.EventHandler(this.especialidadeTextBox_TextChanged);
            // 
            // idPessoaLabel
            // 
            idPessoaLabel.AutoSize = true;
            idPessoaLabel.Location = new System.Drawing.Point(12, 215);
            idPessoaLabel.Name = "idPessoaLabel";
            idPessoaLabel.Size = new System.Drawing.Size(74, 17);
            idPessoaLabel.TabIndex = 4;
            idPessoaLabel.Text = "Id Pessoa:";
            // 
            // idPessoaTextBox
            // 
            this.idPessoaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idPessoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_AnimadorBindingSource, "IdPessoa", true));
            this.idPessoaTextBox.Location = new System.Drawing.Point(154, 210);
            this.idPessoaTextBox.Name = "idPessoaTextBox";
            this.idPessoaTextBox.Size = new System.Drawing.Size(243, 22);
            this.idPessoaTextBox.TabIndex = 5;
            // 
            // FAnimadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idPessoaLabel);
            this.Controls.Add(this.idPessoaTextBox);
            this.Controls.Add(especialidadeLabel);
            this.Controls.Add(this.especialidadeTextBox);
            this.Controls.Add(this.pessoaSet_AnimadorDataGridView);
            this.Controls.Add(this.pessoaSet_AnimadorBindingNavigator);
            this.Name = "FAnimadores";
            this.Text = "FormAnimadores";
            this.Load += new System.EventHandler(this.FormAnimadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_AnimadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_AnimadorBindingNavigator)).EndInit();
            this.pessoaSet_AnimadorBindingNavigator.ResumeLayout(false);
            this.pessoaSet_AnimadorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_AnimadorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BooKids_DBDataSet booKids_DBDataSet;
        private System.Windows.Forms.BindingSource pessoaSet_AnimadorBindingSource;
        private BooKids_DBDataSetTableAdapters.PessoaSet_AnimadorTableAdapter pessoaSet_AnimadorTableAdapter;
        private BooKids_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pessoaSet_AnimadorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pessoaSet_AnimadorBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pessoaSet_AnimadorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox especialidadeTextBox;
        private System.Windows.Forms.TextBox idPessoaTextBox;
    }
}