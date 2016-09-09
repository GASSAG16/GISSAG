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
    public partial class SamaProgramServer : Form
    {
        // Слои 
        readonly GMapOverlay top = new GMapOverlay();
        internal readonly GMapOverlay objects = new GMapOverlay("objects");     // объекты
        internal readonly GMapOverlay routes = new GMapOverlay("routes");       // Дороги
        internal readonly GMapOverlay polygons = new GMapOverlay("polygons");   // Полигоны
        internal readonly GMapOverlay marshryt = new GMapOverlay("marshryt");   // Маршруты

        // Прочее
        readonly Random rnd = new Random();
        readonly DescendingComparer ComparerIpStatus = new DescendingComparer();
        GMapMarkerRect CurentRectMarker = null;

        // Полигон
        GMapPolygon polygon;
        
        public SamaProgramServer()
        {
            InitializeComponent();
            
           
            //if (!GMapControl.IsDesignerHosted)
            //{

            //    // конфигурация карты  
            //    {
            //        mapen.MapProvider = GMapProviders.YandexMap;       // провайдер карты
            //        mapen.MinZoom = 0;
            //        mapen.MaxZoom = 24;
            //        mapen.Zoom = 9;
            //    }

            //    // события карты
            //    {
            //        mapen.OnMarkerEnter += new MarkerEnter(mapen_OnMarkerEnter);  // События мыши при нажатии
            //        mapen.OnMarkerLeave += new MarkerLeave(mapen_OnMarkerLeave); //  События мыши при отпускании
            //    }
            //    {
            //        mapen.Overlays.Add(routes);         // добавление дорог
            //        mapen.Overlays.Add(polygons);       // добавление полигонов
            //        mapen.Overlays.Add(objects);        // добавление объектов
            //        mapen.Overlays.Add(top);            // добавление обрамления
            //        mapen.Overlays.Add(marshryt);       // добавление маршрута
            //    }
            //}



        }
    }
}
