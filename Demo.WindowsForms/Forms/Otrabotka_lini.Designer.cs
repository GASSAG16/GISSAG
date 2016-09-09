namespace Demo.WindowsForms.Forms
{
    partial class Otrabotka_lini
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
            this.map1 = new Demo.WindowsForms.Map();
            this.SuspendLayout();
            // 
            // map1
            // 
            this.map1.Bearing = 0F;
            this.map1.CanDragMap = true;
            this.map1.EmptyTileColor = System.Drawing.Color.Navy;
            this.map1.GrayScaleMode = false;
            this.map1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map1.LevelsKeepInMemmory = 5;
            this.map1.Location = new System.Drawing.Point(12, 12);
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
            this.map1.Size = new System.Drawing.Size(150, 150);
            this.map1.TabIndex = 0;
            this.map1.Zoom = 0D;
            // 
            // Otrabotka_lini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 529);
            this.Controls.Add(this.map1);
            this.Name = "Otrabotka_lini";
            this.Text = "Otrabotka_lini";
            this.ResumeLayout(false);

        }

        #endregion

        private Map map1;
    }
}