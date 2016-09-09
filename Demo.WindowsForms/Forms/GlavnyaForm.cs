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

//using BSE.Windows.Forms;

namespace Demo.WindowsForms.Forms
{
    public partial class GlavnyaForm : Form
    {
        private int childFormNumber = 0;
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



        public GlavnyaForm()
        {
            InitializeComponent();
            //panel2.Visible = false;
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
                mapen.MapProvider = GMapProviders.YandexMap;
                //mapen.Position = new PointLatLng(54.6961334816182, 25.2985095977783);
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

                mapen.OnMarkerClick += new MarkerClick(mapen_OnMarkerClick);
                mapen.OnMarkerEnter += new MarkerEnter(mapen_OnMarkerEnter);
                mapen.OnMarkerLeave += new MarkerLeave(mapen_OnMarkerLeave);

                //mapen.OnPolygonEnter += new PolygonEnter(mapen_OnPolygonEnter);
                //mapen.OnPolygonLeave += new PolygonLeave(mapen_OnPolygonLeave);

                mapen.OnRouteEnter += new RouteEnter(mapen_OnRouteEnter);
                mapen.OnRouteLeave += new RouteLeave(mapen_OnRouteLeave);

                //mapen.Manager.OnTileCacheComplete += new TileCacheComplete(OnTileCacheComplete);
                //mapen.Manager.OnTileCacheStart += new TileCacheStart(OnTileCacheStart);
                //mapen.Manager.OnTileCacheProgress += new TileCacheProgress(OnTileCacheProgress);
                //}

                mapen.MouseMove += new MouseEventHandler(mapen_MouseMove);
                 // mapen.MouseDown += new MouseEventHandler(mapen_MouseDown);
                //mapen.MouseUp += new MouseEventHandler(mapen_MouseUp);
                //mapen.MouseDoubleClick += new MouseEventHandler(mapen_MouseDoubleClick);

                {
                    mapen.Overlays.Add(routes);
                    mapen.Overlays.Add(polygons);
                    mapen.Overlays.Add(objects);
                    mapen.Overlays.Add(top);

                  // routes.Routes.CollectionChanged += new GMap.NET.ObjectModel.NotifyCollectionChangedEventHandler(Routes_CollectionChanged);
                    objects.Markers.CollectionChanged += new GMap.NET.ObjectModel.NotifyCollectionChangedEventHandler(Markers_CollectionChanged);
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
                rc.ToolTipText = "OnMarkerEnter: ";
                 rc.ToolTipMode = MarkerTooltipMode.Always;

            }
        }

        
        void mapen_OnMarkerClick(object sender, MouseEventArgs e)
        {
           
            //panel2.Show();
            //this.ShowDialog(Message.ActiveForm);

            //if (e.Button == System.Windows.Forms.MouseButtons.Left)
            //{
            //    if (item is GMapMarkerRect)
            //    {
            //        GeoCoderStatusCode status;
            //        var pos = GMapProviders.GoogleMap.GetPlacemark(item.Position, out status);
            //        if (status == GeoCoderStatusCode.G_GEO_SUCCESS && pos != null)
            //        {
            //            GMapMarkerRect v = item as GMapMarkerRect;
            //            {
            //                v.ToolTipText = pos.Value.Address;
            //            }
            //            MainMap.Invalidate(false);
            //        }
            //    }
            //    else
            //    {
            //        if (item.Tag != null)
            //        {
            //            if (currentTransport != null)
            //            {
            //                currentTransport.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            //                currentTransport = null;
            //            }
            //            currentTransport = item;
            //            currentTransport.ToolTipMode = MarkerTooltipMode.Always;
            //        }
            //    }
            //}
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

        void RegeneratePolygon()
        {
            List<PointLatLng> polygonPoints = new List<PointLatLng>();

            foreach (GMapMarker m in objects.Markers)
            {
                if (m is GMapMarkerRect)
                {
                    m.Tag = polygonPoints.Count;
                    polygonPoints.Add(m.Position);
                }
            }

            if (polygon == null)
            {
                polygon = new GMapPolygon(polygonPoints, "polygon test");
                polygon.IsHitTestVisible = true;
                polygons.Polygons.Add(polygon);
            }
            else
            {
                polygon.Points.Clear();
                polygon.Points.AddRange(polygonPoints);

                if (polygons.Polygons.Count == 0)
                {
                    polygons.Polygons.Add(polygon);
                }
                else
                {
                    mapen.UpdatePolygonLocalPosition(polygon);
                }
            }
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

        // void mapen_MouseUp(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        isMouseDown = false;
        //    }
        //}

        //// add demo circle
        //void mapen_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    var cc = new GMapMarkerCircle(mapen.FromLocalToLatLng(e.X, e.Y));
        //    objects.Markers.Add(cc);
        //}

        void mapen_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;

                if (currentMarker.IsHitTestVisible)
                {
                    mapen.Position = mapen.FromLocalToLatLng(e.X, e.Y);

                      // var px = mapen.MapProvider.Projection.FromLatLngToPixel(currentMarker.Position.Lat, currentMarker.Position.Lng, (int)mapen.Zoom);
                     //  var tile = mapen.MapProvider.Projection.FromPixelToTileXY(px);

                    //  Debug.WriteLine("MouseDown: geo: " + currentMarker.Position + " | px: " + px + " | tile: " + tile);
                }
            }
        }

        //// move current marker with left holding
        void mapen_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isMouseDown)
            {
                if (CurentRectMarker == null)
                {
                    if (currentMarker.IsHitTestVisible)
                    {
                        mapen.Position = mapen.FromLocalToLatLng(e.X, e.Y);
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
                        mapen.Position = pnew;
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

        private void Glavnya_Load(object sender, EventArgs e)
        {
            GeoCoderStatusCode status = mapen.SetPositionByKeywords("Москва Октябрьская улица");
            if (status != GeoCoderStatusCode.G_GEO_SUCCESS)
            {
                // MessageBox.Show("Geocoder can't find: '" + textBoxGeo.Text + "', reason: " + status.ToString(), "GMap.NET", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                GMapMarkerCircle mBordert = new GMapMarkerCircle(mapen.Position);
                {
                    //mBorder.stroke = m;
                    mBorders.InnerMarker = m;

                    if (polygon != null)
                    {
                       // mBorders.Tag = polygon.Points.Count;
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
                   // mBorders.ToolTipText = p.Value.Address;
                }
                else
                {
                   // mBorders.ToolTipText = mapen.Position.ToString();
                }

                objects.Markers.Add(m);
                objects.Markers.Add(mBorders);

               // RegeneratePolygon();

            }
        }

      

       private void button2_Click(object sender, EventArgs e)
        {
              StreamReader ReadFile = File.OpenText("Line.txt");
              string Input = null;
              //Читаем из файла информацию
              while ((Input = ReadFile.ReadLine()) != null)
              {
                  label1.Text = Input.Remove(15);
                  label2.Text = Input.Substring(16);

                  double lat = double.Parse(label2.Text, CultureInfo.InvariantCulture);
                  double lng = double.Parse(label1.Text, CultureInfo.InvariantCulture);

                  mapen.Position = new PointLatLng(lat, lng);
              }
       }

      void Markers_CollectionChanged(object sender, GMap.NET.ObjectModel.NotifyCollectionChangedEventArgs e)
      {
         label5.Text = objects.Markers.Count.ToString();
      }

      void Routes_CollectionChanged(object sender, GMap.NET.ObjectModel.NotifyCollectionChangedEventArgs e)
      {
         label6.Text = routes.Routes.Count.ToString();
      }

      private void button3_Click(object sender, EventArgs e)
      {
          end = mapen.Position;
       

                StreamReader ReadFile = File.OpenText("Line.txt");
                string Input = null;
              //Читаем из файла информацию
                Input = ReadFile.ReadLine();
                //while ((Input = ReadFile.ReadLine()) != null)
                //{

                    label1.Text = Input.Remove(15);
                    label2.Text = Input.Substring(16);

                    double lat = double.Parse(label2.Text, CultureInfo.InvariantCulture);
                    double lng = double.Parse(label1.Text, CultureInfo.InvariantCulture);

                    mapen.Position = new PointLatLng(lat, lng);
                    
                //}

      }

      private void button4_Click(object sender, EventArgs e)
      {
          
          start = mapen.Position;

          StreamReader ReadFile = File.OpenText("Line.txt");
          string Input = null;
          //Читаем из файла информацию
          while ((Input = ReadFile.ReadLine()) != null)
          {

              label1.Text = Input.Remove(15);
              label2.Text = Input.Substring(16);

              double lat = double.Parse(label2.Text, CultureInfo.InvariantCulture);
              double lng = double.Parse(label1.Text, CultureInfo.InvariantCulture);

              mapen.Position = new PointLatLng(lat, lng);

          }

      }

      private void button5_Click(object sender, EventArgs e)
      {
          
              RoutingProvider rp = mapen.MapProvider as RoutingProvider;
              //  RoutingProvider rm = MainMap.MapProvider as RoutingProvider;
              if (rp == null)
              {
                  rp = GMapProviders.OpenStreetMap; // use OpenStreetMap if provider does not implement routing
                  //  rm = GMapProviders.OpenCycleTransportMap;
              }
         
              // //---------------------------------------
              //StreamReader ReadFile = File.OpenText("Line.txt");
              //string Input = null;
              ////Читаем из файла информацию
              //while ((Input = ReadFile.ReadLine()) != null)
              //{

              //    label1.Text = Input.Remove(15);
              //    label2.Text = Input.Substring(16);

              //    double lat = double.Parse(label2.Text, CultureInfo.InvariantCulture);
              //    double lng = double.Parse(label1.Text, CultureInfo.InvariantCulture);

              //    mapen.Position = new PointLatLng(lat, lng);


              //List<PointLatLng> tochki = new List<PointLatLng>();
              //{
              //    tochki.Add(mapen.Position);
              //}
              //    start = MainMap.Position;
              //    end = currentMarker.Position;
                  ///--------------------------------
                  MapRoute route = rp.GetRoute(start, end, false, false, (int)mapen.Zoom);
                  //MapRoute route = rp.GetRoute(label1.Text, label2.Text, false, false, (int)MainMap.Zoom);
                  if (route != null)
                  {

                      // add route
                      GMapRoute r = new GMapRoute(route.Points, route.Name);
                      r.IsVisible = true;

                      r.Stroke = new Pen(Color.FromArgb(144, Color.Red));
                      r.Stroke.Width = 5;
                      r.Stroke.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;

                      routes.Routes.Add(r);


                      // add route start/end marks
                      GMapMarker m1 = new GMarkerGoogle(start, GMarkerGoogleType.green_big_go);
                      m1.ToolTipText = "Start: " + route.Name;
                      m1.ToolTipMode = MarkerTooltipMode.Always;

                      GMapMarker m2 = new GMarkerGoogle(end, GMarkerGoogleType.red_big_stop);
                      m2.ToolTipText = "End: " + end.ToString();
                      m2.ToolTipMode = MarkerTooltipMode.Always;

                      objects.Markers.Add(m1);
                      objects.Markers.Add(m2);

                     mapen.ZoomAndCenterRoute(r);
                  }
              
          }

      private void button2_MouseLeave(object sender, EventArgs e)
      {
          StreamReader ReadFile = File.OpenText("Line.txt");
          string Input = null;
          //Читаем из файла информацию
          while ((Input = ReadFile.ReadLine()) != null)
          {
              label1.Text = Input.Remove(15);
              label2.Text = Input.Substring(16);

              double lat = double.Parse(label2.Text, CultureInfo.InvariantCulture);
              double lng = double.Parse(label1.Text, CultureInfo.InvariantCulture);

              mapen.Position = new PointLatLng(lat, lng);
          }
          MessageBox.Show("Готово!!!");
      }

      private void button7_MouseEnter(object sender, EventArgs e)
      {
         // rectangleShape1.Show();
          
      }
      }
     






         

        //----------------------------------------------------------

            //StreamReader ReadFile = File.OpenText("Line.txt");
            //string Input = null;
            ////Читаем из файла информацию
            //while ((Input = ReadFile.ReadLine()) != null)
            //{

            //    label1.Text = Input.Remove(15);
            //    label2.Text = Input.Substring(16);

            //    double lat = double.Parse(label2.Text, CultureInfo.InvariantCulture);
            //    double lng = double.Parse(label1.Text, CultureInfo.InvariantCulture);

            //    mapen.Position = new PointLatLng(lat, lng);


            //    List<PointLatLng> tochki = new List<PointLatLng>();
            //    {
            //        tochki.Add(mapen.Position);
            //    }

            //    GMapRoute rt = new GMapRoute(tochki, string.Empty);
            //    {
            //        rt.Stroke = new Pen(Color.FromArgb(144, Color.Red));
            //        rt.Stroke.Width = 90;
            //        rt.Stroke.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            //        rt.IsHitTestVisible = true;
            //         // add route
            //        //GMapRoute ret = new GMapRoute(tochki, string.Empty);
            //        // rt.IsHitTestVisible = true;
                    
            //        routes.Routes.Add(rt);
            //    }
            }
         
  

 
    

