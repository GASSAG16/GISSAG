namespace Demo.WindowsForms.Forms
{
    partial class SamaProgramaFull
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузкаОсновыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OnLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpisokZadachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PoRainamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PoUlichamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PoVsemyGorodyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripMenuItem,
            this.SpisokZadachToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1203, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuToolStripMenuItem
            // 
            this.MenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузкаОсновыToolStripMenuItem,
            this.AboitToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            this.MenuToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.MenuToolStripMenuItem.Text = "Меню";
            // 
            // загрузкаОсновыToolStripMenuItem
            // 
            this.загрузкаОсновыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnLineToolStripMenuItem,
            this.LocalToolStripMenuItem});
            this.загрузкаОсновыToolStripMenuItem.Enabled = false;
            this.загрузкаОсновыToolStripMenuItem.Name = "загрузкаОсновыToolStripMenuItem";
            this.загрузкаОсновыToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.загрузкаОсновыToolStripMenuItem.Text = "Загрузка основы";
            this.загрузкаОсновыToolStripMenuItem.ToolTipText = "Будет доступно в следующей версии";
            // 
            // OnLineToolStripMenuItem
            // 
            this.OnLineToolStripMenuItem.Name = "OnLineToolStripMenuItem";
            this.OnLineToolStripMenuItem.Size = new System.Drawing.Size(412, 24);
            this.OnLineToolStripMenuItem.Text = "он-лайн версия (требуется связь с интернетом)";
            this.OnLineToolStripMenuItem.Click += new System.EventHandler(this.OnLineToolStripMenuItem_Click);
            // 
            // LocalToolStripMenuItem
            // 
            this.LocalToolStripMenuItem.Name = "LocalToolStripMenuItem";
            this.LocalToolStripMenuItem.Size = new System.Drawing.Size(412, 24);
            this.LocalToolStripMenuItem.Text = "локальная версия (прогруженная с интернета";
            // 
            // AboitToolStripMenuItem
            // 
            this.AboitToolStripMenuItem.Name = "AboitToolStripMenuItem";
            this.AboitToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.AboitToolStripMenuItem.Text = "О программе";
            this.AboitToolStripMenuItem.Click += new System.EventHandler(this.AboitToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // SpisokZadachToolStripMenuItem
            // 
            this.SpisokZadachToolStripMenuItem.AccessibleName = "";
            this.SpisokZadachToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.TransportToolStripMenuItem});
            this.SpisokZadachToolStripMenuItem.Name = "SpisokZadachToolStripMenuItem";
            this.SpisokZadachToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.SpisokZadachToolStripMenuItem.Text = "Список задач";
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
            this.PoRainamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.PoRainamToolStripMenuItem.Name = "PoRainamToolStripMenuItem";
            this.PoRainamToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.PoRainamToolStripMenuItem.Text = "по районам";
            this.PoRainamToolStripMenuItem.Click += new System.EventHandler(this.PoRainamToolStripMenuItem_Click);
            // 
            // PoUlichamToolStripMenuItem
            // 
            this.PoUlichamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
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
            this.TransportToolStripMenuItem.Name = "TransportToolStripMenuItem";
            this.TransportToolStripMenuItem.Size = new System.Drawing.Size(619, 24);
            this.TransportToolStripMenuItem.Text = "Отображение  маршрутов городского пассажирского наземного транспорта";
            this.TransportToolStripMenuItem.Click += new System.EventHandler(this.TransportToolStripMenuItem_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 27);
            this.label12.TabIndex = 2;
            this.label12.Text = "label1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 27);
            this.label14.TabIndex = 3;
            this.label14.Text = "label14";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(12, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 128);
            this.panel1.TabIndex = 4;
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox1.Text = "Выбрать";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox2.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox2_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 27);
            this.label13.TabIndex = 4;
            this.label13.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // SamaProgramaFull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SamaProgramaFull";
            this.Text = "Добро пожаловать в программу GISSAG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SamaPrograma_FormClosed);
            this.Load += new System.EventHandler(this.SamaPrograma_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SpisokZadachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem PoRainamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PoUlichamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PoVsemyGorodyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузкаОсновыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OnLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem TransportToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
    }
}