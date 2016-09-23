namespace WindowsForms.Forms
{
    partial class fmServerMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmServerMode));
            this.ssMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbImportRoutesOfTheRoute = new System.Windows.Forms.ToolStripMenuItem();
            this.lbAboitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbSpisokZadachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbSpecificRouteOfTransport = new System.Windows.Forms.ToolStripMenuItem();
            this.tbMarsh = new System.Windows.Forms.ToolStripComboBox();
            this.tbTheDirectionRoute = new System.Windows.Forms.ToolStripComboBox();
            this.lbForTheDistrict = new System.Windows.Forms.ToolStripMenuItem();
            this.lbByArea = new System.Windows.Forms.ToolStripMenuItem();
            this.lbOnStreetAvenueEtc = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbCountCoordinatPassanger = new System.Windows.Forms.Label();
            this.requestPassangerStopCountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gISSIGData = new WindowsForms.GISSIGData();
            this.lbKoordiYPassanger = new System.Windows.Forms.Label();
            this.requestPassangerStopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbKoordiXPassanger = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.requestTracksCountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbKoordiX = new System.Windows.Forms.Label();
            this.requestTracksRoutesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbKoordiY = new System.Windows.Forms.Label();
            this.lbTheNameOfTheStop = new System.Windows.Forms.Label();
            this.requestTracksRoutesTableAdapter = new WindowsForms.GISSIGDataTableAdapters.requestTracksRoutesTableAdapter();
            this.tableAdapterManager = new WindowsForms.GISSIGDataTableAdapters.TableAdapterManager();
            this.requestTracksCountTableAdapter = new WindowsForms.GISSIGDataTableAdapters.requestTracksCountTableAdapter();
            this.requestPassangerStopTableAdapter = new WindowsForms.GISSIGDataTableAdapters.requestPassangerStopTableAdapter();
            this.requestPassangerStopCountTableAdapter = new WindowsForms.GISSIGDataTableAdapters.requestPassangerStopCountTableAdapter();
            this.cbAreaPassanger = new System.Windows.Forms.CheckBox();
            this.mapen = new WindowsForms.Map();
            this.ssMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestPassangerStopCountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gISSIGData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestPassangerStopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestTracksCountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestTracksRoutesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ssMenu
            // 
            this.ssMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.lbSpisokZadachToolStripMenuItem});
            this.ssMenu.Location = new System.Drawing.Point(0, 0);
            this.ssMenu.Name = "ssMenu";
            this.ssMenu.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.ssMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ssMenu.Size = new System.Drawing.Size(1654, 32);
            this.ssMenu.TabIndex = 46;
            this.ssMenu.Text = "Меню";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbImportRoutesOfTheRoute,
            this.lbAboitToolStripMenuItem,
            this.lbExitToolStripMenuItem});
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(63, 24);
            this.toolStripMenuItem8.Text = "Меню";
            // 
            // lbImportRoutesOfTheRoute
            // 
            this.lbImportRoutesOfTheRoute.Name = "lbImportRoutesOfTheRoute";
            this.lbImportRoutesOfTheRoute.Size = new System.Drawing.Size(257, 24);
            this.lbImportRoutesOfTheRoute.Text = "Импорт трасс маршрутов";
            this.lbImportRoutesOfTheRoute.Click += new System.EventHandler(this.lbImportRoutesOfTheRoute_Click);
            // 
            // lbAboitToolStripMenuItem
            // 
            this.lbAboitToolStripMenuItem.Name = "lbAboitToolStripMenuItem";
            this.lbAboitToolStripMenuItem.Size = new System.Drawing.Size(257, 24);
            this.lbAboitToolStripMenuItem.Text = "О программе";
            this.lbAboitToolStripMenuItem.Click += new System.EventHandler(this.lbAboitToolStripMenuItem_Click);
            // 
            // lbExitToolStripMenuItem
            // 
            this.lbExitToolStripMenuItem.Name = "lbExitToolStripMenuItem";
            this.lbExitToolStripMenuItem.Size = new System.Drawing.Size(257, 24);
            this.lbExitToolStripMenuItem.Text = "Выход";
            this.lbExitToolStripMenuItem.Click += new System.EventHandler(this.lbExitToolStripMenuItem_Click);
            // 
            // lbSpisokZadachToolStripMenuItem
            // 
            this.lbSpisokZadachToolStripMenuItem.AccessibleName = "";
            this.lbSpisokZadachToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem13});
            this.lbSpisokZadachToolStripMenuItem.Name = "lbSpisokZadachToolStripMenuItem";
            this.lbSpisokZadachToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.lbSpisokZadachToolStripMenuItem.Text = "Список задач";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12});
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(619, 24);
            this.toolStripMenuItem9.Text = "Отображение остановок";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(193, 24);
            this.toolStripMenuItem10.Text = "по районам";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2});
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(193, 24);
            this.toolStripMenuItem11.Text = "по улицам";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(193, 24);
            this.toolStripMenuItem12.Text = "по всему городу";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbSpecificRouteOfTransport,
            this.lbForTheDistrict,
            this.lbByArea,
            this.lbOnStreetAvenueEtc});
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(619, 24);
            this.toolStripMenuItem13.Text = "Отображение  маршрутов городского пассажирского наземного транспорта";
            // 
            // lbSpecificRouteOfTransport
            // 
            this.lbSpecificRouteOfTransport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbMarsh,
            this.tbTheDirectionRoute});
            this.lbSpecificRouteOfTransport.Name = "lbSpecificRouteOfTransport";
            this.lbSpecificRouteOfTransport.Size = new System.Drawing.Size(332, 24);
            this.lbSpecificRouteOfTransport.Text = "Конкретный маршрут";
            // 
            // tbMarsh
            // 
            this.tbMarsh.AutoCompleteCustomSource.AddRange(new string[] {
            "//-"});
            this.tbMarsh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbMarsh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbMarsh.Items.AddRange(new object[] {
            "--------"});
            this.tbMarsh.Name = "tbMarsh";
            this.tbMarsh.Size = new System.Drawing.Size(121, 28);
            this.tbMarsh.Text = "Маршрут";
            this.tbMarsh.SelectedIndexChanged += new System.EventHandler(this.tbMarsh_SelectedIndexChanged);
            this.tbMarsh.Click += new System.EventHandler(this.tbMarsh_Click);
            // 
            // tbTheDirectionRoute
            // 
            this.tbTheDirectionRoute.AutoCompleteCustomSource.AddRange(new string[] {
            "//-"});
            this.tbTheDirectionRoute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbTheDirectionRoute.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbTheDirectionRoute.Name = "tbTheDirectionRoute";
            this.tbTheDirectionRoute.Size = new System.Drawing.Size(121, 28);
            this.tbTheDirectionRoute.Text = "Направление";
            this.tbTheDirectionRoute.SelectedIndexChanged += new System.EventHandler(this.tbTheDirectionRoute_SelectedIndexChanged);
            // 
            // lbForTheDistrict
            // 
            this.lbForTheDistrict.Name = "lbForTheDistrict";
            this.lbForTheDistrict.Size = new System.Drawing.Size(332, 24);
            this.lbForTheDistrict.Text = "Конкретный округ";
            // 
            // lbByArea
            // 
            this.lbByArea.Name = "lbByArea";
            this.lbByArea.Size = new System.Drawing.Size(332, 24);
            this.lbByArea.Text = "Конкретный район";
            // 
            // lbOnStreetAvenueEtc
            // 
            this.lbOnStreetAvenueEtc.Name = "lbOnStreetAvenueEtc";
            this.lbOnStreetAvenueEtc.Size = new System.Drawing.Size(332, 24);
            this.lbOnStreetAvenueEtc.Text = "Конкретная улица/проспект/прочее";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lbCountCoordinatPassanger);
            this.panel3.Controls.Add(this.lbKoordiYPassanger);
            this.panel3.Controls.Add(this.lbKoordiXPassanger);
            this.panel3.Controls.Add(this.lbCount);
            this.panel3.Controls.Add(this.lbKoordiX);
            this.panel3.Controls.Add(this.lbKoordiY);
            this.panel3.Location = new System.Drawing.Point(13, 844);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 56);
            this.panel3.TabIndex = 49;
            // 
            // lbCountCoordinatPassanger
            // 
            this.lbCountCoordinatPassanger.AutoSize = true;
            this.lbCountCoordinatPassanger.BackColor = System.Drawing.Color.Transparent;
            this.lbCountCoordinatPassanger.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestPassangerStopCountBindingSource, "ALL", true));
            this.lbCountCoordinatPassanger.Location = new System.Drawing.Point(278, 31);
            this.lbCountCoordinatPassanger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCountCoordinatPassanger.Name = "lbCountCoordinatPassanger";
            this.lbCountCoordinatPassanger.Size = new System.Drawing.Size(135, 22);
            this.lbCountCoordinatPassanger.TabIndex = 5;
            this.lbCountCoordinatPassanger.Text = "CountCoordinat";
            // 
            // requestPassangerStopCountBindingSource
            // 
            this.requestPassangerStopCountBindingSource.DataMember = "requestPassangerStopCount";
            this.requestPassangerStopCountBindingSource.DataSource = this.gISSIGData;
            // 
            // gISSIGData
            // 
            this.gISSIGData.DataSetName = "GISSIGData";
            this.gISSIGData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbKoordiYPassanger
            // 
            this.lbKoordiYPassanger.AutoSize = true;
            this.lbKoordiYPassanger.BackColor = System.Drawing.Color.Transparent;
            this.lbKoordiYPassanger.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestPassangerStopBindingSource, "KoordiY", true));
            this.lbKoordiYPassanger.Location = new System.Drawing.Point(141, 31);
            this.lbKoordiYPassanger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKoordiYPassanger.Name = "lbKoordiYPassanger";
            this.lbKoordiYPassanger.Size = new System.Drawing.Size(129, 22);
            this.lbKoordiYPassanger.TabIndex = 4;
            this.lbKoordiYPassanger.Text = "Координата Y";
            // 
            // requestPassangerStopBindingSource
            // 
            this.requestPassangerStopBindingSource.DataMember = "requestPassangerStop";
            this.requestPassangerStopBindingSource.DataSource = this.gISSIGData;
            // 
            // lbKoordiXPassanger
            // 
            this.lbKoordiXPassanger.AutoSize = true;
            this.lbKoordiXPassanger.BackColor = System.Drawing.Color.Transparent;
            this.lbKoordiXPassanger.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestPassangerStopBindingSource, "KoordiX", true));
            this.lbKoordiXPassanger.Location = new System.Drawing.Point(4, 31);
            this.lbKoordiXPassanger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKoordiXPassanger.Name = "lbKoordiXPassanger";
            this.lbKoordiXPassanger.Size = new System.Drawing.Size(129, 22);
            this.lbKoordiXPassanger.TabIndex = 3;
            this.lbKoordiXPassanger.Text = "Координата X";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.BackColor = System.Drawing.Color.Transparent;
            this.lbCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestTracksCountBindingSource, "Count", true));
            this.lbCount.Location = new System.Drawing.Point(278, 9);
            this.lbCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(135, 22);
            this.lbCount.TabIndex = 2;
            this.lbCount.Text = "CountCoordinat";
            // 
            // requestTracksCountBindingSource
            // 
            this.requestTracksCountBindingSource.DataMember = "requestTracksCount";
            this.requestTracksCountBindingSource.DataSource = this.gISSIGData;
            // 
            // lbKoordiX
            // 
            this.lbKoordiX.AutoSize = true;
            this.lbKoordiX.BackColor = System.Drawing.Color.Transparent;
            this.lbKoordiX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestTracksRoutesBindingSource, "KoordiX", true));
            this.lbKoordiX.Location = new System.Drawing.Point(4, 9);
            this.lbKoordiX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKoordiX.Name = "lbKoordiX";
            this.lbKoordiX.Size = new System.Drawing.Size(129, 22);
            this.lbKoordiX.TabIndex = 1;
            this.lbKoordiX.Text = "Координата X";
            // 
            // requestTracksRoutesBindingSource
            // 
            this.requestTracksRoutesBindingSource.DataMember = "requestTracksRoutes";
            this.requestTracksRoutesBindingSource.DataSource = this.gISSIGData;
            // 
            // lbKoordiY
            // 
            this.lbKoordiY.AutoSize = true;
            this.lbKoordiY.BackColor = System.Drawing.Color.Transparent;
            this.lbKoordiY.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestTracksRoutesBindingSource, "KoordiY", true));
            this.lbKoordiY.Location = new System.Drawing.Point(141, 9);
            this.lbKoordiY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKoordiY.Name = "lbKoordiY";
            this.lbKoordiY.Size = new System.Drawing.Size(129, 22);
            this.lbKoordiY.TabIndex = 0;
            this.lbKoordiY.Text = "Координата Y";
            // 
            // lbTheNameOfTheStop
            // 
            this.lbTheNameOfTheStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTheNameOfTheStop.AutoSize = true;
            this.lbTheNameOfTheStop.BackColor = System.Drawing.Color.Transparent;
            this.lbTheNameOfTheStop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestPassangerStopBindingSource, "TheNameOfTheStop", true));
            this.lbTheNameOfTheStop.Location = new System.Drawing.Point(13, 818);
            this.lbTheNameOfTheStop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTheNameOfTheStop.Name = "lbTheNameOfTheStop";
            this.lbTheNameOfTheStop.Size = new System.Drawing.Size(183, 22);
            this.lbTheNameOfTheStop.TabIndex = 6;
            this.lbTheNameOfTheStop.Text = "Название остановки";
            // 
            // requestTracksRoutesTableAdapter
            // 
            this.requestTracksRoutesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministratTableAdapter = null;
            this.tableAdapterManager.AdressOstanovkiulichaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DirectionOfRouteTableAdapter = null;
            this.tableAdapterManager.DvigenieTableAdapter = null;
            this.tableAdapterManager.GraniogrugaTableAdapter = null;
            this.tableAdapterManager.ImportMarshrutaTableAdapter = null;
            this.tableAdapterManager.ImportOstanovokExcelTableAdapter = null;
            this.tableAdapterManager.KoordiProba16TableAdapter = null;
            this.tableAdapterManager.MarshTableAdapter = null;
            this.tableAdapterManager.MarsrutiPodrobnoTableAdapter = null;
            this.tableAdapterManager.OpisanievidaTableAdapter = null;
            this.tableAdapterManager.OstanovkiTableAdapter = null;
            this.tableAdapterManager.PassagenerStopTableAdapter = null;
            this.tableAdapterManager.RaionOstanovkiTableAdapter = null;
            this.tableAdapterManager.RoutesMarshTableAdapter = null;
            this.tableAdapterManager.RouteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsForms.GISSIGDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // requestTracksCountTableAdapter
            // 
            this.requestTracksCountTableAdapter.ClearBeforeFill = true;
            // 
            // requestPassangerStopTableAdapter
            // 
            this.requestPassangerStopTableAdapter.ClearBeforeFill = true;
            // 
            // requestPassangerStopCountTableAdapter
            // 
            this.requestPassangerStopCountTableAdapter.ClearBeforeFill = true;
            // 
            // cbAreaPassanger
            // 
            this.cbAreaPassanger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAreaPassanger.AutoSize = true;
            this.cbAreaPassanger.Enabled = false;
            this.cbAreaPassanger.Location = new System.Drawing.Point(1264, 35);
            this.cbAreaPassanger.Name = "cbAreaPassanger";
            this.cbAreaPassanger.Size = new System.Drawing.Size(390, 26);
            this.cbAreaPassanger.TabIndex = 50;
            this.cbAreaPassanger.Text = "Отображение зон подхода к остан. пункту";
            this.cbAreaPassanger.UseVisualStyleBackColor = true;
            // 
            // mapen
            // 
            this.mapen.Bearing = 0F;
            this.mapen.CanDragMap = true;
            this.mapen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapen.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapen.GrayScaleMode = false;
            this.mapen.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapen.LevelsKeepInMemmory = 5;
            this.mapen.Location = new System.Drawing.Point(0, 0);
            this.mapen.Margin = new System.Windows.Forms.Padding(4);
            this.mapen.MarkersEnabled = true;
            this.mapen.MaxZoom = 2;
            this.mapen.MinZoom = 2;
            this.mapen.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapen.Name = "mapen";
            this.mapen.NegativeMode = false;
            this.mapen.PolygonsEnabled = true;
            this.mapen.RetryLoadTile = 0;
            this.mapen.RoutesEnabled = true;
            this.mapen.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapen.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapen.ShowTileGridLines = false;
            this.mapen.Size = new System.Drawing.Size(1654, 930);
            this.mapen.TabIndex = 0;
            this.mapen.Zoom = 0D;
            // 
            // fmServerMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1654, 930);
            this.Controls.Add(this.cbAreaPassanger);
            this.Controls.Add(this.lbTheNameOfTheStop);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ssMenu);
            this.Controls.Add(this.mapen);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmServerMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добро пожаловать в программу GISSAG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmServerMode_FormClosed);
            this.Load += new System.EventHandler(this.fmServerMode_Load);
            this.ssMenu.ResumeLayout(false);
            this.ssMenu.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestPassangerStopCountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gISSIGData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestPassangerStopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestTracksCountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestTracksRoutesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Map mapen;
        private System.Windows.Forms.MenuStrip ssMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem lbImportRoutesOfTheRoute;
        private System.Windows.Forms.ToolStripMenuItem lbAboitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lbExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lbSpisokZadachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem lbSpecificRouteOfTransport;
        private System.Windows.Forms.ToolStripComboBox tbMarsh;
        private System.Windows.Forms.ToolStripComboBox tbTheDirectionRoute;
        private System.Windows.Forms.ToolStripMenuItem lbForTheDistrict;
        private System.Windows.Forms.ToolStripMenuItem lbByArea;
        private System.Windows.Forms.ToolStripMenuItem lbOnStreetAvenueEtc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label lbKoordiX;
        private System.Windows.Forms.Label lbKoordiY;
        private GISSIGData gISSIGData;
        private System.Windows.Forms.BindingSource requestTracksRoutesBindingSource;
        private GISSIGDataTableAdapters.requestTracksRoutesTableAdapter requestTracksRoutesTableAdapter;
        private GISSIGDataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource requestTracksCountBindingSource;
        private GISSIGDataTableAdapters.requestTracksCountTableAdapter requestTracksCountTableAdapter;
        private System.Windows.Forms.Label lbKoordiYPassanger;
        private System.Windows.Forms.Label lbKoordiXPassanger;
        private System.Windows.Forms.Label lbCountCoordinatPassanger;
        private System.Windows.Forms.Label lbTheNameOfTheStop;
        private System.Windows.Forms.BindingSource requestPassangerStopBindingSource;
        private System.Windows.Forms.BindingSource requestPassangerStopCountBindingSource;
        private GISSIGDataTableAdapters.requestPassangerStopTableAdapter requestPassangerStopTableAdapter;
        private GISSIGDataTableAdapters.requestPassangerStopCountTableAdapter requestPassangerStopCountTableAdapter;
        private System.Windows.Forms.CheckBox cbAreaPassanger;
    }
}