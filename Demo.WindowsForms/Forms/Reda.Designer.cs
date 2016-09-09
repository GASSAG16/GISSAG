
namespace Demo.WindowsForms.Forms
{
    partial class Reda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reda));
            this.gISSIGData = new Demo.WindowsForms.GISSIGData();
            this.selectPoMarshBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectPoMarshTableAdapter = new Demo.WindowsForms.GISSIGDataTableAdapters.SelectPoMarshTableAdapter();
            this.tableAdapterManager = new Demo.WindowsForms.GISSIGDataTableAdapters.TableAdapterManager();
            this.selectPoMarshBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.selectPoMarshBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.marsrutiPodrobnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marsrutiPodrobnoTableAdapter = new Demo.WindowsForms.GISSIGDataTableAdapters.MarsrutiPodrobnoTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.marsrutiPodrobnoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertMarshrutiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insertMarshrutiTableAdapter = new Demo.WindowsForms.GISSIGDataTableAdapters.InsertMarshrutiTableAdapter();
            this.marsrutiPodrobnoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.marsrutiPodrobnoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gISSIGData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPoMarshBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPoMarshBindingNavigator)).BeginInit();
            this.selectPoMarshBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marsrutiPodrobnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marsrutiPodrobnoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertMarshrutiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marsrutiPodrobnoBindingNavigator)).BeginInit();
            this.marsrutiPodrobnoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // gISSIGData
            // 
            this.gISSIGData.DataSetName = "GISSIGData";
            this.gISSIGData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectPoMarshBindingSource
            // 
            this.selectPoMarshBindingSource.DataMember = "SelectPoMarsh";
            this.selectPoMarshBindingSource.DataSource = this.gISSIGData;
            // 
            // selectPoMarshTableAdapter
            // 
            this.selectPoMarshTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ImportMarshrutaTableAdapter = null;
            this.tableAdapterManager.ImportOstanovokExcelTableAdapter = null;
            this.tableAdapterManager.MarshTableAdapter = null;
            this.tableAdapterManager.MarsrutiPodrobnoTableAdapter = null;
            this.tableAdapterManager.OpisanievidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Demo.WindowsForms.GISSIGDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // selectPoMarshBindingNavigator
            // 
            this.selectPoMarshBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.selectPoMarshBindingNavigator.BindingSource = this.selectPoMarshBindingSource;
            this.selectPoMarshBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.selectPoMarshBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.selectPoMarshBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.selectPoMarshBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.selectPoMarshBindingNavigatorSaveItem});
            this.selectPoMarshBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.selectPoMarshBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.selectPoMarshBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.selectPoMarshBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.selectPoMarshBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.selectPoMarshBindingNavigator.Name = "selectPoMarshBindingNavigator";
            this.selectPoMarshBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.selectPoMarshBindingNavigator.Size = new System.Drawing.Size(298, 27);
            this.selectPoMarshBindingNavigator.TabIndex = 0;
            this.selectPoMarshBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // selectPoMarshBindingNavigatorSaveItem
            // 
            this.selectPoMarshBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectPoMarshBindingNavigatorSaveItem.Enabled = false;
            this.selectPoMarshBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("selectPoMarshBindingNavigatorSaveItem.Image")));
            this.selectPoMarshBindingNavigatorSaveItem.Name = "selectPoMarshBindingNavigatorSaveItem";
            this.selectPoMarshBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.selectPoMarshBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // marsrutiPodrobnoBindingSource
            // 
            this.marsrutiPodrobnoBindingSource.DataMember = "MarsrutiPodrobno";
            this.marsrutiPodrobnoBindingSource.DataSource = this.gISSIGData;
            // 
            // marsrutiPodrobnoTableAdapter
            // 
            this.marsrutiPodrobnoTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1075, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // marsrutiPodrobnoDataGridView
            // 
            this.marsrutiPodrobnoDataGridView.AutoGenerateColumns = false;
            this.marsrutiPodrobnoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marsrutiPodrobnoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.marsrutiPodrobnoDataGridView.DataSource = this.marsrutiPodrobnoBindingSource;
            this.marsrutiPodrobnoDataGridView.Location = new System.Drawing.Point(12, 90);
            this.marsrutiPodrobnoDataGridView.Name = "marsrutiPodrobnoDataGridView";
            this.marsrutiPodrobnoDataGridView.RowTemplate.Height = 24;
            this.marsrutiPodrobnoDataGridView.Size = new System.Drawing.Size(1051, 196);
            this.marsrutiPodrobnoDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NMarshryt";
            this.dataGridViewTextBoxColumn2.HeaderText = "NMarshryt";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "KoordiX";
            this.dataGridViewTextBoxColumn3.HeaderText = "KoordiX";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "KoordiY";
            this.dataGridViewTextBoxColumn4.HeaderText = "KoordiY";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NameOstanovki";
            this.dataGridViewTextBoxColumn5.HeaderText = "NameOstanovki";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NameStreetOstanivki";
            this.dataGridViewTextBoxColumn6.HeaderText = "NameStreetOstanivki";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Administrati";
            this.dataGridViewTextBoxColumn7.HeaderText = "Administrati";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Raion";
            this.dataGridViewTextBoxColumn8.HeaderText = "Raion";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Pailion";
            this.dataGridViewTextBoxColumn9.HeaderText = "Pailion";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NapravDvigeniy";
            this.dataGridViewTextBoxColumn10.HeaderText = "NapravDvigeniy";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // insertMarshrutiBindingSource
            // 
            this.insertMarshrutiBindingSource.DataMember = "InsertMarshruti";
            this.insertMarshrutiBindingSource.DataSource = this.gISSIGData;
            // 
            // insertMarshrutiTableAdapter
            // 
            this.insertMarshrutiTableAdapter.ClearBeforeFill = true;
            // 
            // marsrutiPodrobnoBindingNavigator
            // 
            this.marsrutiPodrobnoBindingNavigator.AddNewItem = this.toolStripButton1;
            this.marsrutiPodrobnoBindingNavigator.BindingSource = this.marsrutiPodrobnoBindingSource;
            this.marsrutiPodrobnoBindingNavigator.CountItem = this.toolStripLabel1;
            this.marsrutiPodrobnoBindingNavigator.DeleteItem = this.toolStripButton2;
            this.marsrutiPodrobnoBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.marsrutiPodrobnoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox2,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.marsrutiPodrobnoBindingNavigatorSaveItem});
            this.marsrutiPodrobnoBindingNavigator.Location = new System.Drawing.Point(0, 51);
            this.marsrutiPodrobnoBindingNavigator.MoveFirstItem = this.toolStripButton3;
            this.marsrutiPodrobnoBindingNavigator.MoveLastItem = this.toolStripButton6;
            this.marsrutiPodrobnoBindingNavigator.MoveNextItem = this.toolStripButton5;
            this.marsrutiPodrobnoBindingNavigator.MovePreviousItem = this.toolStripButton4;
            this.marsrutiPodrobnoBindingNavigator.Name = "marsrutiPodrobnoBindingNavigator";
            this.marsrutiPodrobnoBindingNavigator.PositionItem = this.toolStripTextBox2;
            this.marsrutiPodrobnoBindingNavigator.Size = new System.Drawing.Size(298, 27);
            this.marsrutiPodrobnoBindingNavigator.TabIndex = 18;
            this.marsrutiPodrobnoBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton1.Text = "Добавить";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 24);
            this.toolStripLabel1.Text = "для {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton2.Text = "Удалить";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton3.Text = "Переместить в начало";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton4.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Положение";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 27);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton5.Text = "Переместить вперед";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton6.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // marsrutiPodrobnoBindingNavigatorSaveItem
            // 
            this.marsrutiPodrobnoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.marsrutiPodrobnoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("marsrutiPodrobnoBindingNavigatorSaveItem.Image")));
            this.marsrutiPodrobnoBindingNavigatorSaveItem.Name = "marsrutiPodrobnoBindingNavigatorSaveItem";
            this.marsrutiPodrobnoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.marsrutiPodrobnoBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // Reda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 490);
            this.Controls.Add(this.marsrutiPodrobnoBindingNavigator);
            this.Controls.Add(this.marsrutiPodrobnoDataGridView);
            this.Controls.Add(this.selectPoMarshBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reda";
            this.Text = "Reda";
            this.Load += new System.EventHandler(this.Reda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gISSIGData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPoMarshBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPoMarshBindingNavigator)).EndInit();
            this.selectPoMarshBindingNavigator.ResumeLayout(false);
            this.selectPoMarshBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marsrutiPodrobnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marsrutiPodrobnoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertMarshrutiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marsrutiPodrobnoBindingNavigator)).EndInit();
            this.marsrutiPodrobnoBindingNavigator.ResumeLayout(false);
            this.marsrutiPodrobnoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GISSIGData gISSIGData;
        private System.Windows.Forms.BindingSource selectPoMarshBindingSource;
        private WindowsForms.GISSIGDataTableAdapters.SelectPoMarshTableAdapter selectPoMarshTableAdapter;
        private WindowsForms.GISSIGDataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator selectPoMarshBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton selectPoMarshBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource marsrutiPodrobnoBindingSource;
        private WindowsForms.GISSIGDataTableAdapters.MarsrutiPodrobnoTableAdapter marsrutiPodrobnoTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView marsrutiPodrobnoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource insertMarshrutiBindingSource;
        private GISSIGDataTableAdapters.InsertMarshrutiTableAdapter insertMarshrutiTableAdapter;
        private System.Windows.Forms.BindingNavigator marsrutiPodrobnoBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton marsrutiPodrobnoBindingNavigatorSaveItem;
    }
}