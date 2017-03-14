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

namespace WindowsForms.Logic
{
    class logicShow : logicEventmap
    {
        readonly GMapOverlay top = new GMapOverlay();
        
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

        #region Route

        //public void TheRoutesOfUrbanPassengerTransport(BindingSource requestTracksRoutesBindingSource, Map mapen, Label lbKoordiX, Label lbKoordiY, Label lbCount)
        //{
        //    Overlays(mapen);
        //    try
        //    {
        //        List<PointLatLng> spisok = new List<PointLatLng>();                 // Формируем в цикле список координат
        //        {
        //            int f = Convert.ToInt32(lbCount.Text);
        //            for (int v = -1; v < f; v++)//
        //            {
        //                requestTracksRoutesBindingSource.MoveNext();

        //                lbKoordiX.Text = lbKoordiX.Text.Replace(",", ".");
        //                lbKoordiY.Text = lbKoordiY.Text.Replace(",", ".");

        //                double lat = double.Parse(lbKoordiY.Text, CultureInfo.InvariantCulture);
        //                double lng = double.Parse(lbKoordiX.Text, CultureInfo.InvariantCulture);

        //                spisok.Add(new PointLatLng(lat, lng));
        //            }
        //        }           
        //        GMapRoute L = new GMapRoute(spisok, "линия");
        //        L.Stroke.Width = 5;
        //        L.Stroke.Color = Color.Red;                                     // Настройка линии
        //        line.Routes.Add(L);
        //        mapen.ZoomAndCenterRoute(L);
        //        mapen.Zoom = 15;
        //    }
        //    catch 
        //    {
        //        //специально сделано
        //    }
        //}

        //public void TheRoutesOfUrbanPassengerStop(BindingSource requestPassangerStopBindingSource, Map mapen, 
        //    Label lbKoordiXPassanger, Label lbKoordiYPassanger, Label lbCountPassanger, Label lbTheNameOfTheStop)
        //{
        //    Overlays(mapen);//Passanger
        //    try
        //    {
        //        int f = Convert.ToInt32(lbCountPassanger.Text);
        //        for (int v = -1; v < f; v++)//
        //        {
        //            requestPassangerStopBindingSource.MoveNext();

        //            lbKoordiXPassanger.Text = lbKoordiXPassanger.Text.Replace(",", ".");
        //            lbKoordiYPassanger.Text = lbKoordiYPassanger.Text.Replace(",", ".");

        //            double lat = double.Parse(lbKoordiYPassanger.Text, CultureInfo.InvariantCulture);
        //            double lng = double.Parse(lbKoordiXPassanger.Text, CultureInfo.InvariantCulture);


        //            mapen.Position = new PointLatLng(lat, lng);                                           //Формирование координат

        //            GMarkerGoogle m = new GMarkerGoogle(mapen.Position, GMarkerGoogleType.green_pushpin); // Установка в точке значка
        //            GMapMarkerRect mBorders = new GMapMarkerRect(mapen.Position);                         // Установка ограничителя - квадрат
        //            GMapMarkerCircle mBordert = new GMapMarkerCircle(mapen.Position);                      // Установка ограничителя - окружность

        //            {
        //                mBorders.InnerMarker = m;
        //            }

        //            //if (checkBox2.Checked)
        //            //{
        //            //    mBorders.ToolTipText = mapens.Position.ToString();
        //            //}

        //            mBorders.ToolTipText = lbTheNameOfTheStop.Text;
        //            objects.Markers.Add(m);
        //            objects.Markers.Add(mBorders);
        //        }
        //        MessageBox.Show("Завершено!");
        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}


        //Переделать TheRoutesOfUrbanPassengerTransport
        public void TheRoutesOfUrbanPassengerTransport(BindingSource requestTracksRoutesBindingSource, Map mapen, Label lbKoordiX, Label lbKoordiY, Label lbCount,
            BindingSource x, Label lbKoordiXPassanger, Label lbKoordiYPassanger, Label lbCountPassanger, Label lbTheNameOfTheStop, CheckBox cbAreaPassanger, BindingSource x2)
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

                    GMapRoute L = new GMapRoute(spisok, "линия");
                    L.Stroke.Width = 5;
                    L.Stroke.Color = Color.Red;                                     // Настройка линии
                    line.Routes.Add(L);
                    mapen.ZoomAndCenterRoute(L);
                    mapen.Zoom = 15;
                }

                clearData(lbKoordiXPassanger, lbKoordiYPassanger, lbCountPassanger, lbTheNameOfTheStop);
                addDataDistrictsCountiesStreetAndCity(lbKoordiXPassanger, lbKoordiYPassanger, lbCountPassanger, lbTheNameOfTheStop, x, x2);
                logicBuilding(x, mapen, lbKoordiXPassanger, lbKoordiYPassanger, lbCountPassanger, lbTheNameOfTheStop);    
            }
            catch
            {
                //специально сделано
            }
        }

        #endregion
        
        #region Bus stops in districts, counties, and city
        
        /// <summary>
        ///  Один метод для 4 задач (Отображение остановок по районам/округам/улицам/городу
        /// </summary>
        /// <param name="x">Привязка основных данных по BindingSource</param>
        /// <param name="mapen">gmap.net</param>
        /// <param name="lbKoordiXPassanger">Координата X</param>
        /// <param name="lbKoordiYPassanger">Координата Y</param>
        /// <param name="lbCountPassanger">Число для счётчика, получаемого от сервера</param>
        /// <param name="lbTheNameOfTheStop">Название остановки</param>
        /// <param name="x2">Привязка кол-ва найденных остановок от сервера по BindingSource</param>
        public void DistrictsCountiesStreetAndCity(BindingSource x, Map mapen,
            Label lbKoordiXPassanger, Label lbKoordiYPassanger, Label lbCountPassanger, Label lbTheNameOfTheStop, BindingSource x2)
        {
            clearData(lbKoordiXPassanger, lbKoordiYPassanger, lbCountPassanger, lbTheNameOfTheStop);
            addDataDistrictsCountiesStreetAndCity(lbKoordiXPassanger, lbKoordiYPassanger, lbCountPassanger, lbTheNameOfTheStop, x, x2);
            logicBuilding(x, mapen, lbKoordiXPassanger, lbKoordiYPassanger, lbCountPassanger, lbTheNameOfTheStop);
        }

        private void clearData(Label lbKoordiXPassanger, Label lbKoordiYPassanger, Label lbCountPassanger, Label lbTheNameOfTheStop)
        {  
            lbKoordiYPassanger.DataBindings.Clear();
            lbKoordiXPassanger.DataBindings.Clear();
            lbCountPassanger.DataBindings.Clear();
            lbTheNameOfTheStop.DataBindings.Clear();
        }

        private void addDataDistrictsCountiesStreetAndCity(Label lbKoordiXPassanger, Label lbKoordiYPassanger, Label lbCountPassanger, Label lbTheNameOfTheStop,
           BindingSource x, BindingSource x2)
        {
            lbKoordiXPassanger.DataBindings.Add(new System.Windows.Forms.Binding("Text", x, "KoordiX", true));
            lbKoordiYPassanger.DataBindings.Add(new System.Windows.Forms.Binding("Text", x, "KoordiY", true));
            lbCountPassanger.DataBindings.Add(new System.Windows.Forms.Binding("Text", x2, "Count", true));
            lbTheNameOfTheStop.DataBindings.Add(new System.Windows.Forms.Binding("Text", x, "TheNameOfTheStop", true));
        }

        private void logicBuilding(BindingSource DistrictsCountiesAndCityBindingSource, Map mapen, Label lbKoordiXPassanger, Label lbKoordiYPassanger, Label lbCountPassanger, Label lbTheNameOfTheStop)
        {
            Overlays(mapen);

            try
            {
                int f = Convert.ToInt32(lbCountPassanger.Text);
                for (int v = -1; v < f; v++)
                {
                    DistrictsCountiesAndCityBindingSource.MoveNext();

                    lbKoordiXPassanger.Text = lbKoordiXPassanger.Text.Replace(",", ".");
                    lbKoordiYPassanger.Text = lbKoordiYPassanger.Text.Replace(",", ".");

                    double lat = double.Parse(lbKoordiYPassanger.Text, CultureInfo.InvariantCulture);
                    double lng = double.Parse(lbKoordiXPassanger.Text, CultureInfo.InvariantCulture);


                    mapen.Position = new PointLatLng(lat, lng);                                             //Формирование координат

                    GMarkerGoogle m = new GMarkerGoogle(mapen.Position, GMarkerGoogleType.green_pushpin);   // Установка в точке значка
                    GMapMarkerRect mBorders = new GMapMarkerRect(mapen.Position);                           // Установка ограничителя - квадрат
                    GMapMarkerCircle mBordert = new GMapMarkerCircle(mapen.Position);                       // Установка ограничителя - окружность
                    GMapMarkerCircle nrt = new GMapMarkerCircle(mapen.Position);
                    {
                        mBorders.InnerMarker = m;
                    }

                    mBorders.ToolTipText = lbTheNameOfTheStop.Text;
                    mBordert.Radius = 300;
                    mBordert.Fill = new SolidBrush(Color.Empty);
                    
                    //nrt.Radius = 2250;
                    //nrt.Fill = new SolidBrush(Color.Empty);
                    //nrt.Stroke.Color = Color.Blue;

                    //objects.Markers.Add(m);
                    objects.Markers.Add(mBorders);
                    objects.Markers.Add(mBordert);

                    //objects2.Markers.Add(nrt);
                }
                MessageBox.Show("Завершено!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void Overlays(Map mapen)
        {
            mapen.Overlays.Add(objects);        // добавление объектов на слои
            mapen.Overlays.Add(line);
            mapen.Overlays.Add(line2);
            mapen.Overlays.Add(objects2);
        }

        public void CleanLayer(Map mapen)
        {
            objects.Markers.Clear();
            objects.Clear();
            line.Clear();
            objects2.Clear();
        }
        #endregion
    }
}
