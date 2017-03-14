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
            this.lbMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lbSendimage = new System.Windows.Forms.ToolStripMenuItem();
            this.lbImportRoutesOfTheRoute = new System.Windows.Forms.ToolStripMenuItem();
            this.lbAboitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTasklist = new System.Windows.Forms.ToolStripMenuItem();
            this.lbDisplayofBusStops = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTheStreets = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSelectTheStreets = new System.Windows.Forms.ToolStripComboBox();
            this.lbAreas = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSelectAreas = new System.Windows.Forms.ToolStripComboBox();
            this.lbByDistrict = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSelectByDistrict = new System.Windows.Forms.ToolStripComboBox();
            this.lbAcrossTheCity = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTheDisplayRoutesUrbanPassengerTransport = new System.Windows.Forms.ToolStripMenuItem();
            this.lbSpecificRouteOfTransport = new System.Windows.Forms.ToolStripMenuItem();
            this.tbMarsh = new System.Windows.Forms.ToolStripComboBox();
            this.tbTheDirectionRoute = new System.Windows.Forms.ToolStripComboBox();
            this.lbForTheDistrict = new System.Windows.Forms.ToolStripMenuItem();
            this.lbByArea = new System.Windows.Forms.ToolStripMenuItem();
            this.lbOnStreetAvenueEtc = new System.Windows.Forms.ToolStripMenuItem();
            this.lbCleaningLayer = new System.Windows.Forms.ToolStripMenuItem();
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
            this.cbAreaPassanger = new System.Windows.Forms.CheckBox();
            this.tbZoomUp = new System.Windows.Forms.Button();
            this.btZoomDown = new System.Windows.Forms.Button();
            this.tbBearingLeft = new System.Windows.Forms.Button();
            this.tbBearingRight = new System.Windows.Forms.Button();
            this.tbBearingReset = new System.Windows.Forms.Button();
            this.requestTracksRoutesTableAdapter = new WindowsForms.GISSIGDataTableAdapters.requestTracksRoutesTableAdapter();
            this.tableAdapterManager = new WindowsForms.GISSIGDataTableAdapters.TableAdapterManager();
            this.requestTracksCountTableAdapter = new WindowsForms.GISSIGDataTableAdapters.requestTracksCountTableAdapter();
            this.requestPassangerStopTableAdapter = new WindowsForms.GISSIGDataTableAdapters.requestPassangerStopTableAdapter();
            this.requestPassangerStopCountTableAdapter = new WindowsForms.GISSIGDataTableAdapters.requestPassangerStopCountTableAdapter();
            this.requestSelectAreasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestSelectAreasCountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestSelectByDistrictBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestSelectByDistrictCountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestDistrictPassangerStopTableAdapter = new WindowsForms.GISSIGDataTableAdapters.requestDistrictPassangerStopTableAdapter();
            this.requestDistrictPassangerStopCountTableAdapter = new WindowsForms.GISSIGDataTableAdapters.requestDistrictPassangerStopCountTableAdapter();
            this.requestDistrictPassangerEnlargementTableAdapter = new WindowsForms.GISSIGDataTableAdapters.requestDistrictPassangerEnlargementTableAdapter();
            this.requestDistrictPassangerEnlargementCountTableAdapter = new WindowsForms.GISSIGDataTableAdapters.requestDistrictPassangerEnlargementCountTableAdapter();
            this.requestCoordinatStopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestCoordinatStopTableAdapter = new WindowsForms.GISSIGDataTableAdapters.requestCoordinatStopTableAdapter();
            this.mapen = new WindowsForms.Map();
            this.ssMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestPassangerStopCountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gISSIGData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestPassangerStopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestTracksCountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestTracksRoutesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestSelectAreasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestSelectAreasCountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestSelectByDistrictBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestSelectByDistrictCountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestCoordinatStopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ssMenu
            // 
            this.ssMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbMenu,
            this.lbTasklist});
            this.ssMenu.Location = new System.Drawing.Point(0, 0);
            this.ssMenu.Name = "ssMenu";
            this.ssMenu.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.ssMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ssMenu.Size = new System.Drawing.Size(1654, 32);
            this.ssMenu.TabIndex = 46;
            this.ssMenu.Text = "Меню";
            // 
            // lbMenu
            // 
            this.lbMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbSendimage,
            this.lbImportRoutesOfTheRoute,
            this.lbAboitToolStripMenuItem,
            this.lbExitToolStripMenuItem});
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(63, 24);
            this.lbMenu.Text = "Меню";
            // 
            // lbSendimage
            // 
            this.lbSendimage.Name = "lbSendimage";
            this.lbSendimage.Size = new System.Drawing.Size(372, 24);
            this.lbSendimage.Text = "Отправить изображения на рабочий стол";
            this.lbSendimage.Click += new System.EventHandler(this.lbSendimage_Click);
            // 
            // lbImportRoutesOfTheRoute
            // 
            this.lbImportRoutesOfTheRoute.Name = "lbImportRoutesOfTheRoute";
            this.lbImportRoutesOfTheRoute.Size = new System.Drawing.Size(372, 24);
            this.lbImportRoutesOfTheRoute.Text = "Импорт трасс маршрутов";
            this.lbImportRoutesOfTheRoute.Click += new System.EventHandler(this.lbImportRoutesOfTheRoute_Click);
            // 
            // lbAboitToolStripMenuItem
            // 
            this.lbAboitToolStripMenuItem.Name = "lbAboitToolStripMenuItem";
            this.lbAboitToolStripMenuItem.Size = new System.Drawing.Size(372, 24);
            this.lbAboitToolStripMenuItem.Text = "О программе";
            this.lbAboitToolStripMenuItem.Click += new System.EventHandler(this.lbAboitToolStripMenuItem_Click);
            // 
            // lbExitToolStripMenuItem
            // 
            this.lbExitToolStripMenuItem.Name = "lbExitToolStripMenuItem";
            this.lbExitToolStripMenuItem.Size = new System.Drawing.Size(372, 24);
            this.lbExitToolStripMenuItem.Text = "Выход";
            this.lbExitToolStripMenuItem.Click += new System.EventHandler(this.lbExitToolStripMenuItem_Click);
            // 
            // lbTasklist
            // 
            this.lbTasklist.AccessibleName = "";
            this.lbTasklist.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbDisplayofBusStops,
            this.lbTheDisplayRoutesUrbanPassengerTransport,
            this.lbCleaningLayer});
            this.lbTasklist.Name = "lbTasklist";
            this.lbTasklist.Size = new System.Drawing.Size(114, 24);
            this.lbTasklist.Text = "Список задач";
            // 
            // lbDisplayofBusStops
            // 
            this.lbDisplayofBusStops.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbTheStreets,
            this.lbAreas,
            this.lbByDistrict,
            this.lbAcrossTheCity});
            this.lbDisplayofBusStops.Name = "lbDisplayofBusStops";
            this.lbDisplayofBusStops.Size = new System.Drawing.Size(615, 24);
            this.lbDisplayofBusStops.Text = "Отображение остановок транспорта";
            // 
            // lbTheStreets
            // 
            this.lbTheStreets.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbSelectTheStreets});
            this.lbTheStreets.Name = "lbTheStreets";
            this.lbTheStreets.Size = new System.Drawing.Size(193, 24);
            this.lbTheStreets.Text = "по улицам";
            // 
            // tbSelectTheStreets
            // 
            this.tbSelectTheStreets.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbSelectTheStreets.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbSelectTheStreets.Name = "tbSelectTheStreets";
            this.tbSelectTheStreets.Size = new System.Drawing.Size(121, 28);
            this.tbSelectTheStreets.Text = "Улица";
            this.tbSelectTheStreets.SelectedIndexChanged += new System.EventHandler(this.tbSelectTheStreets_SelectedIndexChanged);
            // 
            // lbAreas
            // 
            this.lbAreas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbSelectAreas});
            this.lbAreas.Name = "lbAreas";
            this.lbAreas.Size = new System.Drawing.Size(193, 24);
            this.lbAreas.Text = "по районам";
            // 
            // tbSelectAreas
            // 
            this.tbSelectAreas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbSelectAreas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbSelectAreas.Name = "tbSelectAreas";
            this.tbSelectAreas.Size = new System.Drawing.Size(121, 28);
            this.tbSelectAreas.Text = "Район";
            this.tbSelectAreas.SelectedIndexChanged += new System.EventHandler(this.tbSelectAreas_SelectedIndexChanged);
            // 
            // lbByDistrict
            // 
            this.lbByDistrict.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbSelectByDistrict});
            this.lbByDistrict.Name = "lbByDistrict";
            this.lbByDistrict.Size = new System.Drawing.Size(193, 24);
            this.lbByDistrict.Text = "по округам";
            // 
            // tbSelectByDistrict
            // 
            this.tbSelectByDistrict.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbSelectByDistrict.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbSelectByDistrict.Name = "tbSelectByDistrict";
            this.tbSelectByDistrict.Size = new System.Drawing.Size(121, 28);
            this.tbSelectByDistrict.Text = "Округ";
            this.tbSelectByDistrict.SelectedIndexChanged += new System.EventHandler(this.tbSelectByDistrict_SelectedIndexChanged);
            // 
            // lbAcrossTheCity
            // 
            this.lbAcrossTheCity.Name = "lbAcrossTheCity";
            this.lbAcrossTheCity.Size = new System.Drawing.Size(193, 24);
            this.lbAcrossTheCity.Text = "по всему городу";
            // 
            // lbTheDisplayRoutesUrbanPassengerTransport
            // 
            this.lbTheDisplayRoutesUrbanPassengerTransport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbSpecificRouteOfTransport,
            this.lbForTheDistrict,
            this.lbByArea,
            this.lbOnStreetAvenueEtc});
            this.lbTheDisplayRoutesUrbanPassengerTransport.Name = "lbTheDisplayRoutesUrbanPassengerTransport";
            this.lbTheDisplayRoutesUrbanPassengerTransport.Size = new System.Drawing.Size(615, 24);
            this.lbTheDisplayRoutesUrbanPassengerTransport.Text = "Отображение маршрутов городского пассажирского наземного транспорта";
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
            // lbCleaningLayer
            // 
            this.lbCleaningLayer.Name = "lbCleaningLayer";
            this.lbCleaningLayer.Size = new System.Drawing.Size(615, 24);
            this.lbCleaningLayer.Text = "Очистка слоя карты";
            this.lbCleaningLayer.Click += new System.EventHandler(this.lbCleaningLayer_Click);
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
            // cbAreaPassanger
            // 
            this.cbAreaPassanger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAreaPassanger.AutoSize = true;
            this.cbAreaPassanger.Location = new System.Drawing.Point(1264, 35);
            this.cbAreaPassanger.Name = "cbAreaPassanger";
            this.cbAreaPassanger.Size = new System.Drawing.Size(390, 26);
            this.cbAreaPassanger.TabIndex = 50;
            this.cbAreaPassanger.Text = "Отображение зон подхода к остан. пункту";
            this.cbAreaPassanger.UseVisualStyleBackColor = true;
            // 
            // tbZoomUp
            // 
            this.tbZoomUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbZoomUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbZoomUp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbZoomUp.Location = new System.Drawing.Point(13, 726);
            this.tbZoomUp.Margin = new System.Windows.Forms.Padding(0);
            this.tbZoomUp.Name = "tbZoomUp";
            this.tbZoomUp.Size = new System.Drawing.Size(88, 33);
            this.tbZoomUp.TabIndex = 52;
            this.tbZoomUp.Text = "Zoom +";
            this.tbZoomUp.UseVisualStyleBackColor = true;
            this.tbZoomUp.Click += new System.EventHandler(this.tbZoomUp_Click);
            // 
            // btZoomDown
            // 
            this.btZoomDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btZoomDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btZoomDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btZoomDown.Location = new System.Drawing.Point(13, 759);
            this.btZoomDown.Margin = new System.Windows.Forms.Padding(0);
            this.btZoomDown.Name = "btZoomDown";
            this.btZoomDown.Size = new System.Drawing.Size(88, 33);
            this.btZoomDown.TabIndex = 53;
            this.btZoomDown.Text = "Zoom -";
            this.btZoomDown.UseVisualStyleBackColor = true;
            this.btZoomDown.Click += new System.EventHandler(this.btZoomDown_Click);
            // 
            // tbBearingLeft
            // 
            this.tbBearingLeft.Location = new System.Drawing.Point(21, 111);
            this.tbBearingLeft.Name = "tbBearingLeft";
            this.tbBearingLeft.Size = new System.Drawing.Size(43, 31);
            this.tbBearingLeft.TabIndex = 54;
            this.tbBearingLeft.Text = "-";
            this.tbBearingLeft.UseVisualStyleBackColor = true;
            this.tbBearingLeft.Click += new System.EventHandler(this.tbBearingLeft_Click);
            // 
            // tbBearingRight
            // 
            this.tbBearingRight.Location = new System.Drawing.Point(21, 148);
            this.tbBearingRight.Name = "tbBearingRight";
            this.tbBearingRight.Size = new System.Drawing.Size(43, 31);
            this.tbBearingRight.TabIndex = 54;
            this.tbBearingRight.Text = "+";
            this.tbBearingRight.UseVisualStyleBackColor = true;
            this.tbBearingRight.Click += new System.EventHandler(this.tbBearingRight_Click);
            // 
            // tbBearingReset
            // 
            this.tbBearingReset.Location = new System.Drawing.Point(23, 185);
            this.tbBearingReset.Name = "tbBearingReset";
            this.tbBearingReset.Size = new System.Drawing.Size(41, 31);
            this.tbBearingReset.TabIndex = 56;
            this.tbBearingReset.Text = "R";
            this.tbBearingReset.UseVisualStyleBackColor = true;
            this.tbBearingReset.Click += new System.EventHandler(this.tbBearingReset_Click);
            // 
            // requestTracksRoutesTableAdapter
            // 
            this.requestTracksRoutesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministrativeDistrictsTableAdapter = null;
            this.tableAdapterManager.AdministratTableAdapter = null;
            this.tableAdapterManager.AdressOstanovkiulichaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DirectionOfRouteTableAdapter = null;
            this.tableAdapterManager.DistrictsTableAdapter = null;
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
            // requestSelectAreasBindingSource
            // 
            this.requestSelectAreasBindingSource.DataMember = "requestDistrictPassangerStop";
            this.requestSelectAreasBindingSource.DataSource = this.gISSIGData;
            // 
            // requestSelectAreasCountBindingSource
            // 
            this.requestSelectAreasCountBindingSource.DataMember = "requestDistrictPassangerStopCount";
            this.requestSelectAreasCountBindingSource.DataSource = this.gISSIGData;
            // 
            // requestSelectByDistrictBindingSource
            // 
            this.requestSelectByDistrictBindingSource.DataMember = "requestDistrictPassangerEnlargement";
            this.requestSelectByDistrictBindingSource.DataSource = this.gISSIGData;
            // 
            // requestSelectByDistrictCountBindingSource
            // 
            this.requestSelectByDistrictCountBindingSource.DataMember = "requestDistrictPassangerEnlargementCount";
            this.requestSelectByDistrictCountBindingSource.DataSource = this.gISSIGData;
            // 
            // requestDistrictPassangerStopTableAdapter
            // 
            this.requestDistrictPassangerStopTableAdapter.ClearBeforeFill = true;
            // 
            // requestDistrictPassangerStopCountTableAdapter
            // 
            this.requestDistrictPassangerStopCountTableAdapter.ClearBeforeFill = true;
            // 
            // requestDistrictPassangerEnlargementTableAdapter
            // 
            this.requestDistrictPassangerEnlargementTableAdapter.ClearBeforeFill = true;
            // 
            // requestDistrictPassangerEnlargementCountTableAdapter
            // 
            this.requestDistrictPassangerEnlargementCountTableAdapter.ClearBeforeFill = true;
            // 
            // requestCoordinatStopBindingSource
            // 
            this.requestCoordinatStopBindingSource.DataMember = "requestCoordinatStop";
            this.requestCoordinatStopBindingSource.DataSource = this.gISSIGData;
            // 
            // requestCoordinatStopTableAdapter
            // 
            this.requestCoordinatStopTableAdapter.ClearBeforeFill = true;
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
            this.Controls.Add(this.tbBearingReset);
            this.Controls.Add(this.tbBearingRight);
            this.Controls.Add(this.tbBearingLeft);
            this.Controls.Add(this.btZoomDown);
            this.Controls.Add(this.tbZoomUp);
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
            ((System.ComponentModel.ISupportInitialize)(this.requestSelectAreasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestSelectAreasCountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestSelectByDistrictBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestSelectByDistrictCountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestCoordinatStopBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Map mapen;
        private System.Windows.Forms.MenuStrip ssMenu;
        private System.Windows.Forms.ToolStripMenuItem lbMenu;
        private System.Windows.Forms.ToolStripMenuItem lbImportRoutesOfTheRoute;
        private System.Windows.Forms.ToolStripMenuItem lbAboitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lbExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lbTasklist;
        private System.Windows.Forms.ToolStripMenuItem lbDisplayofBusStops;
        private System.Windows.Forms.ToolStripMenuItem lbAreas;
        private System.Windows.Forms.ToolStripMenuItem lbTheStreets;
        private System.Windows.Forms.ToolStripMenuItem lbAcrossTheCity;
        private System.Windows.Forms.ToolStripMenuItem lbTheDisplayRoutesUrbanPassengerTransport;
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
        private System.Windows.Forms.ToolStripMenuItem lbSendimage;
        private System.Windows.Forms.ToolStripMenuItem lbByDistrict;
        private System.Windows.Forms.ToolStripComboBox tbSelectTheStreets;
        private System.Windows.Forms.ToolStripComboBox tbSelectAreas;
        private System.Windows.Forms.ToolStripComboBox tbSelectByDistrict;
        private System.Windows.Forms.ToolStripMenuItem lbCleaningLayer;
        private System.Windows.Forms.BindingSource requestSelectAreasBindingSource;
        private System.Windows.Forms.BindingSource requestSelectAreasCountBindingSource;
        private System.Windows.Forms.BindingSource requestSelectByDistrictBindingSource;
        private System.Windows.Forms.BindingSource requestSelectByDistrictCountBindingSource;
        private GISSIGDataTableAdapters.requestDistrictPassangerStopTableAdapter requestDistrictPassangerStopTableAdapter;
        private GISSIGDataTableAdapters.requestDistrictPassangerStopCountTableAdapter requestDistrictPassangerStopCountTableAdapter;
        private GISSIGDataTableAdapters.requestDistrictPassangerEnlargementTableAdapter requestDistrictPassangerEnlargementTableAdapter;
        private GISSIGDataTableAdapters.requestDistrictPassangerEnlargementCountTableAdapter requestDistrictPassangerEnlargementCountTableAdapter;
        private System.Windows.Forms.Button tbZoomUp;
        private System.Windows.Forms.Button btZoomDown;
        private System.Windows.Forms.Button tbBearingLeft;
        private System.Windows.Forms.Button tbBearingRight;
        private System.Windows.Forms.Button tbBearingReset;
        private System.Windows.Forms.BindingSource requestCoordinatStopBindingSource;
        private GISSIGDataTableAdapters.requestCoordinatStopTableAdapter requestCoordinatStopTableAdapter;
    }
}