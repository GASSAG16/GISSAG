using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo.WindowsForms.Forms
{
    public partial class fmImportTrassMarsh : Form
    {
        public fmImportTrassMarsh()
        {
            InitializeComponent();
        }

        private void btSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog marsh = new OpenFileDialog();
            marsh.Title = "Выберите файл";
            marsh.Filter = "Файлы Excel|*.xlsx";
            if (marsh.ShowDialog() == DialogResult.OK)
            {
                string text = marsh.ToString();
                text = text.Replace("System.Windows.Forms.OpenFileDialog: Title: Выберите файл, FileName: ", "");
                tbSelect.Text = text;
            }
        }

        private void chOk_CheckStateChanged(object sender, EventArgs e)
        {
            var ImportRoutesOfTheRoute = new Import();
            ImportRoutesOfTheRoute.ImportRoutesOfTheRoute(tbLine, tbColumn, tbSelect, lbDirectionOfRoute, lbRouteNamber, lbTransportMode, lbCoordinate_Y, lbCoordinate_X, prProgressI, lbCount);
            this.Close();
        }
    }
}