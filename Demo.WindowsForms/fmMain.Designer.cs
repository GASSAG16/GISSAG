namespace Demo.WindowsForms
{
    partial class fmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbCopyright = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btDemoMode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btFullDemo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(220, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 109);
            this.label1.TabIndex = 0;
            this.label1.Text = "GISSAG";
            // 
            // lbCopyright
            // 
            this.lbCopyright.AutoSize = true;
            this.lbCopyright.Location = new System.Drawing.Point(326, 239);
            this.lbCopyright.Name = "lbCopyright";
            this.lbCopyright.Size = new System.Drawing.Size(206, 17);
            this.lbCopyright.TabIndex = 1;
            this.lbCopyright.Text = "Made Grishanin A. S. age 2016";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbVersion.Location = new System.Drawing.Point(17, 25);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(114, 17);
            this.lbVersion.TabIndex = 2;
            this.lbVersion.Text = "Версия pre-beta";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 96);
            this.label4.TabIndex = 3;
            this.label4.Text = "Информационная система";
            // 
            // btDemoMode
            // 
            this.btDemoMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDemoMode.Location = new System.Drawing.Point(6, 21);
            this.btDemoMode.Name = "btDemoMode";
            this.btDemoMode.Size = new System.Drawing.Size(164, 29);
            this.btDemoMode.TabIndex = 4;
            this.btDemoMode.Text = "Демонстрационный";
            this.btDemoMode.UseVisualStyleBackColor = true;
            this.btDemoMode.Click += new System.EventHandler(this.btDemoMode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btFullDemo);
            this.groupBox1.Controls.Add(this.btDemoMode);
            this.groupBox1.Location = new System.Drawing.Point(343, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 98);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите режим";
            // 
            // btFullDemo
            // 
            this.btFullDemo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btFullDemo.Location = new System.Drawing.Point(6, 56);
            this.btFullDemo.Name = "btFullDemo";
            this.btFullDemo.Size = new System.Drawing.Size(133, 29);
            this.btFullDemo.TabIndex = 5;
            this.btFullDemo.Text = "Полный";
            this.btFullDemo.UseVisualStyleBackColor = true;
            this.btFullDemo.Click += new System.EventHandler(this.btFullDemo_Click);
            // 
            // fmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(561, 291);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lbCopyright);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCopyright;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btDemoMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btFullDemo;
    }
}