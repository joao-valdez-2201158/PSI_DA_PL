﻿
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
            System.Windows.Forms.Label especialidadeLabel;
            System.Windows.Forms.Label idPessoaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimadoresForm));
            this.lbAnimadores = new System.Windows.Forms.Label();
            this.booKids_DBDataSet = new Projeto_DA_BooKids.BooKids_DBDataSet();
            this.pessoaSet_AnimadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaSet_AnimadorTableAdapter = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.PessoaSet_AnimadorTableAdapter();
            this.tableAdapterManager = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager();
            this.pessoaSet_AnimadorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pessoaSet_AnimadorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pessoaSet_AnimadorDataGridView = new System.Windows.Forms.DataGridView();
            this.especialidadeTextBox = new System.Windows.Forms.TextBox();
            this.idPessoaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            especialidadeLabel = new System.Windows.Forms.Label();
            idPessoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_AnimadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_AnimadorBindingNavigator)).BeginInit();
            this.pessoaSet_AnimadorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_AnimadorDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // especialidadeLabel
            // 
            especialidadeLabel.AutoSize = true;
            especialidadeLabel.Location = new System.Drawing.Point(20, 39);
            especialidadeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            especialidadeLabel.Name = "especialidadeLabel";
            especialidadeLabel.Size = new System.Drawing.Size(100, 17);
            especialidadeLabel.TabIndex = 9;
            especialidadeLabel.Text = "Especialidade:";
            // 
            // idPessoaLabel
            // 
            idPessoaLabel.AutoSize = true;
            idPessoaLabel.Location = new System.Drawing.Point(20, 75);
            idPessoaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idPessoaLabel.Name = "idPessoaLabel";
            idPessoaLabel.Size = new System.Drawing.Size(74, 17);
            idPessoaLabel.TabIndex = 10;
            idPessoaLabel.Text = "Id Pessoa:";
            // 
            // lbAnimadores
            // 
            this.lbAnimadores.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimadores.Location = new System.Drawing.Point(0, 43);
            this.lbAnimadores.Name = "lbAnimadores";
            this.lbAnimadores.Size = new System.Drawing.Size(456, 62);
            this.lbAnimadores.TabIndex = 8;
            this.lbAnimadores.Text = "Animadores";
            this.lbAnimadores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pessoaSet_AnimadorBindingNavigator.Size = new System.Drawing.Size(456, 27);
            this.pessoaSet_AnimadorBindingNavigator.TabIndex = 9;
            this.pessoaSet_AnimadorBindingNavigator.Text = "bindingNavigator1";
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
            this.pessoaSet_AnimadorDataGridView.AllowUserToAddRows = false;
            this.pessoaSet_AnimadorDataGridView.AllowUserToDeleteRows = false;
            this.pessoaSet_AnimadorDataGridView.AutoGenerateColumns = false;
            this.pessoaSet_AnimadorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pessoaSet_AnimadorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.pessoaSet_AnimadorDataGridView.DataSource = this.pessoaSet_AnimadorBindingSource;
            this.pessoaSet_AnimadorDataGridView.Location = new System.Drawing.Point(64, 281);
            this.pessoaSet_AnimadorDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pessoaSet_AnimadorDataGridView.Name = "pessoaSet_AnimadorDataGridView";
            this.pessoaSet_AnimadorDataGridView.ReadOnly = true;
            this.pessoaSet_AnimadorDataGridView.RowHeadersWidth = 51;
            this.pessoaSet_AnimadorDataGridView.Size = new System.Drawing.Size(324, 271);
            this.pessoaSet_AnimadorDataGridView.TabIndex = 9;
            // 
            // especialidadeTextBox
            // 
            this.especialidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_AnimadorBindingSource, "Especialidade", true));
            this.especialidadeTextBox.Location = new System.Drawing.Point(135, 36);
            this.especialidadeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.especialidadeTextBox.Name = "especialidadeTextBox";
            this.especialidadeTextBox.Size = new System.Drawing.Size(132, 22);
            this.especialidadeTextBox.TabIndex = 10;
            // 
            // idPessoaTextBox
            // 
            this.idPessoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_AnimadorBindingSource, "IdPessoa", true));
            this.idPessoaTextBox.Location = new System.Drawing.Point(135, 71);
            this.idPessoaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idPessoaTextBox.Name = "idPessoaTextBox";
            this.idPessoaTextBox.Size = new System.Drawing.Size(132, 22);
            this.idPessoaTextBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idPessoaLabel);
            this.groupBox1.Controls.Add(this.idPessoaTextBox);
            this.groupBox1.Controls.Add(this.especialidadeTextBox);
            this.groupBox1.Controls.Add(especialidadeLabel);
            this.groupBox1.Location = new System.Drawing.Point(64, 133);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(324, 123);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir Animador";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Especialidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Especialidade";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdPessoa";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdPessoa";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // AnimadoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 582);
            this.Controls.Add(this.pessoaSet_AnimadorDataGridView);
            this.Controls.Add(this.pessoaSet_AnimadorBindingNavigator);
            this.Controls.Add(this.lbAnimadores);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AnimadoresForm";
            this.Text = "AnimadoresForm";
            this.Load += new System.EventHandler(this.AnimadoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_AnimadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_AnimadorBindingNavigator)).EndInit();
            this.pessoaSet_AnimadorBindingNavigator.ResumeLayout(false);
            this.pessoaSet_AnimadorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_AnimadorDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAnimadores;
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
        private System.Windows.Forms.TextBox especialidadeTextBox;
        private System.Windows.Forms.TextBox idPessoaTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}