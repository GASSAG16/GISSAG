using WindowsForms.CustomMarkers;
using WindowsForms.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsForms;

namespace WindowsForms.Logic
{
    class logicShow : logicEventmap
    {
        //internal readonly GMapOverlay objects = new GMapOverlay("objects");     // объекты
        readonly GMapOverlay top = new GMapOverlay();
        //GMapOverlay line = new GMapOverlay();
        
        #region DemoMode

        public void StationsThroughoutTheCity(Map mapen)
        {
            StreamReader ReadFile = File.OpenText("StationsThroughoutTheCity.txt");
            TheDisplayMechanism(mapen, ReadFile);
        }
        public void StationAreasOfTheCity(Map mapen)
        {
            StreamReader ReadFile = File.OpenText("StationAreasOfTheCity.txt");
            TheDisplayMechanism(mapen, ReadFile);
        }
        public void StationsOnCityStreets(Map mapen)
        {
            StreamReader ReadFile = File.OpenText("StationsOnCityStreets.txt");
            TheDisplayMechanism(mapen, ReadFile);
        }

        public void TheRoutesOfUrbanPassengerTransport(Map mapen)
        {
            Overlays(mapen);

            List<PointLatLng> spisok = new List<PointLatLng>();                 // Формируем в цикле список координат
            {
                StreamReader ReadFile = File.OpenText("TheRoutesOfUrbanPassengerTransport.txt");
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

        private void TheDisplayMechanism(Map mapen, StreamReader ReadFile)
        {
            Overlays(mapen);

            MessageBox.Show("Внимание!!! При формировании остановок, возможно краткосрочное зависание, не прерывайте процесс!");

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
            char ch = ',';
            int del = Input.IndexOf(ch);

            string strLng = Input.Remove(del);
            string strLat = Input.Substring(del + 2);

            lat = double.Parse(strLat, CultureInfo.InvariantCulture);                  //Преобразование данных 
            lng = double.Parse(strLng, CultureInfo.InvariantCulture);

        }

        #endregion

        #region ServerMode

        public void TheRoutesOfUrbanPassengerTransport(BindingSource requestTracksRoutesBindingSource, Map mapen, Label lbKoordiX, Label lbKoordiY, Label lbCount)
        {
            Overlays(mapen);
            try
            {
                List<PointLatLng> spisok = new List<PointLatLng>();                 // Формируем в цикле список координат
                {
                    int f = Convert.ToInt32(lbCount.Text);
                    for (int v = -1; v < f; v++)//
                    {
                        requestTracksRoutesBindingSource.MoveNext();

                        lbKoordiX.Text = lbKoordiX.Text.Replace(",", ".");
                        lbKoordiY.Text = lbKoordiY.Text.Replace(",", ".");

                        double lat = double.Parse(lbKoordiY.Text, CultureInfo.InvariantCulture);
                        double lng = double.Parse(lbKoordiX.Text, CultureInfo.InvariantCulture);

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
            catch 
            {
                //специально сделано
            }
        }

        public void TheRoutesOfUrbanPassengerStop(BindingSource requestPassangerStopBindingSource, Map mapen, 
            Label lbKoordiXPassanger, Label lbKoordiYPassanger, Label lbCountPassanger, Label lbTheNameOfTheStop)
        {
            Overlays(mapen);//Passanger
            try
            {
                int f = Convert.ToInt32(lbCountPassanger.Text);
                for (int v = -1; v < f; v++)//
                {
                    requestPassangerStopBindingSource.MoveNext();

                    lbKoordiXPassanger.Text = lbKoordiXPassanger.Text.Replace(",", ".");
                    lbKoordiYPassanger.Text = lbKoordiYPassanger.Text.Replace(",", ".");

                    double lat = double.Parse(lbKoordiYPassanger.Text, CultureInfo.InvariantCulture);
                    double lng = double.Parse(lbKoordiXPassanger.Text, CultureInfo.InvariantCulture);


                    mapen.Position = new PointLatLng(lat, lng);                                           //Формирование координат

                    GMarkerGoogle m = new GMarkerGoogle(mapen.Position, GMarkerGoogleType.green_pushpin); // Установка в точке значка
                    GMapMarkerRect mBorders = new GMapMarkerRect(mapen.Position);                         // Установка ограничителя - квадрат
                    GMapMarkerCircle mBordert = new GMapMarkerCircle(mapen.Position);                      // Установка ограничителя - окружность

                    {
                        mBorders.InnerMarker = m;
                    }

                    //if (checkBox2.Checked)
                    //{
                    //    mBorders.ToolTipText = mapens.Position.ToString();
                    //}

                    mBorders.ToolTipText = lbTheNameOfTheStop.Text;
                    objects.Markers.Add(m);
                    objects.Markers.Add(mBorders);
                }
                MessageBox.Show("Завершено!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Переделать TheRoutesOfUrbanPassengerTransport
        public void TheRoutesOfUrbanPassengerTransport(BindingSource requestTracksRoutesBindingSource, Map mapen, Label lbKoordiX, Label lbKoordiY, Label lbCount,
            BindingSource requestPassangerStopBindingSource, Label lbKoordiXPassanger, Label lbKoordiYPassanger, Label lbCountPassanger, Label lbTheNameOfTheStop, CheckBox cbAreaPassanger)
        {
            Overlays(mapen);
            try
            {
                List<PointLatLng> spisok = new List<PointLatLng>();                 // Формируем в цикле список координат
                {
                    int f = Convert.ToInt32(lbCount.Text);
                    for (int v = -1; v < f; v++)//
                    {
                        requestTracksRoutesBindingSource.MoveNext();

                        lbKoordiX.Text = lbKoordiX.Text.Replace(",", ".");
                        lbKoordiY.Text = lbKoordiY.Text.Replace(",", ".");

                        double lat = double.Parse(lbKoordiY.Text, CultureInfo.InvariantCulture);
                        double lng = double.Parse(lbKoordiX.Text, CultureInfo.InvariantCulture);

                        spisok.Add(new PointLatLng(lat, lng));
                    }
                }
                GMapRoute L = new GMapRoute(spisok, "линия");
                L.Stroke.Width = 5;
                L.Stroke.Color = Color.Red;                                     // Настройка линии
                line.Routes.Add(L);
                mapen.ZoomAndCenterRoute(L);
                mapen.Zoom = 15;

                int f2 = Convert.ToInt32(lbCountPassanger.Text);
                for (int v = 0; v < f2; v++)//
                {
                    requestPassangerStopBindingSource.MoveNext();

                    lbKoordiXPassanger.Text = lbKoordiXPassanger.Text.Replace(",", ".");
                    lbKoordiYPassanger.Text = lbKoordiYPassanger.Text.Replace(",", ".");

                    double lat = double.Parse(lbKoordiYPassanger.Text, CultureInfo.InvariantCulture);
                    double lng = double.Parse(lbKoordiXPassanger.Text, CultureInfo.InvariantCulture);


                    mapen.Position = new PointLatLng(lat, lng);                                           //Формирование координат

                    GMarkerGoogle m = new GMarkerGoogle(mapen.Position, GMarkerGoogleType.green_pushpin); // Установка в точке значка
                    GMapMarkerRect mBorders = new GMapMarkerRect(mapen.Position);                         // Установка ограничителя - квадрат
                    GMapMarkerCircle mBordert = new GMapMarkerCircle(mapen.Position);                      // Установка ограничителя - окружность

                    {
                        mBorders.InnerMarker = m;
                    }

                    //if (checkBox2.Checked)
                    //{
                    //    mBorders.ToolTipText = mapens.Position.ToString();
                    //}
                    //{
                    //    if (cbAreaPassanger.Checked)
                    //    {
                    //        mBordert.Radius = 300;
                    //        mBordert.Stroke.Width = 1;
                    //        mBordert.Stroke.Color = Color.Green;
                    //        mBordert.Fill = new SolidBrush(Color.Empty);
                    //    }
                    //    else 
                    //    {
                    //        mBordert.Overlay.Clear();
                    //    }
                    //}

                    mBorders.ToolTipText = lbTheNameOfTheStop.Text;

                    objects.Markers.Add(m);
                    objects.Markers.Add(mBorders);
                    //objects.Markers.Add(mBordert);
                }
                MessageBox.Show("Завершено!");
            }
            catch
            {
                //специально сделано
            }
        }


        private void Overlays(Map mapen)
        {
            mapen.Overlays.Add(objects);        // добавление объектов на слои
            mapen.Overlays.Add(line);
        }

        #endregion
    }
}
