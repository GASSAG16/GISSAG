using System;
using System.Windows.Forms;

namespace WindowsForms.Forms
{
    public partial class fmImportTrassMarsh : Form
    {
        OpenFileDialog marsh = new OpenFileDialog();
        
        public fmImportTrassMarsh()
        {
            InitializeComponent();
        }

        private void btSelectFile_Click(object sender, EventArgs e)
        {            
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
            ImportRoutesOfTheRoute.ImportRoutesOfTheRoute(tbLine, tbColumn, tbSelect,lbRouteNamber_,lbTransportMode_);
            ImportRoutesOfTheRoute.ImportDirectionOfRoute(tbLine, tbColumn, tbSelect, lbRouteNamber, lbTransportMode, lbDirectionOfRoute);
            ImportRoutesOfTheRoute.ImportCoordinate(tbLine, tbColumn, tbSelect, lbDirectionOfRoute, lbCoordinate_X, lbCoordinate_Y, prProgressI, lbCount);
            ImportRoutesOfTheRoute.ImportDataAboutStops(tbLineStan, tbColumnStan, tbSelectStan, lbCoordinate_Y_stan, lbCoordinate_X_stan, lbStreet, lbAdministrativeDistrict, lbDistrict, lbTheNameOfTheStop, lbDirection, lbTransportMode_stan, lbRouteNamber_stan, prProgress2, lbCountStan);

            this.Close();
        }

        private void btSelectFileStan_Click(object sender, EventArgs e)
        {
            marsh.Title = "Выберите файл";
            marsh.Filter = "Файлы Excel|*.xlsx";
            if (marsh.ShowDialog() == DialogResult.OK)
            {
                string text = marsh.ToString();
                text = text.Replace("System.Windows.Forms.OpenFileDialog: Title: Выберите файл, FileName: ", "");
                tbSelectStan.Text = text;
            }  

        }
    }
}