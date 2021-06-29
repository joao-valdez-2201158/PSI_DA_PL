
namespace Projeto_DA_BooKids.Forms
{
    partial class EventosForm
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
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label localLabel;
            System.Windows.Forms.Label dataHoraLabel;
            System.Windows.Forms.Label limiteParticipacaoLabel;
            System.Windows.Forms.Label idadeInferiorLabel;
            System.Windows.Forms.Label idadeSuperiorLabel;
            System.Windows.Forms.Label tipoEventoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventosForm));
            this.lbEventos = new System.Windows.Forms.Label();
            this.booKids_DBDataSet = new Projeto_DA_BooKids.BooKids_DBDataSet();
            this.eventoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventoSetTableAdapter = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.EventoSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager();
            this.eventoSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.eventoSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eventoSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.localTextBox = new System.Windows.Forms.TextBox();
            this.dataHoraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.limiteParticipacaoTextBox = new System.Windows.Forms.TextBox();
            this.idadeInferiorTextBox = new System.Windows.Forms.TextBox();
            this.idadeSuperiorTextBox = new System.Windows.Forms.TextBox();
            this.tipoEventoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_Participacao = new System.Windows.Forms.Button();
            this.BTN_Inscricao = new System.Windows.Forms.Button();
            this.BTN_Colaboracao = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BTN_Exportar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            descricaoLabel = new System.Windows.Forms.Label();
            localLabel = new System.Windows.Forms.Label();
            dataHoraLabel = new System.Windows.Forms.Label();
            limiteParticipacaoLabel = new System.Windows.Forms.Label();
            idadeInferiorLabel = new System.Windows.Forms.Label();
            idadeSuperiorLabel = new System.Windows.Forms.Label();
            tipoEventoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoSetBindingNavigator)).BeginInit();
            this.eventoSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventoSetDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(52, 26);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 9;
            descricaoLabel.Text = "Descricao:";
            // 
            // localLabel
            // 
            localLabel.AutoSize = true;
            localLabel.Location = new System.Drawing.Point(74, 111);
            localLabel.Name = "localLabel";
            localLabel.Size = new System.Drawing.Size(36, 13);
            localLabel.TabIndex = 10;
            localLabel.Text = "Local:";
            // 
            // dataHoraLabel
            // 
            dataHoraLabel.AutoSize = true;
            dataHoraLabel.Location = new System.Drawing.Point(51, 140);
            dataHoraLabel.Name = "dataHoraLabel";
            dataHoraLabel.Size = new System.Drawing.Size(59, 13);
            dataHoraLabel.TabIndex = 11;
            dataHoraLabel.Text = "Data Hora:";
            // 
            // limiteParticipacaoLabel
            // 
            limiteParticipacaoLabel.AutoSize = true;
            limiteParticipacaoLabel.Location = new System.Drawing.Point(15, 163);
            limiteParticipacaoLabel.Name = "limiteParticipacaoLabel";
            limiteParticipacaoLabel.Size = new System.Drawing.Size(99, 13);
            limiteParticipacaoLabel.TabIndex = 12;
            limiteParticipacaoLabel.Text = "Limite Participacao:";
            // 
            // idadeInferiorLabel
            // 
            idadeInferiorLabel.AutoSize = true;
            idadeInferiorLabel.Location = new System.Drawing.Point(42, 189);
            idadeInferiorLabel.Name = "idadeInferiorLabel";
            idadeInferiorLabel.Size = new System.Drawing.Size(72, 13);
            idadeInferiorLabel.TabIndex = 13;
            idadeInferiorLabel.Text = "Idade Inferior:";
            // 
            // idadeSuperiorLabel
            // 
            idadeSuperiorLabel.AutoSize = true;
            idadeSuperiorLabel.Location = new System.Drawing.Point(230, 189);
            idadeSuperiorLabel.Name = "idadeSuperiorLabel";
            idadeSuperiorLabel.Size = new System.Drawing.Size(79, 13);
            idadeSuperiorLabel.TabIndex = 14;
            idadeSuperiorLabel.Text = "Idade Superior:";
            // 
            // tipoEventoLabel
            // 
            tipoEventoLabel.AutoSize = true;
            tipoEventoLabel.Location = new System.Drawing.Point(42, 215);
            tipoEventoLabel.Name = "tipoEventoLabel";
            tipoEventoLabel.Size = new System.Drawing.Size(68, 13);
            tipoEventoLabel.TabIndex = 15;
            tipoEventoLabel.Text = "Tipo Evento:";
            // 
            // lbEventos
            // 
            this.lbEventos.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventos.Location = new System.Drawing.Point(11, 39);
            this.lbEventos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEventos.Name = "lbEventos";
            this.lbEventos.Size = new System.Drawing.Size(667, 50);
            this.lbEventos.TabIndex = 8;
            this.lbEventos.Text = "Eventos";
            this.lbEventos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // booKids_DBDataSet
            // 
            this.booKids_DBDataSet.DataSetName = "BooKids_DBDataSet";
            this.booKids_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventoSetBindingSource
            // 
            this.eventoSetBindingSource.DataMember = "EventoSet";
            this.eventoSetBindingSource.DataSource = this.booKids_DBDataSet;
            // 
            // eventoSetTableAdapter
            // 
            this.eventoSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColaboracaoSetTableAdapter = null;
            this.tableAdapterManager.CompraSetTableAdapter = null;
            this.tableAdapterManager.DetalheCompraSetTableAdapter = null;
            this.tableAdapterManager.EscolaSetTableAdapter = null;
            this.tableAdapterManager.EventoSetTableAdapter = this.eventoSetTableAdapter;
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
            // eventoSetBindingNavigator
            // 
            this.eventoSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eventoSetBindingNavigator.BindingSource = this.eventoSetBindingSource;
            this.eventoSetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eventoSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eventoSetBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.eventoSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eventoSetBindingNavigatorSaveItem});
            this.eventoSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eventoSetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eventoSetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eventoSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eventoSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eventoSetBindingNavigator.Name = "eventoSetBindingNavigator";
            this.eventoSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eventoSetBindingNavigator.Size = new System.Drawing.Size(689, 27);
            this.eventoSetBindingNavigator.TabIndex = 9;
            this.eventoSetBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // eventoSetBindingNavigatorSaveItem
            // 
            this.eventoSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eventoSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eventoSetBindingNavigatorSaveItem.Image")));
            this.eventoSetBindingNavigatorSaveItem.Name = "eventoSetBindingNavigatorSaveItem";
            this.eventoSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.eventoSetBindingNavigatorSaveItem.Text = "Save Data";
            this.eventoSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.eventoSetBindingNavigatorSaveItem_Click);
            // 
            // eventoSetDataGridView
            // 
            this.eventoSetDataGridView.AllowUserToAddRows = false;
            this.eventoSetDataGridView.AllowUserToDeleteRows = false;
            this.eventoSetDataGridView.AutoGenerateColumns = false;
            this.eventoSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventoSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.eventoSetDataGridView.DataSource = this.eventoSetBindingSource;
            this.eventoSetDataGridView.Location = new System.Drawing.Point(30, 352);
            this.eventoSetDataGridView.Name = "eventoSetDataGridView";
            this.eventoSetDataGridView.ReadOnly = true;
            this.eventoSetDataGridView.RowHeadersWidth = 51;
            this.eventoSetDataGridView.Size = new System.Drawing.Size(630, 195);
            this.eventoSetDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NrEvento";
            this.dataGridViewTextBoxColumn1.HeaderText = "NrEvento";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Local";
            this.dataGridViewTextBoxColumn3.HeaderText = "Local";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataHora";
            this.dataGridViewTextBoxColumn4.HeaderText = "DataHora";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LimiteParticipacao";
            this.dataGridViewTextBoxColumn5.HeaderText = "LimiteParticipacao";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdadeInferior";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdadeInferior";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdadeSuperior";
            this.dataGridViewTextBoxColumn7.HeaderText = "IdadeSuperior";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TipoEvento";
            this.dataGridViewTextBoxColumn8.HeaderText = "TipoEvento";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoSetBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(120, 23);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(295, 79);
            this.descricaoTextBox.TabIndex = 10;
            // 
            // localTextBox
            // 
            this.localTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoSetBindingSource, "Local", true));
            this.localTextBox.Location = new System.Drawing.Point(120, 108);
            this.localTextBox.Name = "localTextBox";
            this.localTextBox.Size = new System.Drawing.Size(295, 20);
            this.localTextBox.TabIndex = 11;
            // 
            // dataHoraDateTimePicker
            // 
            this.dataHoraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventoSetBindingSource, "DataHora", true));
            this.dataHoraDateTimePicker.Location = new System.Drawing.Point(120, 134);
            this.dataHoraDateTimePicker.Name = "dataHoraDateTimePicker";
            this.dataHoraDateTimePicker.Size = new System.Drawing.Size(295, 20);
            this.dataHoraDateTimePicker.TabIndex = 12;
            // 
            // limiteParticipacaoTextBox
            // 
            this.limiteParticipacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoSetBindingSource, "LimiteParticipacao", true));
            this.limiteParticipacaoTextBox.Location = new System.Drawing.Point(120, 160);
            this.limiteParticipacaoTextBox.MaxLength = 4;
            this.limiteParticipacaoTextBox.Name = "limiteParticipacaoTextBox";
            this.limiteParticipacaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.limiteParticipacaoTextBox.TabIndex = 13;
            // 
            // idadeInferiorTextBox
            // 
            this.idadeInferiorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoSetBindingSource, "IdadeInferior", true));
            this.idadeInferiorTextBox.Location = new System.Drawing.Point(120, 186);
            this.idadeInferiorTextBox.MaxLength = 2;
            this.idadeInferiorTextBox.Name = "idadeInferiorTextBox";
            this.idadeInferiorTextBox.Size = new System.Drawing.Size(100, 20);
            this.idadeInferiorTextBox.TabIndex = 14;
            // 
            // idadeSuperiorTextBox
            // 
            this.idadeSuperiorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoSetBindingSource, "IdadeSuperior", true));
            this.idadeSuperiorTextBox.Location = new System.Drawing.Point(315, 186);
            this.idadeSuperiorTextBox.MaxLength = 3;
            this.idadeSuperiorTextBox.Name = "idadeSuperiorTextBox";
            this.idadeSuperiorTextBox.Size = new System.Drawing.Size(100, 20);
            this.idadeSuperiorTextBox.TabIndex = 15;
            // 
            // tipoEventoTextBox
            // 
            this.tipoEventoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoSetBindingSource, "TipoEvento", true));
            this.tipoEventoTextBox.Location = new System.Drawing.Point(120, 212);
            this.tipoEventoTextBox.Name = "tipoEventoTextBox";
            this.tipoEventoTextBox.Size = new System.Drawing.Size(100, 20);
            this.tipoEventoTextBox.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(tipoEventoLabel);
            this.groupBox1.Controls.Add(this.idadeSuperiorTextBox);
            this.groupBox1.Controls.Add(this.tipoEventoTextBox);
            this.groupBox1.Controls.Add(this.descricaoTextBox);
            this.groupBox1.Controls.Add(idadeSuperiorLabel);
            this.groupBox1.Controls.Add(descricaoLabel);
            this.groupBox1.Controls.Add(this.localTextBox);
            this.groupBox1.Controls.Add(idadeInferiorLabel);
            this.groupBox1.Controls.Add(localLabel);
            this.groupBox1.Controls.Add(this.idadeInferiorTextBox);
            this.groupBox1.Controls.Add(this.dataHoraDateTimePicker);
            this.groupBox1.Controls.Add(limiteParticipacaoLabel);
            this.groupBox1.Controls.Add(dataHoraLabel);
            this.groupBox1.Controls.Add(this.limiteParticipacaoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(30, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 247);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir Evento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_Participacao);
            this.groupBox2.Controls.Add(this.BTN_Inscricao);
            this.groupBox2.Controls.Add(this.BTN_Colaboracao);
            this.groupBox2.Location = new System.Drawing.Point(478, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 152);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalhar Evento";
            // 
            // BTN_Participacao
            // 
            this.BTN_Participacao.Location = new System.Drawing.Point(6, 117);
            this.BTN_Participacao.Name = "BTN_Participacao";
            this.BTN_Participacao.Size = new System.Drawing.Size(170, 29);
            this.BTN_Participacao.TabIndex = 17;
            this.BTN_Participacao.Text = "Inserir Participação";
            this.BTN_Participacao.UseVisualStyleBackColor = true;
            this.BTN_Participacao.Click += new System.EventHandler(this.BTN_Participacao_Click);
            // 
            // BTN_Inscricao
            // 
            this.BTN_Inscricao.Location = new System.Drawing.Point(6, 71);
            this.BTN_Inscricao.Name = "BTN_Inscricao";
            this.BTN_Inscricao.Size = new System.Drawing.Size(170, 29);
            this.BTN_Inscricao.TabIndex = 16;
            this.BTN_Inscricao.Text = "Inserir Inscrição";
            this.BTN_Inscricao.UseVisualStyleBackColor = true;
            this.BTN_Inscricao.Click += new System.EventHandler(this.BTN_Inscricao_Click);
            // 
            // BTN_Colaboracao
            // 
            this.BTN_Colaboracao.Location = new System.Drawing.Point(6, 24);
            this.BTN_Colaboracao.Name = "BTN_Colaboracao";
            this.BTN_Colaboracao.Size = new System.Drawing.Size(170, 29);
            this.BTN_Colaboracao.TabIndex = 15;
            this.BTN_Colaboracao.Text = "Inserir Colaboração";
            this.BTN_Colaboracao.UseVisualStyleBackColor = true;
            this.BTN_Colaboracao.Click += new System.EventHandler(this.BTN_Colaboracao_Click);
            // 
            // BTN_Exportar
            // 
            this.BTN_Exportar.Location = new System.Drawing.Point(6, 29);
            this.BTN_Exportar.Name = "BTN_Exportar";
            this.BTN_Exportar.Size = new System.Drawing.Size(170, 29);
            this.BTN_Exportar.TabIndex = 14;
            this.BTN_Exportar.Text = "Exportar";
            this.BTN_Exportar.UseVisualStyleBackColor = true;
            this.BTN_Exportar.Click += new System.EventHandler(this.BTN_Exportar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BTN_Exportar);
            this.groupBox3.Location = new System.Drawing.Point(478, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 87);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exportar para PDF";
            // 
            // EventosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 576);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.eventoSetDataGridView);
            this.Controls.Add(this.eventoSetBindingNavigator);
            this.Controls.Add(this.lbEventos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EventosForm";
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.EventosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoSetBindingNavigator)).EndInit();
            this.eventoSetBindingNavigator.ResumeLayout(false);
            this.eventoSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventoSetDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEventos;
        private BooKids_DBDataSet booKids_DBDataSet;
        private System.Windows.Forms.BindingSource eventoSetBindingSource;
        private BooKids_DBDataSetTableAdapters.EventoSetTableAdapter eventoSetTableAdapter;
        private BooKids_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eventoSetBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton eventoSetBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView eventoSetDataGridView;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox localTextBox;
        private System.Windows.Forms.DateTimePicker dataHoraDateTimePicker;
        private System.Windows.Forms.TextBox limiteParticipacaoTextBox;
        private System.Windows.Forms.TextBox idadeInferiorTextBox;
        private System.Windows.Forms.TextBox idadeSuperiorTextBox;
        private System.Windows.Forms.TextBox tipoEventoTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BTN_Participacao;
        private System.Windows.Forms.Button BTN_Inscricao;
        private System.Windows.Forms.Button BTN_Colaboracao;
        private System.Windows.Forms.Button BTN_Exportar;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}