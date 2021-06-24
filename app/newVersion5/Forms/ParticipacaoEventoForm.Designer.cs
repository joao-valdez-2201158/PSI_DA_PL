
namespace Projeto_DA_BooKids.Forms
{
    partial class ParticipacaoEventoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParticipacaoEventoForm));
            System.Windows.Forms.Label idEscolaLabel;
            System.Windows.Forms.Label nrEventoLabel;
            this.lbFilhos = new System.Windows.Forms.Label();
            this.booKids_DBDataSet = new Projeto_DA_BooKids.BooKids_DBDataSet();
            this.participacaoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.participacaoSetTableAdapter = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.ParticipacaoSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager();
            this.participacaoSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.participacaoSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.participacaoSetDataGridView = new System.Windows.Forms.DataGridView();
            this.idEscolaTextBox = new System.Windows.Forms.TextBox();
            this.nrEventoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idEscolaLabel = new System.Windows.Forms.Label();
            nrEventoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participacaoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participacaoSetBindingNavigator)).BeginInit();
            this.participacaoSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participacaoSetDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFilhos
            // 
            this.lbFilhos.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilhos.Location = new System.Drawing.Point(11, 35);
            this.lbFilhos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFilhos.Name = "lbFilhos";
            this.lbFilhos.Size = new System.Drawing.Size(384, 50);
            this.lbFilhos.TabIndex = 13;
            this.lbFilhos.Text = "Participação | Escola - Eventos";
            this.lbFilhos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // booKids_DBDataSet
            // 
            this.booKids_DBDataSet.DataSetName = "BooKids_DBDataSet";
            this.booKids_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // participacaoSetBindingSource
            // 
            this.participacaoSetBindingSource.DataMember = "ParticipacaoSet";
            this.participacaoSetBindingSource.DataSource = this.booKids_DBDataSet;
            // 
            // participacaoSetTableAdapter
            // 
            this.participacaoSetTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ParticipacaoSetTableAdapter = this.participacaoSetTableAdapter;
            this.tableAdapterManager.PessoaSet_AnimadorTableAdapter = null;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_FilhoTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.ProdutoSetTableAdapter = null;
            this.tableAdapterManager.TipoProdutoSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // participacaoSetBindingNavigator
            // 
            this.participacaoSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.participacaoSetBindingNavigator.BindingSource = this.participacaoSetBindingSource;
            this.participacaoSetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.participacaoSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.participacaoSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.participacaoSetBindingNavigatorSaveItem});
            this.participacaoSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.participacaoSetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.participacaoSetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.participacaoSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.participacaoSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.participacaoSetBindingNavigator.Name = "participacaoSetBindingNavigator";
            this.participacaoSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.participacaoSetBindingNavigator.Size = new System.Drawing.Size(407, 25);
            this.participacaoSetBindingNavigator.TabIndex = 14;
            this.participacaoSetBindingNavigator.Text = "bindingNavigator1";
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
            // participacaoSetBindingNavigatorSaveItem
            // 
            this.participacaoSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.participacaoSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("participacaoSetBindingNavigatorSaveItem.Image")));
            this.participacaoSetBindingNavigatorSaveItem.Name = "participacaoSetBindingNavigatorSaveItem";
            this.participacaoSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.participacaoSetBindingNavigatorSaveItem.Text = "Save Data";
            this.participacaoSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.participacaoSetBindingNavigatorSaveItem_Click);
            // 
            // participacaoSetDataGridView
            // 
            this.participacaoSetDataGridView.AllowUserToAddRows = false;
            this.participacaoSetDataGridView.AllowUserToDeleteRows = false;
            this.participacaoSetDataGridView.AutoGenerateColumns = false;
            this.participacaoSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.participacaoSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.participacaoSetDataGridView.DataSource = this.participacaoSetBindingSource;
            this.participacaoSetDataGridView.Location = new System.Drawing.Point(90, 230);
            this.participacaoSetDataGridView.Name = "participacaoSetDataGridView";
            this.participacaoSetDataGridView.ReadOnly = true;
            this.participacaoSetDataGridView.Size = new System.Drawing.Size(243, 220);
            this.participacaoSetDataGridView.TabIndex = 14;
            // 
            // idEscolaLabel
            // 
            idEscolaLabel.AutoSize = true;
            idEscolaLabel.Location = new System.Drawing.Point(15, 28);
            idEscolaLabel.Name = "idEscolaLabel";
            idEscolaLabel.Size = new System.Drawing.Size(54, 13);
            idEscolaLabel.TabIndex = 14;
            idEscolaLabel.Text = "Id Escola:";
            // 
            // idEscolaTextBox
            // 
            this.idEscolaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.participacaoSetBindingSource, "IdEscola", true));
            this.idEscolaTextBox.Location = new System.Drawing.Point(75, 25);
            this.idEscolaTextBox.Name = "idEscolaTextBox";
            this.idEscolaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idEscolaTextBox.TabIndex = 15;
            // 
            // nrEventoLabel
            // 
            nrEventoLabel.AutoSize = true;
            nrEventoLabel.Location = new System.Drawing.Point(11, 54);
            nrEventoLabel.Name = "nrEventoLabel";
            nrEventoLabel.Size = new System.Drawing.Size(58, 13);
            nrEventoLabel.TabIndex = 15;
            nrEventoLabel.Text = "Nr Evento:";
            // 
            // nrEventoTextBox
            // 
            this.nrEventoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.participacaoSetBindingSource, "NrEvento", true));
            this.nrEventoTextBox.Location = new System.Drawing.Point(75, 51);
            this.nrEventoTextBox.Name = "nrEventoTextBox";
            this.nrEventoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nrEventoTextBox.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nrEventoTextBox);
            this.groupBox1.Controls.Add(nrEventoLabel);
            this.groupBox1.Controls.Add(idEscolaLabel);
            this.groupBox1.Controls.Add(this.idEscolaTextBox);
            this.groupBox1.Location = new System.Drawing.Point(112, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir Participação";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdEscola";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdEscola";
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
            // ParticipacaoEventoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 462);
            this.Controls.Add(this.participacaoSetDataGridView);
            this.Controls.Add(this.participacaoSetBindingNavigator);
            this.Controls.Add(this.lbFilhos);
            this.Controls.Add(this.groupBox1);
            this.Name = "ParticipacaoEventoForm";
            this.Text = "Participacao";
            this.Load += new System.EventHandler(this.ParticipacaoEventoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participacaoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participacaoSetBindingNavigator)).EndInit();
            this.participacaoSetBindingNavigator.ResumeLayout(false);
            this.participacaoSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participacaoSetDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFilhos;
        private BooKids_DBDataSet booKids_DBDataSet;
        private System.Windows.Forms.BindingSource participacaoSetBindingSource;
        private BooKids_DBDataSetTableAdapters.ParticipacaoSetTableAdapter participacaoSetTableAdapter;
        private BooKids_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator participacaoSetBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton participacaoSetBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView participacaoSetDataGridView;
        private System.Windows.Forms.TextBox idEscolaTextBox;
        private System.Windows.Forms.TextBox nrEventoTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}