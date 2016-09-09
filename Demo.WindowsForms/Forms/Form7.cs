using System;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Demo.WindowsForms.CustomMarkers;
using System.IO;
using System.Globalization;



namespace Demo.WindowsForms.Source
{
    public partial class Form7 : Form 
    {
        // Слои 
        readonly GMapOverlay top = new GMapOverlay();
        internal readonly GMapOverlay objects = new GMapOverlay("objects");     // объекты
        internal readonly GMapOverlay routes = new GMapOverlay("routes");       // Дороги
        internal readonly GMapOverlay polygons = new GMapOverlay("polygons");   // Полигоны
        internal readonly GMapOverlay marshryt = new GMapOverlay("marshryt");   // Маршруты
        internal readonly GMapOverlay okruga = new GMapOverlay("okruga");       // Округа
        internal readonly GMapOverlay markersOverlay = new GMapOverlay("markers"); // Округа


        // Прочее
        readonly Random rnd = new Random();
        readonly DescendingComparer ComparerIpStatus = new DescendingComparer();
        
        GMarkerGoogle currentMarker;
        GMapMarker currentTransport;
        ContextMenu markerMenu = new ContextMenu();
        GMapMarkerRect CurentRectMarker = null;
        
        bool isMouseDown = false;

        // Полигон
        GMapPolygon polygon;

        public Form7()
        {
            InitializeComponent();
            if (!GMapControl.IsDesignerHosted)
            {
                // конфигурация карты  
                {
                    map1.MapProvider = GMapProviders.OpenCycleTransportMap;           // провайдер карты
                    map1.Position = new PointLatLng(55.75393, 37.620795); // Координаты города по умолчанию
                    map1.MinZoom = 0;
                    map1.MaxZoom = 24;
                    map1.Zoom = 9;
                }

                // события карты
                {
                    map1.OnMarkerEnter += new MarkerEnter(map1_OnMarkerEnter);  // События мыши при нажатии
                    map1.OnMarkerLeave += new MarkerLeave(map1_OnMarkerLeave); //  События мыши при отпускании
                    map1.OnMarkerClick += new MarkerClick(map1_OnMarkerClick);

                    map1.MouseDown += new MouseEventHandler(map1_MouseDown);
                    map1.MouseMove += new MouseEventHandler(map1_MouseMove);
                    map1.MouseUp += new MouseEventHandler(map1_MouseUp);
                    map1.MouseDoubleClick += new MouseEventHandler(map1_MouseDoubleClick);            
                }
                {
                    map1.Overlays.Add(routes);         // добавление дорог
                    map1.Overlays.Add(polygons);       // добавление полигонов
                    map1.Overlays.Add(objects);        // добавление объектов
                    map1.Overlays.Add(top);            // добавление обрамления
                    map1.Overlays.Add(marshryt);       // добавление маршрута
                    map1.Overlays.Add(okruga);         // добавление округов
                    map1.Overlays.Add(markersOverlay);
                }

                currentMarker = new GMarkerGoogle(map1.Position, GMarkerGoogleType.arrow);
                currentMarker.IsHitTestVisible = false;
                top.Markers.Add(currentMarker);
            }
            MapMenu();
        }

        private void MapMenu()
        {
            MenuItem command1 = null;
            MenuItem command2 = null;
            MenuItem command3 = null;
            MenuItem command4 = null;

            command1 = new MenuItem("Your command name 1", new EventHandler(Method1));
            command2 = new MenuItem("Your command name 21", new EventHandler(Method2));
            command3 = new MenuItem("Your command name 1", new EventHandler(Method1));
            command4 = new MenuItem("Your command name 2111", new EventHandler(Method2));

            markerMenu.MenuItems.Add(command1);
            markerMenu.MenuItems.Add(command2);
            markerMenu.MenuItems.Add(command3);
            markerMenu.MenuItems.Add(command4);
        }

        void map1_OnMarkerLeave(GMapMarker item)
        {
            if (item is GMapMarkerRect)
            {
                GMapMarkerRect rc = item as GMapMarkerRect;
                rc.Pen.Color = Color.Blue;    
                rc.ToolTipMode = MarkerTooltipMode.Never;
            }
        }
        void map1_OnMarkerEnter(GMapMarker item)
        {
            MouseEventArgs e = null;
            if (item is GMapMarkerRect)
            {
                GMapMarkerRect rc = item as GMapMarkerRect;
                rc.Pen.Color = Color.Red;
                rc.ToolTipMode = MarkerTooltipMode.Always;
                
                
            }
            //KoordiStan(item, e);
        }

        void map1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            KoordiStan(item, e);
        }

        public void KoordiStan(GMapMarker item, MouseEventArgs e)
        {
            //if (e.Button == System.Windows.Forms.MouseButtons.Left)
            //{
                if (item is GMapMarkerRect)
                {
                    GeoCoderStatusCode status;
                    var pos = GMapProviders.GoogleMap.GetPlacemark(item.Position, out status);
                    if (status == GeoCoderStatusCode.G_GEO_SUCCESS && pos != null)
                    {
                        GMapMarkerRect v = item as GMapMarkerRect;
                        {
                            v.ToolTipText = pos.Value.Address;
                        }
                        map1.Invalidate(false);
                    }
                }
                else
                {
                    if (item.Tag != null)
                    {
                        if (currentTransport != null)
                        {
                            currentTransport.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                            currentTransport = null;
                        }
                        currentTransport = item;
                        currentTransport.ToolTipMode = MarkerTooltipMode.Always;
                    }
                }
            //}
        }
        void map1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //var cc = new GMapMarkerCircle(map1.FromLocalToLatLng(e.X, e.Y));
            //objects.Markers.Add(cc);
        }
        
        void map1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left && isMouseDown)
            //{
            //    if (CurentRectMarker == null)
            //    {
            //        if (currentMarker.IsVisible)
            //        {
            //            currentMarker.Position = map1.FromLocalToLatLng(e.X, e.Y);
            //        }
            //    }
            //    else // move rect marker
            //    {
            //        PointLatLng pnew = map1.FromLocalToLatLng(e.X, e.Y);

            //        int? pIndex = (int?)CurentRectMarker.Tag;
            //        if (pIndex.HasValue)
            //        {
            //            if (pIndex < polygon.Points.Count)
            //            {
            //                polygon.Points[pIndex.Value] = pnew;
            //                map1.UpdatePolygonLocalPosition(polygon);
            //            }
            //        }

            //        if (currentMarker.IsVisible)
            //        {
            //            currentMarker.Position = pnew;
            //        }
            //        CurentRectMarker.Position = pnew;

            //        if (CurentRectMarker.InnerMarker != null)
            //        {
            //            CurentRectMarker.InnerMarker.Position = pnew;
            //        }
            //    }

            //    map1.Refresh(); // force instant invalidation
            //}
        }
        void map1_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                if (e.Button == MouseButtons.Right)
                {
                    isMouseDown = false;
                    markerMenu.Show(map1, e.Location);
                }
            }
        }
        void map1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;

                if (currentMarker.IsVisible)
                {
                    currentMarker.Position = map1.FromLocalToLatLng(e.X, e.Y);
                    var px = map1.MapProvider.Projection.FromLatLngToPixel(currentMarker.Position.Lat, currentMarker.Position.Lng, (int)map1.Zoom);
                    var tile = map1.MapProvider.Projection.FromPixelToTileXY(px);

                    // Debug.WriteLine("MouseDown: geo: " + currentMarker.Position + " | px: " + px + " | tile: " + tile);
                }
            }

        }
       
        private void Method1(object sender, EventArgs e)
        {
            MenuItem item = sender as MenuItem;
            // access item.Tag to get the marker Tag info 
            MessageBox.Show("hf");
        }
        private void Method2(object sender, EventArgs e)
        {
            
          
          try
            {
              
                GeoCoderStatusCode status;   
                var pos = GMapProviders.GoogleMap.GetPlacemark(map1.Position, out status);
                GMapMarkerRect s = new GMapMarkerRect(map1.Position);
                s.ToolTipText = map1.Position.ToString();
                    

                   //this.insertKoordiTableAdapter.Fill(this.gISSIGData.InsertKoordi,
                   //    new System.Nullable<double>(((double)(System.Convert.ChangeType(currentMarker.Position.Lat, typeof(double))))),
                   //    new System.Nullable<double>(((double)(System.Convert.ChangeType(currentMarker.Position.Lng, typeof(double))))));
                   MessageBox.Show(s+"Внесено!");
                   //MessageBox.Show("Внесено!");
               
            
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
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

                map1.Position = new PointLatLng(lat, lng);                                            //Формировка координат

                GMarkerGoogle m = new GMarkerGoogle(map1.Position, GMarkerGoogleType.green_pushpin); // Установка в точке значка
                GMapMarkerRect mBorders = new GMapMarkerRect(map1.Position);                         // Установка ограничителя
                {
                    mBorders.InnerMarker = m;
                    mBorders.ToolTipMode = MarkerTooltipMode.Always;
                }

                objects.Markers.Add(m);
                objects.Markers.Add(mBorders);
            }
            MessageBox.Show("Завершено! Внимание, название остановок доступно в полной версии!");
        }

        public void Geo(string Input, out double lat, out double lng)
        {
            label1.Text = Input.Remove(15);                                            // Подготовка данных в текстовом файле
            label2.Text = Input.Substring(16);

            lat = double.Parse(label2.Text, CultureInfo.InvariantCulture);                  //Преобразование данных 
            lng = double.Parse(label1.Text, CultureInfo.InvariantCulture);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Внимание!!! При формировании остановок, возможно краткосрочное зависание, не прерывайте процесс!");

            StreamReader ReadFile = File.OpenText("StanPoUlicham.txt");
            Chteniedannyx(ReadFile);
        }

        
            
      
    
    
    
    
    
    
    }
}



            
