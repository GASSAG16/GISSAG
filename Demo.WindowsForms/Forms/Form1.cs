using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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

using GMap.NET.MapProviders;
using System.Reflection;
using System.Text.RegularExpressions;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

using BSE.Windows.Forms;






namespace Demo.WindowsForms.Forms
{
    public partial class Form1 : Form
    {

        // layers
        readonly GMapOverlay top = new GMapOverlay();
        internal readonly GMapOverlay objects = new GMapOverlay("objects");
        internal readonly GMapOverlay routes = new GMapOverlay("routes");
        internal readonly GMapOverlay polygons = new GMapOverlay("polygons");

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




        public Form1()
        {
            InitializeComponent();

            if (!GMapControl.IsDesignerHosted)
            {
                // add your custom map db provider
                //GMap.NET.CacheProviders.MySQLPureImageCache ch = new GMap.NET.CacheProviders.MySQLPureImageCache();
                //ch.ConnectionString = @"server=sql2008;User Id=trolis;Persist Security Info=True;database=gmapnetcache;password=trolis;";
                //mapen.Manager.SecondaryCache = ch;

                // set your proxy here if need
                //GMapProvider.IsSocksProxy = true;
                //GMapProvider.WebProxy = new WebProxy("127.0.0.1", 1080);
                //GMapProvider.WebProxy.Credentials = new NetworkCredential("ogrenci@bilgeadam.com", "bilgeada");
                // or
                //GMapProvider.WebProxy = WebRequest.DefaultWebProxy;
                //                          

                // set cache mode only if no internet avaible
                if (!Stuff.PingNetwork("pingtest.com"))
                {
                    mapen.Manager.Mode = AccessMode.ServerOnly;
                    MessageBox.Show("No internet connection available, going to CacheOnly mode.", "GMap.NET - Demo.WindowsForms", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // config map         
                mapen.MapProvider = GMapProviders.OpenStreetMap;
                mapen.Position = new PointLatLng(54.6961334816182, 25.2985095977783);
                mapen.MinZoom = 0;
                mapen.MaxZoom = 24;
                mapen.Zoom = 9;

                //mapen.ScaleMode = ScaleModes.Fractional;

                // map events
                {
                    //mapen.OnPositionChanged += new PositionChanged(mapen_OnPositionChanged);

                    //mapen.OnTileLoadStart += new TileLoadStart(mapen_OnTileLoadStart);
                    //mapen.OnTileLoadComplete += new TileLoadComplete(mapen_OnTileLoadComplete);

                    //mapen.OnMapZoomChanged += new MapZoomChanged(mapen_OnMapZoomChanged);
                    //mapen.OnMapTypeChanged += new MapTypeChanged(mapen_OnMapTypeChanged);

                    //mapen.OnMarkerClick += new MarkerClick(mapen_OnMarkerClick);
                    //mapen.OnMarkerEnter += new MarkerEnter(mapen_OnMarkerEnter);
                    //mapen.OnMarkerLeave += new MarkerLeave(mapen_OnMarkerLeave);

                    //mapen.OnPolygonEnter += new PolygonEnter(mapen_OnPolygonEnter);
                    //mapen.OnPolygonLeave += new PolygonLeave(mapen_OnPolygonLeave);

                    //mapen.OnRouteEnter += new RouteEnter(mapen_OnRouteEnter);
                    //mapen.OnRouteLeave += new RouteLeave(mapen_OnRouteLeave);

                    //mapen.Manager.OnTileCacheComplete += new TileCacheComplete(OnTileCacheComplete);
                    //mapen.Manager.OnTileCacheStart += new TileCacheStart(OnTileCacheStart);
                    //mapen.Manager.OnTileCacheProgress += new TileCacheProgress(OnTileCacheProgress);
                }

                mapen.MouseMove += new MouseEventHandler(mapen_MouseMove);
                mapen.MouseDown += new MouseEventHandler(mapen_MouseDown);
                mapen.MouseUp += new MouseEventHandler(mapen_MouseUp);
                mapen.MouseDoubleClick += new MouseEventHandler(mapen_MouseDoubleClick);



                // get position
                //textBoxLat.Text = mapen.Position.Lat.ToString(CultureInfo.InvariantCulture);
                //textBoxLng.Text = mapen.Position.Lng.ToString(CultureInfo.InvariantCulture);

                // get cache modes
                //checkBoxUseRouteCache.Checked = mapen.Manager.UseRouteCache;

                //MobileLogFrom.Value = DateTime.Today;
                //MobileLogTo.Value = DateTime.Now;

                //// get zoom  
                //trackBar1.Minimum = mapen.MinZoom * 100;
                //trackBar1.Maximum = mapen.MaxZoom * 100;
                //trackBar1.TickFrequency = 100;

                //#if DEBUG
                //                //checkBoxDebug.Checked = true;
                //#endif

                //                ToolStripManager.Renderer = new BSE.Windows.Forms.Office2007Renderer();


                // add custom layers  
                {
                    mapen.Overlays.Add(routes);
                    mapen.Overlays.Add(polygons);
                    mapen.Overlays.Add(objects);
                    mapen.Overlays.Add(top);

                    //  routes.Routes.CollectionChanged += new GMap.NET.ObjectModel.NotifyCollectionChangedEventHandler(Routes_CollectionChanged);
                    // objects.Markers.CollectionChanged += new GMap.NET.ObjectModel.NotifyCollectionChangedEventHandler(Markers_CollectionChanged);
                }

                // set current marker
                currentMarker = new GMarkerGoogle(mapen.Position, GMarkerGoogleType.arrow);
                currentMarker.IsHitTestVisible = false;
                top.Markers.Add(currentMarker);

                mapen.VirtualSizeEnabled = true;
                //if(false)
                //{
                //    // add my city location for demo
                //    GeoCoderStatusCode status = GeoCoderStatusCode.Unknow;
                //    {
                //        PointLatLng? pos = GMapProviders.GoogleMap.GetPoint("Россия, Москва, остановка шереметьевская улица", out status);   //задание объекта
                //        PointLatLng? pos2 = GMapProviders.OpenStreetMap.GetPoint("Россия, Москва, остановка октябрьская улица", out status);
                //        //PointLatLng? pos = GMapProviders.GoogleMap.GetPoint("Russia, Moscow", out status);   //задание объекта
                //        //PointLatLng? pos = GMapProviders.GoogleMap.GetPoint("Lithuania, Vilnius", out status);

                //        // PointLatLng? pos = GMapProviders.OpenStreetMap.GetPoint("Россия, Москва, остановка шереметьевская улица", out status);
                //        if (pos != null && status == GeoCoderStatusCode.G_GEO_SUCCESS)
                //{
                //  currentMarker.Position = pos.Value;

                //    GMapMarker myCity = new GMarkerGoogle(pos.Value, GMarkerGoogleType.green_small);
                //    myCity.ToolTipMode = MarkerTooltipMode.Never;
                //    myCity.ToolTipText = "Welcome to Lithuania! ;}";
                //    objects.Markers.Add(myCity);
                //}
                //if (pos2 != null && status == GeoCoderStatusCode.G_GEO_SUCCESS)
                //{
                //  currentMarker.Position = pos.Value;

                //    GMapMarker myCity = new GMarkerGoogle(pos2.Value, GMarkerGoogleType.red_small);
                //    myCity.ToolTipMode = MarkerTooltipMode.Always;
                //    // myCity.ToolTipText = "Welcome to Lithuania! ;}";
                //    objects.Markers.Add(myCity);
                //}




                //}

                // add some points in lithuania
                //AddLocationLithuania("Kaunas");
                //AddLocationLithuania("Klaipėda");
                //AddLocationLithuania("Šiauliai");
                //AddLocationLithuania("Panevėžys");

                //if (objects.Markers.Count > 0)
                //{
                //    mapen.ZoomAndCenterMarkers(null);
                //}
            }
        }
        #region -- map events --

        //void OnTileCacheComplete()
        //{
        //    Debug.WriteLine("OnTileCacheComplete");
        //    long size = 0;
        //    int db = 0;
        //    try
        //    {
        //        DirectoryInfo di = new DirectoryInfo(MainMap.CacheLocation);
        //        var dbs = di.GetFiles("*.gmdb", SearchOption.AllDirectories);
        //        foreach (var d in dbs)
        //        {
        //            size += d.Length;
        //            db++;
        //        }
        //    }
        //    catch
        //    {
        //    }

        //    if (!IsDisposed)
        //    {
        //        MethodInvoker m = delegate
        //        {
        //            textBoxCacheSize.Text = string.Format(CultureInfo.InvariantCulture, "{0} db in {1:00} MB", db, size / (1024.0 * 1024.0));
        //            textBoxCacheStatus.Text = "all tiles saved!";
        //        };

        //        if (!IsDisposed)
        //        {
        //            try
        //            {
        //                Invoke(m);
        //            }
        //            catch (Exception)
        //            {
        //            }
        //        }
        //    }
        //}

        //void OnTileCacheStart()
        //{
        //    Debug.WriteLine("OnTileCacheStart");

        //    if (!IsDisposed)
        //    {
        //        MethodInvoker m = delegate
        //        {
        //            textBoxCacheStatus.Text = "saving tiles...";
        //        };
        //        Invoke(m);
        //    }
        //}

        //void OnTileCacheProgress(int left)
        //{
        //    if (!IsDisposed)
        //    {
        //        MethodInvoker m = delegate
        //        {
        //            textBoxCacheStatus.Text = left + " tile to save...";
        //        };
        //        Invoke(m);
        //    }
        //}

        void mapen_OnMarkerLeave(GMapMarker item)
        {
            if (item is GMapMarkerRect)
            {
                CurentRectMarker = null;

                GMapMarkerRect rc = item as GMapMarkerRect;
                rc.Pen.Color = Color.Blue;

                Debug.WriteLine("OnMarkerLeave: " + item.Position);
            }
        }

        void mapen_OnMarkerEnter(GMapMarker item)
        {
            if (item is GMapMarkerRect)
            {
                GMapMarkerRect rc = item as GMapMarkerRect;
                rc.Pen.Color = Color.Red;

                CurentRectMarker = rc;

                Debug.WriteLine("OnMarkerEnter: " + item.Position);
            }
        }

        GMapPolygon currentPolygon = null;
        void mapen_OnPolygonLeave(GMapPolygon item)
        {
            currentPolygon = null;
            item.Stroke.Color = Color.MidnightBlue;
            Debug.WriteLine("OnPolygonLeave: " + item.Name);
        }

        void mapen_OnPolygonEnter(GMapPolygon item)
        {
            currentPolygon = item;
            item.Stroke.Color = Color.Red;
            Debug.WriteLine("OnPolygonEnter: " + item.Name);
        }

        GMapRoute currentRoute = null;
        void mapen_OnRouteLeave(GMapRoute item)
        {
            currentRoute = null;
            item.Stroke.Color = Color.MidnightBlue;
            Debug.WriteLine("OnRouteLeave: " + item.Name);
        }

        void mapen_OnRouteEnter(GMapRoute item)
        {
            currentRoute = item;
            item.Stroke.Color = Color.Red;
            Debug.WriteLine("OnRouteEnter: " + item.Name);
        }

        //void  mapen_OnMapTypeChanged(GMapProvider type)
        //{
        //    comboBoxMapType.SelectedItem = type;

        //    trackBar1.Minimum = MainMap.MinZoom * 100;
        //    trackBar1.Maximum = MainMap.MaxZoom * 100;

        //    if (radioButtonFlight.Checked)
        //    {
        //        MainMap.ZoomAndCenterMarkers("objects");
        //    }
        //}

        void mapen_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        // add demo circle
        void mapen_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var cc = new GMapMarkerCircle(mapen.FromLocalToLatLng(e.X, e.Y));
            objects.Markers.Add(cc);
        }

        void mapen_MouseDown(object sender, MouseEventArgs e)
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

        // move current marker with left holding
        void mapen_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isMouseDown)
            {
                if (CurentRectMarker == null)
                {
                    if (currentMarker.IsVisible)
                    {
                        currentMarker.Position = mapen.FromLocalToLatLng(e.X, e.Y);
                    }
                }
                else // move rect marker
                {
                    PointLatLng pnew = mapen.FromLocalToLatLng(e.X, e.Y);

                    int? pIndex = (int?)CurentRectMarker.Tag;
                    if (pIndex.HasValue)
                    {
                        if (pIndex < polygon.Points.Count)
                        {
                            polygon.Points[pIndex.Value] = pnew;
                            mapen.UpdatePolygonLocalPosition(polygon);
                        }
                    }

                    if (currentMarker.IsVisible)
                    {
                        currentMarker.Position = pnew;
                    }
                    CurentRectMarker.Position = pnew;

                    if (CurentRectMarker.InnerMarker != null)
                    {
                        CurentRectMarker.InnerMarker.Position = pnew;
                    }
                }

                mapen.Refresh(); // force instant invalidation
            }
        }

        // MapZoomChanged
        //void MainMap_OnMapZoomChanged()
        //{
        //    trackBar1.Value = (int)(MainMap.Zoom * 100.0);
        //    textBoxZoomCurrent.Text = MainMap.Zoom.ToString();
        //}

        // click on some marker
        //void MainMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        //{
        //    if (e.Button == System.Windows.Forms.MouseButtons.Left)
        //    {
        //        if (item is GMapMarkerRect)
        //        {
        //            GeoCoderStatusCode status;
        //            var pos = GMapProviders.GoogleMap.GetPlacemark(item.Position, out status);
        //            if (status == GeoCoderStatusCode.G_GEO_SUCCESS && pos != null)
        //            {
        //                GMapMarkerRect v = item as GMapMarkerRect;
        //                {
        //                    v.ToolTipText = pos.Value.Address;
        //                }
        //                 mapen.Invalidate(false);
        //            }
        //        }
        //        else
        //        {
        //            if (item.Tag != null)
        //            {
        //                if (currentTransport != null)
        //                {
        //                    currentTransport.ToolTipMode = MarkerTooltipMode.OnMouseOver;
        //                    currentTransport = null;
        //                }
        //                currentTransport = item;
        //                currentTransport.ToolTipMode = MarkerTooltipMode.Always;
        //            }
        //        }
        //    }
        //}

        // loader start loading tiles
        //void MainMap_OnTileLoadStart()
        //{
        //    MethodInvoker m = delegate()
        //    {
        //        panelMenu.Text = "Menu: loading tiles...";
        //    };
        //    try
        //    {
        //        BeginInvoke(m);
        //    }
        //    catch
        //    {
        //    }
        //}

        // loader end loading tiles
        //void MainMap_OnTileLoadComplete(long ElapsedMilliseconds)
        //{
        //    MainMap.ElapsedMilliseconds = ElapsedMilliseconds;

        //    MethodInvoker m = delegate()
        //    {
        //        panelMenu.Text = "Menu, last load in " + MainMap.ElapsedMilliseconds + "ms";

        //        textBoxMemory.Text = string.Format(CultureInfo.InvariantCulture, "{0:0.00} MB of {1:0.00} MB", MainMap.Manager.MemoryCache.Size, MainMap.Manager.MemoryCache.Capacity);
        //    };
        //    try
        //    {
        //        BeginInvoke(m);
        //    }
        //    catch
        //    {
        //    }
        //}

        // current point changed
        //void MainMap_OnPositionChanged(PointLatLng point)
        //{
        //    textBoxLatCurrent.Text = point.Lat.ToString(CultureInfo.InvariantCulture);
        //    textBoxLngCurrent.Text = point.Lng.ToString(CultureInfo.InvariantCulture);

        //    lock (flights)
        //    {
        //        lastPosition = point;
        //        lastZoom = (int)MainMap.Zoom;
        //    }
        //}

        PointLatLng lastPosition;
        int lastZoom;

        // center markers on start
        //private void MainForm_Load(object sender, EventArgs e)
        //{
        //    trackBar1.Value = (int)MainMap.Zoom * 100;
        //    Activate();
        //    TopMost = true;
        //    TopMost = false;

        #endregion




        private void Form1_Load(object sender, EventArgs e)
        {
            GeoCoderStatusCode status = mapen.SetPositionByKeywords("Москва Октябрьская улица");
            if (status != GeoCoderStatusCode.G_GEO_SUCCESS)
            {
                // MessageBox.Show("Geocoder can't find: '" + textBoxGeo.Text + "', reason: " + status.ToString(), "GMap.NET", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            StreamReader ReadFile = File.OpenText("stan.txt");
            string Input = null;
            //Читаем из файла информацию
            while ((Input = ReadFile.ReadLine()) != null)
            {

                label1.Text = Input.Remove(15);
                label2.Text = Input.Substring(16);








                double lat = double.Parse(label2.Text, CultureInfo.InvariantCulture);
                double lng = double.Parse(label1.Text, CultureInfo.InvariantCulture);

                mapen.Position = new PointLatLng(lat, lng);





                GMarkerGoogle m = new GMarkerGoogle(mapen.Position, GMarkerGoogleType.green_pushpin);
                GMapMarkerRect mBorders = new GMapMarkerRect(mapen.Position);
                {
                    mBorders.InnerMarker = m;
                    if (polygon != null)
                    {
                        mBorders.Tag = polygon.Points.Count;
                    }
                    mBorders.ToolTipMode = MarkerTooltipMode.Always;
                }

                Placemark? p = null;
                if (checkBox1.Checked)
                {
                    GeoCoderStatusCode status;
                    var ret = GMapProviders.GoogleMap.GetPlacemark(mapen.Position, out status);
                    if (status == GeoCoderStatusCode.G_GEO_SUCCESS && ret != null)
                    {
                        p = ret;
                    }
                }

                if (p != null)
                {
                    mBorders.ToolTipText = p.Value.Address;
                }
                else
                {
                    mBorders.ToolTipText = mapen.Position.ToString();
                }

                objects.Markers.Add(m);
                objects.Markers.Add(mBorders);

                //RegeneratePolygon();

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            double lat = double.Parse(label2.Text, CultureInfo.InvariantCulture);
            double lng = double.Parse(label1.Text, CultureInfo.InvariantCulture);

            mapen.Position = new PointLatLng(lat, lng);
        }
    }
}

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{

        //}

        //private void checkBox2_CheckedChanged(object sender, EventArgs e)
        //{
        //    currentMarker.IsVisible = checkBox2.Checked;
        //}




   

                   //   RegeneratePolygon();

                    //try
                    //{
                    //   GMapOverlay overlay = DeepClone<GMapOverlay>(objects);
                    //   Debug.WriteLine("ISerializable status for markers: OK");

                    //   GMapOverlay overlay2 = DeepClone<GMapOverlay>(polygons);
                    //   Debug.WriteLine("ISerializable status for polygons: OK");

                    //   GMapOverlay overlay3 = DeepClone<GMapOverlay>(routes);
                    //   Debug.WriteLine("ISerializable status for routes: OK");
                    //}
                    //catch(Exception ex)
                    //{
                    //   Debug.WriteLine("ISerializable failure: " + ex.Message);

//#if DEBUG
//                    if (Debugger.IsAttached)
//                    {
//                        Debugger.Break();
//                    }
//#endif
                //}
        //    }
        ////}


        //public T DeepClone<T>(T obj)
        //{
        //   using(var ms = new System.IO.MemoryStream())
        //   {
        //      var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

        //      formatter.Serialize(ms, obj);

        //      ms.Position = 0;

        //      return (T) formatter.Deserialize(ms);
        //   }
        //}

 


        //#region -- performance test --

        //double NextDouble(Random rng, double min, double max)
        //{
        //   return min + (rng.NextDouble() * (max - min));
        //}

        //int tt = 0;
        //void timer_Tick(object sender, EventArgs e)
        //{
        //   var pos = new PointLatLng(NextDouble(rnd, mapen.ViewArea.Top, mapen.ViewArea.Bottom), NextDouble(rnd, mapen.ViewArea.Left, mapen.ViewArea.Right));
        //   GMapMarker m = new GMarkerGoogle(pos, GMarkerGoogleType.green_pushpin);
        //   {
        //      m.ToolTipText = (tt++).ToString();
        //      m.ToolTipMode = MarkerTooltipMode.Always;
        //   }

        //   objects.Markers.Add(m);

        //   if(tt >= 333)
        //   {
        //      timerPerf.Stop();
        //      tt = 0;
        //   }
        //}

        //System.Windows.Forms.Timer timerPerf = new System.Windows.Forms.Timer();
        //#endregion

        //#region -- flight demo --
        //BackgroundWorker flightWorker = new BackgroundWorker();

        //readonly List<FlightRadarData> flights = new List<FlightRadarData>();
        //readonly Dictionary<int, GMapMarker> flightMarkers = new Dictionary<int, GMapMarker>();

        //bool firstLoadFlight = true;
        //GMapMarker currentFlight;

        //void flight_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //   // stops immediate marker/route/polygon invalidations;
        //   // call Refresh to perform single refresh and reset invalidation state
        //   mapen.HoldInvalidation = true;

        //   lock(flights)
        //   {
        //      foreach(FlightRadarData d in flights)
        //      {
        //         GMapMarker marker;

        //         if(!flightMarkers.TryGetValue(d.Id, out marker))
        //         {
        //            marker = new GMarkerGoogle(d.point, GMarkerGoogleType.blue_small);
        //            marker.Tag = d.Id;
        //            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
        //            //(marker as GMapMarkerGoogleGreen).Bearing = (float?)d.bearing;

        //            flightMarkers[d.Id] = marker;
        //            objects.Markers.Add(marker);
        //         }
        //         else
        //         {
        //            marker.Position = d.point;
        //            //(marker as GMapMarkerGoogleGreen).Bearing = (float?)d.bearing;
        //         }
        //         marker.ToolTipText = d.name + ", " + d.altitude + ", " + d.speed;

        //         if(currentFlight != null && currentFlight == marker)
        //         {
        //            mapen.Position = marker.Position;
        //            //mapen.Bearing = (float)d.bearing;
        //         }
        //      }
        //   }

        //   if(firstLoadFlight)
        //   {
        //      mapen.Zoom = 5;
        //      mapen.SetZoomToFitRect(new RectLatLng(54.4955675218741, -0.966796875, 28.916015625, 13.3830987326932));
        //      firstLoadFlight = false;
        //   }
        //   mapen.Refresh();
        //}

        ////void flight_DoWork(object sender, DoWorkEventArgs e)
        ////{
        ////   bool restartSesion = true;

        ////   while(!flightWorker.CancellationPending)
        ////   {
        ////      try
        ////      {
        ////         lock(flights)
        ////         {
        ////            Stuff.GetFlightRadarData(flights, lastPosition, lastZoom, restartSesion);

        ////            if(flights.Count > 0 && restartSesion)
        ////            {
        ////               restartSesion = false;
        ////            }
        ////         }

        ////         flightWorker.ReportProgress(100);
        ////      }
        ////      catch(Exception ex)
        ////      {
        ////         Debug.WriteLine("flight_DoWork: " + ex.ToString());
        ////      }
        ////      Thread.Sleep(5 * 1000);
        ////   }

        ////   flightMarkers.Clear();
        ////}

        //#endregion

        //#region -- transport demo --
        //BackgroundWorker transportWorker = new BackgroundWorker();

        //#region -- old vehicle demo --
        //readonly List<VehicleData> trolleybus = new List<VehicleData>();
        //readonly Dictionary<int, GMapMarker> trolleybusMarkers = new Dictionary<int, GMapMarker>();

        //readonly List<VehicleData> bus = new List<VehicleData>();
        //readonly Dictionary<int, GMapMarker> busMarkers = new Dictionary<int, GMapMarker>();
        //#endregion

        //bool firstLoadTrasport = true;
        //GMapMarker currentTransport;

        //void transport_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //   // stops immediate marker/route/polygon invalidations;
        //   // call Refresh to perform single refresh and reset invalidation state
        //   mapen.HoldInvalidation = true;

        //   #region -- vehicle demo --
        //   lock(trolleybus)
        //   {
        //      foreach(VehicleData d in trolleybus)
        //      {
        //         GMapMarker marker;

        //         if(!trolleybusMarkers.TryGetValue(d.Id, out marker))
        //         {
        //            marker = new GMarkerGoogle(new PointLatLng(d.Lat, d.Lng), GMarkerGoogleType.red_small);
        //            marker.Tag = d.Id;
        //            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;

        //            trolleybusMarkers[d.Id] = marker;
        //            objects.Markers.Add(marker);
        //         }
        //         else
        //         {
        //            marker.Position = new PointLatLng(d.Lat, d.Lng);
        //           // (marker as GMarkerGoogle).Bearing = (float?) d.Bearing;
        //         }
        //         marker.ToolTipText = "Trolley " + d.Line + (d.Bearing.HasValue ? ", bearing: " + d.Bearing.Value.ToString() : string.Empty) + ", " + d.Time;

        //         if(currentTransport != null && currentTransport == marker)
        //         {
        //            mapen.Position = marker.Position;
        //            if(d.Bearing.HasValue)
        //            {
        //               mapen.Bearing = (float) d.Bearing.Value;
        //            }
        //         }
        //      }
        //   }

        //   lock(bus)
        //   {
        //      foreach(VehicleData d in bus)
        //      {
        //         GMapMarker marker;

        //         if(!busMarkers.TryGetValue(d.Id, out marker))
        //         {
        //            marker = new GMarkerGoogle(new PointLatLng(d.Lat, d.Lng), GMarkerGoogleType.green_small);
        //            marker.Tag = d.Id;
        //            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;

        //            busMarkers[d.Id] = marker;
        //            objects.Markers.Add(marker);
        //         }
        //         else
        //         {
        //            marker.Position = new PointLatLng(d.Lat, d.Lng);
        //            //(marker as GMarkerGoogle).Bearing = (float?) d.Bearing;
        //         }
        //         marker.ToolTipText = "Bus " + d.Line + (d.Bearing.HasValue ? ", bearing: " + d.Bearing.Value.ToString() : string.Empty) + ", " + d.Time;

        //         if(currentTransport != null && currentTransport == marker)
        //         {
        //            mapen.Position = marker.Position;
        //            if(d.Bearing.HasValue)
        //            {
        //               mapen.Bearing = (float) d.Bearing.Value;
        //            }
        //         }
        //      }
        //   }
        //   #endregion

        //   if(firstLoadTrasport)
        //   {
        //      mapen.Zoom = 5;
        //      mapen.ZoomAndCenterMarkers("objects");
        //      firstLoadTrasport = false;
        //   }
        //   mapen.Refresh();
        //}

        //void transport_DoWork(object sender, DoWorkEventArgs e)
        //{
        //   while(!transportWorker.CancellationPending)
        //   {
        //      try
        //      {
        //         #region -- old vehicle demo --
        //         lock(trolleybus)
        //         {
        //            Stuff.GetVilniusTransportData(TransportType.TrolleyBus, string.Empty, trolleybus);

        //         }

        //         lock(bus)
        //         {
        //            Stuff.GetVilniusTransportData(TransportType.Bus, string.Empty, bus);
        //         }
        //         #endregion

        //         transportWorker.ReportProgress(100);
        //      }
        //      catch(Exception ex)
        //      {
        //         Debug.WriteLine("transport_DoWork: " + ex.ToString());
        //      }
        //      Thread.Sleep(2 * 1000);
        //   }

        //   trolleybusMarkers.Clear();
        //   busMarkers.Clear();
        //}

        //#endregion

        //#region -- tcp/ip connections demo --
        //BackgroundWorker connectionsWorker = new BackgroundWorker();
        //BackgroundWorker ipInfoSearchWorker = new BackgroundWorker();
        //BackgroundWorker iptracerWorker = new BackgroundWorker();

        //readonly Dictionary<string, IpInfo> TcpState = new Dictionary<string, IpInfo>();
        //readonly Dictionary<string, IpInfo> TcpTracePoints = new Dictionary<string, IpInfo>();
        //readonly Dictionary<string, List<PingReply>> TraceRoutes = new Dictionary<string, List<PingReply>>();

        //readonly List<string> TcpStateNeedLocationInfo = new List<string>();
        //readonly Queue<string> TcpStateNeedtraceInfo = new Queue<string>();

        //volatile bool TryTraceConnection = false;
        //GMapMarker lastTcpmarker;
        //readonly SQLiteIpCache IpCache = new SQLiteIpCache();

        //readonly Dictionary<string, GMapMarker> tcpConnections = new Dictionary<string, GMapMarker>();
        //readonly Dictionary<string, GMapRoute> tcpRoutes = new Dictionary<string, GMapRoute>();

        //readonly List<IpStatus> CountryStatusView = new List<IpStatus>();
        //readonly SortedDictionary<string, int> CountryStatus = new SortedDictionary<string, int>();

        //readonly List<string> SelectedCountries = new List<string>();
        //readonly Dictionary<int, Process> ProcessList = new Dictionary<int, Process>();

        //#endregion


   

    //}
   
//}
