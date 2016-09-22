using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsForms.GISSIGDataTableAdapters;

namespace WindowsForms.Logic.SQL
{
    #region Transport

    class RouteSQL : ImportSQL
    {
        RoutesMarshTableAdapter RoutesMarsh = new RoutesMarshTableAdapter();
        DirectionOfRouteTableAdapter DirectionOfRoute = new DirectionOfRouteTableAdapter();
        requestDirectionsTableAdapter requestDirections = new requestDirectionsTableAdapter();
        BindingContext Binding = new BindingContext();
        requestTracksRoutesTableAdapter requestTracks = new requestTracksRoutesTableAdapter();
        requestTracksCountTableAdapter requestCount = new requestTracksCountTableAdapter();
        requestPassangerStopTableAdapter requestPassangerStop = new requestPassangerStopTableAdapter();
        requestPassangerStopCountTableAdapter requestPassangerStopCount = new requestPassangerStopCountTableAdapter();
           
        #region SpecificRouteOfTransport

        private void marsh(ToolStripComboBox tbMarsh)                           //Реализация привязки маршрутов к ToolStripComboBox
        {
            tbMarsh.ComboBox.BindingContext = Binding;
            tbMarsh.ComboBox.DisplayMember = "RouteNamber";
            tbMarsh.ComboBox.ValueMember = "RouteNamber";
            tbMarsh.ComboBox.DataSource = GISSIG.RoutesMarsh;
        }

        public void dataAddMarsh(ToolStripComboBox tbMarsh)
        {
            RoutesMarsh.Fill(GISSIG.RoutesMarsh);
            marsh(tbMarsh);
        }

        private void theDirectionRoute(ToolStripComboBox tbTheDirectionRoute)   //------//------Направлений
        {
            tbTheDirectionRoute.ComboBox.BindingContext = Binding;
            tbTheDirectionRoute.ComboBox.DisplayMember = "DirectionOfRoute";
            tbTheDirectionRoute.ComboBox.ValueMember = "DirectionOfRoute";
            tbTheDirectionRoute.ComboBox.DataSource = GISSIG.requestDirections;
        }

        public void dataAddtheDirectionRoute(ToolStripComboBox tbTheDirectionRoute, ToolStripComboBox tbMarsh)
        {
            requestDirections.Fill(GISSIG.requestDirections, tbMarsh.Text);
            theDirectionRoute(tbTheDirectionRoute);
        }

        public void dataAddPassangerStop(ToolStripComboBox tbMarshPassanger)
        {
            requestPassangerStop.Fill(GISSIG.requestPassangerStop, tbMarshPassanger.Text);
            requestPassangerStopCount.Fill(GISSIG.requestPassangerStopCount, tbMarshPassanger.Text);
        }

        #endregion
    }

    //class BindingRouteTransport:addBindingRoute
    //{
    //    requestTracksRoutesTableAdapter requestTracks = new requestTracksRoutesTableAdapter();
    //    requestTracksCountTableAdapter requestCount = new requestTracksCountTableAdapter();
    //    //-
    //    //private void BindingSource(Label lbKoordiX, Label lbKoordiY)
    //    //{
    //    //    BindingSource requestTracksRoutesBindingSource = add(lbKoordiX, lbKoordiY);
    //    //    requestTracksRoutesBindingSource.DataMember = "requestTracksRoutes";                                         // Источник списка данных
    //    //    requestTracksRoutesBindingSource.DataSource = GISSIG;
    //    //}
    //    //private void BindingSource(Label lbCount)
    //    //{
    //    //    BindingSource requestTracksCountBindingSource = add(lbCount);
    //    //    requestTracksCountBindingSource.DataMember = "requestTracksCount";                                         // Источник списка данных
    //    //    requestTracksCountBindingSource.DataSource = GISSIG;
    //    //}

    //    //+
    //    public void requestTracksRouteAndCount(ToolStripComboBox tbTheDirectionRoute, Label lbCount)
    //    {
    //        try
    //        {

    //            //requestTracksRoutesTableAdapter.Fill(this.gISSIGData.requestTracksRoutes, tbTheDirectionRoute.Text);
    //            requestTracks.Fill(GISSIG.requestTracksRoutes, tbTheDirectionRoute.Text);
    //            requestCount.Fill(GISSIG.requestTracksCount, tbTheDirectionRoute.Text);
    //            //BindingSource(lbKoordiX, lbKoordiY);
    //            //BindingSource(lbCount);
    //            // MessageBox.Show(lbKoordiX.Text);                                 
    //            //lbKoordiX.DataBindings.Clear();
    //            //lbKoordiY.DataBindings.Clear();
    //            //lbCount.DataBindings.Clear();
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show(ex.Message);
    //        }
    //    }
    //}

    //class addBindingRoute:ImportSQL
    //{
    //    //public BindingSource add(Label lbKoordiX,Label lbKoordiY)
    //    //{
    //    //    BindingSource requestTracksRoutesBindingSource = new BindingSource();
    //    //    requestTracksRoutesBindingSource.DataMember = "requestTracksRoutes";           // Источник списка данных
    //    //    requestTracksRoutesBindingSource.DataSource = GISSIG;                              // Источник данных

    //    //    lbKoordiX.DataBindings.Add(new Binding("Text", requestTracksRoutesBindingSource, "KoordiX", true));
    //    //    lbKoordiY.DataBindings.Add(new Binding("Text", requestTracksRoutesBindingSource, "KoordiY", true));            
    //    //    return requestTracksRoutesBindingSource;
    //    //}
    //    //public BindingSource add(Label lbCount)
    //    //{
    //    //    BindingSource requestTracksCountBindingSource = new BindingSource();
    //    //    requestTracksCountBindingSource.DataMember = "requestTracksCount";           // Источник списка данных
    //    //    requestTracksCountBindingSource.DataSource = GISSIG;                              // Источник данных

    //    //    lbCount.DataBindings.Add(new Binding("Text", requestTracksCountBindingSource, "Count", true));
    //    //    return requestTracksCountBindingSource;
    //    //}
    //}

    #endregion
}
