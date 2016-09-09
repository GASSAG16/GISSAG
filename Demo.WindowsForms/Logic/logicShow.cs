using Demo.WindowsForms.CustomMarkers;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo.WindowsForms.Logic
{
    class logicShow
    {
        internal readonly GMapOverlay objects = new GMapOverlay("objects");     // объекты
        readonly GMapOverlay top = new GMapOverlay();
        GMapOverlay line = new GMapOverlay();

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
  
        private void Overlays(Map mapen)
        {
            mapen.Overlays.Add(objects);        // добавление объектов на слои
            mapen.Overlays.Add(line);
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
    }
}
