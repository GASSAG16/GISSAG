using System;
using System.Windows.Forms;
using WindowsForms.GISSIGDataTableAdapters;

namespace WindowsForms.Logic
{
    class ImportSQL
    {
        public GISSIGData GISSIG =new GISSIGData();
        InsertRouteNamberTransportModeTableAdapter InsertRouteNamberTransportMode = new InsertRouteNamberTransportModeTableAdapter();
        InsertRouteTableAdapter InsertRoute = new InsertRouteTableAdapter();
        InsertDirectionOfRouteTableAdapter InsertDirection = new InsertDirectionOfRouteTableAdapter();
        InsertPassagenerStopTableAdapter InsertPassagenerStop = new InsertPassagenerStopTableAdapter();
        
        double CoordinateX, CoordinateY;

        public void ImportMarshSQL(Label lbRouteNamber_, Label lbTransportMode_)
           {
               string strRouteNamber = lbRouteNamber_.Text;
               string strTransportMode = lbTransportMode_.Text;
               
               try
               {
                   InsertRouteNamberTransportMode.Fill(GISSIG.InsertRouteNamberTransportMode, strRouteNamber, strTransportMode);
               }
               catch 
               {
                   // Без обработки, дублирующие данные не проходят, процесс продолжается.                   
               }
           }

        public void ImportRouteSQL( Label lbDirectionOfRoute_, Label lbCoordinate_X_ ,Label lbCoordinate_Y_)  
        {  
               string lbDirectionOfRoute = lbDirectionOfRoute_.Text;

               CoordinateX = Convert.ToDouble(lbCoordinate_X_.Text);
               CoordinateY = Convert.ToDouble(lbCoordinate_Y_.Text);

               try
               {
                    InsertRoute.Fill(GISSIG.InsertRoute, lbDirectionOfRoute, CoordinateX, CoordinateY);
               }
               catch
               {
                    // Без обработки, дублирующие данные не проходят, процесс продолжается.                   
               }
        }

        public void ImportDirectionSQL(Label lbRouteNamber_, Label lbDirectionOfRoute_)
        {
            string strRouteNamber = lbRouteNamber_.Text;
            string strDirectionOfRoute = lbDirectionOfRoute_.Text;

            try
            {
                InsertDirection.Fill(GISSIG.InsertDirectionOfRoute, strDirectionOfRoute, strRouteNamber);    
            }
            catch
            {
                // Без обработки, дублирующие данные не проходят, процесс продолжается.                   
            }
        }

        public void PassagenerStop(Label lbCoordinate_Y_, Label lbCoordinate_X_,Label lbStreet, Label lbAdministrativeDistrict,
            Label lbDistrict, Label lbTheNameOfTheStop, Label lbDirection, Label lbRouteNamber_stan)
        {

            string strStreet = lbStreet.Text;
            string strAdministrativeDistrict = lbAdministrativeDistrict.Text;
            string strDistrict = lbDistrict.Text;
            string strTheNameOfTheStop = lbTheNameOfTheStop.Text;
            string strDirection = lbDirection.Text;
            string strRouteNamber = lbRouteNamber_stan.Text;

            CoordinateX = Convert.ToDouble(lbCoordinate_Y_.Text);
            CoordinateY = Convert.ToDouble(lbCoordinate_X_.Text);
            
            try
            {
                InsertPassagenerStop.Fill(GISSIG.InsertPassagenerStop, CoordinateY, CoordinateX, strStreet, strAdministrativeDistrict, 
                                                                        strDistrict, strTheNameOfTheStop, strDirection, strRouteNamber);
            }
            catch
            {
                // Без обработки, дублирующие данные не проходят, процесс продолжается.                   
            }
        }
    }
}

