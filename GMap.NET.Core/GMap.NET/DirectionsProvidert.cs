﻿
namespace GMap.NET
{
   using System.Collections.Generic;

   /// <summary>
   /// directions interface
   /// </summary>
   interface DirectionsProvidert 
   {
      DirectionsStatusCode GetDirections(out GDirections direction, PointLatLng start, PointLatLng end, bool transit, bool sensor, bool metric);

      DirectionsStatusCode GetDirections(out GDirections direction, string start, string end, bool transit,  bool sensor, bool metric);

      /// <summary>
      /// service may provide more than one route alternative in the response
      /// </summary>
      /// <param name="status"></param>
      /// <param name="start"></param>
      /// <param name="end"></param>
      /// <param name="avoidHighways"></param>
      /// <param name="avoidTolls"></param>
      /// <param name="walkingMode"></param>
      /// <param name="sensor"></param>
      /// <param name="metric"></param>
      /// <returns></returns>
      IEnumerable<GDirections> GetDirections(out DirectionsStatusCode status, string start, string end, bool transit, bool sensor, bool metric);

      /// <summary>
      /// service may provide more than one route alternative in the response
      /// </summary>
      /// <param name="status"></param>
      /// <param name="start"></param>
      /// <param name="end"></param>
      /// <param name="avoidHighways"></param>
      /// <param name="avoidTolls"></param>
      /// <param name="walkingMode"></param>
      /// <param name="sensor"></param>
      /// <param name="metric"></param>
      /// <returns></returns>
      IEnumerable<GDirections> GetDirections(out DirectionsStatusCode status, PointLatLng start, PointLatLng end, bool transit, bool sensor, bool metric);

      DirectionsStatusCode GetDirections(out GDirections direction, PointLatLng start, IEnumerable<PointLatLng> wayPoints, bool transit, bool sensor, bool metric);

      DirectionsStatusCode GetDirections(out GDirections direction, string start, IEnumerable<string> wayPoints, bool transit, bool sensor, bool metric);
   }
}
