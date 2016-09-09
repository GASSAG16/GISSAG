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

namespace Demo.WindowsForms.Source
{
    public partial class Otrabotka_postroite : Form
    {
        //
        //layers
        readonly GMapOverlay top = new GMapOverlay();
        internal readonly GMapOverlay objects = new GMapOverlay("objects");
        internal readonly GMapOverlay routes = new GMapOverlay("routes");
        internal readonly GMapOverlay polygons = new GMapOverlay("polygons");
        internal readonly GMapOverlay marshryt = new GMapOverlay("marshryt");

        // marker
        GMarkerGoogle currentMarker;

        // polygons
        GMapPolygon polygon;

        // etc
        readonly Random rnd = new Random();
        readonly DescendingComparer ComparerIpStatus = new DescendingComparer();
        GMapMarkerRect CurentRectMarker = null;
        string mobileGpsLog = string.Empty;
        bool isMouseDown = false;
        PointLatLng start;
        PointLatLng end;



        public Otrabotka_postroite()
        {
            InitializeComponent();
            if (!GMapControl.IsDesignerHosted)
            {

                // set cache mode only if no internet avaible
                if (!Stuff.PingNetwork("pingtest.com"))
                {
                    mapen.Manager.Mode = AccessMode.ServerOnly;
                    MessageBox.Show("No internet connection available, going to CacheOnly mode.", "GMap.NET - Demo.WindowsForms", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // config map         
                mapen.MapProvider = GMapProviders.YandexMap;
                mapen.MinZoom = 0;
                mapen.MaxZoom = 24;
                mapen.Zoom = 9;

                //mapen.ScaleMode = ScaleModes.Fractional;

                // map events
                //{
                //mapen.OnPositionChanged += new PositionChanged(mapen_OnPositionChanged);

                //mapen.OnTileLoadStart += new TileLoadStart(mapen_OnTileLoadStart);
                //mapen.OnTileLoadComplete += new TileLoadComplete(mapen_OnTileLoadComplete);

                //mapen.OnMapZoomChanged += new MapZoomChanged(mapen_OnMapZoomChanged);
                //mapen.OnMapTypeChanged += new MapTypeChanged(mapen_OnMapTypeChanged);

                // mapen.OnMarkerClick += new MarkerClick(mapen_OnMarkerClick);
                mapen.OnMarkerEnter += new MarkerEnter(mapen_OnMarkerEnter);
                mapen.OnMarkerLeave += new MarkerLeave(mapen_OnMarkerLeave);

                //mapen.OnPolygonEnter += new PolygonEnter(mapen_OnPolygonEnter);
                //mapen.OnPolygonLeave += new PolygonLeave(mapen_OnPolygonLeave);

                // mapen.OnRouteEnter += new RouteEnter(mapen_OnRouteEnter);
                // mapen.OnRouteLeave += new RouteLeave(mapen_OnRouteLeave);

                //mapen.Manager.OnTileCacheComplete += new TileCacheComplete(OnTileCacheComplete);
                //mapen.Manager.OnTileCacheStart += new TileCacheStart(OnTileCacheStart);
                //mapen.Manager.OnTileCacheProgress += new TileCacheProgress(OnTileCacheProgress);
                //}

                // mapen.MouseMove += new MouseEventHandler(mapen_MouseMove);
                //   mapen.MouseDown += new MouseEventHandler(mapen_MouseDown);
                //  mapen.MouseUp += new MouseEventHandler(mapen_MouseUp);
                //mapen.MouseDoubleClick += new MouseEventHandler(mapen_MouseDoubleClick);

                {
                    mapen.Overlays.Add(routes);
                    mapen.Overlays.Add(polygons);
                    mapen.Overlays.Add(objects);
                    mapen.Overlays.Add(top);
                    mapen.Overlays.Add(marshryt);

                    // routes.Routes.CollectionChanged += new GMap.NET.ObjectModel.NotifyCollectionChangedEventHandler(Routes_CollectionChanged);
                    // objects.Markers.CollectionChanged += new GMap.NET.ObjectModel.NotifyCollectionChangedEventHandler(Markers_CollectionChanged);
                }

                // set current marker
                // currentMarker = new GMarkerGoogle(mapen.Position, GMarkerGoogleType.arrow);
                // currentMarker.IsHitTestVisible = false;
                // top.Markers.Add(currentMarker);

                //mapen.VirtualSizeEnabled = true;
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
                // rc.ToolTipText = label3.ToString();
                rc.ToolTipMode = MarkerTooltipMode.Always;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            GMapOverlay line = new GMapOverlay();
            mapen.Overlays.Add(line);

            List<PointLatLng> spisok = new List<PointLatLng>();
            {
                StreamReader ReadFile = File.OpenText("Line.txt");
                string Input = null;
                //Читаем из файла информацию
                while ((Input = ReadFile.ReadLine()) != null)
                {

                    label1.Text = Input.Remove(15);
                    label2.Text = Input.Substring(16);

                    ///---------------------------------------------------------------------------------
                    double lat = double.Parse(label2.Text, CultureInfo.InvariantCulture);
                    double lng = double.Parse(label1.Text, CultureInfo.InvariantCulture);

                    spisok.Add(new PointLatLng(lat, lng));
                }
            }
            GMapRoute L = new GMapRoute(spisok, "линия");
            L.Stroke.Width = 5;
            L.Stroke.Color = Color.Red;
            line.Routes.Add(L);
            mapen.ZoomAndCenterRoute(L);
            mapen.Zoom = 15;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // label3.Text = "2";
            //string text = " привет мир";

            //text = text.Trim(); // результат "hello world"
            //text = text.Trim(new char[] { 'п', 'р' }); // результат "ello worl"



            // string text = "И поэтому все так произошло";

            //// string[] words = text.Split(new char[] { ' ' });
            // string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            // foreach (string s in words)
            // {
            //     Console.WriteLine(s);
            //     label3.Text = s;
            // }


            // label3.Text = text;

            // string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //string s1 = "hello world";
            //char ch = '8';
            //int indexOfChar = s1.IndexOf(ch); // равно 4
            //Console.WriteLine(indexOfChar);

            ////string subString = "wor";
            ////int indexOfSubstring = s1.IndexOf(subString); // равно 6
            ////Console.WriteLine(indexOfSubstring);

            //label3.Text = s1.IndexOf(ch);
            //string s=&quot;Hello world&quot;;
            //int index = s.IndexOf(&quot;world&quot;);
            //string s = "gfsggvytbygGQVVGH67";
            //Console.WriteLine(s.Count(c => c >= 'a' && c <= 'z'));
            //label3.Text.GetLength();
        }

    }
}

