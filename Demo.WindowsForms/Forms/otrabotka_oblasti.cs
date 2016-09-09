
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
    public partial class otrabotka_oblasti : Form
    {
        Rectangle selRect;
        Point orig;
        Pen pen = new Pen(Brushes.Blue, 0.8f) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };

        
        //
       //layers
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
        //------------------------------------------------
        //
        SqlConnection con = new SqlConnection("server=gas-aleks\\sqlgassag;database=GISSIG;Integrated Security=True");

        public otrabotka_oblasti()
        {
            InitializeComponent();


            //-----------------------------------------------
            if (!GMapControl.IsDesignerHosted)
            {

                // set cache mode only if no internet avaible
                if (!Stuff.PingNetwork("pingtest.com"))
                {
                    mapen.Manager.Mode = AccessMode.ServerOnly;
                    MessageBox.Show("No internet connection available, going to CacheOnly mode.", "GMap.NET - Demo.WindowsForms", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // config map         
                mapen.MapProvider = GMapProviders.OpenStreetMap;
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
        //Rectangle GetSelRectangle(Point orig, Point location)
        //{
        //    int deltaX = location.X - orig.X, deltaY = location.Y - orig.Y;
        //    Size s = new Size(Math.Abs(deltaX), Math.Abs(deltaY));
        //    Rectangle rect = new Rectangle();
        //    if (deltaX >= 0 & deltaY >= 0)
        //        rect = new Rectangle(orig, s);
        //    if (deltaX < 0 & deltaY > 0)
        //        rect = new Rectangle(location.X, orig.Y, s.Width, s.Height);
        //    if (deltaX < 0 & deltaY < 0)
        //        rect = new Rectangle(location, s);
        //    if (deltaX > 0 & deltaY < 0)
        //        rect = new Rectangle(orig.X, location.Y, s.Width, s.Height);
        //    return rect;
        //}
        private void otrabotka_oblasti_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gISSIGData.SelectOstanovki". При необходимости она может быть перемещена или удалена.
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gISSIGData.SkalarVsegoZnach". При необходимости она может быть перемещена или удалена.
            this.skalarVsegoZnachTableAdapter.Fill(this.gISSIGData.SkalarVsegoZnach);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gISSIGData.ImportOstanovokExcel". При необходимости она может быть перемещена или удалена.
            this.importOstanovokExcelTableAdapter1.Fill(this.gISSIGData.ImportOstanovokExcel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gISSIGDataSet1.ImportOstanovokExcel". При необходимости она может быть перемещена или удалена.
           // this.importOstanovokExcelTableAdapter.Fill(this.gISSIGDataSet1.ImportOstanovokExcel);
           
            //button2.Enabled = false;
         
            //GeoCoderStatusCode status = mapen.SetPositionByKeywords("Москва Октябрьская улица");
            //SqlConnection con = new SqlConnection("server=gas-aleks\\sqlgassag;database=GISSIG;Integrated Security=True");
            //if (status != GeoCoderStatusCode.G_GEO_SUCCESS)
            //{
            //    // MessageBox.Show("Geocoder can't find: '" + textBoxGeo.Text + "', reason: " + status.ToString(), "GMap.NET", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        //     //---------------------------       
        //            

        //     private void checkBox1_CheckedState(object sender, EventArgs e)
        //{
        //    if (checkBox1.Checked)
        //    {
        //        //// mapen.MouseMove += new MouseEventHandler(mapen_MouseMove);
        //        //mapen.MouseDown += new MouseEventHandler(mapen_MouseDown);///+
        //        //mapen.MouseUp += new MouseEventHandler(mapen_MouseUp);//+
        //        //mapen.MouseClick += new MouseEventHandler(mapen_MouseClick);
        //    }
        //    else
        //    {
        //        //objects.Markers.Clear();
              
        //        //    //mapen.Enabled = false;
                
        //        //mapen.Update();
        //        //mapen.Hide();
        //        //mapen.Show();
        //        //mapen.Refresh();
        //        //mapen.Enabled = true;
        //    }
        //}
        //     void mapen_MouseUp(object sender, MouseEventArgs e)
        //{
        //   // //Возвращаем основную процедуру рисования
        //   //mapen.Paint -= Selection2_Paint;
        //   // //mapen.Paint += mapen_Paint;
        //   // mapen.Invalidate();
        //}
        //     void mapen_MouseClick(object sender, MouseEventArgs e)
        // {
                
        //        //selRect = GetSelRectangle(orig, e.Location);

        //  }

        //    void mapen_MouseDown(object sender, MouseEventArgs e)
        //    {
        //      //  //Назначаем процедуру рисования при выделении
        //      //  mapen.Paint += mapen_Paint;
        //      //  //mapen.Paint += Selection2_Paint;
        //      //orig = e.Location;
               
        //    }
        //    //Рисование мышкой с нажатой кнопкой
        //    void Selection2_Paint(object sender, PaintEventArgs e)
        //{
        //    //e.Graphics.DrawRectangle(pen, selRect);
        //   // MessageBox.Show("jk1");
        //}
        //    void mapen_Paint(object sender, PaintEventArgs e)
        //{
        //    //e.Graphics.DrawRectangle(Pens.Black, selRect);
        //   // e.Graphics.Clear();
                
        //}
        //    void mapen_MouseMove(object sender, MouseEventArgs e)
        //{
        //    //при движении мышкой считаем прямоугольник и обновляем GMapControl
        //  //  selRect = GetSelRectangle(orig, e.Location);
        //   // if (e.Button == System.Windows.Forms.MouseButtons.Left)
        //    // (sender as GMapControl).Refresh();
        //   // MessageBox.Show("jk2");
        //}

        
        
        //---------------------------------------------------------

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
            
           

            int f = Convert.ToInt32(label4.Text);
            
            //int f;++
            //label4.Text = skalarVsegoZnachBindingSource.Count.ToString();
            // f = skalarVsegoZnachBindingSource.Count;


            //string CountStr = label4.Text;
            //int d = Convert.ToInt32(skalarVsegoZnachBindingSource.Count);
          //  f = 10;++
            
            
            // label4.Text = importOstanovokExcelBindingSource.
           //     SkalarVsegoZnach;
            
                      // SqlDataReader myReader = null;
           //// myCommand.Execute(out myReader);
           
            
                        //   sqlConnection.Open();
     //       SqlDataReader rty = importOstanovokExcelBindingSource.MoveNext();
    //    SqlDataReader sqlReader =  sqlReader.Read();
        //    sqlCommand.ExecuteReader();

        //while (sqlReader.Read())
        //{
        //    nameTextBlock.Text = sqlReader.GetString(0);
        //}

        //sqlConnection.Close();
        //while (label4.Text() != null)
           // while (skalarVsegoZnachBindingSource.)

//            while ((d.ToString() != null))
//            {
//                MessageBox.Show("fgt2");
//            }
////            
            //while (f = 0)
            //{
            //    MessageBox.Show("fgt25");
            //}
            
            
            for (int v = 0; v <f;v++)
            {

             SqlConnection con = new SqlConnection("server=gas-aleks\\sqlgassag;database=GISSIG;Integrated Security=True");
           
           
            // SqlDataReader rety = importOstanovokExcelTableAdapter.Adapter.

            //SqlCommand cmd = new SqlCommand("select * from ImportOstanovokExcel",con);
            
          //  SqlCommand cmd = new SqlCommand("select KoordiX from ImportOstanovokExcel",con);++
           // con.Open();++
           // SqlDataReader reader = cmd.ExecuteReader();++
           // MessageBox.Show("reader");

            //SqlDataReader rty = importOstanovokExcelBindingSource.MoveNext();


            //BindingSource fg = new BindingSource();
            //fg.MoveNext();
            //importOstanovokExcelBindingSource = new BindingSource();
            ////importOstanovokExcelBindingSource.MoveNext();


                         //DataTable dt = (DataTable)dataGridView1.DataSource;

             //foreach (DataRow row in dt.Rows)
             //{
             //    MessageBox.Show("gh");
             //}
           
        //     System.Data.DataTableReader dr = new DataTableReader();
    
        //while (dr.Read())
        //{
        //    if (dr.HasRows)
        //    {
        //        for (int i = 0; i < dr.FieldCount; i++)
        //        {
             
                //for (int i = 0; i < reader.FieldCount; i++)
                //{

             //while (con) 
             //{
               importOstanovokExcelBindingSource.MoveNext();



             label1.Text = label1.Text.Replace(",", ".");
             label2.Text = label2.Text.Replace(",", ".");

             //StreamReader ReadFile = File.OpenText("stan.txt");
             //string Input = null;
             ////Читаем из файла информацию
             //while ((Input = ReadFile.ReadLine()) != null)
             //{

             //    label1.Text = Input.Remove(15);
             //    label2.Text = Input.Substring(16);

             ///---------------------------------------------------------------------------------
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
                 // mBorders.ToolTipMode = MarkerTooltipMode.Always;66
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

                 // mBorders.ToolTipText = label3.ToString();
                 // MessageBox.Show("tyu");
             }
             else
             {
                 // mBorders.ToolTipText = mapen.Position.ToString();
                 // mBorders.ToolTipText = label3.ToString();
                 //mapen.Position.ToString();
             }
             mBorders.ToolTipText = label3.Text;
             objects.Markers.Add(m);
             objects.Markers.Add(mBorders);

            //        // RegeneratePolygon();


                
            }
        
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //this.skalarPoiskPoRaionyTableAdapter.Fill(this.gISSIGData.SkalarPoiskPoRaiony, param1ToolStripTextBox.Text);



            //    //if (importOstanovokExcelBindingSource.Filter= "Raion='" & textBox2.Text & "'")
            //    //    //.Filter = "Raion='" & textBox2.Text & "'")
            //    //{
            //    //    label7.Text = textBox2.Text;
            //    //}
            //    ////{ Добавить фильтр! Фильтр Vb не работает

            //    ////}

            //    ////-------------------------------------
                
            //    int f = Convert.ToInt32(label4.Text);
            //    for (int v = 0; v < f; v++)
            //    {

            //        SqlConnection con = new SqlConnection("server=gas-aleks\\sqlgassag;database=GISSIG;Integrated Security=True");

            //        skalarPoiskPoRaionyBindingSource.MoveNext();

            //        //----------------------------------------------------
            //        label1.Text = label1.Text.Replace(",", ".");
            //        label2.Text = label2.Text.Replace(",", ".");

            //        double lat = double.Parse(label2.Text, CultureInfo.InvariantCulture);
            //        double lng = double.Parse(label1.Text, CultureInfo.InvariantCulture);

            //        mapen.Position = new PointLatLng(lat, lng);


            //        GMarkerGoogle m = new GMarkerGoogle(mapen.Position, GMarkerGoogleType.green_pushpin);
            //        GMapMarkerRect mBorders = new GMapMarkerRect(mapen.Position);
            //        GMapMarkerCircle mBordert = new GMapMarkerCircle(mapen.Position);
            //        {
            //            //mBorder.stroke = m;
            //            mBorders.InnerMarker = m;

            //            if (polygon != null)
            //            {
            //                // mBorders.Tag = polygon.Points.Count;
            //            }
            //            // mBorders.ToolTipMode = MarkerTooltipMode.Always;66
            //        }

            //        Placemark? p = null;
            //        if (checkBox1.Checked)
            //        {
            //            GeoCoderStatusCode status;
            //            var ret = GMapProviders.GoogleMap.GetPlacemark(mapen.Position, out status);
            //            if (status == GeoCoderStatusCode.G_GEO_SUCCESS && ret != null)
            //            {
            //                p = ret;
            //            }
            //        }

            //        //if (p != null)
            //        //{
            //        //    // mBorders.ToolTipText = p.Value.Address;

            //        //    // mBorders.ToolTipText = label3.ToString();
            //        //    // MessageBox.Show("tyu");
            //        //}
            //        //else
            //        //{
            //        //    // mBorders.ToolTipText = mapen.Position.ToString();
            //        //    // mBorders.ToolTipText = label3.ToString();
            //        //    //mapen.Position.ToString();
            //        //}
            //        mBorders.ToolTipText = label3.Text;
            //        objects.Markers.Add(m);
            //        objects.Markers.Add(mBorders);

            //        // RegeneratePolygon();



            //    }

            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //this.skalarPoiskPoRaionyBindingSource1
        //    //this.skalarPoiskPoRaiony1TableAdapter1.Fill(this.gISSIGData.SkalarPoiskPoRaiony1,comboBox1.Text);
        //}

        //private void comboBox1_Enter(object sender, EventArgs e)
        //{
        //  //  this.skalarPoiskPoRaiony1TableAdapter1.Fill(this.gISSIGData.SkalarPoiskPoRaiony1, comboBox1.Text);
        //}

        //private void fillToolStripButton1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.skalarPoiskPoRaiony1TableAdapter1.Fill(this.gISSIGData.SkalarPoiskPoRaiony1, raionToolStripTextBox.Text);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        //---------------------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.skalarPoiskPoRaiony1TableAdapter1.Fill(this.gISSIGData.SkalarPoiskPoRaiony1, textBox3.Text);
             
                int f = Convert.ToInt32(label8.Text);
                for (int v = 0; v < f; v++)
                {

                    SqlConnection con = new SqlConnection("server=gas-aleks\\sqlgassag;database=GISSIG;Integrated Security=True");

                   
                    skalarPoiskPoRaiony1BindingSource.MoveNext();

                    //----------------------------------------------------
                    label10.Text = label10.Text.Replace(",", ".");
                    label9.Text = label9.Text.Replace(",", ".");

                    double lat = double.Parse(label9.Text, CultureInfo.InvariantCulture);
                    double lng = double.Parse(label10.Text, CultureInfo.InvariantCulture);

                    //mapen.Position = new PointLatLng(lat, lng);


                    //GMarkerGoogle m = new GMarkerGoogle(mapen.Position, GMarkerGoogleType.green_pushpin);
                    //GMapMarkerRect mBorders = new GMapMarkerRect(mapen.Position);
                    //GMapMarkerCircle mBordert = new GMapMarkerCircle(mapen.Position);
                    //{
                    //    //mBorder.stroke = m;
                    //    mBorders.InnerMarker = m;

                    //    if (polygon != null)
                    //    {
                    //        // mBorders.Tag = polygon.Points.Count;
                    //    }
                    //    // mBorders.ToolTipMode = MarkerTooltipMode.Always;66
                    //}

                    //Placemark? p = null;
                    //if (checkBox1.Checked)
                    //{
                    //    GeoCoderStatusCode status;
                    //    var ret = GMapProviders.GoogleMap.GetPlacemark(mapen.Position, out status);
                    //    if (status == GeoCoderStatusCode.G_GEO_SUCCESS && ret != null)
                    //    {
                    //        p = ret;
                    //    }
                    //}

                    //if (p != null)
                    //{
                    //    // mBorders.ToolTipText = p.Value.Address;

                    //    // mBorders.ToolTipText = label3.ToString();
                    //    // MessageBox.Show("tyu");
                    //}
                    //else
                    //{
                    //    // mBorders.ToolTipText = mapen.Position.ToString();
                    //    // mBorders.ToolTipText = label3.ToString();
                    //    //mapen.Position.ToString();
                    //}
                    //mBorders.ToolTipText = label11.Text;
                    //objects.Markers.Add(m);
                    //objects.Markers.Add(mBorders);

                    //// RegeneratePolygon();



                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            this.skalarVsegoZnachPoRaionTableAdapter.Fill(this.gISSIGData.SkalarVsegoZnachPoRaion, textBox3.Text);
            button2.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    this.scalarVsegoZnachPoUlchamTableAdapter.Fill(this.gISSIGData.ScalarVsegoZnachPoUlcham, comboBox2.Text);
            //    this.scalarPoiskPoUlichamTableAdapter.Fill(this.gISSIGData.ScalarPoiskPoUlicham, comboBox2.Text);
                
             
            //    int f = Convert.ToInt32(label15.Text);
            //    for (int v = 0; v < f; v++)
            //    {

            //        SqlConnection con = new SqlConnection("server=gas-aleks\\sqlgassag;database=GISSIG;Integrated Security=True");

                                     
            //        scalarPoiskPoUlichambindingSource.MoveNext();

            //        //----------------------------------------------------
            //        label14.Text = label14.Text.Replace(",", ".");
            //        label13.Text = label13.Text.Replace(",", ".");

            //        double lat = double.Parse(label13.Text, CultureInfo.InvariantCulture);
            //        double lng = double.Parse(label14.Text, CultureInfo.InvariantCulture);

            //        mapen.Position = new PointLatLng(lat, lng);


            //        GMarkerGoogle m = new GMarkerGoogle(mapen.Position, GMarkerGoogleType.green_pushpin);
            //        GMapMarkerRect mBorders = new GMapMarkerRect(mapen.Position);
            //        GMapMarkerCircle mBordert = new GMapMarkerCircle(mapen.Position);
            //        {
            //            //mBorder.stroke = m;
            //            mBorders.InnerMarker = m;

            //            if (polygon != null)
            //            {
            //                // mBorders.Tag = polygon.Points.Count;
            //            }
            //        }

            //        mBorders.ToolTipText = label12.Text;
            //        objects.Markers.Add(m);
            //        objects.Markers.Add(mBorders);

            //     }
            //    scalarPoiskPoUlichambindingSource.MoveFirst();
            //    for (int v = 0; v < 1; v++)
            //    {

            //        SqlConnection con = new SqlConnection("server=gas-aleks\\sqlgassag;database=GISSIG;Integrated Security=True");


            //        //----------------------------------------------------
            //        label14.Text = label14.Text.Replace(",", ".");
            //        label13.Text = label13.Text.Replace(",", ".");

            //        double lat = double.Parse(label13.Text, CultureInfo.InvariantCulture);
            //        double lng = double.Parse(label14.Text, CultureInfo.InvariantCulture);

            //        mapen.Position = new PointLatLng(lat, lng);


            //        GMarkerGoogle m = new GMarkerGoogle(mapen.Position, GMarkerGoogleType.green_pushpin);
            //        GMapMarkerRect mBorders = new GMapMarkerRect(mapen.Position);
            //        GMapMarkerCircle mBordert = new GMapMarkerCircle(mapen.Position);
            //        {
            //            //mBorder.stroke = m;
            //            mBorders.InnerMarker = m;

            //            if (polygon != null)
            //            {
            //                // mBorders.Tag = polygon.Points.Count;
            //            }
            //        }
            //        mBorders.ToolTipText = label12.Text;
            //        objects.Markers.Add(m);
            //        objects.Markers.Add(mBorders);
            //    }
            //}

            // catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //label1.DataBindings.Add(new Binding("Text", scalarPoiskPoUlichambindingSource, "<Имя поля, привязанного к label>"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
             StreamReader ReadFile = File.OpenText("line.txt");
            string Input = null;
            //Читаем из файла информацию
  

            while ((Input = ReadFile.ReadLine()) != null)
            {

                label1.Text = Input.Remove(15);
                label2.Text = Input.Substring(16);


                double lat = double.Parse(label2.Text, CultureInfo.InvariantCulture);
                double lng = double.Parse(label1.Text, CultureInfo.InvariantCulture);

                //mapen.Position = new PointLatLng(lat, lng);
                            
                
                //Graphics gh = this.CreateGraphics();
                //int f2 = (int)lat;
                //int f3 = (int)lng;                              работает, но не отображает линию.
                //Pen blackPen = new Pen(Color.DarkRed, 3000);
                //gh.DrawLine(blackPen, f2, f3, f2, f3);

                    //Dim polygonPoints1 As List(Of PointLatLng) = New List(Of PointLatLng)
                    //polygonPoints1.Add(New PointLatLng(startLat, startLong ))
                    //polygonPoints1.Add(New PointLatLng(endLat, endLong))

                    //r = New GMap.NET.WindowsForms.GMapRoute(polygonPoints1, "MyRoute")

                    //r.Stroke.DashStyle = Drawing2D.DashStyle.Dash
                    //Dim routesOverlay As GMapOverlay = New GMapOverlay("routes")
                    //routesOverlay.Routes.Add(r)
                    //Me.myMap.Overlays.Add(routesOverlay)

              //  GMarkerGoogle m = new GMarkerGoogle(mapen.Position, GMarkerGoogleType.green_pushpin);
              //  GMapMarkerRect mBorders = new GMapMarkerRect(mapen.Position);
              //  GMapMarkerCircle mBordert = new GMapMarkerCircle(mapen.Position);
              //  {
              //      //mBorder.stroke = m;
              //      mBorders.InnerMarker = m;

              //      if (polygon != null)
              //      {
              //          mBorders.Tag = polygon.Points.Count;
              //      }
              //      // mBorders.ToolTipMode = MarkerTooltipMode.Always;
              //  }

              //  Placemark? p = null;
              //  if (checkBox1.Checked)
              //  {
              //      GeoCoderStatusCode status;
              //      var ret = GMapProviders.GoogleMap.GetPlacemark(mapen.Position, out status);
              //      if (status == GeoCoderStatusCode.G_GEO_SUCCESS && ret != null)
              //      {
              //          p = ret;
              //      }
              //  }

              //  if (p != null)
              //  {
              //      // mBorders.ToolTipText = p.Value.Address;
              //  }
              //  else
              //  {
              //      // mBorders.ToolTipText = mapen.Position.ToString();
              //  }

              //  objects.Markers.Add(m);
              //  objects.Markers.Add(mBorders);
               
              //RegeneratePolygon();

              }
        }

         void RegeneratePolygon()
         {
             List<PointLatLng> polygonPoints = new List<PointLatLng>();

             foreach (GMapMarker m in objects.Markers)
             {
                 if (m is GMapMarkerRect)
                 {
                     m.Tag = polygonPoints.Count;

                 }
             }

             if (polygon == null)
             {
                 polygon = new GMapPolygon(polygonPoints, "polygon test");

                 polygon.IsHitTestVisible = false;
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
                     //mapen.UpdatePolygonLocalPosition(polygon);
                 }
             }


         }


    }
}
