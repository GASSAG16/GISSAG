using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Demo.WindowsForms.CustomMarkers;
using System.Text;
using GMap.NET.MapProviders;
using System.Reflection;
using System.Text.RegularExpressions;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using BSE.Windows.Forms;
using System.Data.SqlClient;

namespace Demo.WindowsForms.Forms
{
    public partial class SamaProgramaServer : Form
    {
        // Слои 
        readonly GMapOverlay top = new GMapOverlay();
        internal readonly GMapOverlay objects = new GMapOverlay("objects");     // объекты
        internal readonly GMapOverlay routes = new GMapOverlay("routes");       // Дороги
        internal readonly GMapOverlay polygons = new GMapOverlay("polygons");   // Полигоны
        internal readonly GMapOverlay marshryt = new GMapOverlay("marshryt");   // Маршруты

        // Прочее
        readonly Random rnd = new Random();
        readonly DescendingComparer ComparerIpStatus = new DescendingComparer();
        GMapMarkerRect CurentRectMarker = null;

        // Полигон
        GMapPolygon polygon;


        public SamaProgramaServer()
        {
            InitializeComponent();
            if (!GMapControl.IsDesignerHosted)
            {

                // конфигурация карты  
                {
                    mapens.MapProvider = GMapProviders.YandexMap;       // провайдер карты
                    mapens.MinZoom = 0;
                    mapens.MaxZoom = 24;
                    mapens.Zoom = 9;
                }

                // события карты
                {
                    mapens.OnMarkerEnter += new MarkerEnter(mapens_OnMarkerEnter);  // События мыши при нажатии
                    mapens.OnMarkerLeave += new MarkerLeave(mapens_OnMarkerLeave); //  События мыши при отпускании
                }
                {
                    mapens.Overlays.Add(routes);         // добавление дорог
                    mapens.Overlays.Add(polygons);       // добавление полигонов
                    mapens.Overlays.Add(objects);        // добавление объектов
                    mapens.Overlays.Add(top);            // добавление обрамления
                    mapens.Overlays.Add(marshryt);       // добавление маршрута
                }
            }

        }
        void mapens_OnMarkerLeave(GMapMarker item)
        {
            if (item is GMapMarkerRect)
            {
                CurentRectMarker = null;
                GMapMarkerRect rc = item as GMapMarkerRect;
                rc.Pen.Color = Color.Blue;
                rc.ToolTipMode = MarkerTooltipMode.Never;
            }
        }
        void mapens_OnMarkerEnter(GMapMarker item)
        {
            if (item is GMapMarkerRect)
            {
                GMapMarkerRect rc = item as GMapMarkerRect;
                rc.Pen.Color = Color.Red;
                rc.ToolTipMode = MarkerTooltipMode.Always;
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.scalarVsegoZnachPoUlchamTableAdapter.Fill(this.gISSIGData.ScalarVsegoZnachPoUlcham, toolStripComboBox1.Text); // Запрос на сервер сколько значений
                this.scalarPoiskPoUlichamTableAdapter.Fill(this.gISSIGData.ScalarPoiskPoUlicham, toolStripComboBox1.Text);          //Отбор по конкретным улицам

                //-----------------------------------------
                int f = Convert.ToInt32(label1.Text);
                for (int v = 0; v < f; v++)
                {
                    scalarPoiskPoUlichambindingSource.MoveNext();
                    MexanizmOtobrageniya();
                }
                //--------------------------------------------
                scalarPoiskPoUlichambindingSource.MoveFirst(); // Переход к первой записи
                for (int v = 0; v < 1; v++)
                {
                    MexanizmOtobrageniya();
                }
                MessageBox.Show("Завершено!");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void MexanizmOtobrageniya()
        {
            label3.Text = label3.Text.Replace(",", ".");
            label4.Text = label4.Text.Replace(",", ".");                                        //Подготовка данных для сервера

            double lat = double.Parse(label4.Text, CultureInfo.InvariantCulture);
            double lng = double.Parse(label3.Text, CultureInfo.InvariantCulture);

            mapens.Position = new PointLatLng(lat, lng);                                           //Формирование координат

            GMarkerGoogle m = new GMarkerGoogle(mapens.Position, GMarkerGoogleType.green_pushpin); // Установка в точке значка
            GMapMarkerRect mBorders = new GMapMarkerRect(mapens.Position);                         // Установка ограничителя - квадрат
            GMapMarkerCircle mBordert = new GMapMarkerCircle(mapens.Position);                      // Установка ограничителя - окружность
            {
                mBorders.InnerMarker = m;
            }

            mBorders.ToolTipText = label2.Text;
            objects.Markers.Add(m);
            objects.Markers.Add(mBorders);
        }

        private void SamaProgramaServer_Load(object sender, EventArgs e)
        {
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "gISSIGData.SkalarVsegoZnach". При необходимости она может быть перемещена или удалена.
            this.skalarVsegoZnachTableAdapter.Fill(this.gISSIGData.SkalarVsegoZnach);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "gISSIGData.ImportOstanovokExcel". При необходимости она может быть перемещена или удалена.
            this.importOstanovokExcelTableAdapter1.Fill(this.gISSIGData.ImportOstanovokExcel);
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.skalarVsegoZnachPoRaionTableAdapter.Fill(this.gISSIGData.SkalarVsegoZnachPoRaion, toolStripComboBox2.Text);
                this.skalarPoiskPoRaiony1TableAdapter1.Fill(this.gISSIGData.SkalarPoiskPoRaiony1, toolStripComboBox2.Text);

                int f = Convert.ToInt32(label8.Text);

                for (int v = 0; v < f; v++)
                {
                    skalarPoiskPoRaiony1BindingSource.MoveNext();
                    //----------------------------------------------------
                    label5.Text = label5.Text.Replace(",", ".");
                    label6.Text = label6.Text.Replace(",", ".");

                    double lat = double.Parse(label6.Text, CultureInfo.InvariantCulture);
                    double lng = double.Parse(label5.Text, CultureInfo.InvariantCulture);

                    mapens.Position = new PointLatLng(lat, lng);

                    GMarkerGoogle m = new GMarkerGoogle(mapens.Position, GMarkerGoogleType.green_pushpin);
                    GMapMarkerRect mBorders = new GMapMarkerRect(mapens.Position);
                    GMapMarkerCircle mBordert = new GMapMarkerCircle(mapens.Position);
                    {
                        mBorders.InnerMarker = m;
                    }

                    mBorders.ToolTipText = label7.Text;
                    objects.Markers.Add(m);
                    objects.Markers.Add(mBorders);
                }
                MessageBox.Show("Завершено!");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void PoVsemyGorodyToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            DataBinding_ochistka();

            //----------- Привязываем заново -> перенаправляем!

            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skalarVsegoZnachBindingSource, "VsegoZnach", true));
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importOstanovokExcelBindingSource, "KoordiY", true));
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importOstanovokExcelBindingSource, "KoordiX", true));
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importOstanovokExcelBindingSource, "NameOstanovki", true));
        }

        private void DataBinding_ochistka()
        {
            this.label3.DataBindings.Clear();
            this.label4.DataBindings.Clear();                                       // очищаем привязку
            this.label2.DataBindings.Clear();
            this.label1.DataBindings.Clear();
        }


        private void PoVsemyGorodyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int f = Convert.ToInt32(label1.Text);
                for (int v = 0; v < f; v++)
                {
                    importOstanovokExcelBindingSource.MoveNext();
                    MexanizmOtobrageniya();
                }
                MessageBox.Show("Завершено!");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void PoUlichamToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            DataBinding_ochistka();

            //----------- Привязываем заново -> перенаправляем!

            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scalarVsegoZnachPoUlchamBindingSource, "Expr1", true));
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scalarPoiskPoUlichambindingSource, "KoordiY", true));
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scalarPoiskPoUlichambindingSource, "KoordiX", true));
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scalarPoiskPoUlichambindingSource, "NameOstanovki", true));

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SamaProgramaServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ImportTrassMarshrut_Click(object sender, EventArgs e)
        {
            Form Import = new ImportTrassMarshrut();
            Import.ShowDialog();
        }


    }
}