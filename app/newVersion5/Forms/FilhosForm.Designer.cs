
namespace Projeto_DA_BooKids.Forms
{
    partial class FilhosForm
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
            System.Windows.Forms.Label idProgenitorLabel;
            System.Windows.Forms.Label dataNascimentoLabel;
            System.Windows.Forms.Label idEscolaLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label idPessoaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilhosForm));
            this.booKids_DBDataSet = new Projeto_DA_BooKids.BooKids_DBDataSet();
            this.pessoaSet_FilhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaSet_FilhoTableAdapter = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.PessoaSet_FilhoTableAdapter();
            this.tableAdapterManager = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager();
            this.idProgenitorTextBox = new System.Windows.Forms.TextBox();
            this.idEscolaTextBox = new System.Windows.Forms.TextBox();
            this.dataNascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sexoTextBox = new System.Windows.Forms.TextBox();
            this.idPessoaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.pessoaSet_FilhoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pessoaSet_FilhoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.lbFilhos = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaSet_FilhoDataGridView = new System.Windows.Forms.DataGridView();
            idProgenitorLabel = new System.Windows.Forms.Label();
            dataNascimentoLabel = new System.Windows.Forms.Label();
            idEscolaLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            idPessoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_FilhoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_FilhoBindingNavigator)).BeginInit();
            this.pessoaSet_FilhoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_FilhoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // booKids_DBDataSet
            // 
            this.booKids_DBDataSet.DataSetName = "BooKids_DBDataSet";
            this.booKids_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoaSet_FilhoBindingSource
            // 
            this.pessoaSet_FilhoBindingSource.DataMember = "PessoaSet_Filho";
            this.pessoaSet_FilhoBindingSource.DataSource = this.booKids_DBDataSet;
            // 
            // pessoaSet_FilhoTableAdapter
            // 
            this.pessoaSet_FilhoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PessoaSet_FilhoTableAdapter = this.pessoaSet_FilhoTableAdapter;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.ProdutoSetTableAdapter = null;
            this.tableAdapterManager.TipoProdutoSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idProgenitorTextBox
            // 
            this.idProgenitorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_FilhoBindingSource, "IdProgenitor", true));
            this.idProgenitorTextBox.Location = new System.Drawing.Point(118, 116);
            this.idProgenitorTextBox.Name = "idProgenitorTextBox";
            this.idProgenitorTextBox.Size = new System.Drawing.Size(100, 20);
            this.idProgenitorTextBox.TabIndex = 7;
            // 
            // idProgenitorLabel
            // 
            idProgenitorLabel.AutoSize = true;
            idProgenitorLabel.Location = new System.Drawing.Point(15, 119);
            idProgenitorLabel.Name = "idProgenitorLabel";
            idProgenitorLabel.Size = new System.Drawing.Size(70, 13);
            idProgenitorLabel.TabIndex = 6;
            idProgenitorLabel.Text = "Id Progenitor:";
            // 
            // dataNascimentoLabel
            // 
            dataNascimentoLabel.AutoSize = true;
            dataNascimentoLabel.Location = new System.Drawing.Point(15, 68);
            dataNascimentoLabel.Name = "dataNascimentoLabel";
            dataNascimentoLabel.Size = new System.Drawing.Size(92, 13);
            dataNascimentoLabel.TabIndex = 4;
            dataNascimentoLabel.Text = "Data Nascimento:";
            // 
            // idEscolaTextBox
            // 
            this.idEscolaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_FilhoBindingSource, "IdEscola", true));
            this.idEscolaTextBox.Location = new System.Drawing.Point(118, 88);
            this.idEscolaTextBox.Name = "idEscolaTextBox";
            this.idEscolaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idEscolaTextBox.TabIndex = 9;
            // 
            // dataNascimentoDateTimePicker
            // 
            this.dataNascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pessoaSet_FilhoBindingSource, "DataNascimento", true));
            this.dataNascimentoDateTimePicker.Location = new System.Drawing.Point(118, 62);
            this.dataNascimentoDateTimePicker.Name = "dataNascimentoDateTimePicker";
            this.dataNascimentoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataNascimentoDateTimePicker.TabIndex = 5;
            // 
            // idEscolaLabel
            // 
            idEscolaLabel.AutoSize = true;
            idEscolaLabel.Location = new System.Drawing.Point(15, 91);
            idEscolaLabel.Name = "idEscolaLabel";
            idEscolaLabel.Size = new System.Drawing.Size(54, 13);
            idEscolaLabel.TabIndex = 8;
            idEscolaLabel.Text = "Id Escola:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(15, 39);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(34, 13);
            sexoLabel.TabIndex = 2;
            sexoLabel.Text = "Sexo:";
            // 
            // sexoTextBox
            // 
            this.sexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_FilhoBindingSource, "Sexo", true));
            this.sexoTextBox.Location = new System.Drawing.Point(118, 36);
            this.sexoTextBox.Name = "sexoTextBox";
            this.sexoTextBox.Size = new System.Drawing.Size(100, 20);
            this.sexoTextBox.TabIndex = 3;
            // 
            // idPessoaLabel
            // 
            idPessoaLabel.AutoSize = true;
            idPessoaLabel.Location = new System.Drawing.Point(15, 145);
            idPessoaLabel.Name = "idPessoaLabel";
            idPessoaLabel.Size = new System.Drawing.Size(57, 13);
            idPessoaLabel.TabIndex = 10;
            idPessoaLabel.Text = "Id Pessoa:";
            // 
            // idPessoaTextBox
            // 
            this.idPessoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_FilhoBindingSource, "IdPessoa", true));
            this.idPessoaTextBox.Location = new System.Drawing.Point(118, 142);
            this.idPessoaTextBox.Name = "idPessoaTextBox";
            this.idPessoaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idPessoaTextBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idPessoaTextBox);
            this.groupBox1.Controls.Add(idPessoaLabel);
            this.groupBox1.Controls.Add(this.sexoTextBox);
            this.groupBox1.Controls.Add(sexoLabel);
            this.groupBox1.Controls.Add(idEscolaLabel);
            this.groupBox1.Controls.Add(this.dataNascimentoDateTimePicker);
            this.groupBox1.Controls.Add(this.idEscolaTextBox);
            this.groupBox1.Controls.Add(dataNascimentoLabel);
            this.groupBox1.Controls.Add(idProgenitorLabel);
            this.groupBox1.Controls.Add(this.idProgenitorTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 183);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir Filho";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // pessoaSet_FilhoBindingNavigatorSaveItem
            // 
            this.pessoaSet_FilhoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pessoaSet_FilhoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pessoaSet_FilhoBindingNavigatorSaveItem.Image")));
            this.pessoaSet_FilhoBindingNavigatorSaveItem.Name = "pessoaSet_FilhoBindingNavigatorSaveItem";
            this.pessoaSet_FilhoBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.pessoaSet_FilhoBindingNavigatorSaveItem.Text = "Save Data";
            this.pessoaSet_FilhoBindingNavigatorSaveItem.Click += new System.EventHandler(this.pessoaSet_FilhoBindingNavigatorSaveItem_Click);
            // 
            // pessoaSet_FilhoBindingNavigator
            // 
            this.pessoaSet_FilhoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pessoaSet_FilhoBindingNavigator.BindingSource = this.pessoaSet_FilhoBindingSource;
            this.pessoaSet_FilhoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pessoaSet_FilhoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pessoaSet_FilhoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pessoaSet_FilhoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pessoaSet_FilhoBindingNavigatorSaveItem});
            this.pessoaSet_FilhoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pessoaSet_FilhoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pessoaSet_FilhoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pessoaSet_FilhoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pessoaSet_FilhoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pessoaSet_FilhoBindingNavigator.Name = "pessoaSet_FilhoBindingNavigator";
            this.pessoaSet_FilhoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pessoaSet_FilhoBindingNavigator.Size = new System.Drawing.Size(580, 27);
            this.pessoaSet_FilhoBindingNavigator.TabIndex = 0;
            this.pessoaSet_FilhoBindingNavigator.Text = "bindingNavigator1";
            // 
            // lbFilhos
            // 
            this.lbFilhos.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilhos.Location = new System.Drawing.Point(11, 36);
            this.lbFilhos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFilhos.Name = "lbFilhos";
            this.lbFilhos.Size = new System.Drawing.Size(549, 50);
            this.lbFilhos.TabIndex = 12;
            this.lbFilhos.Text = "Filhos";
            this.lbFilhos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IdPessoa";
            this.dataGridViewTextBoxColumn8.HeaderText = "IdPessoa";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdEscola";
            this.dataGridViewTextBoxColumn7.HeaderText = "IdEscola";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdProgenitor";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdProgenitor";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DataNascimento";
            this.dataGridViewTextBoxColumn5.HeaderText = "DataNascimento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Sexo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Sexo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // pessoaSet_FilhoDataGridView
            // 
            this.pessoaSet_FilhoDataGridView.AutoGenerateColumns = false;
            this.pessoaSet_FilhoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pessoaSet_FilhoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.pessoaSet_FilhoDataGridView.DataSource = this.pessoaSet_FilhoBindingSource;
            this.pessoaSet_FilhoDataGridView.Location = new System.Drawing.Point(18, 304);
            this.pessoaSet_FilhoDataGridView.Name = "pessoaSet_FilhoDataGridView";
            this.pessoaSet_FilhoDataGridView.Size = new System.Drawing.Size(543, 220);
            this.pessoaSet_FilhoDataGridView.TabIndex = 13;
            // 
            // FilhosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 541);
            this.Controls.Add(this.pessoaSet_FilhoDataGridView);
            this.Controls.Add(this.lbFilhos);
            this.Controls.Add(this.pessoaSet_FilhoBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FilhosForm";
            this.Text = "Filhos";
            this.Load += new System.EventHandler(this.FilhosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_FilhoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_FilhoBindingNavigator)).EndInit();
            this.pessoaSet_FilhoBindingNavigator.ResumeLayout(false);
            this.pessoaSet_FilhoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_FilhoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BooKids_DBDataSet booKids_DBDataSet;
        private System.Windows.Forms.BindingSource pessoaSet_FilhoBindingSource;
        private BooKids_DBDataSetTableAdapters.PessoaSet_FilhoTableAdapter pessoaSet_FilhoTableAdapter;
        private BooKids_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox idProgenitorTextBox;
        private System.Windows.Forms.TextBox idEscolaTextBox;
        private System.Windows.Forms.DateTimePicker dataNascimentoDateTimePicker;
        private System.Windows.Forms.TextBox sexoTextBox;
        private System.Windows.Forms.TextBox idPessoaTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton pessoaSet_FilhoBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator pessoaSet_FilhoBindingNavigator;
        private System.Windows.Forms.Label lbFilhos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView pessoaSet_FilhoDataGridView;
    }
}