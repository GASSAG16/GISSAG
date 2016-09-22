namespace WindowsForms.Forms
{
    partial class fmImportTrassMarsh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmImportTrassMarsh));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chOk = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.prProgress2 = new System.Windows.Forms.ProgressBar();
            this.lbCountStan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLineStan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbColumnStan = new System.Windows.Forms.TextBox();
            this.tbSelectStan = new System.Windows.Forms.TextBox();
            this.btSelectFileStan = new System.Windows.Forms.Button();
            this.tbSelect = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btSelectFile = new System.Windows.Forms.Button();
            this.tbLine = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbColumn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.prProgressI = new System.Windows.Forms.ProgressBar();
            this.lbCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDirectionOfRoute = new System.Windows.Forms.Label();
            this.lbCoordinate_X = new System.Windows.Forms.Label();
            this.lbTransportMode = new System.Windows.Forms.Label();
            this.lbRouteNamber = new System.Windows.Forms.Label();
            this.lbCoordinate_Y = new System.Windows.Forms.Label();
            this.gbMarsh = new System.Windows.Forms.GroupBox();
            this.gbPassagenerStop = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTheNameOfTheStop = new System.Windows.Forms.Label();
            this.lbDistrict = new System.Windows.Forms.Label();
            this.lbAdministrativeDistrict = new System.Windows.Forms.Label();
            this.lbStreet = new System.Windows.Forms.Label();
            this.lbDirection = new System.Windows.Forms.Label();
            this.lbCoordinate_X_stan = new System.Windows.Forms.Label();
            this.lbRouteNamber_stan = new System.Windows.Forms.Label();
            this.lbTransportMode_stan = new System.Windows.Forms.Label();
            this.lbCoordinate_Y_stan = new System.Windows.Forms.Label();
            this.gbNomerMarsh = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbRouteNamber_ = new System.Windows.Forms.Label();
            this.lbTransportMode_ = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbMarsh.SuspendLayout();
            this.gbPassagenerStop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbNomerMarsh.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chOk);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 371);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Внимательно прочитать";
            // 
            // chOk
            // 
            this.chOk.AutoSize = true;
            this.chOk.Location = new System.Drawing.Point(431, 255);
            this.chOk.Name = "chOk";
            this.chOk.Size = new System.Drawing.Size(50, 21);
            this.chOk.TabIndex = 0;
            this.chOk.Text = "ОК";
            this.chOk.UseVisualStyleBackColor = true;
            this.chOk.CheckStateChanged += new System.EventHandler(this.chOk_CheckStateChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.prProgress2);
            this.groupBox4.Controls.Add(this.lbCountStan);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(258, 283);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(223, 76);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ход процесса:";
            // 
            // prProgress2
            // 
            this.prProgress2.Location = new System.Drawing.Point(22, 21);
            this.prProgress2.MarqueeAnimationSpeed = 15;
            this.prProgress2.Maximum = 23000;
            this.prProgress2.Name = "prProgress2";
            this.prProgress2.Size = new System.Drawing.Size(191, 23);
            this.prProgress2.Step = 1;
            this.prProgress2.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prProgress2.TabIndex = 3;
            // 
            // lbCountStan
            // 
            this.lbCountStan.AutoSize = true;
            this.lbCountStan.Location = new System.Drawing.Point(146, 47);
            this.lbCountStan.Name = "lbCountStan";
            this.lbCountStan.Size = new System.Drawing.Size(16, 17);
            this.lbCountStan.TabIndex = 9;
            this.lbCountStan.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Всего загружено:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbLineStan);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbColumnStan);
            this.groupBox3.Controls.Add(this.tbSelectStan);
            this.groupBox3.Controls.Add(this.btSelectFileStan);
            this.groupBox3.Controls.Add(this.tbSelect);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btSelectFile);
            this.groupBox3.Controls.Add(this.tbLine);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbColumn);
            this.groupBox3.Location = new System.Drawing.Point(20, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 158);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "2. Выберите файлы с расширением *.xsls";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Задайте число строк\r\n";
            // 
            // tbLineStan
            // 
            this.tbLineStan.Location = new System.Drawing.Point(160, 121);
            this.tbLineStan.Name = "tbLineStan";
            this.tbLineStan.Size = new System.Drawing.Size(55, 22);
            this.tbLineStan.TabIndex = 19;
            this.tbLineStan.Text = "1000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Задайте число столбцов";
            // 
            // tbColumnStan
            // 
            this.tbColumnStan.Location = new System.Drawing.Point(397, 121);
            this.tbColumnStan.Name = "tbColumnStan";
            this.tbColumnStan.Size = new System.Drawing.Size(49, 22);
            this.tbColumnStan.TabIndex = 21;
            this.tbColumnStan.Text = "32";
            // 
            // tbSelectStan
            // 
            this.tbSelectStan.Location = new System.Drawing.Point(260, 89);
            this.tbSelectStan.Name = "tbSelectStan";
            this.tbSelectStan.Size = new System.Drawing.Size(186, 22);
            this.tbSelectStan.TabIndex = 17;
            this.tbSelectStan.Text = "H:\\osm.xlsx";
            // 
            // btSelectFileStan
            // 
            this.btSelectFileStan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSelectFileStan.Location = new System.Drawing.Point(9, 89);
            this.btSelectFileStan.Name = "btSelectFileStan";
            this.btSelectFileStan.Size = new System.Drawing.Size(233, 25);
            this.btSelectFileStan.TabIndex = 16;
            this.btSelectFileStan.Text = "Выберите файл с остановками";
            this.btSelectFileStan.UseVisualStyleBackColor = true;
            this.btSelectFileStan.Click += new System.EventHandler(this.btSelectFileStan_Click);
            // 
            // tbSelect
            // 
            this.tbSelect.Location = new System.Drawing.Point(260, 30);
            this.tbSelect.Name = "tbSelect";
            this.tbSelect.Size = new System.Drawing.Size(186, 22);
            this.tbSelect.TabIndex = 15;
            this.tbSelect.Text = "H:\\osm.xlsx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Задайте число строк\r\n";
            // 
            // btSelectFile
            // 
            this.btSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSelectFile.Location = new System.Drawing.Point(9, 31);
            this.btSelectFile.Name = "btSelectFile";
            this.btSelectFile.Size = new System.Drawing.Size(206, 25);
            this.btSelectFile.TabIndex = 14;
            this.btSelectFile.Text = "Выберите файл с трассами";
            this.btSelectFile.UseVisualStyleBackColor = true;
            this.btSelectFile.Click += new System.EventHandler(this.btSelectFile_Click);
            // 
            // tbLine
            // 
            this.tbLine.Location = new System.Drawing.Point(160, 61);
            this.tbLine.Name = "tbLine";
            this.tbLine.Size = new System.Drawing.Size(55, 22);
            this.tbLine.TabIndex = 5;
            this.tbLine.Text = "401";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Задайте число столбцов";
            // 
            // tbColumn
            // 
            this.tbColumn.Location = new System.Drawing.Point(397, 61);
            this.tbColumn.Name = "tbColumn";
            this.tbColumn.Size = new System.Drawing.Size(49, 22);
            this.tbColumn.TabIndex = 7;
            this.tbColumn.Text = "752";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Убедитесь, что файл (формата *.xlsx) для импорта подготовлен правильно! Занесе" +
    "ние неверных файлов приведёт к неправельному построению маршрутов и  дальнейшей " +
    "работе!!!";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "5. Если все данные подготовлены, отметьте галочку.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.prProgressI);
            this.groupBox2.Controls.Add(this.lbCount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(26, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 76);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ход процесса:";
            // 
            // prProgressI
            // 
            this.prProgressI.Location = new System.Drawing.Point(22, 21);
            this.prProgressI.MarqueeAnimationSpeed = 15;
            this.prProgressI.Maximum = 23000;
            this.prProgressI.Name = "prProgressI";
            this.prProgressI.Size = new System.Drawing.Size(191, 23);
            this.prProgressI.Step = 1;
            this.prProgressI.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prProgressI.TabIndex = 3;
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(146, 47);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(16, 17);
            this.lbCount.TabIndex = 9;
            this.lbCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Всего загружено:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.lbDirectionOfRoute);
            this.panel2.Controls.Add(this.lbCoordinate_X);
            this.panel2.Controls.Add(this.lbTransportMode);
            this.panel2.Controls.Add(this.lbRouteNamber);
            this.panel2.Controls.Add(this.lbCoordinate_Y);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 82);
            this.panel2.TabIndex = 15;
            // 
            // lbDirectionOfRoute
            // 
            this.lbDirectionOfRoute.AutoSize = true;
            this.lbDirectionOfRoute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDirectionOfRoute.Location = new System.Drawing.Point(6, 30);
            this.lbDirectionOfRoute.Name = "lbDirectionOfRoute";
            this.lbDirectionOfRoute.Size = new System.Drawing.Size(165, 17);
            this.lbDirectionOfRoute.TabIndex = 2;
            this.lbDirectionOfRoute.Text = "Направление движения";
            // 
            // lbCoordinate_X
            // 
            this.lbCoordinate_X.AutoSize = true;
            this.lbCoordinate_X.Location = new System.Drawing.Point(6, 43);
            this.lbCoordinate_X.Name = "lbCoordinate_X";
            this.lbCoordinate_X.Size = new System.Drawing.Size(101, 17);
            this.lbCoordinate_X.TabIndex = 7;
            this.lbCoordinate_X.Text = "Координата X";
            // 
            // lbTransportMode
            // 
            this.lbTransportMode.AutoSize = true;
            this.lbTransportMode.Location = new System.Drawing.Point(6, 0);
            this.lbTransportMode.Name = "lbTransportMode";
            this.lbTransportMode.Size = new System.Drawing.Size(190, 17);
            this.lbTransportMode.TabIndex = 4;
            this.lbTransportMode.Text = "Вид городского транспорта";
            // 
            // lbRouteNamber
            // 
            this.lbRouteNamber.AutoSize = true;
            this.lbRouteNamber.Location = new System.Drawing.Point(6, 15);
            this.lbRouteNamber.Name = "lbRouteNamber";
            this.lbRouteNamber.Size = new System.Drawing.Size(121, 17);
            this.lbRouteNamber.TabIndex = 3;
            this.lbRouteNamber.Text = "Номер маршрута";
            // 
            // lbCoordinate_Y
            // 
            this.lbCoordinate_Y.AutoSize = true;
            this.lbCoordinate_Y.Location = new System.Drawing.Point(6, 60);
            this.lbCoordinate_Y.Name = "lbCoordinate_Y";
            this.lbCoordinate_Y.Size = new System.Drawing.Size(101, 17);
            this.lbCoordinate_Y.TabIndex = 6;
            this.lbCoordinate_Y.Text = "Координата Y";
            // 
            // gbMarsh
            // 
            this.gbMarsh.Controls.Add(this.panel2);
            this.gbMarsh.Location = new System.Drawing.Point(503, 86);
            this.gbMarsh.Name = "gbMarsh";
            this.gbMarsh.Size = new System.Drawing.Size(357, 103);
            this.gbMarsh.TabIndex = 2;
            this.gbMarsh.TabStop = false;
            this.gbMarsh.Text = "Трасса маршрута";
            // 
            // gbPassagenerStop
            // 
            this.gbPassagenerStop.Controls.Add(this.panel1);
            this.gbPassagenerStop.Location = new System.Drawing.Point(503, 192);
            this.gbPassagenerStop.Name = "gbPassagenerStop";
            this.gbPassagenerStop.Size = new System.Drawing.Size(357, 191);
            this.gbPassagenerStop.TabIndex = 3;
            this.gbPassagenerStop.TabStop = false;
            this.gbPassagenerStop.Text = "Остановки";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.lbTheNameOfTheStop);
            this.panel1.Controls.Add(this.lbDistrict);
            this.panel1.Controls.Add(this.lbAdministrativeDistrict);
            this.panel1.Controls.Add(this.lbStreet);
            this.panel1.Controls.Add(this.lbDirection);
            this.panel1.Controls.Add(this.lbCoordinate_X_stan);
            this.panel1.Controls.Add(this.lbRouteNamber_stan);
            this.panel1.Controls.Add(this.lbTransportMode_stan);
            this.panel1.Controls.Add(this.lbCoordinate_Y_stan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 170);
            this.panel1.TabIndex = 16;
            // 
            // lbTheNameOfTheStop
            // 
            this.lbTheNameOfTheStop.AutoSize = true;
            this.lbTheNameOfTheStop.Location = new System.Drawing.Point(6, 93);
            this.lbTheNameOfTheStop.Name = "lbTheNameOfTheStop";
            this.lbTheNameOfTheStop.Size = new System.Drawing.Size(144, 17);
            this.lbTheNameOfTheStop.TabIndex = 11;
            this.lbTheNameOfTheStop.Text = "Название остановки";
            // 
            // lbDistrict
            // 
            this.lbDistrict.AutoSize = true;
            this.lbDistrict.Location = new System.Drawing.Point(6, 76);
            this.lbDistrict.Name = "lbDistrict";
            this.lbDistrict.Size = new System.Drawing.Size(49, 17);
            this.lbDistrict.TabIndex = 10;
            this.lbDistrict.Text = "Район";
            // 
            // lbAdministrativeDistrict
            // 
            this.lbAdministrativeDistrict.AutoSize = true;
            this.lbAdministrativeDistrict.Location = new System.Drawing.Point(6, 59);
            this.lbAdministrativeDistrict.Name = "lbAdministrativeDistrict";
            this.lbAdministrativeDistrict.Size = new System.Drawing.Size(175, 17);
            this.lbAdministrativeDistrict.TabIndex = 9;
            this.lbAdministrativeDistrict.Text = "Административный округ";
            // 
            // lbStreet
            // 
            this.lbStreet.AutoSize = true;
            this.lbStreet.Location = new System.Drawing.Point(6, 42);
            this.lbStreet.Name = "lbStreet";
            this.lbStreet.Size = new System.Drawing.Size(339, 17);
            this.lbStreet.TabIndex = 8;
            this.lbStreet.Text = "Название улицы на которой находится остановка";
            // 
            // lbDirection
            // 
            this.lbDirection.AutoSize = true;
            this.lbDirection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDirection.Location = new System.Drawing.Point(6, 110);
            this.lbDirection.Name = "lbDirection";
            this.lbDirection.Size = new System.Drawing.Size(97, 17);
            this.lbDirection.TabIndex = 2;
            this.lbDirection.Text = "Направление";
            // 
            // lbCoordinate_X_stan
            // 
            this.lbCoordinate_X_stan.AutoSize = true;
            this.lbCoordinate_X_stan.Location = new System.Drawing.Point(6, 23);
            this.lbCoordinate_X_stan.Name = "lbCoordinate_X_stan";
            this.lbCoordinate_X_stan.Size = new System.Drawing.Size(101, 17);
            this.lbCoordinate_X_stan.TabIndex = 7;
            this.lbCoordinate_X_stan.Text = "Координата X";
            // 
            // lbRouteNamber_stan
            // 
            this.lbRouteNamber_stan.AutoSize = true;
            this.lbRouteNamber_stan.Location = new System.Drawing.Point(6, 145);
            this.lbRouteNamber_stan.Name = "lbRouteNamber_stan";
            this.lbRouteNamber_stan.Size = new System.Drawing.Size(121, 17);
            this.lbRouteNamber_stan.TabIndex = 3;
            this.lbRouteNamber_stan.Text = "Номер маршрута";
            // 
            // lbTransportMode_stan
            // 
            this.lbTransportMode_stan.AutoSize = true;
            this.lbTransportMode_stan.Location = new System.Drawing.Point(6, 127);
            this.lbTransportMode_stan.Name = "lbTransportMode_stan";
            this.lbTransportMode_stan.Size = new System.Drawing.Size(190, 17);
            this.lbTransportMode_stan.TabIndex = 4;
            this.lbTransportMode_stan.Text = "Вид городского транспорта";
            // 
            // lbCoordinate_Y_stan
            // 
            this.lbCoordinate_Y_stan.AutoSize = true;
            this.lbCoordinate_Y_stan.Location = new System.Drawing.Point(6, 6);
            this.lbCoordinate_Y_stan.Name = "lbCoordinate_Y_stan";
            this.lbCoordinate_Y_stan.Size = new System.Drawing.Size(101, 17);
            this.lbCoordinate_Y_stan.TabIndex = 6;
            this.lbCoordinate_Y_stan.Text = "Координата Y";
            // 
            // gbNomerMarsh
            // 
            this.gbNomerMarsh.Controls.Add(this.panel3);
            this.gbNomerMarsh.Location = new System.Drawing.Point(503, 12);
            this.gbNomerMarsh.Name = "gbNomerMarsh";
            this.gbNomerMarsh.Size = new System.Drawing.Size(357, 68);
            this.gbNomerMarsh.TabIndex = 4;
            this.gbNomerMarsh.TabStop = false;
            this.gbNomerMarsh.Text = "Вид и номер маршрута";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.lbRouteNamber_);
            this.panel3.Controls.Add(this.lbTransportMode_);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 47);
            this.panel3.TabIndex = 15;
            // 
            // lbRouteNamber_
            // 
            this.lbRouteNamber_.AutoSize = true;
            this.lbRouteNamber_.Location = new System.Drawing.Point(6, 9);
            this.lbRouteNamber_.Name = "lbRouteNamber_";
            this.lbRouteNamber_.Size = new System.Drawing.Size(121, 17);
            this.lbRouteNamber_.TabIndex = 3;
            this.lbRouteNamber_.Text = "Номер маршрута";
            // 
            // lbTransportMode_
            // 
            this.lbTransportMode_.AutoSize = true;
            this.lbTransportMode_.Location = new System.Drawing.Point(6, 26);
            this.lbTransportMode_.Name = "lbTransportMode_";
            this.lbTransportMode_.Size = new System.Drawing.Size(190, 17);
            this.lbTransportMode_.TabIndex = 4;
            this.lbTransportMode_.Text = "Вид городского транспорта";
            // 
            // fmImportTrassMarsh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(865, 413);
            this.Controls.Add(this.gbNomerMarsh);
            this.Controls.Add(this.gbPassagenerStop);
            this.Controls.Add(this.gbMarsh);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmImportTrassMarsh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Импорт трасс маршрутов и остановочных пунктов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbMarsh.ResumeLayout(false);
            this.gbPassagenerStop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbNomerMarsh.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbSelect;
        private System.Windows.Forms.Button btSelectFile;
        private System.Windows.Forms.TextBox tbColumn;
        private System.Windows.Forms.CheckBox chOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar prProgressI;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDirectionOfRoute;
        private System.Windows.Forms.Label lbRouteNamber;
        private System.Windows.Forms.Label lbTransportMode;
        private System.Windows.Forms.Label lbCoordinate_Y;
        private System.Windows.Forms.Label lbCoordinate_X;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbSelectStan;
        private System.Windows.Forms.Button btSelectFileStan;
        private System.Windows.Forms.GroupBox gbMarsh;
        private System.Windows.Forms.GroupBox gbPassagenerStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTheNameOfTheStop;
        private System.Windows.Forms.Label lbDistrict;
        private System.Windows.Forms.Label lbAdministrativeDistrict;
        private System.Windows.Forms.Label lbStreet;
        private System.Windows.Forms.Label lbDirection;
        private System.Windows.Forms.Label lbCoordinate_X_stan;
        private System.Windows.Forms.Label lbRouteNamber_stan;
        private System.Windows.Forms.Label lbTransportMode_stan;
        private System.Windows.Forms.Label lbCoordinate_Y_stan;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ProgressBar prProgress2;
        private System.Windows.Forms.Label lbCountStan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLineStan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbColumnStan;
        private System.Windows.Forms.GroupBox gbNomerMarsh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbRouteNamber_;
        private System.Windows.Forms.Label lbTransportMode_;
    }
}