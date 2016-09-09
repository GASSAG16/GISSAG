namespace Demo.WindowsForms.Forms
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.button1 = new System.Windows.Forms.Button();
            this.insertCoordiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insertCoordiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.insertCoordiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.idToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.coordyYToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.coordyYToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.coordyXToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.coordyXToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.insertCoordiDataGridView = new System.Windows.Forms.DataGridView();
            this.map1 = new Demo.WindowsForms.Map();
            ((System.ComponentModel.ISupportInitialize)(this.insertCoordiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertCoordiBindingNavigator)).BeginInit();
            this.insertCoordiBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insertCoordiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1035, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // insertCoordiBindingNavigator
            // 
            this.insertCoordiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.insertCoordiBindingNavigator.BindingSource = this.insertCoordiBindingSource;
            this.insertCoordiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.insertCoordiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.insertCoordiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.insertCoordiBindingNavigatorSaveItem});
            this.insertCoordiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.insertCoordiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.insertCoordiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.insertCoordiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.insertCoordiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.insertCoordiBindingNavigator.Name = "insertCoordiBindingNavigator";
            this.insertCoordiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.insertCoordiBindingNavigator.Size = new System.Drawing.Size(1122, 27);
            this.insertCoordiBindingNavigator.TabIndex = 1;
            this.insertCoordiBindingNavigator.Text = "bindingNavigator1";
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
            // insertCoordiBindingNavigatorSaveItem
            // 
            this.insertCoordiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.insertCoordiBindingNavigatorSaveItem.Enabled = false;
            this.insertCoordiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("insertCoordiBindingNavigatorSaveItem.Image")));
            this.insertCoordiBindingNavigatorSaveItem.Name = "insertCoordiBindingNavigatorSaveItem";
            this.insertCoordiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.insertCoordiBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idToolStripLabel,
            this.idToolStripTextBox,
            this.coordyYToolStripLabel,
            this.coordyYToolStripTextBox,
            this.coordyXToolStripLabel,
            this.coordyXToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 27);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1122, 27);
            this.fillToolStrip.TabIndex = 2;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // idToolStripLabel
            // 
            this.idToolStripLabel.Name = "idToolStripLabel";
            this.idToolStripLabel.Size = new System.Drawing.Size(25, 24);
            this.idToolStripLabel.Text = "Id:";
            // 
            // idToolStripTextBox
            // 
            this.idToolStripTextBox.Name = "idToolStripTextBox";
            this.idToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // coordyYToolStripLabel
            // 
            this.coordyYToolStripLabel.Name = "coordyYToolStripLabel";
            this.coordyYToolStripLabel.Size = new System.Drawing.Size(68, 24);
            this.coordyYToolStripLabel.Text = "CoordyY:";
            // 
            // coordyYToolStripTextBox
            // 
            this.coordyYToolStripTextBox.Name = "coordyYToolStripTextBox";
            this.coordyYToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // coordyXToolStripLabel
            // 
            this.coordyXToolStripLabel.Name = "coordyXToolStripLabel";
            this.coordyXToolStripLabel.Size = new System.Drawing.Size(69, 24);
            this.coordyXToolStripLabel.Text = "CoordyX:";
            // 
            // coordyXToolStripTextBox
            // 
            this.coordyXToolStripTextBox.Name = "coordyXToolStripTextBox";
            this.coordyXToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(32, 24);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click_2);
            // 
            // insertCoordiDataGridView
            // 
            this.insertCoordiDataGridView.AutoGenerateColumns = false;
            this.insertCoordiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.insertCoordiDataGridView.DataSource = this.insertCoordiBindingSource;
            this.insertCoordiDataGridView.Location = new System.Drawing.Point(523, 74);
            this.insertCoordiDataGridView.Name = "insertCoordiDataGridView";
            this.insertCoordiDataGridView.RowTemplate.Height = 24;
            this.insertCoordiDataGridView.Size = new System.Drawing.Size(365, 327);
            this.insertCoordiDataGridView.TabIndex = 3;
            // 
            // map1
            // 
            this.map1.Bearing = 0F;
            this.map1.CanDragMap = true;
            this.map1.EmptyTileColor = System.Drawing.Color.Navy;
            this.map1.GrayScaleMode = false;
            this.map1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map1.LevelsKeepInMemmory = 5;
            this.map1.Location = new System.Drawing.Point(12, 74);
            this.map1.MarkersEnabled = true;
            this.map1.MaxZoom = 2;
            this.map1.MinZoom = 2;
            this.map1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map1.Name = "map1";
            this.map1.NegativeMode = false;
            this.map1.PolygonsEnabled = true;
            this.map1.RetryLoadTile = 0;
            this.map1.RoutesEnabled = true;
            this.map1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map1.ShowTileGridLines = false;
            this.map1.Size = new System.Drawing.Size(441, 278);
            this.map1.TabIndex = 4;
            this.map1.Zoom = 0D;
            this.map1.Click += new System.EventHandler(this.map1_Click);
            this.map1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map1_MouseClick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 504);
            this.Controls.Add(this.map1);
            this.Controls.Add(this.insertCoordiDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.insertCoordiBindingNavigator);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insertCoordiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertCoordiBindingNavigator)).EndInit();
            this.insertCoordiBindingNavigator.ResumeLayout(false);
            this.insertCoordiBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insertCoordiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private Map map1;
        // private ProbvstavkaDataSet probvstavkaDataSet;
        // private ProbvstavkaDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        //private ProbvstavkaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        // private ProbvstavkaDataSetTableAdapters.InsertProbTableAdapter insertProbTableAdapter;
        //private System.Windows.Forms.BindingSource selectQuery54BindingSource;
        //// private ProbvstavkaDataSetTableAdapters.SelectQuery54TableAdapter selectQuery54TableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
        
        private System.Windows.Forms.BindingSource insertCoordiBindingSource;
       
        private System.Windows.Forms.BindingNavigator insertCoordiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton insertCoordiBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel idToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel coordyYToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox coordyYToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel coordyXToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox coordyXToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView insertCoordiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn koordiYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koordiY1DataGridViewTextBoxColumn;
        private Map map1;
      
      
        
    }
}