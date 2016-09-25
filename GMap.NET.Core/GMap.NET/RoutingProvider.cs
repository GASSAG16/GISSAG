
namespace GMap.NET
{
   /// <summary>
   /// routing interface
   /// </summary>
   public interface RoutingProvider
   {
      /// <summary>
      /// get route between two points
      /// </summary>
      MapRoute GetRoute(PointLatLng start, PointLatLng end, bool avoidHighways, bool walkingMode, int Zoom);
     
       // Сводка:
      //     get route between two points
      //MapRoute GetRoute2(PointLatLng start, PointLatLng end, bool avoidHighways, bool walkingMode, int Zoom);
      ////
      //// Сводка:
      ////     get route between two points
      //MapRoute GetRoute2(string start, string end, bool avoidHighways, bool walkingMode, int Zoom);

      //MapRoute GetRoute2(PointLatLng start, PointLatLng end, bool avoidHighways,bool transit, int Zoom);
      /// <summary>
      /// get route between two points// добавление режима автобуса
      /// </summary>
       //MapRoute GetTransit(string start, string end, bool transit, int Zoom);
      /// <summary>
      /// get route between two points
      /// </summary>
      MapRoute GetRoute(string start, string end, bool avoidHighways, bool walkingMode, int Zoom);
   //   MapRoute GetRoute2(string start, string end, bool avoidHighways,bool transit, int Zoom);
      
   }
}
