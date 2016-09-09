using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Demo.WindowsForms.Forms
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        double Xcoordy = 25.4, Ycoordy = 32.4;
        



        private ContextMenu markerMenu = new ContextMenu();
        private MenuItem command1 = null;
        private MenuItem command2 = null;
        private MenuItem command3 = null;
        private MenuItem command4 = null;

        private void Method1(object sender, EventArgs e)
        {
          MenuItem item = sender as MenuItem;
          // access item.Tag to get the marker Tag info 
        }
        private void Method2(object sender, EventArgs e)
        {
            

            //insertCoordiTableAdapter.Fill(dataProbaDataSet.InsertCoordi, Xcoordy, Ycoordy);
           // insertretTableAdapter.Fill(dataProbaDataSet.Insertret, Xcoordy, Ycoordy);
           // insertCoordiTableAdapter.Fill(dataProbaDataSet.InsertCoordi, Xcoordy, Ycoordy);
            MessageBox.Show("g");
            
            //insertProbTableAdapter.Fill(this.probvstavkaDataSet.InsertProb,
                //new System.Nullable<int>(((int)(System.Convert.ChangeType(prov,
                //    typeof(int))))), new System.Nullable<double>(((double)(System.Convert.ChangeType(Xcoordy,
                //        typeof(double))))), new System.Nullable<double>(((double)
                //(System.Convert.ChangeType(Ycoordy, typeof(double))))));

           // this.Validate();
           //this.insertCoordiBindingSource.EndEdit();
           
          



        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataProbaDataSet.CoordiProb". При необходимости она может быть перемещена или удалена.
           // this.coordiProbTableAdapter.Fill(this.dataProbaDataSet.CoordiProb);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "probvstavkaDataSet.Table". При необходимости она может быть перемещена или удалена.
           // this.tableTableAdapter.Fill(this.probvstavkaDataSet.Table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "probvstavkaDataSet.SelectQuery54". При необходимости она может быть перемещена или удалена.
          //  this.selectQuery54TableAdapter.Fill(this.probvstavkaDataSet.SelectQuery54);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "probvstavkaDataSet.Table". При необходимости она может быть перемещена или удалена.
        
          // initialize the commands
          command1 = new MenuItem("Your command name 1", new EventHandler(Method1));
          command2 = new MenuItem("Your command name 21", new EventHandler(Method2));
          command3 = new MenuItem("Your command name 1", new EventHandler(Method1));
          command4 = new MenuItem("Your command name 211", new EventHandler(Method2));

          markerMenu.MenuItems.Add(command1);
          markerMenu.MenuItems.Add(command2);
          markerMenu.MenuItems.Add(command3);
          markerMenu.MenuItems.Add(command4);

          // Initialize map:
          map1.MapProvider = YandexMapProvider.Instance;
          GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
          map1.SetPositionByKeywords("Maputo, Mozambique");

          GMapOverlay markersOverlay = new GMapOverlay("markers");
          GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(Xcoordy, Ycoordy),GMarkerGoogleType.green);
          // retain some data with this marker
          marker.Tag = "I am a stock marker";

          markersOverlay.Markers.Add(marker);
          map1.Overlays.Add(markersOverlay);

          map1.OnMarkerClick += new MarkerClick(gMap_OnMarkerClick);
        }

        private void gMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {           
           object identityData = item.Tag;

           // load the menus with marker data.
           command1.Tag = identityData;
           command2.Tag = identityData;
           command3.Tag = identityData;
           command4.Tag = identityData;

           if (identityData != null && e.Button == MouseButtons.Right)
           {
              markerMenu.Show(map1, e.Location);
            }
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
  

        }

        private void map1_Click(object sender, EventArgs e)
        {
           
                    
                
        }

        private void map1_MouseClick(object sender, MouseEventArgs e)
        {
            
                    markerMenu.Show(map1, e.Location);
                
        }
    
      
    }
}
