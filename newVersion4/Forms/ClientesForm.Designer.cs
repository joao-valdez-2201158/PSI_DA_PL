﻿
namespace Projeto_DA_BooKids.Forms
{
    partial class ClientesForm
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
            System.Windows.Forms.Label valorOfertaLabel;
            System.Windows.Forms.Label nrCartaoLabel;
            System.Windows.Forms.Label idPessoaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesForm));
            this.booKids_DataSet = new Projeto_DA_BooKids.BooKids_DataSet();
            this.pessoaSet_ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaSet_ClienteTableAdapter = new Projeto_DA_BooKids.BooKids_DataSetTableAdapters.PessoaSet_ClienteTableAdapter();
            this.tableAdapterManager = new Projeto_DA_BooKids.BooKids_DataSetTableAdapters.TableAdapterManager();
            this.pessoaSet_ClienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pessoaSet_ClienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pessoaSet_ClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.valorOfertaTextBox = new System.Windows.Forms.TextBox();
            this.nrCartaoTextBox = new System.Windows.Forms.TextBox();
            this.idPessoaTextBox = new System.Windows.Forms.TextBox();
            this.lbClientes = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            valorOfertaLabel = new System.Windows.Forms.Label();
            nrCartaoLabel = new System.Windows.Forms.Label();
            idPessoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_ClienteBindingNavigator)).BeginInit();
            this.pessoaSet_ClienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_ClienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // valorOfertaLabel
            // 
            valorOfertaLabel.AutoSize = true;
            valorOfertaLabel.Location = new System.Drawing.Point(43, 236);
            valorOfertaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            valorOfertaLabel.Name = "valorOfertaLabel";
            valorOfertaLabel.Size = new System.Drawing.Size(89, 17);
            valorOfertaLabel.TabIndex = 2;
            valorOfertaLabel.Text = "Valor Oferta:";
            // 
            // nrCartaoLabel
            // 
            nrCartaoLabel.AutoSize = true;
            nrCartaoLabel.Location = new System.Drawing.Point(43, 265);
            nrCartaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nrCartaoLabel.Name = "nrCartaoLabel";
            nrCartaoLabel.Size = new System.Drawing.Size(73, 17);
            nrCartaoLabel.TabIndex = 4;
            nrCartaoLabel.Text = "Nr Cartao:";
            // 
            // idPessoaLabel
            // 
            idPessoaLabel.AutoSize = true;
            idPessoaLabel.Location = new System.Drawing.Point(43, 300);
            idPessoaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idPessoaLabel.Name = "idPessoaLabel";
            idPessoaLabel.Size = new System.Drawing.Size(74, 17);
            idPessoaLabel.TabIndex = 6;
            idPessoaLabel.Text = "Id Pessoa:";
            // 
            // booKids_DataSet
            // 
            this.booKids_DataSet.DataSetName = "BooKids_DataSet";
            this.booKids_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoaSet_ClienteBindingSource
            // 
            this.pessoaSet_ClienteBindingSource.DataMember = "PessoaSet_Cliente";
            this.pessoaSet_ClienteBindingSource.DataSource = this.booKids_DataSet;
            // 
            // pessoaSet_ClienteTableAdapter
            // 
            this.pessoaSet_ClienteTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = this.pessoaSet_ClienteTableAdapter;
            this.tableAdapterManager.PessoaSet_FilhoTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.ProdutoSetTableAdapter = null;
            this.tableAdapterManager.TipoProdutoSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_BooKids.BooKids_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pessoaSet_ClienteBindingNavigator
            // 
            this.pessoaSet_ClienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pessoaSet_ClienteBindingNavigator.BindingSource = this.pessoaSet_ClienteBindingSource;
            this.pessoaSet_ClienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pessoaSet_ClienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pessoaSet_ClienteBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pessoaSet_ClienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pessoaSet_ClienteBindingNavigatorSaveItem});
            this.pessoaSet_ClienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pessoaSet_ClienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pessoaSet_ClienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pessoaSet_ClienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pessoaSet_ClienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pessoaSet_ClienteBindingNavigator.Name = "pessoaSet_ClienteBindingNavigator";
            this.pessoaSet_ClienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pessoaSet_ClienteBindingNavigator.Size = new System.Drawing.Size(552, 27);
            this.pessoaSet_ClienteBindingNavigator.TabIndex = 0;
            this.pessoaSet_ClienteBindingNavigator.Text = "bindingNavigator1";
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
            // pessoaSet_ClienteBindingNavigatorSaveItem
            // 
            this.pessoaSet_ClienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pessoaSet_ClienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pessoaSet_ClienteBindingNavigatorSaveItem.Image")));
            this.pessoaSet_ClienteBindingNavigatorSaveItem.Name = "pessoaSet_ClienteBindingNavigatorSaveItem";
            this.pessoaSet_ClienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.pessoaSet_ClienteBindingNavigatorSaveItem.Text = "Save Data";
            this.pessoaSet_ClienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.pessoaSet_ClienteBindingNavigatorSaveItem_Click);
            // 
            // pessoaSet_ClienteDataGridView
            // 
            this.pessoaSet_ClienteDataGridView.AutoGenerateColumns = false;
            this.pessoaSet_ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pessoaSet_ClienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.pessoaSet_ClienteDataGridView.DataSource = this.pessoaSet_ClienteBindingSource;
            this.pessoaSet_ClienteDataGridView.Location = new System.Drawing.Point(36, 363);
            this.pessoaSet_ClienteDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pessoaSet_ClienteDataGridView.Name = "pessoaSet_ClienteDataGridView";
            this.pessoaSet_ClienteDataGridView.RowHeadersWidth = 51;
            this.pessoaSet_ClienteDataGridView.Size = new System.Drawing.Size(459, 271);
            this.pessoaSet_ClienteDataGridView.TabIndex = 1;
            // 
            // valorOfertaTextBox
            // 
            this.valorOfertaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_ClienteBindingSource, "ValorOferta", true));
            this.valorOfertaTextBox.Location = new System.Drawing.Point(146, 231);
            this.valorOfertaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valorOfertaTextBox.Name = "valorOfertaTextBox";
            this.valorOfertaTextBox.Size = new System.Drawing.Size(103, 22);
            this.valorOfertaTextBox.TabIndex = 3;
            // 
            // nrCartaoTextBox
            // 
            this.nrCartaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_ClienteBindingSource, "NrCartao", true));
            this.nrCartaoTextBox.Location = new System.Drawing.Point(146, 265);
            this.nrCartaoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nrCartaoTextBox.Name = "nrCartaoTextBox";
            this.nrCartaoTextBox.Size = new System.Drawing.Size(191, 22);
            this.nrCartaoTextBox.TabIndex = 5;
            // 
            // idPessoaTextBox
            // 
            this.idPessoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_ClienteBindingSource, "IdPessoa", true));
            this.idPessoaTextBox.Location = new System.Drawing.Point(146, 295);
            this.idPessoaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idPessoaTextBox.Name = "idPessoaTextBox";
            this.idPessoaTextBox.Size = new System.Drawing.Size(103, 22);
            this.idPessoaTextBox.TabIndex = 7;
            // 
            // lbClientes
            // 
            this.lbClientes.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClientes.Location = new System.Drawing.Point(1, 86);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(551, 66);
            this.lbClientes.TabIndex = 18;
            this.lbClientes.Text = "Clientes";
            this.lbClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdPessoa";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdPessoa";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ValorOferta";
            this.dataGridViewTextBoxColumn1.HeaderText = "ValorOferta";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NrCartao";
            this.dataGridViewTextBoxColumn2.HeaderText = "NrCartao";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 692);
            this.Controls.Add(this.lbClientes);
            this.Controls.Add(idPessoaLabel);
            this.Controls.Add(this.idPessoaTextBox);
            this.Controls.Add(nrCartaoLabel);
            this.Controls.Add(this.nrCartaoTextBox);
            this.Controls.Add(valorOfertaLabel);
            this.Controls.Add(this.valorOfertaTextBox);
            this.Controls.Add(this.pessoaSet_ClienteDataGridView);
            this.Controls.Add(this.pessoaSet_ClienteBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ClientesForm";
            this.Text = "ClientesForm";
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_ClienteBindingNavigator)).EndInit();
            this.pessoaSet_ClienteBindingNavigator.ResumeLayout(false);
            this.pessoaSet_ClienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_ClienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BooKids_DataSet booKids_DataSet;
        private System.Windows.Forms.BindingSource pessoaSet_ClienteBindingSource;
        private BooKids_DataSetTableAdapters.PessoaSet_ClienteTableAdapter pessoaSet_ClienteTableAdapter;
        private BooKids_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pessoaSet_ClienteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pessoaSet_ClienteBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pessoaSet_ClienteDataGridView;
        private System.Windows.Forms.TextBox valorOfertaTextBox;
        private System.Windows.Forms.TextBox nrCartaoTextBox;
        private System.Windows.Forms.TextBox idPessoaTextBox;
        private System.Windows.Forms.Label lbClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}