﻿using System.Linq;
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
using System.Data.SqlClient;

namespace Demo.WindowsForms.Forms
{
    public partial class SamaProgramaServer : Form
    {
        // Слои 
        readonly GMapOverlay top = new GMapOverlay();
        internal readonly GMapOverlay objects = new GMapOverlay("objects");     // объекты
        internal readonly GMapOverlay routes = new GMapOverlay("routes");       // Дороги
        internal readonly GMapOverlay polygons = new GMapOverlay("polygons");   // Полигоны
        internal readonly GMapOverlay marshryt = new GMapOverlay("marshryt");   // Маршруты
        internal readonly GMapOverlay okruga = new GMapOverlay("okruga");       // Округа

        // Прочее
        readonly Random rnd = new Random();
        readonly DescendingComparer ComparerIpStatus = new DescendingComparer();
        ContextMenu markerMenu = new ContextMenu();
        //GMapMarkerRect CurentRectMarker = null;
        GMarkerGoogle currentMarker;
        bool isMouseDown = false;
        GMapMarker currentTransport;
        // Полигон
        //  GMapPolygon polygon;
        


        public SamaProgramaServer()
        {
            InitializeComponent();
            if (!GMapControl.IsDesignerHosted)
            {

                // конфигурация карты  
                {
                    mapens.MapProvider = GMapProviders.OpenCycleTransportMap;           // провайдер карты
                    mapens.Position = new PointLatLng(55.75393, 37.620795); // Координаты города по умолчанию
                    mapens.MinZoom = 0;
                    mapens.MaxZoom = 24;
                    mapens.Zoom = 9;      
                }

                // события карты
                {
                    mapens.OnMarkerEnter += new MarkerEnter(mapens_OnMarkerEnter);  // События мыши при нажатии
                    mapens.OnMarkerLeave += new MarkerLeave(mapens_OnMarkerLeave); //  События мыши при отпускании
                    mapens.MouseUp += new MouseEventHandler(mapens_MouseUp);
                    mapens.OnMarkerClick += new MarkerClick(mapens_OnMarkerClick);
                    

                    mapens.MouseDown += new MouseEventHandler(mapens_MouseDown);
                }
                {
                    mapens.Overlays.Add(routes);         // добавление дорог
                    mapens.Overlays.Add(polygons);       // добавление полигонов
                    mapens.Overlays.Add(objects);        // добавление объектов
                    mapens.Overlays.Add(top);            // добавление обрамления
                    mapens.Overlays.Add(marshryt);       // добавление маршрута
                    mapens.Overlays.Add(okruga);         // добавление округов
                }
                currentMarker = new GMarkerGoogle(mapens.Position, GMarkerGoogleType.arrow);
                currentMarker.IsHitTestVisible = false;
                top.Markers.Add(currentMarker);
            }
            MapMenu();
        }


        void mapens_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                if (e.Button == MouseButtons.Right)
                {
                    isMouseDown = false;
                    markerMenu.Show(mapens, e.Location);
                }
            }
        }
        void mapens_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;

                if (currentMarker.IsVisible)
                {
                    currentMarker.Position = mapens.FromLocalToLatLng(e.X, e.Y);
                    var px = mapens.MapProvider.Projection.FromLatLngToPixel(currentMarker.Position.Lat, currentMarker.Position.Lng, (int)mapens.Zoom);
                    var tile = mapens.MapProvider.Projection.FromPixelToTileXY(px);

                    // Debug.WriteLine("MouseDown: geo: " + currentMarker.Position + " | px: " + px + " | tile: " + tile);
                }
            }

        }
        
        void mapens_OnMarkerClick(GMapMarker item, MouseEventArgs e)
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
                    mapens.Invalidate(false);
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
       
        void mapens_OnMarkerLeave(GMapMarker item)
        {
            if (item is GMapMarkerRect)
            {
                //CurentRectMarker = null;
                GMapMarkerRect rc = item as GMapMarkerRect;
                rc.Pen.Color = Color.Blue;
                rc.ToolTipMode = MarkerTooltipMode.Never;
            }
        } 
        void mapens_OnMarkerEnter(GMapMarker item)
        {
            if (item is GMapMarkerRect)
            {
                GMapMarkerRect rc = item as GMapMarkerRect;
                rc.Pen.Color = Color.Red;
                rc.ToolTipMode = MarkerTooltipMode.Always;
            }
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
                var pos = GMapProviders.GoogleMap.GetPlacemark(mapens.Position, out status);
                GMapMarkerRect s = new GMapMarkerRect(mapens.Position);
                s.ToolTipText = mapens.Position.ToString();
                //s.ToolTipText = label2.Text;

                //this.insertKoordiTableAdapter.Fill(this.gISSIGData.InsertKoordi, currentMarker.Position.Lng, currentMarker.Position.Lat);
                MessageBox.Show("Внесено!");
                MessageBox.Show(s.ToolTipText);
              
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        } 
        
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.scalarVsegoZnachPoUlchamTableAdapter.Fill(this.gISSIGData.ScalarVsegoZnachPoUlcham, toolStripComboBox1.Text); // Запрос на сервер сколько значений
                this.scalarPoiskPoUlichamTableAdapter.Fill(this.gISSIGData.ScalarPoiskPoUlicham, toolStripComboBox1.Text);          //Отбор по конкретным улицам

                //-----------------------------------------
                int f = Convert.ToInt32(label1.Text);
                for (int v = 0; v < f; v++)
                {
                    scalarPoiskPoUlichambindingSource.MoveNext();
                    MexanizmOtobrageniya();
                }
                //--------------------------------------------
                scalarPoiskPoUlichambindingSource.MoveFirst(); // Переход к первой записи
                for (int v = 0; v < 1; v++)
                {
                    MexanizmOtobrageniya();
                }
                MessageBox.Show("Завершено!");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void MexanizmOtobrageniya()
        {
            label3.Text = label3.Text.Replace(",", ".");
            label4.Text = label4.Text.Replace(",", ".");                                        //Подготовка данных для сервера

            double lat = double.Parse(label4.Text, CultureInfo.InvariantCulture);
            double lng = double.Parse(label3.Text, CultureInfo.InvariantCulture);

            Mestopologenie(lat, lng);
        }

        private void Mestopologenie(double lat, double lng)
        {
            mapens.Position = new PointLatLng(lat, lng);                                           //Формирование координат

            GMarkerGoogle m = new GMarkerGoogle(mapens.Position, GMarkerGoogleType.green_pushpin); // Установка в точке значка
            GMapMarkerRect mBorders = new GMapMarkerRect(mapens.Position);                         // Установка ограничителя - квадрат
            GMapMarkerCircle mBordert = new GMapMarkerCircle(mapens.Position);                      // Установка ограничителя - окружность
      
            {
                mBorders.InnerMarker = m;
            }

            if (checkBox2.Checked)
            {
                mBorders.ToolTipText = mapens.Position.ToString();
            }
 
            mBorders.ToolTipText = label2.Text;  
            objects.Markers.Add(m);
            objects.Markers.Add(mBorders);
        }

        private void SamaProgramaServer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gISSIGData.MarsrutiPodrobno". При необходимости она может быть перемещена или удалена.
            this.marsrutiPodrobnoTableAdapter.Fill(this.gISSIGData.MarsrutiPodrobno);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gISSIGData.Marsh". При необходимости она может быть перемещена или удалена.
            this.marshTableAdapter.Fill(this.gISSIGData.Marsh);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "gISSIGData.SkalarVsegoZnach". При необходимости она может быть перемещена или удалена.
            this.skalarVsegoZnachTableAdapter.Fill(this.gISSIGData.SkalarVsegoZnach);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "gISSIGData.ImportOstanovokExcel". При необходимости она может быть перемещена или удалена.
            this.importOstanovokExcelTableAdapter1.Fill(this.gISSIGData.ImportOstanovokExcel);
            this.marshTableAdapter.Fill(this.gISSIGData.Marsh);

            panel2.Hide();
            marsrutiPodrobnoBindingNavigator.Hide();
            selectPoMarshBindingNavigator.Hide();

            toolstripComboBoxPriv();

            
           // this.selectOkrugTableAdapter.Fill(this.gISSIGData.SelectOkrug, param1ToolStripTextBox.Text);
        }

        private void toolstripComboBoxPriv()                    //привязка данных к toolStripComboBox
        {
 
            this.toolStripComboBox3.ComboBox.BindingContext = BindingContext;
            this.toolStripComboBox3.ComboBox.DisplayMember = "NMarshryt";
            this.toolStripComboBox3.ComboBox.ValueMember = "NMarshryt";
            this.toolStripComboBox3.ComboBox.DataSource = gISSIGData.Marsh;

            //this.toolStripComboBox2.ComboBox.BindingContext = BindingContext;
            //this.toolStripComboBox2.ComboBox.DisplayMember = "Raion";
            //this.toolStripComboBox2.ComboBox.ValueMember = "Raion";                           // не работает долным образом
            //this.toolStripComboBox2.ComboBox.DataSource = gISSIGData.SkalarPoiskPoRaiony1;         
         }

        private void PoVsemyGorodyToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            DataBinding_ochistka();

            //----------- Привязываем заново -> перенаправляем!

            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skalarVsegoZnachBindingSource, "VsegoZnach", true));
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importOstanovokExcelBindingSource, "KoordiY", true));
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importOstanovokExcelBindingSource, "KoordiX", true));
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importOstanovokExcelBindingSource, "NameOstanovki", true));
        }

        private void DataBinding_ochistka()                     // очищаем привязку
        {
            this.label3.DataBindings.Clear();
            this.label4.DataBindings.Clear();                                       
            this.label2.DataBindings.Clear();
            this.label1.DataBindings.Clear();
        }
           
        private void PoVsemyGorodyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int f = Convert.ToInt32(label1.Text);
                for (int v = 0; v < f; v++)
                {
                    importOstanovokExcelBindingSource.MoveNext();
                    MexanizmOtobrageniya();                  
                }
                    MessageBox.Show("Завершено!");
            }
            catch (System.Exception ex)
            {
                 System.Windows.Forms.MessageBox.Show(ex.Message);
            }    
        }

        private void PoUlichamToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            DataBinding_ochistka();

            //----------- Привязываем заново -> перенаправляем!

            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scalarVsegoZnachPoUlchamBindingSource, "Expr1", true));
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scalarPoiskPoUlichambindingSource, "KoordiY", true));
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scalarPoiskPoUlichambindingSource, "KoordiX", true));
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scalarPoiskPoUlichambindingSource, "NameOstanovki", true));
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void SamaProgramaServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ImportTrassMarshrut_Click(object sender, EventArgs e)
        {
            Form Import =new ImportTrassMarshrut();
            Import.ShowDialog();
        }

        private void KonkretMarsh_Click(object sender, EventArgs e)
        {
            try
            {
                this.selectPoMarshTableAdapter.Fill(this.gISSIGData.SelectPoMarsh, toolStripComboBox3.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
                GMapOverlay line = new GMapOverlay();
                mapens.Overlays.Add(line);
                List<PointLatLng> spisok = new List<PointLatLng>();
                 try
                 {
                    int f = Convert.ToInt32(label18.Text);
                    for (int v = -1; v < f; v++)
                    {
                    selectPoMarshBindingSource.MoveNext();
                    MarshKoordi(spisok);
                    }
                    MessageBox.Show("Завершено!");
                     }
                    catch (System.Exception ex)
                     {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                     }  
          
                GMapRoute L = new GMapRoute(spisok, "линия");
                L.Stroke.Width = 5;
                L.Stroke.Color = Color.Red;
                line.Routes.Add(L);
                mapens.ZoomAndCenterRoute(L);
                mapens.Zoom = 15;
        }

        private void MarshKoordi(List<PointLatLng> spisok)
        {
            label16.Text = label16.Text.Replace(",", ".");
            label17.Text = label17.Text.Replace(",", ".");                                        //Подготовка данных для сервера

            double lat = double.Parse(label17.Text, CultureInfo.InvariantCulture);
            double lng = double.Parse(label16.Text, CultureInfo.InvariantCulture);

            spisok.Add(new PointLatLng(lat, lng));
        }

        private void marsrutiPodrobnoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.selectMarshKonkretBindingSource.EndEdit();
            this.updateConkreetBindingSource.EndEdit();
            
            this.tableAdapterManager.UpdateAll(this.gISSIGData);
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {  
        }               //резерв

        private void toolStripComboBox2_DropDownClosed(object sender, EventArgs e)
        {   
        }      //резерв

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //skalarPoiskPoRaiony1BindingSource - KoordiX label5
            //skalarPoiskPoRaiony1BindingSource - KoordiY label6
            try
            {
                this.skalarVsegoZnachPoRaionTableAdapter.Fill(this.gISSIGData.SkalarVsegoZnachPoRaion, toolStripComboBox2.Text);
                this.skalarPoiskPoRaiony1TableAdapter1.Fill(this.gISSIGData.SkalarPoiskPoRaiony1, toolStripComboBox2.Text);

                int f = Convert.ToInt32(label8.Text);

                for (int v = 0; v < f; v++)
                {
                    skalarPoiskPoRaiony1BindingSource.MoveNext();
                    //----------------------------------------------------
                    label5.Text = label5.Text.Replace(",", ".");
                    label6.Text = label6.Text.Replace(",", ".");

                    double lat = double.Parse(label6.Text, CultureInfo.InvariantCulture);
                    double lng = double.Parse(label5.Text, CultureInfo.InvariantCulture);

                    mapens.Position = new PointLatLng(lat, lng);

                    GMarkerGoogle m = new GMarkerGoogle(mapens.Position, GMarkerGoogleType.green_pushpin);
                    GMapMarkerRect mBorders = new GMapMarkerRect(mapens.Position);
                    GMapMarkerCircle mBordert = new GMapMarkerCircle(mapens.Position);
                    {
                        mBorders.InnerMarker = m;
                    }

                    mBorders.ToolTipText = label7.Text;
                    objects.Markers.Add(m);
                    objects.Markers.Add(mBorders);
                }
                MessageBox.Show("Завершено!");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void RegimRedacktoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel2.Show();
            marsrutiPodrobnoBindingNavigator.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            marsrutiPodrobnoBindingNavigator.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int prym=1;
      
            try
            {
                this.selectMarshKonkretTableAdapter.Fill(this.gISSIGData.SelectMarshKonkret, prym.ToString(), toolStripComboBox3.Text);
            }
            catch (System.Exception ex)
            {
                 System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            GMapOverlay line = new GMapOverlay();
            mapens.Overlays.Add(line);
            List<PointLatLng> spisok = new List<PointLatLng>();

            try
            {
                int f = Convert.ToInt32(label18.Text);
                for (int v = 0; v < f; v++)
                {
                    selectMarshKonkretBindingSource.MoveNext();
                    MarshKoordi(spisok);
                }
                //------------------------------------------
                selectMarshKonkretBindingSource.MoveFirst();// Переход к первой записи
                for (int v = 0; v < 1; v++)
                {
                    MarshKoordi(spisok);
                }
                MessageBox.Show("Завершено!");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            GMapRoute L = new GMapRoute(spisok, "линия");
            L.Stroke.Width = 5;
            L.Stroke.Color = Color.Red;
            line.Routes.Add(L);
            mapens.ZoomAndCenterRoute(L);
            mapens.Zoom = 15;
        }

        private void AboitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ty = new AboutGASSAG();
            ty.ShowDialog();
        }

        private void toolStripComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStripComboBox3_Click(object sender, EventArgs e)
        {

        }
        }
    }

