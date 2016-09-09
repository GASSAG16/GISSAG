//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Windows.Forms;
//using GMap.NET;
//using GMap.NET.WindowsForms;
//using GMap.NET.WindowsForms.Markers;
//using GMap.NET.WindowsForms.ToolTips;
//using GMap.NET.MapProviders;
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
    public partial class SamaProgramaFull : Form
    {
        // Слои 
        readonly GMapOverlay top = new GMapOverlay();
        internal readonly GMapOverlay objects = new GMapOverlay("objects");     // объекты
        internal readonly GMapOverlay routes = new GMapOverlay("routes");       // Дороги
        internal readonly GMapOverlay polygons = new GMapOverlay("polygons");   // Полигоны

        // Прочее
        readonly Random rnd = new Random();
        readonly DescendingComparer ComparerIpStatus = new DescendingComparer();
        GMapMarkerRect CurentRectMarker = null;

        // Полигон
        GMapPolygon polygon;
        
        
        public SamaProgramaFull()
        {
            InitializeComponent();

            if (!GMapControl.IsDesignerHosted)
            {

                // конфигурация карты  
                {
                    mapen.MapProvider = GMapProviders.YandexMap;       // провайдер карты
                    mapen.MinZoom = 0;
                    mapen.MaxZoom = 24;
                    mapen.Zoom = 9;
                }

                // события карты
                {
                    mapen.OnMarkerEnter += new MarkerEnter(mapen_OnMarkerEnter);  // События мыши при нажатии
                    mapen.OnMarkerLeave += new MarkerLeave(mapen_OnMarkerLeave); //  События мыши при отпускании
                }
                {
                    mapen.Overlays.Add(routes);         // добавление дорог
                    mapen.Overlays.Add(polygons);       // добавление полигонов
                    mapen.Overlays.Add(objects);        // добавление объектов
                    mapen.Overlays.Add(top);            // добавление обрамления
                }
            }
        }
        void mapen_OnMarkerLeave(GMapMarker item)
        {
            if (item is GMapMarkerRect)
            {
                CurentRectMarker = null;
                GMapMarkerRect rc = item as GMapMarkerRect;
                rc.Pen.Color = Color.Blue;
                rc.ToolTipMode = MarkerTooltipMode.Never;
            }
        }
        void mapen_OnMarkerEnter(GMapMarker item)
        {
            if (item is GMapMarkerRect)
            {
                GMapMarkerRect rc = item as GMapMarkerRect;
                rc.Pen.Color = Color.Red;
                rc.ToolTipMode = MarkerTooltipMode.Always;
            }
        }

        private void PoVsemyGorodyToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("Внимание!!! При формировании остановок, возможно краткосрочное зависание, это связано с работой видеокарты и вывода картинки, поэтому не прерывайте процесс!");

            StreamReader ReadFile = File.OpenText("StanPoVsemyGorody.txt");
            Chteniedannyx(ReadFile);
 
        }

        private void Chteniedannyx(StreamReader ReadFile)
        {
            string Input = null;
            //Читаем из файла информацию в цикле
            while ((Input = ReadFile.ReadLine()) != null)
            {

                double lat;
                double lng;
                Geo(Input, out lat, out lng);

                mapen.Position = new PointLatLng(lat, lng);                                            //Формировка координат

                GMarkerGoogle m = new GMarkerGoogle(mapen.Position, GMarkerGoogleType.green_pushpin); // Установка в точке значка
                GMapMarkerRect mBorders = new GMapMarkerRect(mapen.Position);                         // Установка ограничителя
                {
                    mBorders.InnerMarker = m;
                    mBorders.ToolTipMode = MarkerTooltipMode.Always;
                }

                objects.Markers.Add(m);
                objects.Markers.Add(mBorders);
            }
            MessageBox.Show("Завершено! Внимание, название остановок доступно в полной версии!");
        }

        private void Geo(string Input, out double lat, out double lng)
        {
            label12.Text = Input.Remove(15);                                            // Подготовка данных в текстовом файле
            label14.Text = Input.Substring(16);

            lat = double.Parse(label14.Text, CultureInfo.InvariantCulture);                  //Преобразование данных 
            lng = double.Parse(label12.Text, CultureInfo.InvariantCulture);
        }

        private void OnLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void PoRainamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader ReadFile = File.OpenText("StanPoRaion.txt");
            Chteniedannyx(ReadFile);
        }

        private void PoUlichamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader ReadFile = File.OpenText("StanPoUlicham.txt");
            Chteniedannyx(ReadFile);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ty = new AboutGASSAG();
            ty.ShowDialog();
        }

        private void SamaPrograma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SamaPrograma_Load(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void TransportToolStripMenuItem_Click(object sender, EventArgs e)
        {
             GMapOverlay line = new GMapOverlay();
            mapen.Overlays.Add(line);

            List<PointLatLng> spisok = new List<PointLatLng>();                 // Формируем в цикле список координат
            {
                StreamReader ReadFile = File.OpenText("Line.txt");
                string Input = null;
                //Читаем из файла информацию
                while ((Input = ReadFile.ReadLine()) != null)
                {
                    double lat;
                    double lng;
                    Geo(Input, out lat, out lng);
                
                spisok.Add(new PointLatLng(lat, lng));
                }
            }
                GMapRoute L = new GMapRoute(spisok, "линия");
                L.Stroke.Width = 5;
                L.Stroke.Color = Color.Red;                                     // Настройка линии
                line.Routes.Add(L);
                mapen.ZoomAndCenterRoute(L);
                mapen.Zoom = 15;
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
              try
            {
                this.scalarVsegoZnachPoUlchamTableAdapter.Fill(this.gISSIGData.ScalarVsegoZnachPoUlcham, toolStripComboBox2.Text);
                this.scalarPoiskPoUlichamTableAdapter.Fill(this.gISSIGData.ScalarPoiskPoUlicham, toolStripComboBox2.Text);
                
             
                int f = Convert.ToInt32(label12.Text);
                for (int v = 0; v < f; v++)
                {

                    SqlConnection con = new SqlConnection("server=gas-aleks\\sqlgassag;database=GISSIG;Integrated Security=True");

                                     
                    scalarPoiskPoUlichambindingSource.MoveNext();

                    //----------------------------------------------------
                    label14.Text = label14.Text.Replace(",", ".");
                    label13.Text = label13.Text.Replace(",", ".");

                    double lat = double.Parse(label13.Text, CultureInfo.InvariantCulture);
                    double lng = double.Parse(label14.Text, CultureInfo.InvariantCulture);

                    mapen.Position = new PointLatLng(lat, lng);


                    GMarkerGoogle m = new GMarkerGoogle(mapen.Position, GMarkerGoogleType.green_pushpin);
                    GMapMarkerRect mBorders = new GMapMarkerRect(mapen.Position);
                    GMapMarkerCircle mBordert = new GMapMarkerCircle(mapen.Position);
                    {
                        //mBorder.stroke = m;
                        mBorders.InnerMarker = m;

                        if (polygon != null)
                        {
                            // mBorders.Tag = polygon.Points.Count;
                        }
                    }

                    mBorders.ToolTipText = label12.Text;
                    objects.Markers.Add(m);
                    objects.Markers.Add(mBorders);

            }
                scalarPoiskPoUlichambindingSource.MoveFirst();
                for (int v = 0; v < 1; v++)
                {

                    SqlConnection con = new SqlConnection("server=gas-aleks\\sqlgassag;database=GISSIG;Integrated Security=True");


                    //----------------------------------------------------
                    label14.Text = label14.Text.Replace(",", ".");
                    label13.Text = label13.Text.Replace(",", ".");

                    double lat = double.Parse(label13.Text, CultureInfo.InvariantCulture);
                    double lng = double.Parse(label14.Text, CultureInfo.InvariantCulture);

                    mapen.Position = new PointLatLng(lat, lng);


                    GMarkerGoogle m = new GMarkerGoogle(mapen.Position, GMarkerGoogleType.green_pushpin);
                    GMapMarkerRect mBorders = new GMapMarkerRect(mapen.Position);
                    GMapMarkerCircle mBordert = new GMapMarkerCircle(mapen.Position);
                    {
                        //mBorder.stroke = m;
                        mBorders.InnerMarker = m;

                        if (polygon != null)
                        {
                            // mBorders.Tag = polygon.Points.Count;
                        }
                    }
                    mBorders.ToolTipText = label12.Text;
                    objects.Markers.Add(m);
                    objects.Markers.Add(mBorders);
                }
            }

             catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
   
        
        }
        
    }
}
