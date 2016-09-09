namespace Demo.WindowsForms.Source
{
    partial class Form7
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
            this.gISSIGData = new Demo.WindowsForms.GISSIGData();
            this.insertKoordiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insertKoordiTableAdapter = new Demo.WindowsForms.GISSIGDataTableAdapters.InsertKoordiTableAdapter();
            this.tableAdapterManager = new Demo.WindowsForms.GISSIGDataTableAdapters.TableAdapterManager();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.map1 = new Demo.WindowsForms.Map();
            ((System.ComponentModel.ISupportInitialize)(this.gISSIGData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertKoordiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gISSIGData
            // 
            this.gISSIGData.DataSetName = "GISSIGData";
            this.gISSIGData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insertKoordiBindingSource
            // 
            this.insertKoordiBindingSource.DataMember = "InsertKoordi";
            this.insertKoordiBindingSource.DataSource = this.gISSIGData;
            // 
            // insertKoordiTableAdapter
            // 
            this.insertKoordiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministratTableAdapter = null;
            this.tableAdapterManager.AdressOstanovkiulichaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GraniogrugaTableAdapter = null;
            this.tableAdapterManager.ImportMarshrutaTableAdapter = null;
            this.tableAdapterManager.ImportOstanovokExcelTableAdapter = null;
            this.tableAdapterManager.KoordiProba16TableAdapter = null;
            this.tableAdapterManager.MarshTableAdapter = null;
            this.tableAdapterManager.MarsrutiPodrobnoTableAdapter = null;
            this.tableAdapterManager.OpisanievidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Demo.WindowsForms.GISSIGDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "YES";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // map1
            // 
            this.map1.Bearing = 0F;
            this.map1.CanDragMap = true;
            this.map1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map1.EmptyTileColor = System.Drawing.Color.Navy;
            this.map1.GrayScaleMode = false;
            this.map1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map1.LevelsKeepInMemmory = 5;
            this.map1.Location = new System.Drawing.Point(0, 0);
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
            this.map1.Size = new System.Drawing.Size(868, 474);
            this.map1.TabIndex = 0;
            this.map1.Zoom = 0D;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.map1);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.gISSIGData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertKoordiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GISSIGData gISSIGData;
        private System.Windows.Forms.BindingSource insertKoordiBindingSource;
        private GISSIGDataTableAdapters.InsertKoordiTableAdapter insertKoordiTableAdapter;
        private GISSIGDataTableAdapters.TableAdapterManager tableAdapterManager;
        private Map map1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        
    }
}