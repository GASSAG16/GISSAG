namespace Demo.WindowsForms.Forms
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label nMarshrytLabel;
            System.Windows.Forms.Label koordiXLabel;
            System.Windows.Forms.Label koordiYLabel;
            System.Windows.Forms.Label nameOstanovkiLabel;
            System.Windows.Forms.Label nameStreetOstanivkiLabel;
            System.Windows.Forms.Label administratiLabel;
            System.Windows.Forms.Label raionLabel;
            System.Windows.Forms.Label pailionLabel;
            System.Windows.Forms.Label napravDvigeniyLabel;
            this.gISSIGData = new Demo.WindowsForms.GISSIGData();
            this.marsrutiPodrobnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marsrutiPodrobnoTableAdapter = new Demo.WindowsForms.GISSIGDataTableAdapters.MarsrutiPodrobnoTableAdapter();
            this.tableAdapterManager = new Demo.WindowsForms.GISSIGDataTableAdapters.TableAdapterManager();
            this.marsrutiPodrobnoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.marsrutiPodrobnoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nMarshrytTextBox = new System.Windows.Forms.TextBox();
            this.koordiXTextBox = new System.Windows.Forms.TextBox();
            this.koordiYTextBox = new System.Windows.Forms.TextBox();
            this.nameOstanovkiComboBox = new System.Windows.Forms.ComboBox();
            this.nameStreetOstanivkiTextBox = new System.Windows.Forms.TextBox();
            this.administratiTextBox = new System.Windows.Forms.TextBox();
            this.raionTextBox = new System.Windows.Forms.TextBox();
            this.pailionTextBox = new System.Windows.Forms.TextBox();
            this.napravDvigeniyTextBox = new System.Windows.Forms.TextBox();
            nMarshrytLabel = new System.Windows.Forms.Label();
            koordiXLabel = new System.Windows.Forms.Label();
            koordiYLabel = new System.Windows.Forms.Label();
            nameOstanovkiLabel = new System.Windows.Forms.Label();
            nameStreetOstanivkiLabel = new System.Windows.Forms.Label();
            administratiLabel = new System.Windows.Forms.Label();
            raionLabel = new System.Windows.Forms.Label();
            pailionLabel = new System.Windows.Forms.Label();
            napravDvigeniyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gISSIGData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marsrutiPodrobnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marsrutiPodrobnoBindingNavigator)).BeginInit();
            this.marsrutiPodrobnoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // gISSIGData
            // 
            this.gISSIGData.DataSetName = "GISSIGData";
            this.gISSIGData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ImportMarshrutaTableAdapter = null;
            this.tableAdapterManager.ImportOstanovokExcelTableAdapter = null;
            this.tableAdapterManager.MarshTableAdapter = null;
            this.tableAdapterManager.MarsrutiPodrobnoTableAdapter = this.marsrutiPodrobnoTableAdapter;
            this.tableAdapterManager.OpisanievidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Demo.WindowsForms.GISSIGDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // marsrutiPodrobnoBindingNavigator
            // 
            this.marsrutiPodrobnoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.marsrutiPodrobnoBindingNavigator.BindingSource = this.marsrutiPodrobnoBindingSource;
            this.marsrutiPodrobnoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.marsrutiPodrobnoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.marsrutiPodrobnoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.marsrutiPodrobnoBindingNavigatorSaveItem});
            this.marsrutiPodrobnoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.marsrutiPodrobnoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.marsrutiPodrobnoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.marsrutiPodrobnoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.marsrutiPodrobnoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.marsrutiPodrobnoBindingNavigator.Name = "marsrutiPodrobnoBindingNavigator";
            this.marsrutiPodrobnoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.marsrutiPodrobnoBindingNavigator.Size = new System.Drawing.Size(716, 29);
            this.marsrutiPodrobnoBindingNavigator.TabIndex = 0;
            this.marsrutiPodrobnoBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 26);
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
            // marsrutiPodrobnoBindingNavigatorSaveItem
            // 
            this.marsrutiPodrobnoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.marsrutiPodrobnoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("marsrutiPodrobnoBindingNavigatorSaveItem.Image")));
            this.marsrutiPodrobnoBindingNavigatorSaveItem.Name = "marsrutiPodrobnoBindingNavigatorSaveItem";
            this.marsrutiPodrobnoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.marsrutiPodrobnoBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.marsrutiPodrobnoBindingNavigatorSaveItem.Click += new System.EventHandler(this.marsrutiPodrobnoBindingNavigatorSaveItem_Click);
            // 
            // nMarshrytLabel
            // 
            nMarshrytLabel.AutoSize = true;
            nMarshrytLabel.Location = new System.Drawing.Point(166, 155);
            nMarshrytLabel.Name = "nMarshrytLabel";
            nMarshrytLabel.Size = new System.Drawing.Size(77, 17);
            nMarshrytLabel.TabIndex = 1;
            nMarshrytLabel.Text = "NMarshryt:";
            // 
            // nMarshrytTextBox
            // 
            this.nMarshrytTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marsrutiPodrobnoBindingSource, "NMarshryt", true));
            this.nMarshrytTextBox.Location = new System.Drawing.Point(325, 152);
            this.nMarshrytTextBox.Name = "nMarshrytTextBox";
            this.nMarshrytTextBox.Size = new System.Drawing.Size(121, 22);
            this.nMarshrytTextBox.TabIndex = 2;
            // 
            // koordiXLabel
            // 
            koordiXLabel.AutoSize = true;
            koordiXLabel.Location = new System.Drawing.Point(166, 183);
            koordiXLabel.Name = "koordiXLabel";
            koordiXLabel.Size = new System.Drawing.Size(66, 17);
            koordiXLabel.TabIndex = 3;
            koordiXLabel.Text = "Koordi X:";
            // 
            // koordiXTextBox
            // 
            this.koordiXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marsrutiPodrobnoBindingSource, "KoordiX", true));
            this.koordiXTextBox.Location = new System.Drawing.Point(325, 180);
            this.koordiXTextBox.Name = "koordiXTextBox";
            this.koordiXTextBox.Size = new System.Drawing.Size(121, 22);
            this.koordiXTextBox.TabIndex = 4;
            // 
            // koordiYLabel
            // 
            koordiYLabel.AutoSize = true;
            koordiYLabel.Location = new System.Drawing.Point(166, 211);
            koordiYLabel.Name = "koordiYLabel";
            koordiYLabel.Size = new System.Drawing.Size(66, 17);
            koordiYLabel.TabIndex = 5;
            koordiYLabel.Text = "Koordi Y:";
            // 
            // koordiYTextBox
            // 
            this.koordiYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marsrutiPodrobnoBindingSource, "KoordiY", true));
            this.koordiYTextBox.Location = new System.Drawing.Point(325, 208);
            this.koordiYTextBox.Name = "koordiYTextBox";
            this.koordiYTextBox.Size = new System.Drawing.Size(121, 22);
            this.koordiYTextBox.TabIndex = 6;
            // 
            // nameOstanovkiLabel
            // 
            nameOstanovkiLabel.AutoSize = true;
            nameOstanovkiLabel.Location = new System.Drawing.Point(166, 239);
            nameOstanovkiLabel.Name = "nameOstanovkiLabel";
            nameOstanovkiLabel.Size = new System.Drawing.Size(116, 17);
            nameOstanovkiLabel.TabIndex = 7;
            nameOstanovkiLabel.Text = "Name Ostanovki:";
            // 
            // nameOstanovkiComboBox
            // 
            this.nameOstanovkiComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marsrutiPodrobnoBindingSource, "NameOstanovki", true));
            this.nameOstanovkiComboBox.FormattingEnabled = true;
            this.nameOstanovkiComboBox.Location = new System.Drawing.Point(325, 236);
            this.nameOstanovkiComboBox.Name = "nameOstanovkiComboBox";
            this.nameOstanovkiComboBox.Size = new System.Drawing.Size(121, 24);
            this.nameOstanovkiComboBox.TabIndex = 8;
            // 
            // nameStreetOstanivkiLabel
            // 
            nameStreetOstanivkiLabel.AutoSize = true;
            nameStreetOstanivkiLabel.Location = new System.Drawing.Point(166, 270);
            nameStreetOstanivkiLabel.Name = "nameStreetOstanivkiLabel";
            nameStreetOstanivkiLabel.Size = new System.Drawing.Size(153, 17);
            nameStreetOstanivkiLabel.TabIndex = 9;
            nameStreetOstanivkiLabel.Text = "Name Street Ostanivki:";
            // 
            // nameStreetOstanivkiTextBox
            // 
            this.nameStreetOstanivkiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marsrutiPodrobnoBindingSource, "NameStreetOstanivki", true));
            this.nameStreetOstanivkiTextBox.Location = new System.Drawing.Point(325, 267);
            this.nameStreetOstanivkiTextBox.Name = "nameStreetOstanivkiTextBox";
            this.nameStreetOstanivkiTextBox.Size = new System.Drawing.Size(121, 22);
            this.nameStreetOstanivkiTextBox.TabIndex = 10;
            // 
            // administratiLabel
            // 
            administratiLabel.AutoSize = true;
            administratiLabel.Location = new System.Drawing.Point(166, 298);
            administratiLabel.Name = "administratiLabel";
            administratiLabel.Size = new System.Drawing.Size(85, 17);
            administratiLabel.TabIndex = 11;
            administratiLabel.Text = "Administrati:";
            // 
            // administratiTextBox
            // 
            this.administratiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marsrutiPodrobnoBindingSource, "Administrati", true));
            this.administratiTextBox.Location = new System.Drawing.Point(325, 295);
            this.administratiTextBox.Name = "administratiTextBox";
            this.administratiTextBox.Size = new System.Drawing.Size(121, 22);
            this.administratiTextBox.TabIndex = 12;
            // 
            // raionLabel
            // 
            raionLabel.AutoSize = true;
            raionLabel.Location = new System.Drawing.Point(166, 326);
            raionLabel.Name = "raionLabel";
            raionLabel.Size = new System.Drawing.Size(49, 17);
            raionLabel.TabIndex = 13;
            raionLabel.Text = "Raion:";
            // 
            // raionTextBox
            // 
            this.raionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marsrutiPodrobnoBindingSource, "Raion", true));
            this.raionTextBox.Location = new System.Drawing.Point(325, 323);
            this.raionTextBox.Name = "raionTextBox";
            this.raionTextBox.Size = new System.Drawing.Size(121, 22);
            this.raionTextBox.TabIndex = 14;
            // 
            // pailionLabel
            // 
            pailionLabel.AutoSize = true;
            pailionLabel.Location = new System.Drawing.Point(166, 354);
            pailionLabel.Name = "pailionLabel";
            pailionLabel.Size = new System.Drawing.Size(54, 17);
            pailionLabel.TabIndex = 15;
            pailionLabel.Text = "Pailion:";
            // 
            // pailionTextBox
            // 
            this.pailionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marsrutiPodrobnoBindingSource, "Pailion", true));
            this.pailionTextBox.Location = new System.Drawing.Point(325, 351);
            this.pailionTextBox.Name = "pailionTextBox";
            this.pailionTextBox.Size = new System.Drawing.Size(121, 22);
            this.pailionTextBox.TabIndex = 16;
            // 
            // napravDvigeniyLabel
            // 
            napravDvigeniyLabel.AutoSize = true;
            napravDvigeniyLabel.Location = new System.Drawing.Point(166, 382);
            napravDvigeniyLabel.Name = "napravDvigeniyLabel";
            napravDvigeniyLabel.Size = new System.Drawing.Size(116, 17);
            napravDvigeniyLabel.TabIndex = 17;
            napravDvigeniyLabel.Text = "Naprav Dvigeniy:";
            // 
            // napravDvigeniyTextBox
            // 
            this.napravDvigeniyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marsrutiPodrobnoBindingSource, "NapravDvigeniy", true));
            this.napravDvigeniyTextBox.Location = new System.Drawing.Point(325, 379);
            this.napravDvigeniyTextBox.Name = "napravDvigeniyTextBox";
            this.napravDvigeniyTextBox.Size = new System.Drawing.Size(121, 22);
            this.napravDvigeniyTextBox.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 470);
            this.Controls.Add(nMarshrytLabel);
            this.Controls.Add(this.nMarshrytTextBox);
            this.Controls.Add(koordiXLabel);
            this.Controls.Add(this.koordiXTextBox);
            this.Controls.Add(koordiYLabel);
            this.Controls.Add(this.koordiYTextBox);
            this.Controls.Add(nameOstanovkiLabel);
            this.Controls.Add(this.nameOstanovkiComboBox);
            this.Controls.Add(nameStreetOstanivkiLabel);
            this.Controls.Add(this.nameStreetOstanivkiTextBox);
            this.Controls.Add(administratiLabel);
            this.Controls.Add(this.administratiTextBox);
            this.Controls.Add(raionLabel);
            this.Controls.Add(this.raionTextBox);
            this.Controls.Add(pailionLabel);
            this.Controls.Add(this.pailionTextBox);
            this.Controls.Add(napravDvigeniyLabel);
            this.Controls.Add(this.napravDvigeniyTextBox);
            this.Controls.Add(this.marsrutiPodrobnoBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gISSIGData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marsrutiPodrobnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marsrutiPodrobnoBindingNavigator)).EndInit();
            this.marsrutiPodrobnoBindingNavigator.ResumeLayout(false);
            this.marsrutiPodrobnoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GISSIGData gISSIGData;
        private System.Windows.Forms.BindingSource marsrutiPodrobnoBindingSource;
        private GISSIGDataTableAdapters.MarsrutiPodrobnoTableAdapter marsrutiPodrobnoTableAdapter;
        private GISSIGDataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator marsrutiPodrobnoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton marsrutiPodrobnoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nMarshrytTextBox;
        private System.Windows.Forms.TextBox koordiXTextBox;
        private System.Windows.Forms.TextBox koordiYTextBox;
        private System.Windows.Forms.ComboBox nameOstanovkiComboBox;
        private System.Windows.Forms.TextBox nameStreetOstanivkiTextBox;
        private System.Windows.Forms.TextBox administratiTextBox;
        private System.Windows.Forms.TextBox raionTextBox;
        private System.Windows.Forms.TextBox pailionTextBox;
        private System.Windows.Forms.TextBox napravDvigeniyTextBox;
    }
}