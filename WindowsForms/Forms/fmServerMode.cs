using WindowsForms.Logic;
using WindowsForms.Logic.SQL;
using System;
using System.Windows.Forms;
using WindowsForms.CustomMarkers;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace WindowsForms.Forms
{
    public partial class fmServerMode : Form
    {
        #region Maps
        // Слои 
        readonly GMapOverlay top = new GMapOverlay();
        public readonly GMapOverlay objects = new GMapOverlay("objects");     // объекты
        internal readonly GMapOverlay routes = new GMapOverlay("routes");       // Дороги
        internal readonly GMapOverlay polygons = new GMapOverlay("polygons");   // Полигоны

        // Полигон
        GMapPolygon polygon = null;
        GMarkerGoogle currentMarker;
        GMapMarker currentTransport = null;

        // Логика обработчика событий
        logicEventmap logicMap = new logicEventmap();


        // Прочее
        readonly Random rnd = new Random();
        readonly DescendingComparer ComparerIpStatus = new DescendingComparer();
        GMapMarkerRect CurentRectMarker = null;
        bool isMouseDown;


        #endregion

        logicShow StationsANDRoute = new logicShow();
        fmImportTrassMarsh ImportRoutesOfTheRoute = new fmImportTrassMarsh();
        RouteSQL RSQL = new RouteSQL(); 
                
        public fmServerMode()
        {
            InitializeComponent();
            settingsGMapControl();
        }

        private void settingsGMapControl()
        {
            if (!GMapControl.IsDesignerHosted)
            {

                // конфигурация карты  
                {
                    mapen.MapProvider = GMapProviders.YandexMap;           // провайдер карты
                    mapen.Position = new PointLatLng(55.75393, 37.620795);              // Координаты города по умолчанию
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
            logicMap.MapMenu();  
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
            logicMap.MouseUP(e, isMouseDown,mapen);
            
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

                    //Debug.WriteLine("MouseDown: geo: " + currentMarker.Position + " | px: " + px + " | tile: " + tile);
                }
            }
        }
        #endregion

       
        private void lbImportRoutesOfTheRoute_Click(object sender, EventArgs e)
        {
            ImportRoutesOfTheRoute.ShowDialog();
        }

        private void lbAboitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lbExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbMarsh_SelectedIndexChanged(object sender, EventArgs e)
        {
            RSQL.dataAddtheDirectionRoute(tbTheDirectionRoute, tbMarsh);
        }

        private void fmServerMode_Load(object sender, EventArgs e)
        {
            RSQL.dataAddMarsh(tbMarsh);
        }

        private void tbTheDirectionRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            requestTracksRoutesTableAdapter.Fill(this.gISSIGData.requestTracksRoutes, tbTheDirectionRoute.Text);
            requestTracksCountTableAdapter.Fill(this.gISSIGData.requestTracksCount, tbTheDirectionRoute.Text);
            requestPassangerStopTableAdapter.Fill(this.gISSIGData.requestPassangerStop, tbMarsh.Text);
            requestPassangerStopCountTableAdapter.Fill(this.gISSIGData.requestPassangerStopCount, tbMarsh.Text);
            //RSQL.dataAddPassangerStop(tbMarsh);
            StationsANDRoute.TheRoutesOfUrbanPassengerTransport(requestTracksRoutesBindingSource, mapen, lbKoordiX, lbKoordiY, lbCount, requestPassangerStopBindingSource, lbKoordiXPassanger, lbKoordiYPassanger, lbCountCoordinatPassanger, lbTheNameOfTheStop, cbAreaPassanger);
        }

        private void tbMarsh_Click(object sender, EventArgs e)
        {
           
        }

        private void fmServerMode_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
