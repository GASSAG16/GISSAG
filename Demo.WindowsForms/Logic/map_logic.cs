using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Demo.WindowsForms.CustomMarkers;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Diagnostics;




namespace Demo.WindowsForms.Forms
{

    class map_logic
    {
    }
        class logicEventmap
        {
            // Слои 
            readonly GMapOverlay top = new GMapOverlay();
            internal readonly GMapOverlay objects = new GMapOverlay("objects");     // объекты
            internal readonly GMapOverlay routes = new GMapOverlay("routes");       // Дороги
            internal readonly GMapOverlay polygons = new GMapOverlay("polygons");   // Полигоны

            // Прочее
            readonly Random rnd = new Random();
            readonly DescendingComparer ComparerIpStatus = new DescendingComparer();
       
            public void OnMarker(Map mapen, GMapMarker item, MouseEventArgs e, GMapMarker currentTransport)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
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
                            mapen.Invalidate(false);
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
                }
            }
            public static void OnMarkerEnter(GMapMarker item)
            {
                if (item is GMapMarkerRect)
                {
                    GMapMarkerRect rc = item as GMapMarkerRect;
                    rc.Pen.Color = Color.Red;
                    rc.ToolTipMode = MarkerTooltipMode.Always;
                }
            }
            public static void OnMarkerLeave(GMapMarker item)
            {
                if (item is GMapMarkerRect)
                {
                    // CurentRectMarker = null;
                    GMapMarkerRect rc = item as GMapMarkerRect;
                    rc.Pen.Color = Color.Blue;
                    rc.ToolTipMode = MarkerTooltipMode.Never;
                }
            }
            public void MouseMove(MouseEventArgs e, GMapMarkerRect CurentRectMarker, Map mapen, GMarkerGoogle currentMarker, GMapPolygon polygon, bool isMouseDown)
            {
                if (e.Button == MouseButtons.Left && isMouseDown)//GMarkerGoogle currentMarker, GMapPolygon polygon, bool isMouseDown
                {
                    if (CurentRectMarker == null)
                    {
                        if (currentMarker.IsVisible)
                        {
                            currentMarker.Position = mapen.FromLocalToLatLng(e.X, e.Y);
                        }
                    }
                    else // move rect marker
                    {
                        PointLatLng pnew = mapen.FromLocalToLatLng(e.X, e.Y);

                        int? pIndex = (int?)CurentRectMarker.Tag;
                        if (pIndex.HasValue)
                        {
                            if (pIndex < polygon.Points.Count)
                            {
                                polygon.Points[pIndex.Value] = pnew;
                                mapen.UpdatePolygonLocalPosition(polygon);
                            }
                        }

                        if (currentMarker.IsVisible)
                        {
                            currentMarker.Position = pnew;
                        }
                        CurentRectMarker.Position = pnew;

                        if (CurentRectMarker.InnerMarker != null)
                        {
                            CurentRectMarker.InnerMarker.Position = pnew;
                        }
                    }

                    mapen.Refresh(); // force instant invalidation
                }
            }
            public void MouseDouble(MouseEventArgs e, Map mapen, GMapOverlay objects)
            {
                var cc = new GMapMarkerCircle(mapen.FromLocalToLatLng(e.X, e.Y));
                objects.Markers.Add(cc);
            }
            public void MouseDownMap(MouseEventArgs e, GMarkerGoogle currentMarker, Map mapen, bool isMouseDown)
            {
                if (e.Button == MouseButtons.Left && isMouseDown)
                {
                    // isMouseDown = true;

                    if (currentMarker.IsVisible)
                    {
                        currentMarker.Position = mapen.FromLocalToLatLng(e.X, e.Y);
                        var px = mapen.MapProvider.Projection.FromLatLngToPixel(currentMarker.Position.Lat, currentMarker.Position.Lng, (int)mapen.Zoom);
                        var tile = mapen.MapProvider.Projection.FromPixelToTileXY(px);

                        Debug.WriteLine("MouseDown: geo: " + currentMarker.Position + " | px: " + px + " | tile: " + tile);
                    }
                }
            }
            public void MouseUP(MouseEventArgs e, bool isMouseDown)
            {
                if (e.Button == MouseButtons.Left)
                {
                    isMouseDown = false;
                }
            }
        }
    }

