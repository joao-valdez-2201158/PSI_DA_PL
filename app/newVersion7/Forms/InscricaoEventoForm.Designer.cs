
namespace Projeto_DA_BooKids.Forms
{
    partial class InscricaoEventoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InscricaoEventoForm));
            System.Windows.Forms.Label confirmadaLabel;
            System.Windows.Forms.Label filhoIdPessoaLabel;
            System.Windows.Forms.Label eventoNrEventoLabel;
            this.booKids_DBDataSet = new Projeto_DA_BooKids.BooKids_DBDataSet();
            this.inscricaoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inscricaoSetTableAdapter = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.InscricaoSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager();
            this.inscricaoSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.inscricaoSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.inscricaoSetDataGridView = new System.Windows.Forms.DataGridView();
            this.confirmadaCheckBox = new System.Windows.Forms.CheckBox();
            this.filhoIdPessoaTextBox = new System.Windows.Forms.TextBox();
            this.eventoNrEventoTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbFilhoEvento = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            confirmadaLabel = new System.Windows.Forms.Label();
            filhoIdPessoaLabel = new System.Windows.Forms.Label();
            eventoNrEventoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaoSetBindingNavigator)).BeginInit();
            this.inscricaoSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaoSetDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // booKids_DBDataSet
            // 
            this.booKids_DBDataSet.DataSetName = "BooKids_DBDataSet";
            this.booKids_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inscricaoSetBindingSource
            // 
            this.inscricaoSetBindingSource.DataMember = "InscricaoSet";
            this.inscricaoSetBindingSource.DataSource = this.booKids_DBDataSet;
            // 
            // inscricaoSetTableAdapter
            // 
            this.inscricaoSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColaboracaoSetTableAdapter = null;
            this.tableAdapterManager.CompraSetTableAdapter = null;
            this.tableAdapterManager.DetalheCompraSetTableAdapter = null;
            this.tableAdapterManager.EscolaSetTableAdapter = null;
            this.tableAdapterManager.EventoSetTableAdapter = null;
            this.tableAdapterManager.InscricaoSetTableAdapter = this.inscricaoSetTableAdapter;
            this.tableAdapterManager.ParticipacaoSetTableAdapter = null;
            this.tableAdapterManager.PessoaSet_AnimadorTableAdapter = null;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_FilhoTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.ProdutoSetTableAdapter = null;
            this.tableAdapterManager.TipoProdutoSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inscricaoSetBindingNavigator
            // 
            this.inscricaoSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.inscricaoSetBindingNavigator.BindingSource = this.inscricaoSetBindingSource;
            this.inscricaoSetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.inscricaoSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.inscricaoSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.inscricaoSetBindingNavigatorSaveItem});
            this.inscricaoSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inscricaoSetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.inscricaoSetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.inscricaoSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.inscricaoSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.inscricaoSetBindingNavigator.Name = "inscricaoSetBindingNavigator";
            this.inscricaoSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.inscricaoSetBindingNavigator.Size = new System.Drawing.Size(368, 25);
            this.inscricaoSetBindingNavigator.TabIndex = 0;
            this.inscricaoSetBindingNavigator.Text = "bindingNavigator1";
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
            // inscricaoSetBindingNavigatorSaveItem
            // 
            this.inscricaoSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inscricaoSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("inscricaoSetBindingNavigatorSaveItem.Image")));
            this.inscricaoSetBindingNavigatorSaveItem.Name = "inscricaoSetBindingNavigatorSaveItem";
            this.inscricaoSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.inscricaoSetBindingNavigatorSaveItem.Text = "Save Data";
            this.inscricaoSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.inscricaoSetBindingNavigatorSaveItem_Click);
            // 
            // inscricaoSetDataGridView
            // 
            this.inscricaoSetDataGridView.AllowUserToAddRows = false;
            this.inscricaoSetDataGridView.AllowUserToDeleteRows = false;
            this.inscricaoSetDataGridView.AutoGenerateColumns = false;
            this.inscricaoSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inscricaoSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.inscricaoSetDataGridView.DataSource = this.inscricaoSetBindingSource;
            this.inscricaoSetDataGridView.Location = new System.Drawing.Point(12, 248);
            this.inscricaoSetDataGridView.Name = "inscricaoSetDataGridView";
            this.inscricaoSetDataGridView.ReadOnly = true;
            this.inscricaoSetDataGridView.Size = new System.Drawing.Size(342, 220);
            this.inscricaoSetDataGridView.TabIndex = 1;
            // 
            // confirmadaLabel
            // 
            confirmadaLabel.AutoSize = true;
            confirmadaLabel.Location = new System.Drawing.Point(6, 29);
            confirmadaLabel.Name = "confirmadaLabel";
            confirmadaLabel.Size = new System.Drawing.Size(63, 13);
            confirmadaLabel.TabIndex = 2;
            confirmadaLabel.Text = "Confirmada:";
            // 
            // confirmadaCheckBox
            // 
            this.confirmadaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.inscricaoSetBindingSource, "Confirmada", true));
            this.confirmadaCheckBox.Location = new System.Drawing.Point(75, 24);
            this.confirmadaCheckBox.Name = "confirmadaCheckBox";
            this.confirmadaCheckBox.Size = new System.Drawing.Size(104, 24);
            this.confirmadaCheckBox.TabIndex = 3;
            this.confirmadaCheckBox.UseVisualStyleBackColor = true;
            // 
            // filhoIdPessoaLabel
            // 
            filhoIdPessoaLabel.AutoSize = true;
            filhoIdPessoaLabel.Location = new System.Drawing.Point(25, 52);
            filhoIdPessoaLabel.Name = "filhoIdPessoaLabel";
            filhoIdPessoaLabel.Size = new System.Drawing.Size(44, 13);
            filhoIdPessoaLabel.TabIndex = 4;
            filhoIdPessoaLabel.Text = "Id Filho:";
            // 
            // filhoIdPessoaTextBox
            // 
            this.filhoIdPessoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscricaoSetBindingSource, "FilhoIdPessoa", true));
            this.filhoIdPessoaTextBox.Location = new System.Drawing.Point(75, 49);
            this.filhoIdPessoaTextBox.Name = "filhoIdPessoaTextBox";
            this.filhoIdPessoaTextBox.Size = new System.Drawing.Size(100, 20);
            this.filhoIdPessoaTextBox.TabIndex = 5;
            // 
            // eventoNrEventoLabel
            // 
            eventoNrEventoLabel.AutoSize = true;
            eventoNrEventoLabel.Location = new System.Drawing.Point(11, 78);
            eventoNrEventoLabel.Name = "eventoNrEventoLabel";
            eventoNrEventoLabel.Size = new System.Drawing.Size(58, 13);
            eventoNrEventoLabel.TabIndex = 6;
            eventoNrEventoLabel.Text = "Nr Evento:";
            // 
            // eventoNrEventoTextBox
            // 
            this.eventoNrEventoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscricaoSetBindingSource, "EventoNrEvento", true));
            this.eventoNrEventoTextBox.Location = new System.Drawing.Point(75, 75);
            this.eventoNrEventoTextBox.Name = "eventoNrEventoTextBox";
            this.eventoNrEventoTextBox.Size = new System.Drawing.Size(100, 20);
            this.eventoNrEventoTextBox.TabIndex = 7;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Confirmada";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Confirmada";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FilhoIdPessoa";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id Filho";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EventoNrEvento";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nr Evento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // lbFilhoEvento
            // 
            this.lbFilhoEvento.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilhoEvento.Location = new System.Drawing.Point(11, 42);
            this.lbFilhoEvento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFilhoEvento.Name = "lbFilhoEvento";
            this.lbFilhoEvento.Size = new System.Drawing.Size(343, 50);
            this.lbFilhoEvento.TabIndex = 13;
            this.lbFilhoEvento.Text = "Inscrição | Filho - Evento";
            this.lbFilhoEvento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(confirmadaLabel);
            this.groupBox1.Controls.Add(this.confirmadaCheckBox);
            this.groupBox1.Controls.Add(this.eventoNrEventoTextBox);
            this.groupBox1.Controls.Add(eventoNrEventoLabel);
            this.groupBox1.Controls.Add(filhoIdPessoaLabel);
            this.groupBox1.Controls.Add(this.filhoIdPessoaTextBox);
            this.groupBox1.Location = new System.Drawing.Point(61, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 135);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir Insrição";
            // 
            // InscricaoEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 480);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbFilhoEvento);
            this.Controls.Add(this.inscricaoSetDataGridView);
            this.Controls.Add(this.inscricaoSetBindingNavigator);
            this.Name = "InscricaoEvento";
            this.Text = "Inscricao";
            this.Load += new System.EventHandler(this.InscricaoEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaoSetBindingNavigator)).EndInit();
            this.inscricaoSetBindingNavigator.ResumeLayout(false);
            this.inscricaoSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaoSetDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BooKids_DBDataSet booKids_DBDataSet;
        private System.Windows.Forms.BindingSource inscricaoSetBindingSource;
        private BooKids_DBDataSetTableAdapters.InscricaoSetTableAdapter inscricaoSetTableAdapter;
        private BooKids_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator inscricaoSetBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton inscricaoSetBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView inscricaoSetDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.CheckBox confirmadaCheckBox;
        private System.Windows.Forms.TextBox filhoIdPessoaTextBox;
        private System.Windows.Forms.TextBox eventoNrEventoTextBox;
        private System.Windows.Forms.Label lbFilhoEvento;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}