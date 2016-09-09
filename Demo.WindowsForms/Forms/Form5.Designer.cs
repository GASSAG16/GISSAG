namespace Demo.WindowsForms.Forms
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label koordiXLabel;
            System.Windows.Forms.Label koordiYLabel;
            this.dataProbaDataSet = new Demo.WindowsForms.DataProbaDataSet();
            this.insertretBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insertretTableAdapter = new Demo.WindowsForms.DataProbaDataSetTableAdapters.InsertretTableAdapter();
            this.tableAdapterManager = new Demo.WindowsForms.DataProbaDataSetTableAdapters.TableAdapterManager();
            this.insertretBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.insertretBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.koordiXToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.koordiXToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.koordiYToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.koordiYToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.koordiXTextBox = new System.Windows.Forms.TextBox();
            this.koordiYTextBox = new System.Windows.Forms.TextBox();
            this.insertretDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordiProbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coordiProbTableAdapter = new Demo.WindowsForms.DataProbaDataSetTableAdapters.CoordiProbTableAdapter();
            this.coordiProbDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            koordiXLabel = new System.Windows.Forms.Label();
            koordiYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataProbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertretBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertretBindingNavigator)).BeginInit();
            this.insertretBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insertretDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordiProbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordiProbDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataProbaDataSet
            // 
            this.dataProbaDataSet.DataSetName = "DataProbaDataSet";
            this.dataProbaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insertretBindingSource
            // 
            this.insertretBindingSource.DataMember = "Insertret";
            this.insertretBindingSource.DataSource = this.dataProbaDataSet;
            // 
            // insertretTableAdapter
            // 
            this.insertretTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoordiProbTableAdapter = this.coordiProbTableAdapter;
            this.tableAdapterManager.UpdateOrder = Demo.WindowsForms.DataProbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // insertretBindingNavigator
            // 
            this.insertretBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.insertretBindingNavigator.BindingSource = this.insertretBindingSource;
            this.insertretBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.insertretBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.insertretBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.insertretBindingNavigatorSaveItem});
            this.insertretBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.insertretBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.insertretBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.insertretBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.insertretBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.insertretBindingNavigator.Name = "insertretBindingNavigator";
            this.insertretBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.insertretBindingNavigator.Size = new System.Drawing.Size(716, 27);
            this.insertretBindingNavigator.TabIndex = 0;
            this.insertretBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // insertretBindingNavigatorSaveItem
            // 
            this.insertretBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.insertretBindingNavigatorSaveItem.Enabled = false;
            this.insertretBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("insertretBindingNavigatorSaveItem.Image")));
            this.insertretBindingNavigatorSaveItem.Name = "insertretBindingNavigatorSaveItem";
            this.insertretBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.insertretBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.koordiXToolStripLabel,
            this.koordiXToolStripTextBox,
            this.koordiYToolStripLabel,
            this.koordiYToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 27);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(716, 27);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // koordiXToolStripLabel
            // 
            this.koordiXToolStripLabel.Name = "koordiXToolStripLabel";
            this.koordiXToolStripLabel.Size = new System.Drawing.Size(66, 22);
            this.koordiXToolStripLabel.Text = "KoordiX:";
            // 
            // koordiXToolStripTextBox
            // 
            this.koordiXToolStripTextBox.Name = "koordiXToolStripTextBox";
            this.koordiXToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // koordiYToolStripLabel
            // 
            this.koordiYToolStripLabel.Name = "koordiYToolStripLabel";
            this.koordiYToolStripLabel.Size = new System.Drawing.Size(65, 20);
            this.koordiYToolStripLabel.Text = "KoordiY:";
            // 
            // koordiYToolStripTextBox
            // 
            this.koordiYToolStripTextBox.Name = "koordiYToolStripTextBox";
            this.koordiYToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(32, 24);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // koordiXLabel
            // 
            koordiXLabel.AutoSize = true;
            koordiXLabel.Location = new System.Drawing.Point(413, 139);
            koordiXLabel.Name = "koordiXLabel";
            koordiXLabel.Size = new System.Drawing.Size(66, 17);
            koordiXLabel.TabIndex = 4;
            koordiXLabel.Text = "Koordi X:";
            // 
            // koordiXTextBox
            // 
            this.koordiXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.insertretBindingSource, "KoordiX", true));
            this.koordiXTextBox.Location = new System.Drawing.Point(485, 136);
            this.koordiXTextBox.Name = "koordiXTextBox";
            this.koordiXTextBox.Size = new System.Drawing.Size(100, 22);
            this.koordiXTextBox.TabIndex = 5;
            // 
            // koordiYLabel
            // 
            koordiYLabel.AutoSize = true;
            koordiYLabel.Location = new System.Drawing.Point(413, 167);
            koordiYLabel.Name = "koordiYLabel";
            koordiYLabel.Size = new System.Drawing.Size(66, 17);
            koordiYLabel.TabIndex = 6;
            koordiYLabel.Text = "Koordi Y:";
            // 
            // koordiYTextBox
            // 
            this.koordiYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.insertretBindingSource, "KoordiY", true));
            this.koordiYTextBox.Location = new System.Drawing.Point(485, 164);
            this.koordiYTextBox.Name = "koordiYTextBox";
            this.koordiYTextBox.Size = new System.Drawing.Size(100, 22);
            this.koordiYTextBox.TabIndex = 7;
            // 
            // insertretDataGridView
            // 
            this.insertretDataGridView.AutoGenerateColumns = false;
            this.insertretDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.insertretDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.insertretDataGridView.DataSource = this.insertretBindingSource;
            this.insertretDataGridView.Location = new System.Drawing.Point(12, 69);
            this.insertretDataGridView.Name = "insertretDataGridView";
            this.insertretDataGridView.RowTemplate.Height = 24;
            this.insertretDataGridView.Size = new System.Drawing.Size(350, 220);
            this.insertretDataGridView.TabIndex = 8;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KoordiX";
            this.dataGridViewTextBoxColumn2.HeaderText = "KoordiX";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "KoordiY";
            this.dataGridViewTextBoxColumn3.HeaderText = "KoordiY";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // coordiProbBindingSource
            // 
            this.coordiProbBindingSource.DataMember = "CoordiProb";
            this.coordiProbBindingSource.DataSource = this.dataProbaDataSet;
            // 
            // coordiProbTableAdapter
            // 
            this.coordiProbTableAdapter.ClearBeforeFill = true;
            // 
            // coordiProbDataGridView
            // 
            this.coordiProbDataGridView.AutoGenerateColumns = false;
            this.coordiProbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coordiProbDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.coordiProbDataGridView.DataSource = this.coordiProbBindingSource;
            this.coordiProbDataGridView.Location = new System.Drawing.Point(385, 224);
            this.coordiProbDataGridView.Name = "coordiProbDataGridView";
            this.coordiProbDataGridView.RowTemplate.Height = 24;
            this.coordiProbDataGridView.Size = new System.Drawing.Size(300, 220);
            this.coordiProbDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn4.HeaderText = "id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "KoordiX";
            this.dataGridViewTextBoxColumn5.HeaderText = "KoordiX";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "KoordiY";
            this.dataGridViewTextBoxColumn6.HeaderText = "KoordiY";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 588);
            this.Controls.Add(this.coordiProbDataGridView);
            this.Controls.Add(this.insertretDataGridView);
            this.Controls.Add(koordiXLabel);
            this.Controls.Add(this.koordiXTextBox);
            this.Controls.Add(koordiYLabel);
            this.Controls.Add(this.koordiYTextBox);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.insertretBindingNavigator);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertretBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertretBindingNavigator)).EndInit();
            this.insertretBindingNavigator.ResumeLayout(false);
            this.insertretBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insertretDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordiProbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordiProbDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataProbaDataSet dataProbaDataSet;
        private System.Windows.Forms.BindingSource insertretBindingSource;
        private DataProbaDataSetTableAdapters.InsertretTableAdapter insertretTableAdapter;
        private DataProbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator insertretBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton insertretBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel koordiXToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox koordiXToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel koordiYToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox koordiYToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.TextBox koordiXTextBox;
        private System.Windows.Forms.TextBox koordiYTextBox;
        private System.Windows.Forms.DataGridView insertretDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataProbaDataSetTableAdapters.CoordiProbTableAdapter coordiProbTableAdapter;
        private System.Windows.Forms.BindingSource coordiProbBindingSource;
        private System.Windows.Forms.DataGridView coordiProbDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}