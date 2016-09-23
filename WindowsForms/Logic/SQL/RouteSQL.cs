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
    #endregion
}
