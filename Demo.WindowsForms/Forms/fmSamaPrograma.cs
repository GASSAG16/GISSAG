using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Demo.WindowsForms.CustomMarkers;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Diagnostics;
using Demo.WindowsForms.Logic;


namespace Demo.WindowsForms.Forms
{
    public partial class fmSamaPrograma : Form
    {
        #region Maps
        // Слои 
        readonly GMapOverlay top = new GMapOverlay();
        public readonly GMapOverlay objects = new GMapOverlay("objects");     // объекты
        internal readonly GMapOverlay routes = new GMapOverlay("routes");       // Дороги
        internal readonly GMapOverlay polygons = new GMapOverlay("polygons");   // Полигоны

        // Прочее
        readonly Random rnd = new Random();
        readonly DescendingComparer ComparerIpStatus = new DescendingComparer();
        GMapMarkerRect CurentRectMarker = null;
        bool isMouseDown = false;

        // Полигон
        GMapPolygon polygon = null;
        GMarkerGoogle currentMarker;
        GMapMarker currentTransport = null;

        // Логика обработчика событий
        logicEventmap logicMap = new logicEventmap();

        #endregion

        logicShow StationsANDRoute = new logicShow();
        fmImportTrassMarsh ImportRoutesOfTheRoute = new fmImportTrassMarsh();

        public fmSamaPrograma()
        {
            InitializeComponent();
            settingsGMapControl();
        }

        public void settingsGMapControl()
        {
            if (!GMapControl.IsDesignerHosted)
            {

                // конфигурация карты  
                {
                    mapen.MapProvider = GMapProviders.OpenStreetMap;       // провайдер карты
                    mapen.MinZoom = 0;
                    mapen.MaxZoom = 24;
                    mapen.Zoom = 9;
                }

                // события карты
                {
                    mapen.OnMarkerEnter += new MarkerEnter(mapen_OnMarkerEnter);  // События мыши при нажатии
                    mapen.OnMarkerLeave += new MarkerLeave(mapen_OnMarkerLeave); //  События мыши при отпускании
                    mapen.OnMarkerClick += new MarkerClick(mapen_OnMarkerClick);

                    mapen.MouseDown += new MouseEventHandler(mapen_MouseDown);
                    mapen.MouseMove += new MouseEventHandler(mapen_MouseMove);
                    mapen.MouseUp += new MouseEventHandler(mapen_MouseUp);
                    mapen.MouseDoubleClick += new MouseEventHandler(mapen_MouseDoubleClick);

                    //MainMap.OnPolygonEnter += new PolygonEnter(MainMap_OnPolygonEnter);
                    //MainMap.OnPolygonLeave += new PolygonLeave(MainMap_OnPolygonLeave);

                    //MainMap.OnRouteEnter += new RouteEnter(MainMap_OnRouteEnter);
                    //MainMap.OnRouteLeave += new RouteLeave(MainMap_OnRouteLeave);

                    //MainMap.Manager.OnTileCacheComplete += new TileCacheComplete(OnTileCacheComplete);
                    //MainMap.Manager.OnTileCacheStart += new TileCacheStart(OnTileCacheStart);
                    //MainMap.Manager.OnTileCacheProgress += new TileCacheProgress(OnTileCacheProgress);                      
                }
                {
                    mapen.Overlays.Add(routes);         // добавление дорог
                    mapen.Overlays.Add(polygons);       // добавление полигонов
                    mapen.Overlays.Add(objects);        // добавление объектов
                    mapen.Overlays.Add(top);            // добавление обрамления
                }

                currentMarker = new GMarkerGoogle(mapen.Position, GMarkerGoogleType.arrow);
                currentMarker.IsHitTestVisible = false;
                top.Markers.Add(currentMarker);
            }
        }

        #region Events

        void mapen_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            logicMap.OnMarker(mapen, item, e, currentTransport);
        }

        void mapen_MouseMove(object sender, MouseEventArgs e)
        {
            logicMap.MouseMove(e, CurentRectMarker, mapen, currentMarker, polygon, isMouseDown);
        }

        void mapen_OnMarkerLeave(GMapMarker item)
        {
            logicEventmap.OnMarkerLeave(item);
        }

        void mapen_OnMarkerEnter(GMapMarker item)
        {
            logicEventmap.OnMarkerEnter(item);
        }

        void mapen_MouseUp(object sender, MouseEventArgs e)
        {
            logicMap.MouseUP(e, isMouseDown);
        }

        void mapen_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            logicMap.MouseDouble(e, mapen, objects);
        }

        void mapen_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownd(e);
        }

        private void MouseDownd(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;

                if (currentMarker.IsVisible)
                {
                    currentMarker.Position = mapen.FromLocalToLatLng(e.X, e.Y);
                    var px = mapen.MapProvider.Projection.FromLatLngToPixel(currentMarker.Position.Lat, currentMarker.Position.Lng, (int)mapen.Zoom);
                    var tile = mapen.MapProvider.Projection.FromPixelToTileXY(px);

                    Debug.WriteLine("MouseDown: geo: " + currentMarker.Position + " | px: " + px + " | tile: " + tile);
                }
            }
        }
        #endregion


        private void PoVsemyGorodyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StationsANDRoute.StationsThroughoutTheCity(mapen);
        }

        private void PoRainamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StationsANDRoute.StationAreasOfTheCity(mapen);
        }

        private void PoUlichamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StationsANDRoute.StationsOnCityStreets(mapen);
        }

        private void lbExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbAboitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fmAbout = new AboutGASSAG();
            fmAbout.ShowDialog();
        }

        private void SamaPrograma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SamaPrograma_Load(object sender, EventArgs e)
        {
            //panel1.Hide();

            //GMapOverlay line = new GMapOverlay();
            //mapen.Overlays.Add(line);

            //List<PointLatLng> spisok = new List<PointLatLng>();                 // Формируем в цикле список координат
            //{
            //    StreamReader ReadFile = File.OpenText("CenterOkrug.txt");
            //    Sokr(spisok, ReadFile);
            //}
            //GMapRoute L = new GMapRoute(spisok, "линия");
            //L.Stroke.Width = 5;
            //L.Stroke.Color = Color.Red;                                     // Настройка линии
            //line.Routes.Add(L);
            //mapen.ZoomAndCenterRoute(L);
            //mapen.Zoom = 15;
        }

        private void TransportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StationsANDRoute.TheRoutesOfUrbanPassengerTransport(mapen);
        }

        private void bImportRoutesOfTheRoute_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" В демонстрационной версии отражен процесс импорта трасс маршрутов. В полной версии программы, формируется связка с сервером!");
            ImportRoutesOfTheRoute.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paInfo.Hide();
        }

    }
}

