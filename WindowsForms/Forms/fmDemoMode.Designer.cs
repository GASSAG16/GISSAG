namespace WindowsForms.Forms
{
    partial class fmDemoMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDemoMode));
            this.ssMenu = new System.Windows.Forms.MenuStrip();
            this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbImportRoutesOfTheRoute = new System.Windows.Forms.ToolStripMenuItem();
            this.lbAboitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbSpisokZadachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PoRainamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PoUlichamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PoVsemyGorodyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.paInfo = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.mapen = new WindowsForms.Map();
            this.ssMenu.SuspendLayout();
            this.paInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssMenu
            // 
            this.ssMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripMenuItem,
            this.lbSpisokZadachToolStripMenuItem});
            this.ssMenu.Location = new System.Drawing.Point(0, 0);
            this.ssMenu.Name = "ssMenu";
            this.ssMenu.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.ssMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ssMenu.Size = new System.Drawing.Size(1203, 30);
            this.ssMenu.TabIndex = 0;
            this.ssMenu.Text = "Меню";
            // 
            // MenuToolStripMenuItem
            // 
            this.MenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbImportRoutesOfTheRoute,
            this.lbAboitToolStripMenuItem,
            this.lbExitToolStripMenuItem});
            this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            this.MenuToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.MenuToolStripMenuItem.Text = "Меню";
            // 
            // lbImportRoutesOfTheRoute
            // 
            this.lbImportRoutesOfTheRoute.Name = "lbImportRoutesOfTheRoute";
            this.lbImportRoutesOfTheRoute.Size = new System.Drawing.Size(257, 24);
            this.lbImportRoutesOfTheRoute.Text = "Импорт трасс маршрутов";
            this.lbImportRoutesOfTheRoute.Click += new System.EventHandler(this.bImportRoutesOfTheRoute_Click);
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
            this.toolStripMenuItem1,
            this.TransportToolStripMenuItem});
            this.lbSpisokZadachToolStripMenuItem.Name = "lbSpisokZadachToolStripMenuItem";
            this.lbSpisokZadachToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.lbSpisokZadachToolStripMenuItem.Text = "Список задач";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PoRainamToolStripMenuItem,
            this.PoUlichamToolStripMenuItem,
            this.PoVsemyGorodyToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(619, 24);
            this.toolStripMenuItem1.Text = "Отображение остановок";
            // 
            // PoRainamToolStripMenuItem
            // 
            this.PoRainamToolStripMenuItem.Name = "PoRainamToolStripMenuItem";
            this.PoRainamToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.PoRainamToolStripMenuItem.Text = "по районам";
            this.PoRainamToolStripMenuItem.Click += new System.EventHandler(this.PoRainamToolStripMenuItem_Click);
            // 
            // PoUlichamToolStripMenuItem
            // 
            this.PoUlichamToolStripMenuItem.Name = "PoUlichamToolStripMenuItem";
            this.PoUlichamToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.PoUlichamToolStripMenuItem.Text = "по улицам";
            this.PoUlichamToolStripMenuItem.Click += new System.EventHandler(this.PoUlichamToolStripMenuItem_Click);
            // 
            // PoVsemyGorodyToolStripMenuItem
            // 
            this.PoVsemyGorodyToolStripMenuItem.Name = "PoVsemyGorodyToolStripMenuItem";
            this.PoVsemyGorodyToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.PoVsemyGorodyToolStripMenuItem.Text = "по всему городу";
            this.PoVsemyGorodyToolStripMenuItem.Click += new System.EventHandler(this.PoVsemyGorodyToolStripMenuItem_Click);
            // 
            // TransportToolStripMenuItem
            // 
            this.TransportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.TransportToolStripMenuItem.Name = "TransportToolStripMenuItem";
            this.TransportToolStripMenuItem.Size = new System.Drawing.Size(619, 24);
            this.TransportToolStripMenuItem.Text = "Отображение  маршрутов городского пассажирского наземного транспорта";
            this.TransportToolStripMenuItem.Click += new System.EventHandler(this.TransportToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 24);
            this.toolStripMenuItem2.Text = "Прямой";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(150, 24);
            this.toolStripMenuItem3.Text = "Обратный";
            // 
            // paInfo
            // 
            this.paInfo.BackColor = System.Drawing.SystemColors.Info;
            this.paInfo.Controls.Add(this.label9);
            this.paInfo.Controls.Add(this.label10);
            this.paInfo.Controls.Add(this.label8);
            this.paInfo.Controls.Add(this.label5);
            this.paInfo.Controls.Add(this.label6);
            this.paInfo.Controls.Add(this.label7);
            this.paInfo.Controls.Add(this.label4);
            this.paInfo.Controls.Add(this.label3);
            this.paInfo.Controls.Add(this.btClose);
            this.paInfo.Location = new System.Drawing.Point(12, 100);
            this.paInfo.Name = "paInfo";
            this.paInfo.Size = new System.Drawing.Size(618, 260);
            this.paInfo.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(30, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(587, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "- улучшена читабельность и поддержаемость кода, отлажен импорт";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(4, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(383, 22);
            this.label10.TabIndex = 8;
            this.label10.Text = "В версии от 9 сентября 2016 года доступно:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(30, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(559, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "- отображение остановок городского пассажирского транспорта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(375, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "В версии от 30 апреля 2016 года доступно:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(30, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "- отображение трассы маршрута";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(4, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(338, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "В версии от 1 мая 2016 года доступно:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(369, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "- отображение административного округа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "В версии от 27 июня 2016 года доступно:";
            // 
            // btClose
            // 
            this.btClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btClose.Location = new System.Drawing.Point(587, 0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(28, 36);
            this.btClose.TabIndex = 0;
            this.btClose.Text = "X";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.button1_Click);
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
            this.mapen.Size = new System.Drawing.Size(1203, 494);
            this.mapen.TabIndex = 7;
            this.mapen.Zoom = 0D;
            // 
            // fmDemoMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 494);
            this.Controls.Add(this.paInfo);
            this.Controls.Add(this.ssMenu);
            this.Controls.Add(this.mapen);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ssMenu;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fmDemoMode";
            this.Text = "Добро пожаловать в программу GISSAG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SamaPrograma_FormClosed);
            this.Load += new System.EventHandler(this.SamaPrograma_Load);
            this.ssMenu.ResumeLayout(false);
            this.ssMenu.PerformLayout();
            this.paInfo.ResumeLayout(false);
            this.paInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ssMenu;
        private System.Windows.Forms.ToolStripMenuItem lbSpisokZadachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem PoRainamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PoUlichamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PoVsemyGorodyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lbAboitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lbExitToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem TransportToolStripMenuItem;
        //private Map mapen;
        private System.Windows.Forms.ToolStripMenuItem lbImportRoutesOfTheRoute;
        private System.Windows.Forms.Panel paInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Map mapen;
        
    }
}