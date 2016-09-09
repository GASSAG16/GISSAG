namespace Demo.WindowsForms.Forms
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDirectionOfRoute = new System.Windows.Forms.Label();
            this.lbCoordinate_X = new System.Windows.Forms.Label();
            this.lbRouteNamber = new System.Windows.Forms.Label();
            this.lbTransportMode = new System.Windows.Forms.Label();
            this.lbCoordinate_Y = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbSelect = new System.Windows.Forms.TextBox();
            this.btSelectFile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.prProgressI = new System.Windows.Forms.ProgressBar();
            this.lbCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbColumn = new System.Windows.Forms.TextBox();
            this.chOk = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tbColumn);
            this.groupBox1.Controls.Add(this.chOk);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbLine);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 358);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Внимательно прочитать";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.lbDirectionOfRoute);
            this.panel2.Controls.Add(this.lbCoordinate_X);
            this.panel2.Controls.Add(this.lbRouteNamber);
            this.panel2.Controls.Add(this.lbTransportMode);
            this.panel2.Controls.Add(this.lbCoordinate_Y);
            this.panel2.Location = new System.Drawing.Point(281, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 96);
            this.panel2.TabIndex = 15;
            // 
            // lbDirectionOfRoute
            // 
            this.lbDirectionOfRoute.AutoSize = true;
            this.lbDirectionOfRoute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDirectionOfRoute.Location = new System.Drawing.Point(6, 5);
            this.lbDirectionOfRoute.Name = "lbDirectionOfRoute";
            this.lbDirectionOfRoute.Size = new System.Drawing.Size(165, 17);
            this.lbDirectionOfRoute.TabIndex = 2;
            this.lbDirectionOfRoute.Text = "Направление движения";
            // 
            // lbCoordinate_X
            // 
            this.lbCoordinate_X.AutoSize = true;
            this.lbCoordinate_X.Location = new System.Drawing.Point(6, 74);
            this.lbCoordinate_X.Name = "lbCoordinate_X";
            this.lbCoordinate_X.Size = new System.Drawing.Size(101, 17);
            this.lbCoordinate_X.TabIndex = 7;
            this.lbCoordinate_X.Text = "Координата X";
            // 
            // lbRouteNamber
            // 
            this.lbRouteNamber.AutoSize = true;
            this.lbRouteNamber.Location = new System.Drawing.Point(6, 23);
            this.lbRouteNamber.Name = "lbRouteNamber";
            this.lbRouteNamber.Size = new System.Drawing.Size(121, 17);
            this.lbRouteNamber.TabIndex = 3;
            this.lbRouteNamber.Text = "Номер маршрута";
            // 
            // lbTransportMode
            // 
            this.lbTransportMode.AutoSize = true;
            this.lbTransportMode.Location = new System.Drawing.Point(6, 40);
            this.lbTransportMode.Name = "lbTransportMode";
            this.lbTransportMode.Size = new System.Drawing.Size(190, 17);
            this.lbTransportMode.TabIndex = 4;
            this.lbTransportMode.Text = "Вид городского транспорта";
            // 
            // lbCoordinate_Y
            // 
            this.lbCoordinate_Y.AutoSize = true;
            this.lbCoordinate_Y.Location = new System.Drawing.Point(6, 57);
            this.lbCoordinate_Y.Name = "lbCoordinate_Y";
            this.lbCoordinate_Y.Size = new System.Drawing.Size(101, 17);
            this.lbCoordinate_Y.TabIndex = 6;
            this.lbCoordinate_Y.Text = "Координата Y";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbSelect);
            this.groupBox3.Controls.Add(this.btSelectFile);
            this.groupBox3.Location = new System.Drawing.Point(20, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 68);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "2. Выберите файлы с расширением *.xsls";
            // 
            // tbSelect
            // 
            this.tbSelect.Location = new System.Drawing.Point(261, 33);
            this.tbSelect.Name = "tbSelect";
            this.tbSelect.Size = new System.Drawing.Size(178, 22);
            this.tbSelect.TabIndex = 15;
            this.tbSelect.Text = "H:\\osm.xlsx";
            // 
            // btSelectFile
            // 
            this.btSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSelectFile.Location = new System.Drawing.Point(22, 30);
            this.btSelectFile.Name = "btSelectFile";
            this.btSelectFile.Size = new System.Drawing.Size(233, 25);
            this.btSelectFile.TabIndex = 14;
            this.btSelectFile.Text = "Выберите файл с трассами";
            this.btSelectFile.UseVisualStyleBackColor = true;
            this.btSelectFile.Click += new System.EventHandler(this.btSelectFile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.prProgressI);
            this.groupBox2.Controls.Add(this.lbCount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(20, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 76);
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
            this.prProgressI.Size = new System.Drawing.Size(417, 23);
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
            // tbColumn
            // 
            this.tbColumn.Location = new System.Drawing.Point(225, 192);
            this.tbColumn.Name = "tbColumn";
            this.tbColumn.Size = new System.Drawing.Size(53, 22);
            this.tbColumn.TabIndex = 7;
            this.tbColumn.Text = "119";
            // 
            // chOk
            // 
            this.chOk.AutoSize = true;
            this.chOk.Location = new System.Drawing.Point(225, 239);
            this.chOk.Name = "chOk";
            this.chOk.Size = new System.Drawing.Size(50, 21);
            this.chOk.TabIndex = 0;
            this.chOk.Text = "ОК";
            this.chOk.UseVisualStyleBackColor = true;
            this.chOk.CheckStateChanged += new System.EventHandler(this.chOk_CheckStateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "4. Задайте число столбцов";
            // 
            // tbLine
            // 
            this.tbLine.Location = new System.Drawing.Point(225, 166);
            this.tbLine.Name = "tbLine";
            this.tbLine.Size = new System.Drawing.Size(53, 22);
            this.tbLine.TabIndex = 5;
            this.tbLine.Text = "752";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "3. Задайте число строк\r\n";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "5. Если все данные подготовлены, отметьте галочку.";
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
            // fmImportTrassMarsh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(507, 378);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "fmImportTrassMarsh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Импорт трасс маршрутов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}