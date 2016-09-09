namespace Demo.WindowsForms.Forms
{
    partial class otrabotka_oblasti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(otrabotka_oblasti));
            this.label1 = new System.Windows.Forms.Label();
            this.importOstanovokExcelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.importOstanovokExcelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.skalarVsegoZnachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gISSIGData = new Demo.WindowsForms.GISSIGData();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.scalarPoiskPoUlichambindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.scalarVsegoZnachPoUlchamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.skalarPoiskPoRaiony1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.skalarVsegoZnachPoRaionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.importOstanovokExcelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.importOstanovokExcelTableAdapter1 = new Demo.WindowsForms.GISSIGDataTableAdapters.ImportOstanovokExcelTableAdapter();
            this.tableAdapterManager = new Demo.WindowsForms.GISSIGDataTableAdapters.TableAdapterManager();
            this.skalarVsegoZnachTableAdapter = new Demo.WindowsForms.GISSIGDataTableAdapters.SkalarVsegoZnachTableAdapter();
            this.skalarPoiskPoRaionyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.skalarPoiskPoRaionyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skalarPoiskPoRaiony1TableAdapter1 = new Demo.WindowsForms.GISSIGDataTableAdapters.SkalarPoiskPoRaiony1TableAdapter();
            this.skalarVsegoZnachPoRaionTableAdapter = new Demo.WindowsForms.GISSIGDataTableAdapters.SkalarVsegoZnachPoRaionTableAdapter();
            this.scalarPoiskPoUlichamTableAdapter = new Demo.WindowsForms.GISSIGDataTableAdapters.ScalarPoiskPoUlichamTableAdapter();
            this.scalarVsegoZnachPoUlchamTableAdapter = new Demo.WindowsForms.GISSIGDataTableAdapters.ScalarVsegoZnachPoUlchamTableAdapter();
            this.mapen = new Demo.WindowsForms.Map();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.importOstanovokExcelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importOstanovokExcelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skalarVsegoZnachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gISSIGData)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scalarPoiskPoUlichambindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scalarVsegoZnachPoUlchamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skalarPoiskPoRaiony1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skalarVsegoZnachPoRaionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importOstanovokExcelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skalarPoiskPoRaionyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skalarPoiskPoRaionyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importOstanovokExcelBindingSource, "KoordiX", true));
            this.label1.Name = "label1";
            // 
            // importOstanovokExcelBindingSource
            // 
            this.importOstanovokExcelBindingSource.DataMember = "ImportOstanovokExcel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importOstanovokExcelBindingSource, "KoordiY", true));
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importOstanovokExcelBindingSource, "NameOstanovki", true));
            this.label3.Name = "label3";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // importOstanovokExcelBindingSource2
            // 
            this.importOstanovokExcelBindingSource2.DataMember = "ImportOstanovokExcel";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skalarVsegoZnachBindingSource, "VsegoZnach", true));
            this.label4.Name = "label4";
            // 
            // skalarVsegoZnachBindingSource
            // 
            this.skalarVsegoZnachBindingSource.DataMember = "SkalarVsegoZnach";
            this.skalarVsegoZnachBindingSource.DataSource = this.gISSIGData;
            // 
            // gISSIGData
            // 
            this.gISSIGData.DataSetName = "GISSIGData";
            this.gISSIGData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skalarVsegoZnachBindingSource, "VsegoZnach", true));
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scalarPoiskPoUlichambindingSource, "NameOstanovki", true));
            this.label12.Name = "label12";
            // 
            // scalarPoiskPoUlichambindingSource
            // 
            this.scalarPoiskPoUlichambindingSource.DataMember = "ScalarPoiskPoUlicham";
            this.scalarPoiskPoUlichambindingSource.DataSource = this.gISSIGData;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scalarPoiskPoUlichambindingSource, "KoordiY", true));
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scalarPoiskPoUlichambindingSource, "KoordiX", true));
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scalarVsegoZnachPoUlchamBindingSource, "Expr1", true));
            this.label15.Name = "label15";
            // 
            // scalarVsegoZnachPoUlchamBindingSource
            // 
            this.scalarVsegoZnachPoUlchamBindingSource.DataMember = "ScalarVsegoZnachPoUlcham";
            this.scalarVsegoZnachPoUlchamBindingSource.DataSource = this.gISSIGData;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skalarPoiskPoRaiony1BindingSource, "NameOstanovki", true));
            this.label11.Name = "label11";
            // 
            // skalarPoiskPoRaiony1BindingSource
            // 
            this.skalarPoiskPoRaiony1BindingSource.DataMember = "SkalarPoiskPoRaiony1";
            this.skalarPoiskPoRaiony1BindingSource.DataSource = this.gISSIGData;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skalarPoiskPoRaiony1BindingSource, "KoordiY", true));
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skalarPoiskPoRaiony1BindingSource, "KoordiX", true));
            this.label10.Name = "label10";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skalarVsegoZnachPoRaionBindingSource, "Expr1", true));
            this.label8.Name = "label8";
            // 
            // skalarVsegoZnachPoRaionBindingSource
            // 
            this.skalarVsegoZnachPoRaionBindingSource.DataMember = "SkalarVsegoZnachPoRaion";
            this.skalarVsegoZnachPoRaionBindingSource.DataSource = this.gISSIGData;
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.MouseLeave += new System.EventHandler(this.textBox3_MouseLeave);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // comboBox2
            // 
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            resources.GetString("comboBox2.Items"),
            resources.GetString("comboBox2.Items1"),
            resources.GetString("comboBox2.Items2"),
            resources.GetString("comboBox2.Items3"),
            resources.GetString("comboBox2.Items4"),
            resources.GetString("comboBox2.Items5"),
            resources.GetString("comboBox2.Items6"),
            resources.GetString("comboBox2.Items7"),
            resources.GetString("comboBox2.Items8"),
            resources.GetString("comboBox2.Items9"),
            resources.GetString("comboBox2.Items10"),
            resources.GetString("comboBox2.Items11"),
            resources.GetString("comboBox2.Items12"),
            resources.GetString("comboBox2.Items13"),
            resources.GetString("comboBox2.Items14"),
            resources.GetString("comboBox2.Items15"),
            resources.GetString("comboBox2.Items16"),
            resources.GetString("comboBox2.Items17"),
            resources.GetString("comboBox2.Items18"),
            resources.GetString("comboBox2.Items19"),
            resources.GetString("comboBox2.Items20"),
            resources.GetString("comboBox2.Items21"),
            resources.GetString("comboBox2.Items22"),
            resources.GetString("comboBox2.Items23"),
            resources.GetString("comboBox2.Items24"),
            resources.GetString("comboBox2.Items25"),
            resources.GetString("comboBox2.Items26"),
            resources.GetString("comboBox2.Items27"),
            resources.GetString("comboBox2.Items28"),
            resources.GetString("comboBox2.Items29"),
            resources.GetString("comboBox2.Items30"),
            resources.GetString("comboBox2.Items31"),
            resources.GetString("comboBox2.Items32"),
            resources.GetString("comboBox2.Items33"),
            resources.GetString("comboBox2.Items34"),
            resources.GetString("comboBox2.Items35"),
            resources.GetString("comboBox2.Items36"),
            resources.GetString("comboBox2.Items37"),
            resources.GetString("comboBox2.Items38"),
            resources.GetString("comboBox2.Items39"),
            resources.GetString("comboBox2.Items40"),
            resources.GetString("comboBox2.Items41"),
            resources.GetString("comboBox2.Items42"),
            resources.GetString("comboBox2.Items43"),
            resources.GetString("comboBox2.Items44"),
            resources.GetString("comboBox2.Items45"),
            resources.GetString("comboBox2.Items46"),
            resources.GetString("comboBox2.Items47"),
            resources.GetString("comboBox2.Items48"),
            resources.GetString("comboBox2.Items49"),
            resources.GetString("comboBox2.Items50"),
            resources.GetString("comboBox2.Items51"),
            resources.GetString("comboBox2.Items52"),
            resources.GetString("comboBox2.Items53"),
            resources.GetString("comboBox2.Items54"),
            resources.GetString("comboBox2.Items55"),
            resources.GetString("comboBox2.Items56"),
            resources.GetString("comboBox2.Items57"),
            resources.GetString("comboBox2.Items58"),
            resources.GetString("comboBox2.Items59"),
            resources.GetString("comboBox2.Items60"),
            resources.GetString("comboBox2.Items61"),
            resources.GetString("comboBox2.Items62"),
            resources.GetString("comboBox2.Items63"),
            resources.GetString("comboBox2.Items64"),
            resources.GetString("comboBox2.Items65"),
            resources.GetString("comboBox2.Items66"),
            resources.GetString("comboBox2.Items67"),
            resources.GetString("comboBox2.Items68"),
            resources.GetString("comboBox2.Items69"),
            resources.GetString("comboBox2.Items70"),
            resources.GetString("comboBox2.Items71"),
            resources.GetString("comboBox2.Items72"),
            resources.GetString("comboBox2.Items73"),
            resources.GetString("comboBox2.Items74"),
            resources.GetString("comboBox2.Items75"),
            resources.GetString("comboBox2.Items76"),
            resources.GetString("comboBox2.Items77"),
            resources.GetString("comboBox2.Items78"),
            resources.GetString("comboBox2.Items79"),
            resources.GetString("comboBox2.Items80"),
            resources.GetString("comboBox2.Items81"),
            resources.GetString("comboBox2.Items82"),
            resources.GetString("comboBox2.Items83"),
            resources.GetString("comboBox2.Items84"),
            resources.GetString("comboBox2.Items85"),
            resources.GetString("comboBox2.Items86"),
            resources.GetString("comboBox2.Items87"),
            resources.GetString("comboBox2.Items88"),
            resources.GetString("comboBox2.Items89"),
            resources.GetString("comboBox2.Items90"),
            resources.GetString("comboBox2.Items91"),
            resources.GetString("comboBox2.Items92"),
            resources.GetString("comboBox2.Items93"),
            resources.GetString("comboBox2.Items94"),
            resources.GetString("comboBox2.Items95"),
            resources.GetString("comboBox2.Items96"),
            resources.GetString("comboBox2.Items97"),
            resources.GetString("comboBox2.Items98"),
            resources.GetString("comboBox2.Items99"),
            resources.GetString("comboBox2.Items100"),
            resources.GetString("comboBox2.Items101"),
            resources.GetString("comboBox2.Items102"),
            resources.GetString("comboBox2.Items103"),
            resources.GetString("comboBox2.Items104"),
            resources.GetString("comboBox2.Items105"),
            resources.GetString("comboBox2.Items106"),
            resources.GetString("comboBox2.Items107"),
            resources.GetString("comboBox2.Items108"),
            resources.GetString("comboBox2.Items109"),
            resources.GetString("comboBox2.Items110"),
            resources.GetString("comboBox2.Items111"),
            resources.GetString("comboBox2.Items112"),
            resources.GetString("comboBox2.Items113"),
            resources.GetString("comboBox2.Items114"),
            resources.GetString("comboBox2.Items115"),
            resources.GetString("comboBox2.Items116"),
            resources.GetString("comboBox2.Items117"),
            resources.GetString("comboBox2.Items118"),
            resources.GetString("comboBox2.Items119"),
            resources.GetString("comboBox2.Items120"),
            resources.GetString("comboBox2.Items121"),
            resources.GetString("comboBox2.Items122"),
            resources.GetString("comboBox2.Items123"),
            resources.GetString("comboBox2.Items124"),
            resources.GetString("comboBox2.Items125"),
            resources.GetString("comboBox2.Items126"),
            resources.GetString("comboBox2.Items127"),
            resources.GetString("comboBox2.Items128"),
            resources.GetString("comboBox2.Items129"),
            resources.GetString("comboBox2.Items130"),
            resources.GetString("comboBox2.Items131"),
            resources.GetString("comboBox2.Items132"),
            resources.GetString("comboBox2.Items133"),
            resources.GetString("comboBox2.Items134"),
            resources.GetString("comboBox2.Items135"),
            resources.GetString("comboBox2.Items136"),
            resources.GetString("comboBox2.Items137"),
            resources.GetString("comboBox2.Items138"),
            resources.GetString("comboBox2.Items139"),
            resources.GetString("comboBox2.Items140"),
            resources.GetString("comboBox2.Items141"),
            resources.GetString("comboBox2.Items142"),
            resources.GetString("comboBox2.Items143"),
            resources.GetString("comboBox2.Items144"),
            resources.GetString("comboBox2.Items145"),
            resources.GetString("comboBox2.Items146"),
            resources.GetString("comboBox2.Items147"),
            resources.GetString("comboBox2.Items148"),
            resources.GetString("comboBox2.Items149"),
            resources.GetString("comboBox2.Items150"),
            resources.GetString("comboBox2.Items151"),
            resources.GetString("comboBox2.Items152"),
            resources.GetString("comboBox2.Items153"),
            resources.GetString("comboBox2.Items154"),
            resources.GetString("comboBox2.Items155"),
            resources.GetString("comboBox2.Items156"),
            resources.GetString("comboBox2.Items157"),
            resources.GetString("comboBox2.Items158"),
            resources.GetString("comboBox2.Items159"),
            resources.GetString("comboBox2.Items160"),
            resources.GetString("comboBox2.Items161"),
            resources.GetString("comboBox2.Items162"),
            resources.GetString("comboBox2.Items163"),
            resources.GetString("comboBox2.Items164"),
            resources.GetString("comboBox2.Items165"),
            resources.GetString("comboBox2.Items166"),
            resources.GetString("comboBox2.Items167"),
            resources.GetString("comboBox2.Items168"),
            resources.GetString("comboBox2.Items169"),
            resources.GetString("comboBox2.Items170"),
            resources.GetString("comboBox2.Items171"),
            resources.GetString("comboBox2.Items172"),
            resources.GetString("comboBox2.Items173"),
            resources.GetString("comboBox2.Items174"),
            resources.GetString("comboBox2.Items175"),
            resources.GetString("comboBox2.Items176"),
            resources.GetString("comboBox2.Items177"),
            resources.GetString("comboBox2.Items178"),
            resources.GetString("comboBox2.Items179"),
            resources.GetString("comboBox2.Items180"),
            resources.GetString("comboBox2.Items181"),
            resources.GetString("comboBox2.Items182"),
            resources.GetString("comboBox2.Items183"),
            resources.GetString("comboBox2.Items184"),
            resources.GetString("comboBox2.Items185"),
            resources.GetString("comboBox2.Items186"),
            resources.GetString("comboBox2.Items187"),
            resources.GetString("comboBox2.Items188"),
            resources.GetString("comboBox2.Items189"),
            resources.GetString("comboBox2.Items190"),
            resources.GetString("comboBox2.Items191"),
            resources.GetString("comboBox2.Items192"),
            resources.GetString("comboBox2.Items193"),
            resources.GetString("comboBox2.Items194"),
            resources.GetString("comboBox2.Items195"),
            resources.GetString("comboBox2.Items196"),
            resources.GetString("comboBox2.Items197"),
            resources.GetString("comboBox2.Items198"),
            resources.GetString("comboBox2.Items199"),
            resources.GetString("comboBox2.Items200"),
            resources.GetString("comboBox2.Items201"),
            resources.GetString("comboBox2.Items202"),
            resources.GetString("comboBox2.Items203"),
            resources.GetString("comboBox2.Items204"),
            resources.GetString("comboBox2.Items205"),
            resources.GetString("comboBox2.Items206"),
            resources.GetString("comboBox2.Items207"),
            resources.GetString("comboBox2.Items208"),
            resources.GetString("comboBox2.Items209"),
            resources.GetString("comboBox2.Items210"),
            resources.GetString("comboBox2.Items211"),
            resources.GetString("comboBox2.Items212"),
            resources.GetString("comboBox2.Items213"),
            resources.GetString("comboBox2.Items214"),
            resources.GetString("comboBox2.Items215"),
            resources.GetString("comboBox2.Items216"),
            resources.GetString("comboBox2.Items217"),
            resources.GetString("comboBox2.Items218"),
            resources.GetString("comboBox2.Items219"),
            resources.GetString("comboBox2.Items220"),
            resources.GetString("comboBox2.Items221"),
            resources.GetString("comboBox2.Items222"),
            resources.GetString("comboBox2.Items223"),
            resources.GetString("comboBox2.Items224"),
            resources.GetString("comboBox2.Items225"),
            resources.GetString("comboBox2.Items226"),
            resources.GetString("comboBox2.Items227"),
            resources.GetString("comboBox2.Items228"),
            resources.GetString("comboBox2.Items229"),
            resources.GetString("comboBox2.Items230"),
            resources.GetString("comboBox2.Items231"),
            resources.GetString("comboBox2.Items232"),
            resources.GetString("comboBox2.Items233"),
            resources.GetString("comboBox2.Items234"),
            resources.GetString("comboBox2.Items235"),
            resources.GetString("comboBox2.Items236"),
            resources.GetString("comboBox2.Items237"),
            resources.GetString("comboBox2.Items238"),
            resources.GetString("comboBox2.Items239"),
            resources.GetString("comboBox2.Items240"),
            resources.GetString("comboBox2.Items241"),
            resources.GetString("comboBox2.Items242"),
            resources.GetString("comboBox2.Items243"),
            resources.GetString("comboBox2.Items244"),
            resources.GetString("comboBox2.Items245"),
            resources.GetString("comboBox2.Items246"),
            resources.GetString("comboBox2.Items247"),
            resources.GetString("comboBox2.Items248"),
            resources.GetString("comboBox2.Items249"),
            resources.GetString("comboBox2.Items250"),
            resources.GetString("comboBox2.Items251"),
            resources.GetString("comboBox2.Items252"),
            resources.GetString("comboBox2.Items253"),
            resources.GetString("comboBox2.Items254"),
            resources.GetString("comboBox2.Items255"),
            resources.GetString("comboBox2.Items256"),
            resources.GetString("comboBox2.Items257"),
            resources.GetString("comboBox2.Items258"),
            resources.GetString("comboBox2.Items259"),
            resources.GetString("comboBox2.Items260"),
            resources.GetString("comboBox2.Items261"),
            resources.GetString("comboBox2.Items262"),
            resources.GetString("comboBox2.Items263"),
            resources.GetString("comboBox2.Items264"),
            resources.GetString("comboBox2.Items265"),
            resources.GetString("comboBox2.Items266"),
            resources.GetString("comboBox2.Items267"),
            resources.GetString("comboBox2.Items268"),
            resources.GetString("comboBox2.Items269"),
            resources.GetString("comboBox2.Items270"),
            resources.GetString("comboBox2.Items271"),
            resources.GetString("comboBox2.Items272"),
            resources.GetString("comboBox2.Items273"),
            resources.GetString("comboBox2.Items274"),
            resources.GetString("comboBox2.Items275"),
            resources.GetString("comboBox2.Items276"),
            resources.GetString("comboBox2.Items277"),
            resources.GetString("comboBox2.Items278"),
            resources.GetString("comboBox2.Items279"),
            resources.GetString("comboBox2.Items280"),
            resources.GetString("comboBox2.Items281"),
            resources.GetString("comboBox2.Items282"),
            resources.GetString("comboBox2.Items283"),
            resources.GetString("comboBox2.Items284"),
            resources.GetString("comboBox2.Items285"),
            resources.GetString("comboBox2.Items286"),
            resources.GetString("comboBox2.Items287"),
            resources.GetString("comboBox2.Items288"),
            resources.GetString("comboBox2.Items289"),
            resources.GetString("comboBox2.Items290"),
            resources.GetString("comboBox2.Items291"),
            resources.GetString("comboBox2.Items292"),
            resources.GetString("comboBox2.Items293"),
            resources.GetString("comboBox2.Items294"),
            resources.GetString("comboBox2.Items295"),
            resources.GetString("comboBox2.Items296"),
            resources.GetString("comboBox2.Items297"),
            resources.GetString("comboBox2.Items298"),
            resources.GetString("comboBox2.Items299"),
            resources.GetString("comboBox2.Items300"),
            resources.GetString("comboBox2.Items301"),
            resources.GetString("comboBox2.Items302"),
            resources.GetString("comboBox2.Items303"),
            resources.GetString("comboBox2.Items304"),
            resources.GetString("comboBox2.Items305"),
            resources.GetString("comboBox2.Items306"),
            resources.GetString("comboBox2.Items307"),
            resources.GetString("comboBox2.Items308"),
            resources.GetString("comboBox2.Items309"),
            resources.GetString("comboBox2.Items310"),
            resources.GetString("comboBox2.Items311"),
            resources.GetString("comboBox2.Items312"),
            resources.GetString("comboBox2.Items313"),
            resources.GetString("comboBox2.Items314"),
            resources.GetString("comboBox2.Items315"),
            resources.GetString("comboBox2.Items316"),
            resources.GetString("comboBox2.Items317"),
            resources.GetString("comboBox2.Items318"),
            resources.GetString("comboBox2.Items319"),
            resources.GetString("comboBox2.Items320"),
            resources.GetString("comboBox2.Items321"),
            resources.GetString("comboBox2.Items322"),
            resources.GetString("comboBox2.Items323"),
            resources.GetString("comboBox2.Items324"),
            resources.GetString("comboBox2.Items325"),
            resources.GetString("comboBox2.Items326"),
            resources.GetString("comboBox2.Items327"),
            resources.GetString("comboBox2.Items328"),
            resources.GetString("comboBox2.Items329"),
            resources.GetString("comboBox2.Items330"),
            resources.GetString("comboBox2.Items331"),
            resources.GetString("comboBox2.Items332"),
            resources.GetString("comboBox2.Items333"),
            resources.GetString("comboBox2.Items334"),
            resources.GetString("comboBox2.Items335"),
            resources.GetString("comboBox2.Items336"),
            resources.GetString("comboBox2.Items337"),
            resources.GetString("comboBox2.Items338"),
            resources.GetString("comboBox2.Items339"),
            resources.GetString("comboBox2.Items340"),
            resources.GetString("comboBox2.Items341"),
            resources.GetString("comboBox2.Items342"),
            resources.GetString("comboBox2.Items343"),
            resources.GetString("comboBox2.Items344"),
            resources.GetString("comboBox2.Items345"),
            resources.GetString("comboBox2.Items346"),
            resources.GetString("comboBox2.Items347"),
            resources.GetString("comboBox2.Items348"),
            resources.GetString("comboBox2.Items349"),
            resources.GetString("comboBox2.Items350"),
            resources.GetString("comboBox2.Items351"),
            resources.GetString("comboBox2.Items352"),
            resources.GetString("comboBox2.Items353"),
            resources.GetString("comboBox2.Items354"),
            resources.GetString("comboBox2.Items355"),
            resources.GetString("comboBox2.Items356"),
            resources.GetString("comboBox2.Items357"),
            resources.GetString("comboBox2.Items358"),
            resources.GetString("comboBox2.Items359"),
            resources.GetString("comboBox2.Items360"),
            resources.GetString("comboBox2.Items361"),
            resources.GetString("comboBox2.Items362"),
            resources.GetString("comboBox2.Items363"),
            resources.GetString("comboBox2.Items364"),
            resources.GetString("comboBox2.Items365"),
            resources.GetString("comboBox2.Items366"),
            resources.GetString("comboBox2.Items367"),
            resources.GetString("comboBox2.Items368"),
            resources.GetString("comboBox2.Items369"),
            resources.GetString("comboBox2.Items370"),
            resources.GetString("comboBox2.Items371"),
            resources.GetString("comboBox2.Items372"),
            resources.GetString("comboBox2.Items373"),
            resources.GetString("comboBox2.Items374"),
            resources.GetString("comboBox2.Items375"),
            resources.GetString("comboBox2.Items376"),
            resources.GetString("comboBox2.Items377"),
            resources.GetString("comboBox2.Items378"),
            resources.GetString("comboBox2.Items379"),
            resources.GetString("comboBox2.Items380"),
            resources.GetString("comboBox2.Items381"),
            resources.GetString("comboBox2.Items382"),
            resources.GetString("comboBox2.Items383"),
            resources.GetString("comboBox2.Items384"),
            resources.GetString("comboBox2.Items385"),
            resources.GetString("comboBox2.Items386"),
            resources.GetString("comboBox2.Items387"),
            resources.GetString("comboBox2.Items388"),
            resources.GetString("comboBox2.Items389"),
            resources.GetString("comboBox2.Items390"),
            resources.GetString("comboBox2.Items391"),
            resources.GetString("comboBox2.Items392"),
            resources.GetString("comboBox2.Items393"),
            resources.GetString("comboBox2.Items394"),
            resources.GetString("comboBox2.Items395"),
            resources.GetString("comboBox2.Items396"),
            resources.GetString("comboBox2.Items397"),
            resources.GetString("comboBox2.Items398"),
            resources.GetString("comboBox2.Items399"),
            resources.GetString("comboBox2.Items400"),
            resources.GetString("comboBox2.Items401"),
            resources.GetString("comboBox2.Items402"),
            resources.GetString("comboBox2.Items403"),
            resources.GetString("comboBox2.Items404"),
            resources.GetString("comboBox2.Items405"),
            resources.GetString("comboBox2.Items406"),
            resources.GetString("comboBox2.Items407"),
            resources.GetString("comboBox2.Items408"),
            resources.GetString("comboBox2.Items409"),
            resources.GetString("comboBox2.Items410"),
            resources.GetString("comboBox2.Items411"),
            resources.GetString("comboBox2.Items412"),
            resources.GetString("comboBox2.Items413"),
            resources.GetString("comboBox2.Items414"),
            resources.GetString("comboBox2.Items415"),
            resources.GetString("comboBox2.Items416"),
            resources.GetString("comboBox2.Items417"),
            resources.GetString("comboBox2.Items418"),
            resources.GetString("comboBox2.Items419"),
            resources.GetString("comboBox2.Items420"),
            resources.GetString("comboBox2.Items421"),
            resources.GetString("comboBox2.Items422"),
            resources.GetString("comboBox2.Items423"),
            resources.GetString("comboBox2.Items424"),
            resources.GetString("comboBox2.Items425"),
            resources.GetString("comboBox2.Items426"),
            resources.GetString("comboBox2.Items427"),
            resources.GetString("comboBox2.Items428"),
            resources.GetString("comboBox2.Items429"),
            resources.GetString("comboBox2.Items430"),
            resources.GetString("comboBox2.Items431"),
            resources.GetString("comboBox2.Items432"),
            resources.GetString("comboBox2.Items433"),
            resources.GetString("comboBox2.Items434"),
            resources.GetString("comboBox2.Items435"),
            resources.GetString("comboBox2.Items436"),
            resources.GetString("comboBox2.Items437"),
            resources.GetString("comboBox2.Items438"),
            resources.GetString("comboBox2.Items439"),
            resources.GetString("comboBox2.Items440"),
            resources.GetString("comboBox2.Items441"),
            resources.GetString("comboBox2.Items442"),
            resources.GetString("comboBox2.Items443"),
            resources.GetString("comboBox2.Items444"),
            resources.GetString("comboBox2.Items445"),
            resources.GetString("comboBox2.Items446"),
            resources.GetString("comboBox2.Items447"),
            resources.GetString("comboBox2.Items448"),
            resources.GetString("comboBox2.Items449"),
            resources.GetString("comboBox2.Items450"),
            resources.GetString("comboBox2.Items451"),
            resources.GetString("comboBox2.Items452"),
            resources.GetString("comboBox2.Items453"),
            resources.GetString("comboBox2.Items454"),
            resources.GetString("comboBox2.Items455"),
            resources.GetString("comboBox2.Items456"),
            resources.GetString("comboBox2.Items457"),
            resources.GetString("comboBox2.Items458"),
            resources.GetString("comboBox2.Items459"),
            resources.GetString("comboBox2.Items460"),
            resources.GetString("comboBox2.Items461"),
            resources.GetString("comboBox2.Items462"),
            resources.GetString("comboBox2.Items463"),
            resources.GetString("comboBox2.Items464"),
            resources.GetString("comboBox2.Items465"),
            resources.GetString("comboBox2.Items466"),
            resources.GetString("comboBox2.Items467"),
            resources.GetString("comboBox2.Items468"),
            resources.GetString("comboBox2.Items469"),
            resources.GetString("comboBox2.Items470"),
            resources.GetString("comboBox2.Items471"),
            resources.GetString("comboBox2.Items472"),
            resources.GetString("comboBox2.Items473"),
            resources.GetString("comboBox2.Items474"),
            resources.GetString("comboBox2.Items475"),
            resources.GetString("comboBox2.Items476"),
            resources.GetString("comboBox2.Items477"),
            resources.GetString("comboBox2.Items478"),
            resources.GetString("comboBox2.Items479"),
            resources.GetString("comboBox2.Items480"),
            resources.GetString("comboBox2.Items481"),
            resources.GetString("comboBox2.Items482"),
            resources.GetString("comboBox2.Items483"),
            resources.GetString("comboBox2.Items484"),
            resources.GetString("comboBox2.Items485"),
            resources.GetString("comboBox2.Items486"),
            resources.GetString("comboBox2.Items487"),
            resources.GetString("comboBox2.Items488"),
            resources.GetString("comboBox2.Items489"),
            resources.GetString("comboBox2.Items490"),
            resources.GetString("comboBox2.Items491"),
            resources.GetString("comboBox2.Items492"),
            resources.GetString("comboBox2.Items493"),
            resources.GetString("comboBox2.Items494"),
            resources.GetString("comboBox2.Items495"),
            resources.GetString("comboBox2.Items496"),
            resources.GetString("comboBox2.Items497"),
            resources.GetString("comboBox2.Items498"),
            resources.GetString("comboBox2.Items499"),
            resources.GetString("comboBox2.Items500"),
            resources.GetString("comboBox2.Items501"),
            resources.GetString("comboBox2.Items502"),
            resources.GetString("comboBox2.Items503"),
            resources.GetString("comboBox2.Items504"),
            resources.GetString("comboBox2.Items505"),
            resources.GetString("comboBox2.Items506"),
            resources.GetString("comboBox2.Items507"),
            resources.GetString("comboBox2.Items508"),
            resources.GetString("comboBox2.Items509"),
            resources.GetString("comboBox2.Items510"),
            resources.GetString("comboBox2.Items511"),
            resources.GetString("comboBox2.Items512"),
            resources.GetString("comboBox2.Items513"),
            resources.GetString("comboBox2.Items514"),
            resources.GetString("comboBox2.Items515"),
            resources.GetString("comboBox2.Items516"),
            resources.GetString("comboBox2.Items517"),
            resources.GetString("comboBox2.Items518"),
            resources.GetString("comboBox2.Items519"),
            resources.GetString("comboBox2.Items520"),
            resources.GetString("comboBox2.Items521"),
            resources.GetString("comboBox2.Items522"),
            resources.GetString("comboBox2.Items523"),
            resources.GetString("comboBox2.Items524"),
            resources.GetString("comboBox2.Items525"),
            resources.GetString("comboBox2.Items526"),
            resources.GetString("comboBox2.Items527"),
            resources.GetString("comboBox2.Items528"),
            resources.GetString("comboBox2.Items529"),
            resources.GetString("comboBox2.Items530"),
            resources.GetString("comboBox2.Items531"),
            resources.GetString("comboBox2.Items532"),
            resources.GetString("comboBox2.Items533"),
            resources.GetString("comboBox2.Items534"),
            resources.GetString("comboBox2.Items535"),
            resources.GetString("comboBox2.Items536"),
            resources.GetString("comboBox2.Items537"),
            resources.GetString("comboBox2.Items538"),
            resources.GetString("comboBox2.Items539"),
            resources.GetString("comboBox2.Items540"),
            resources.GetString("comboBox2.Items541"),
            resources.GetString("comboBox2.Items542"),
            resources.GetString("comboBox2.Items543"),
            resources.GetString("comboBox2.Items544"),
            resources.GetString("comboBox2.Items545"),
            resources.GetString("comboBox2.Items546"),
            resources.GetString("comboBox2.Items547"),
            resources.GetString("comboBox2.Items548"),
            resources.GetString("comboBox2.Items549"),
            resources.GetString("comboBox2.Items550"),
            resources.GetString("comboBox2.Items551"),
            resources.GetString("comboBox2.Items552"),
            resources.GetString("comboBox2.Items553"),
            resources.GetString("comboBox2.Items554"),
            resources.GetString("comboBox2.Items555"),
            resources.GetString("comboBox2.Items556"),
            resources.GetString("comboBox2.Items557"),
            resources.GetString("comboBox2.Items558"),
            resources.GetString("comboBox2.Items559"),
            resources.GetString("comboBox2.Items560"),
            resources.GetString("comboBox2.Items561"),
            resources.GetString("comboBox2.Items562"),
            resources.GetString("comboBox2.Items563"),
            resources.GetString("comboBox2.Items564"),
            resources.GetString("comboBox2.Items565"),
            resources.GetString("comboBox2.Items566"),
            resources.GetString("comboBox2.Items567"),
            resources.GetString("comboBox2.Items568"),
            resources.GetString("comboBox2.Items569"),
            resources.GetString("comboBox2.Items570"),
            resources.GetString("comboBox2.Items571"),
            resources.GetString("comboBox2.Items572"),
            resources.GetString("comboBox2.Items573"),
            resources.GetString("comboBox2.Items574"),
            resources.GetString("comboBox2.Items575"),
            resources.GetString("comboBox2.Items576"),
            resources.GetString("comboBox2.Items577"),
            resources.GetString("comboBox2.Items578"),
            resources.GetString("comboBox2.Items579"),
            resources.GetString("comboBox2.Items580"),
            resources.GetString("comboBox2.Items581"),
            resources.GetString("comboBox2.Items582"),
            resources.GetString("comboBox2.Items583"),
            resources.GetString("comboBox2.Items584"),
            resources.GetString("comboBox2.Items585"),
            resources.GetString("comboBox2.Items586"),
            resources.GetString("comboBox2.Items587"),
            resources.GetString("comboBox2.Items588"),
            resources.GetString("comboBox2.Items589"),
            resources.GetString("comboBox2.Items590"),
            resources.GetString("comboBox2.Items591"),
            resources.GetString("comboBox2.Items592"),
            resources.GetString("comboBox2.Items593"),
            resources.GetString("comboBox2.Items594"),
            resources.GetString("comboBox2.Items595"),
            resources.GetString("comboBox2.Items596"),
            resources.GetString("comboBox2.Items597"),
            resources.GetString("comboBox2.Items598"),
            resources.GetString("comboBox2.Items599"),
            resources.GetString("comboBox2.Items600"),
            resources.GetString("comboBox2.Items601"),
            resources.GetString("comboBox2.Items602"),
            resources.GetString("comboBox2.Items603"),
            resources.GetString("comboBox2.Items604"),
            resources.GetString("comboBox2.Items605"),
            resources.GetString("comboBox2.Items606"),
            resources.GetString("comboBox2.Items607"),
            resources.GetString("comboBox2.Items608"),
            resources.GetString("comboBox2.Items609"),
            resources.GetString("comboBox2.Items610"),
            resources.GetString("comboBox2.Items611"),
            resources.GetString("comboBox2.Items612"),
            resources.GetString("comboBox2.Items613"),
            resources.GetString("comboBox2.Items614"),
            resources.GetString("comboBox2.Items615"),
            resources.GetString("comboBox2.Items616"),
            resources.GetString("comboBox2.Items617"),
            resources.GetString("comboBox2.Items618"),
            resources.GetString("comboBox2.Items619"),
            resources.GetString("comboBox2.Items620"),
            resources.GetString("comboBox2.Items621"),
            resources.GetString("comboBox2.Items622"),
            resources.GetString("comboBox2.Items623"),
            resources.GetString("comboBox2.Items624"),
            resources.GetString("comboBox2.Items625"),
            resources.GetString("comboBox2.Items626"),
            resources.GetString("comboBox2.Items627"),
            resources.GetString("comboBox2.Items628"),
            resources.GetString("comboBox2.Items629"),
            resources.GetString("comboBox2.Items630"),
            resources.GetString("comboBox2.Items631"),
            resources.GetString("comboBox2.Items632"),
            resources.GetString("comboBox2.Items633"),
            resources.GetString("comboBox2.Items634"),
            resources.GetString("comboBox2.Items635"),
            resources.GetString("comboBox2.Items636"),
            resources.GetString("comboBox2.Items637"),
            resources.GetString("comboBox2.Items638"),
            resources.GetString("comboBox2.Items639"),
            resources.GetString("comboBox2.Items640"),
            resources.GetString("comboBox2.Items641"),
            resources.GetString("comboBox2.Items642"),
            resources.GetString("comboBox2.Items643"),
            resources.GetString("comboBox2.Items644"),
            resources.GetString("comboBox2.Items645"),
            resources.GetString("comboBox2.Items646"),
            resources.GetString("comboBox2.Items647"),
            resources.GetString("comboBox2.Items648"),
            resources.GetString("comboBox2.Items649"),
            resources.GetString("comboBox2.Items650"),
            resources.GetString("comboBox2.Items651"),
            resources.GetString("comboBox2.Items652"),
            resources.GetString("comboBox2.Items653"),
            resources.GetString("comboBox2.Items654"),
            resources.GetString("comboBox2.Items655"),
            resources.GetString("comboBox2.Items656"),
            resources.GetString("comboBox2.Items657"),
            resources.GetString("comboBox2.Items658"),
            resources.GetString("comboBox2.Items659"),
            resources.GetString("comboBox2.Items660"),
            resources.GetString("comboBox2.Items661"),
            resources.GetString("comboBox2.Items662"),
            resources.GetString("comboBox2.Items663"),
            resources.GetString("comboBox2.Items664"),
            resources.GetString("comboBox2.Items665"),
            resources.GetString("comboBox2.Items666"),
            resources.GetString("comboBox2.Items667"),
            resources.GetString("comboBox2.Items668"),
            resources.GetString("comboBox2.Items669"),
            resources.GetString("comboBox2.Items670"),
            resources.GetString("comboBox2.Items671"),
            resources.GetString("comboBox2.Items672"),
            resources.GetString("comboBox2.Items673"),
            resources.GetString("comboBox2.Items674"),
            resources.GetString("comboBox2.Items675"),
            resources.GetString("comboBox2.Items676"),
            resources.GetString("comboBox2.Items677"),
            resources.GetString("comboBox2.Items678"),
            resources.GetString("comboBox2.Items679"),
            resources.GetString("comboBox2.Items680"),
            resources.GetString("comboBox2.Items681"),
            resources.GetString("comboBox2.Items682"),
            resources.GetString("comboBox2.Items683"),
            resources.GetString("comboBox2.Items684"),
            resources.GetString("comboBox2.Items685"),
            resources.GetString("comboBox2.Items686"),
            resources.GetString("comboBox2.Items687"),
            resources.GetString("comboBox2.Items688"),
            resources.GetString("comboBox2.Items689"),
            resources.GetString("comboBox2.Items690"),
            resources.GetString("comboBox2.Items691"),
            resources.GetString("comboBox2.Items692"),
            resources.GetString("comboBox2.Items693"),
            resources.GetString("comboBox2.Items694"),
            resources.GetString("comboBox2.Items695"),
            resources.GetString("comboBox2.Items696"),
            resources.GetString("comboBox2.Items697"),
            resources.GetString("comboBox2.Items698"),
            resources.GetString("comboBox2.Items699"),
            resources.GetString("comboBox2.Items700"),
            resources.GetString("comboBox2.Items701"),
            resources.GetString("comboBox2.Items702"),
            resources.GetString("comboBox2.Items703"),
            resources.GetString("comboBox2.Items704"),
            resources.GetString("comboBox2.Items705"),
            resources.GetString("comboBox2.Items706"),
            resources.GetString("comboBox2.Items707"),
            resources.GetString("comboBox2.Items708"),
            resources.GetString("comboBox2.Items709"),
            resources.GetString("comboBox2.Items710"),
            resources.GetString("comboBox2.Items711"),
            resources.GetString("comboBox2.Items712"),
            resources.GetString("comboBox2.Items713"),
            resources.GetString("comboBox2.Items714"),
            resources.GetString("comboBox2.Items715"),
            resources.GetString("comboBox2.Items716"),
            resources.GetString("comboBox2.Items717"),
            resources.GetString("comboBox2.Items718"),
            resources.GetString("comboBox2.Items719"),
            resources.GetString("comboBox2.Items720"),
            resources.GetString("comboBox2.Items721"),
            resources.GetString("comboBox2.Items722"),
            resources.GetString("comboBox2.Items723"),
            resources.GetString("comboBox2.Items724"),
            resources.GetString("comboBox2.Items725"),
            resources.GetString("comboBox2.Items726"),
            resources.GetString("comboBox2.Items727"),
            resources.GetString("comboBox2.Items728"),
            resources.GetString("comboBox2.Items729"),
            resources.GetString("comboBox2.Items730"),
            resources.GetString("comboBox2.Items731"),
            resources.GetString("comboBox2.Items732"),
            resources.GetString("comboBox2.Items733"),
            resources.GetString("comboBox2.Items734"),
            resources.GetString("comboBox2.Items735"),
            resources.GetString("comboBox2.Items736"),
            resources.GetString("comboBox2.Items737"),
            resources.GetString("comboBox2.Items738"),
            resources.GetString("comboBox2.Items739"),
            resources.GetString("comboBox2.Items740"),
            resources.GetString("comboBox2.Items741"),
            resources.GetString("comboBox2.Items742"),
            resources.GetString("comboBox2.Items743"),
            resources.GetString("comboBox2.Items744"),
            resources.GetString("comboBox2.Items745"),
            resources.GetString("comboBox2.Items746"),
            resources.GetString("comboBox2.Items747"),
            resources.GetString("comboBox2.Items748"),
            resources.GetString("comboBox2.Items749"),
            resources.GetString("comboBox2.Items750"),
            resources.GetString("comboBox2.Items751"),
            resources.GetString("comboBox2.Items752"),
            resources.GetString("comboBox2.Items753"),
            resources.GetString("comboBox2.Items754"),
            resources.GetString("comboBox2.Items755"),
            resources.GetString("comboBox2.Items756"),
            resources.GetString("comboBox2.Items757"),
            resources.GetString("comboBox2.Items758"),
            resources.GetString("comboBox2.Items759"),
            resources.GetString("comboBox2.Items760"),
            resources.GetString("comboBox2.Items761"),
            resources.GetString("comboBox2.Items762"),
            resources.GetString("comboBox2.Items763"),
            resources.GetString("comboBox2.Items764"),
            resources.GetString("comboBox2.Items765"),
            resources.GetString("comboBox2.Items766"),
            resources.GetString("comboBox2.Items767"),
            resources.GetString("comboBox2.Items768"),
            resources.GetString("comboBox2.Items769"),
            resources.GetString("comboBox2.Items770"),
            resources.GetString("comboBox2.Items771"),
            resources.GetString("comboBox2.Items772"),
            resources.GetString("comboBox2.Items773"),
            resources.GetString("comboBox2.Items774"),
            resources.GetString("comboBox2.Items775"),
            resources.GetString("comboBox2.Items776"),
            resources.GetString("comboBox2.Items777"),
            resources.GetString("comboBox2.Items778"),
            resources.GetString("comboBox2.Items779"),
            resources.GetString("comboBox2.Items780"),
            resources.GetString("comboBox2.Items781"),
            resources.GetString("comboBox2.Items782"),
            resources.GetString("comboBox2.Items783"),
            resources.GetString("comboBox2.Items784"),
            resources.GetString("comboBox2.Items785"),
            resources.GetString("comboBox2.Items786"),
            resources.GetString("comboBox2.Items787"),
            resources.GetString("comboBox2.Items788"),
            resources.GetString("comboBox2.Items789"),
            resources.GetString("comboBox2.Items790"),
            resources.GetString("comboBox2.Items791"),
            resources.GetString("comboBox2.Items792"),
            resources.GetString("comboBox2.Items793"),
            resources.GetString("comboBox2.Items794"),
            resources.GetString("comboBox2.Items795"),
            resources.GetString("comboBox2.Items796"),
            resources.GetString("comboBox2.Items797"),
            resources.GetString("comboBox2.Items798"),
            resources.GetString("comboBox2.Items799"),
            resources.GetString("comboBox2.Items800"),
            resources.GetString("comboBox2.Items801"),
            resources.GetString("comboBox2.Items802"),
            resources.GetString("comboBox2.Items803"),
            resources.GetString("comboBox2.Items804"),
            resources.GetString("comboBox2.Items805"),
            resources.GetString("comboBox2.Items806"),
            resources.GetString("comboBox2.Items807"),
            resources.GetString("comboBox2.Items808"),
            resources.GetString("comboBox2.Items809"),
            resources.GetString("comboBox2.Items810"),
            resources.GetString("comboBox2.Items811"),
            resources.GetString("comboBox2.Items812"),
            resources.GetString("comboBox2.Items813"),
            resources.GetString("comboBox2.Items814"),
            resources.GetString("comboBox2.Items815"),
            resources.GetString("comboBox2.Items816"),
            resources.GetString("comboBox2.Items817"),
            resources.GetString("comboBox2.Items818"),
            resources.GetString("comboBox2.Items819"),
            resources.GetString("comboBox2.Items820"),
            resources.GetString("comboBox2.Items821"),
            resources.GetString("comboBox2.Items822"),
            resources.GetString("comboBox2.Items823"),
            resources.GetString("comboBox2.Items824"),
            resources.GetString("comboBox2.Items825"),
            resources.GetString("comboBox2.Items826"),
            resources.GetString("comboBox2.Items827"),
            resources.GetString("comboBox2.Items828"),
            resources.GetString("comboBox2.Items829"),
            resources.GetString("comboBox2.Items830"),
            resources.GetString("comboBox2.Items831"),
            resources.GetString("comboBox2.Items832"),
            resources.GetString("comboBox2.Items833"),
            resources.GetString("comboBox2.Items834"),
            resources.GetString("comboBox2.Items835"),
            resources.GetString("comboBox2.Items836"),
            resources.GetString("comboBox2.Items837"),
            resources.GetString("comboBox2.Items838"),
            resources.GetString("comboBox2.Items839"),
            resources.GetString("comboBox2.Items840"),
            resources.GetString("comboBox2.Items841"),
            resources.GetString("comboBox2.Items842"),
            resources.GetString("comboBox2.Items843"),
            resources.GetString("comboBox2.Items844"),
            resources.GetString("comboBox2.Items845"),
            resources.GetString("comboBox2.Items846"),
            resources.GetString("comboBox2.Items847"),
            resources.GetString("comboBox2.Items848"),
            resources.GetString("comboBox2.Items849"),
            resources.GetString("comboBox2.Items850"),
            resources.GetString("comboBox2.Items851"),
            resources.GetString("comboBox2.Items852"),
            resources.GetString("comboBox2.Items853"),
            resources.GetString("comboBox2.Items854"),
            resources.GetString("comboBox2.Items855"),
            resources.GetString("comboBox2.Items856"),
            resources.GetString("comboBox2.Items857"),
            resources.GetString("comboBox2.Items858"),
            resources.GetString("comboBox2.Items859"),
            resources.GetString("comboBox2.Items860"),
            resources.GetString("comboBox2.Items861"),
            resources.GetString("comboBox2.Items862"),
            resources.GetString("comboBox2.Items863"),
            resources.GetString("comboBox2.Items864"),
            resources.GetString("comboBox2.Items865"),
            resources.GetString("comboBox2.Items866"),
            resources.GetString("comboBox2.Items867"),
            resources.GetString("comboBox2.Items868"),
            resources.GetString("comboBox2.Items869"),
            resources.GetString("comboBox2.Items870"),
            resources.GetString("comboBox2.Items871"),
            resources.GetString("comboBox2.Items872"),
            resources.GetString("comboBox2.Items873"),
            resources.GetString("comboBox2.Items874"),
            resources.GetString("comboBox2.Items875"),
            resources.GetString("comboBox2.Items876"),
            resources.GetString("comboBox2.Items877"),
            resources.GetString("comboBox2.Items878"),
            resources.GetString("comboBox2.Items879"),
            resources.GetString("comboBox2.Items880"),
            resources.GetString("comboBox2.Items881"),
            resources.GetString("comboBox2.Items882"),
            resources.GetString("comboBox2.Items883"),
            resources.GetString("comboBox2.Items884"),
            resources.GetString("comboBox2.Items885"),
            resources.GetString("comboBox2.Items886"),
            resources.GetString("comboBox2.Items887"),
            resources.GetString("comboBox2.Items888"),
            resources.GetString("comboBox2.Items889"),
            resources.GetString("comboBox2.Items890"),
            resources.GetString("comboBox2.Items891"),
            resources.GetString("comboBox2.Items892"),
            resources.GetString("comboBox2.Items893"),
            resources.GetString("comboBox2.Items894"),
            resources.GetString("comboBox2.Items895"),
            resources.GetString("comboBox2.Items896"),
            resources.GetString("comboBox2.Items897"),
            resources.GetString("comboBox2.Items898"),
            resources.GetString("comboBox2.Items899"),
            resources.GetString("comboBox2.Items900"),
            resources.GetString("comboBox2.Items901"),
            resources.GetString("comboBox2.Items902"),
            resources.GetString("comboBox2.Items903"),
            resources.GetString("comboBox2.Items904"),
            resources.GetString("comboBox2.Items905"),
            resources.GetString("comboBox2.Items906"),
            resources.GetString("comboBox2.Items907"),
            resources.GetString("comboBox2.Items908"),
            resources.GetString("comboBox2.Items909"),
            resources.GetString("comboBox2.Items910"),
            resources.GetString("comboBox2.Items911"),
            resources.GetString("comboBox2.Items912"),
            resources.GetString("comboBox2.Items913"),
            resources.GetString("comboBox2.Items914"),
            resources.GetString("comboBox2.Items915"),
            resources.GetString("comboBox2.Items916"),
            resources.GetString("comboBox2.Items917"),
            resources.GetString("comboBox2.Items918"),
            resources.GetString("comboBox2.Items919"),
            resources.GetString("comboBox2.Items920"),
            resources.GetString("comboBox2.Items921"),
            resources.GetString("comboBox2.Items922"),
            resources.GetString("comboBox2.Items923"),
            resources.GetString("comboBox2.Items924"),
            resources.GetString("comboBox2.Items925"),
            resources.GetString("comboBox2.Items926"),
            resources.GetString("comboBox2.Items927"),
            resources.GetString("comboBox2.Items928"),
            resources.GetString("comboBox2.Items929"),
            resources.GetString("comboBox2.Items930"),
            resources.GetString("comboBox2.Items931"),
            resources.GetString("comboBox2.Items932"),
            resources.GetString("comboBox2.Items933"),
            resources.GetString("comboBox2.Items934"),
            resources.GetString("comboBox2.Items935"),
            resources.GetString("comboBox2.Items936"),
            resources.GetString("comboBox2.Items937"),
            resources.GetString("comboBox2.Items938"),
            resources.GetString("comboBox2.Items939"),
            resources.GetString("comboBox2.Items940"),
            resources.GetString("comboBox2.Items941"),
            resources.GetString("comboBox2.Items942"),
            resources.GetString("comboBox2.Items943"),
            resources.GetString("comboBox2.Items944"),
            resources.GetString("comboBox2.Items945"),
            resources.GetString("comboBox2.Items946"),
            resources.GetString("comboBox2.Items947"),
            resources.GetString("comboBox2.Items948"),
            resources.GetString("comboBox2.Items949"),
            resources.GetString("comboBox2.Items950"),
            resources.GetString("comboBox2.Items951"),
            resources.GetString("comboBox2.Items952"),
            resources.GetString("comboBox2.Items953"),
            resources.GetString("comboBox2.Items954"),
            resources.GetString("comboBox2.Items955"),
            resources.GetString("comboBox2.Items956"),
            resources.GetString("comboBox2.Items957"),
            resources.GetString("comboBox2.Items958"),
            resources.GetString("comboBox2.Items959"),
            resources.GetString("comboBox2.Items960"),
            resources.GetString("comboBox2.Items961"),
            resources.GetString("comboBox2.Items962"),
            resources.GetString("comboBox2.Items963"),
            resources.GetString("comboBox2.Items964"),
            resources.GetString("comboBox2.Items965"),
            resources.GetString("comboBox2.Items966"),
            resources.GetString("comboBox2.Items967"),
            resources.GetString("comboBox2.Items968"),
            resources.GetString("comboBox2.Items969"),
            resources.GetString("comboBox2.Items970"),
            resources.GetString("comboBox2.Items971"),
            resources.GetString("comboBox2.Items972"),
            resources.GetString("comboBox2.Items973"),
            resources.GetString("comboBox2.Items974"),
            resources.GetString("comboBox2.Items975"),
            resources.GetString("comboBox2.Items976"),
            resources.GetString("comboBox2.Items977"),
            resources.GetString("comboBox2.Items978"),
            resources.GetString("comboBox2.Items979"),
            resources.GetString("comboBox2.Items980"),
            resources.GetString("comboBox2.Items981"),
            resources.GetString("comboBox2.Items982"),
            resources.GetString("comboBox2.Items983"),
            resources.GetString("comboBox2.Items984"),
            resources.GetString("comboBox2.Items985"),
            resources.GetString("comboBox2.Items986"),
            resources.GetString("comboBox2.Items987"),
            resources.GetString("comboBox2.Items988"),
            resources.GetString("comboBox2.Items989"),
            resources.GetString("comboBox2.Items990"),
            resources.GetString("comboBox2.Items991"),
            resources.GetString("comboBox2.Items992"),
            resources.GetString("comboBox2.Items993"),
            resources.GetString("comboBox2.Items994"),
            resources.GetString("comboBox2.Items995"),
            resources.GetString("comboBox2.Items996"),
            resources.GetString("comboBox2.Items997"),
            resources.GetString("comboBox2.Items998"),
            resources.GetString("comboBox2.Items999"),
            resources.GetString("comboBox2.Items1000"),
            resources.GetString("comboBox2.Items1001"),
            resources.GetString("comboBox2.Items1002"),
            resources.GetString("comboBox2.Items1003"),
            resources.GetString("comboBox2.Items1004"),
            resources.GetString("comboBox2.Items1005"),
            resources.GetString("comboBox2.Items1006"),
            resources.GetString("comboBox2.Items1007"),
            resources.GetString("comboBox2.Items1008"),
            resources.GetString("comboBox2.Items1009"),
            resources.GetString("comboBox2.Items1010"),
            resources.GetString("comboBox2.Items1011"),
            resources.GetString("comboBox2.Items1012"),
            resources.GetString("comboBox2.Items1013"),
            resources.GetString("comboBox2.Items1014"),
            resources.GetString("comboBox2.Items1015"),
            resources.GetString("comboBox2.Items1016"),
            resources.GetString("comboBox2.Items1017"),
            resources.GetString("comboBox2.Items1018"),
            resources.GetString("comboBox2.Items1019"),
            resources.GetString("comboBox2.Items1020"),
            resources.GetString("comboBox2.Items1021"),
            resources.GetString("comboBox2.Items1022"),
            resources.GetString("comboBox2.Items1023"),
            resources.GetString("comboBox2.Items1024"),
            resources.GetString("comboBox2.Items1025"),
            resources.GetString("comboBox2.Items1026"),
            resources.GetString("comboBox2.Items1027"),
            resources.GetString("comboBox2.Items1028"),
            resources.GetString("comboBox2.Items1029"),
            resources.GetString("comboBox2.Items1030"),
            resources.GetString("comboBox2.Items1031"),
            resources.GetString("comboBox2.Items1032"),
            resources.GetString("comboBox2.Items1033"),
            resources.GetString("comboBox2.Items1034"),
            resources.GetString("comboBox2.Items1035"),
            resources.GetString("comboBox2.Items1036"),
            resources.GetString("comboBox2.Items1037"),
            resources.GetString("comboBox2.Items1038"),
            resources.GetString("comboBox2.Items1039"),
            resources.GetString("comboBox2.Items1040"),
            resources.GetString("comboBox2.Items1041"),
            resources.GetString("comboBox2.Items1042"),
            resources.GetString("comboBox2.Items1043"),
            resources.GetString("comboBox2.Items1044"),
            resources.GetString("comboBox2.Items1045"),
            resources.GetString("comboBox2.Items1046"),
            resources.GetString("comboBox2.Items1047"),
            resources.GetString("comboBox2.Items1048"),
            resources.GetString("comboBox2.Items1049"),
            resources.GetString("comboBox2.Items1050"),
            resources.GetString("comboBox2.Items1051"),
            resources.GetString("comboBox2.Items1052"),
            resources.GetString("comboBox2.Items1053"),
            resources.GetString("comboBox2.Items1054"),
            resources.GetString("comboBox2.Items1055"),
            resources.GetString("comboBox2.Items1056"),
            resources.GetString("comboBox2.Items1057"),
            resources.GetString("comboBox2.Items1058"),
            resources.GetString("comboBox2.Items1059"),
            resources.GetString("comboBox2.Items1060"),
            resources.GetString("comboBox2.Items1061"),
            resources.GetString("comboBox2.Items1062"),
            resources.GetString("comboBox2.Items1063"),
            resources.GetString("comboBox2.Items1064"),
            resources.GetString("comboBox2.Items1065"),
            resources.GetString("comboBox2.Items1066"),
            resources.GetString("comboBox2.Items1067"),
            resources.GetString("comboBox2.Items1068"),
            resources.GetString("comboBox2.Items1069"),
            resources.GetString("comboBox2.Items1070"),
            resources.GetString("comboBox2.Items1071"),
            resources.GetString("comboBox2.Items1072"),
            resources.GetString("comboBox2.Items1073"),
            resources.GetString("comboBox2.Items1074"),
            resources.GetString("comboBox2.Items1075"),
            resources.GetString("comboBox2.Items1076"),
            resources.GetString("comboBox2.Items1077"),
            resources.GetString("comboBox2.Items1078"),
            resources.GetString("comboBox2.Items1079"),
            resources.GetString("comboBox2.Items1080"),
            resources.GetString("comboBox2.Items1081"),
            resources.GetString("comboBox2.Items1082"),
            resources.GetString("comboBox2.Items1083"),
            resources.GetString("comboBox2.Items1084"),
            resources.GetString("comboBox2.Items1085"),
            resources.GetString("comboBox2.Items1086"),
            resources.GetString("comboBox2.Items1087"),
            resources.GetString("comboBox2.Items1088"),
            resources.GetString("comboBox2.Items1089"),
            resources.GetString("comboBox2.Items1090"),
            resources.GetString("comboBox2.Items1091"),
            resources.GetString("comboBox2.Items1092"),
            resources.GetString("comboBox2.Items1093"),
            resources.GetString("comboBox2.Items1094"),
            resources.GetString("comboBox2.Items1095"),
            resources.GetString("comboBox2.Items1096"),
            resources.GetString("comboBox2.Items1097"),
            resources.GetString("comboBox2.Items1098"),
            resources.GetString("comboBox2.Items1099"),
            resources.GetString("comboBox2.Items1100"),
            resources.GetString("comboBox2.Items1101"),
            resources.GetString("comboBox2.Items1102"),
            resources.GetString("comboBox2.Items1103"),
            resources.GetString("comboBox2.Items1104"),
            resources.GetString("comboBox2.Items1105"),
            resources.GetString("comboBox2.Items1106"),
            resources.GetString("comboBox2.Items1107"),
            resources.GetString("comboBox2.Items1108"),
            resources.GetString("comboBox2.Items1109"),
            resources.GetString("comboBox2.Items1110"),
            resources.GetString("comboBox2.Items1111"),
            resources.GetString("comboBox2.Items1112"),
            resources.GetString("comboBox2.Items1113"),
            resources.GetString("comboBox2.Items1114"),
            resources.GetString("comboBox2.Items1115"),
            resources.GetString("comboBox2.Items1116"),
            resources.GetString("comboBox2.Items1117"),
            resources.GetString("comboBox2.Items1118"),
            resources.GetString("comboBox2.Items1119"),
            resources.GetString("comboBox2.Items1120"),
            resources.GetString("comboBox2.Items1121"),
            resources.GetString("comboBox2.Items1122"),
            resources.GetString("comboBox2.Items1123"),
            resources.GetString("comboBox2.Items1124"),
            resources.GetString("comboBox2.Items1125"),
            resources.GetString("comboBox2.Items1126"),
            resources.GetString("comboBox2.Items1127"),
            resources.GetString("comboBox2.Items1128"),
            resources.GetString("comboBox2.Items1129"),
            resources.GetString("comboBox2.Items1130"),
            resources.GetString("comboBox2.Items1131"),
            resources.GetString("comboBox2.Items1132"),
            resources.GetString("comboBox2.Items1133"),
            resources.GetString("comboBox2.Items1134"),
            resources.GetString("comboBox2.Items1135"),
            resources.GetString("comboBox2.Items1136"),
            resources.GetString("comboBox2.Items1137"),
            resources.GetString("comboBox2.Items1138"),
            resources.GetString("comboBox2.Items1139"),
            resources.GetString("comboBox2.Items1140"),
            resources.GetString("comboBox2.Items1141"),
            resources.GetString("comboBox2.Items1142"),
            resources.GetString("comboBox2.Items1143"),
            resources.GetString("comboBox2.Items1144"),
            resources.GetString("comboBox2.Items1145"),
            resources.GetString("comboBox2.Items1146"),
            resources.GetString("comboBox2.Items1147"),
            resources.GetString("comboBox2.Items1148"),
            resources.GetString("comboBox2.Items1149"),
            resources.GetString("comboBox2.Items1150"),
            resources.GetString("comboBox2.Items1151"),
            resources.GetString("comboBox2.Items1152"),
            resources.GetString("comboBox2.Items1153"),
            resources.GetString("comboBox2.Items1154"),
            resources.GetString("comboBox2.Items1155"),
            resources.GetString("comboBox2.Items1156"),
            resources.GetString("comboBox2.Items1157"),
            resources.GetString("comboBox2.Items1158"),
            resources.GetString("comboBox2.Items1159"),
            resources.GetString("comboBox2.Items1160"),
            resources.GetString("comboBox2.Items1161"),
            resources.GetString("comboBox2.Items1162"),
            resources.GetString("comboBox2.Items1163"),
            resources.GetString("comboBox2.Items1164"),
            resources.GetString("comboBox2.Items1165"),
            resources.GetString("comboBox2.Items1166"),
            resources.GetString("comboBox2.Items1167"),
            resources.GetString("comboBox2.Items1168"),
            resources.GetString("comboBox2.Items1169"),
            resources.GetString("comboBox2.Items1170"),
            resources.GetString("comboBox2.Items1171"),
            resources.GetString("comboBox2.Items1172"),
            resources.GetString("comboBox2.Items1173"),
            resources.GetString("comboBox2.Items1174"),
            resources.GetString("comboBox2.Items1175"),
            resources.GetString("comboBox2.Items1176"),
            resources.GetString("comboBox2.Items1177"),
            resources.GetString("comboBox2.Items1178"),
            resources.GetString("comboBox2.Items1179"),
            resources.GetString("comboBox2.Items1180"),
            resources.GetString("comboBox2.Items1181"),
            resources.GetString("comboBox2.Items1182"),
            resources.GetString("comboBox2.Items1183"),
            resources.GetString("comboBox2.Items1184"),
            resources.GetString("comboBox2.Items1185"),
            resources.GetString("comboBox2.Items1186"),
            resources.GetString("comboBox2.Items1187"),
            resources.GetString("comboBox2.Items1188"),
            resources.GetString("comboBox2.Items1189"),
            resources.GetString("comboBox2.Items1190"),
            resources.GetString("comboBox2.Items1191"),
            resources.GetString("comboBox2.Items1192"),
            resources.GetString("comboBox2.Items1193"),
            resources.GetString("comboBox2.Items1194"),
            resources.GetString("comboBox2.Items1195"),
            resources.GetString("comboBox2.Items1196"),
            resources.GetString("comboBox2.Items1197"),
            resources.GetString("comboBox2.Items1198"),
            resources.GetString("comboBox2.Items1199"),
            resources.GetString("comboBox2.Items1200"),
            resources.GetString("comboBox2.Items1201"),
            resources.GetString("comboBox2.Items1202"),
            resources.GetString("comboBox2.Items1203"),
            resources.GetString("comboBox2.Items1204"),
            resources.GetString("comboBox2.Items1205"),
            resources.GetString("comboBox2.Items1206"),
            resources.GetString("comboBox2.Items1207"),
            resources.GetString("comboBox2.Items1208"),
            resources.GetString("comboBox2.Items1209"),
            resources.GetString("comboBox2.Items1210"),
            resources.GetString("comboBox2.Items1211"),
            resources.GetString("comboBox2.Items1212"),
            resources.GetString("comboBox2.Items1213"),
            resources.GetString("comboBox2.Items1214"),
            resources.GetString("comboBox2.Items1215"),
            resources.GetString("comboBox2.Items1216"),
            resources.GetString("comboBox2.Items1217"),
            resources.GetString("comboBox2.Items1218"),
            resources.GetString("comboBox2.Items1219"),
            resources.GetString("comboBox2.Items1220"),
            resources.GetString("comboBox2.Items1221"),
            resources.GetString("comboBox2.Items1222"),
            resources.GetString("comboBox2.Items1223"),
            resources.GetString("comboBox2.Items1224"),
            resources.GetString("comboBox2.Items1225"),
            resources.GetString("comboBox2.Items1226"),
            resources.GetString("comboBox2.Items1227"),
            resources.GetString("comboBox2.Items1228"),
            resources.GetString("comboBox2.Items1229"),
            resources.GetString("comboBox2.Items1230"),
            resources.GetString("comboBox2.Items1231"),
            resources.GetString("comboBox2.Items1232"),
            resources.GetString("comboBox2.Items1233"),
            resources.GetString("comboBox2.Items1234"),
            resources.GetString("comboBox2.Items1235"),
            resources.GetString("comboBox2.Items1236"),
            resources.GetString("comboBox2.Items1237"),
            resources.GetString("comboBox2.Items1238"),
            resources.GetString("comboBox2.Items1239"),
            resources.GetString("comboBox2.Items1240"),
            resources.GetString("comboBox2.Items1241"),
            resources.GetString("comboBox2.Items1242"),
            resources.GetString("comboBox2.Items1243"),
            resources.GetString("comboBox2.Items1244"),
            resources.GetString("comboBox2.Items1245"),
            resources.GetString("comboBox2.Items1246"),
            resources.GetString("comboBox2.Items1247"),
            resources.GetString("comboBox2.Items1248"),
            resources.GetString("comboBox2.Items1249"),
            resources.GetString("comboBox2.Items1250"),
            resources.GetString("comboBox2.Items1251"),
            resources.GetString("comboBox2.Items1252"),
            resources.GetString("comboBox2.Items1253"),
            resources.GetString("comboBox2.Items1254"),
            resources.GetString("comboBox2.Items1255"),
            resources.GetString("comboBox2.Items1256"),
            resources.GetString("comboBox2.Items1257"),
            resources.GetString("comboBox2.Items1258"),
            resources.GetString("comboBox2.Items1259"),
            resources.GetString("comboBox2.Items1260"),
            resources.GetString("comboBox2.Items1261"),
            resources.GetString("comboBox2.Items1262"),
            resources.GetString("comboBox2.Items1263"),
            resources.GetString("comboBox2.Items1264"),
            resources.GetString("comboBox2.Items1265"),
            resources.GetString("comboBox2.Items1266")});
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            // 
            // importOstanovokExcelBindingSource1
            // 
            this.importOstanovokExcelBindingSource1.DataMember = "ImportOstanovokExcel";
            this.importOstanovokExcelBindingSource1.DataSource = this.gISSIGData;
            // 
            // importOstanovokExcelTableAdapter1
            // 
            this.importOstanovokExcelTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ImportOstanovokExcelTableAdapter = this.importOstanovokExcelTableAdapter1;
            this.tableAdapterManager.UpdateOrder = Demo.WindowsForms.GISSIGDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // skalarVsegoZnachTableAdapter
            // 
            this.skalarVsegoZnachTableAdapter.ClearBeforeFill = true;
            // 
            // skalarPoiskPoRaionyBindingSource1
            // 
            this.skalarPoiskPoRaionyBindingSource1.DataMember = "SkalarPoiskPoRaiony";
            this.skalarPoiskPoRaionyBindingSource1.DataSource = this.gISSIGData;
            // 
            // skalarPoiskPoRaionyBindingSource
            // 
            this.skalarPoiskPoRaionyBindingSource.DataMember = "SkalarPoiskPoRaiony";
            this.skalarPoiskPoRaionyBindingSource.DataSource = this.gISSIGData;
            // 
            // skalarPoiskPoRaiony1TableAdapter1
            // 
            this.skalarPoiskPoRaiony1TableAdapter1.ClearBeforeFill = true;
            // 
            // skalarVsegoZnachPoRaionTableAdapter
            // 
            this.skalarVsegoZnachPoRaionTableAdapter.ClearBeforeFill = true;
            // 
            // scalarPoiskPoUlichamTableAdapter
            // 
            this.scalarPoiskPoUlichamTableAdapter.ClearBeforeFill = true;
            // 
            // scalarVsegoZnachPoUlchamTableAdapter
            // 
            this.scalarVsegoZnachPoUlchamTableAdapter.ClearBeforeFill = true;
            // 
            // mapen
            // 
            this.mapen.Bearing = 0F;
            this.mapen.CanDragMap = true;
            resources.ApplyResources(this.mapen, "mapen");
            this.mapen.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapen.GrayScaleMode = false;
            this.mapen.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapen.LevelsKeepInMemmory = 5;
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
            this.mapen.Zoom = 0D;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            // 
            // otrabotka_oblasti
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mapen);
            this.Name = "otrabotka_oblasti";
            this.Load += new System.EventHandler(this.otrabotka_oblasti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.importOstanovokExcelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importOstanovokExcelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skalarVsegoZnachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gISSIGData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scalarPoiskPoUlichambindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scalarVsegoZnachPoUlchamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skalarPoiskPoRaiony1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skalarVsegoZnachPoRaionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importOstanovokExcelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skalarPoiskPoRaionyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skalarPoiskPoRaionyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label label1;
       
        private System.Windows.Forms.BindingSource importOstanovokExcelBindingSource;
        
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private GISSIGData gISSIGData;
        private System.Windows.Forms.BindingSource importOstanovokExcelBindingSource1;
        private GISSIGDataTableAdapters.ImportOstanovokExcelTableAdapter importOstanovokExcelTableAdapter1;
        private GISSIGDataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource importOstanovokExcelBindingSource2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource skalarVsegoZnachBindingSource;
        private GISSIGDataTableAdapters.SkalarVsegoZnachTableAdapter skalarVsegoZnachTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource skalarPoiskPoRaionyBindingSource;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource skalarPoiskPoRaionyBindingSource1;
        private GISSIGDataTableAdapters.SkalarPoiskPoRaiony1TableAdapter skalarPoiskPoRaiony1TableAdapter1;
        private System.Windows.Forms.BindingSource skalarPoiskPoRaiony1BindingSource;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource skalarVsegoZnachPoRaionBindingSource;
        private GISSIGDataTableAdapters.SkalarVsegoZnachPoRaionTableAdapter skalarVsegoZnachPoRaionTableAdapter;
        private System.Windows.Forms.Label label11;
        private GISSIGDataTableAdapters.ScalarPoiskPoUlichamTableAdapter scalarPoiskPoUlichamTableAdapter;
        private System.Windows.Forms.BindingSource scalarPoiskPoUlichambindingSource;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.BindingSource scalarVsegoZnachPoUlchamBindingSource;
        private GISSIGDataTableAdapters.ScalarVsegoZnachPoUlchamTableAdapter scalarVsegoZnachPoUlchamTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private Map mapen;
        private System.Windows.Forms.DataGridView dataGridView1;
        
    }
}