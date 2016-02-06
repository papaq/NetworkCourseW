using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using NetsCo;

namespace NetworksCeW
{
    public static class AllStuffThatRocksCanvas
    {
        public static Unit GetUnitByIndex(int idx, List<Unit> listOfUnits)
        {
            return listOfUnits.Find(unit => unit.Index == idx);
        }

        public static double GetDistanceBetweenPoints(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        public static double GetDistanceToLine(Point dot, Line line)
        {
            var distance = Math.Abs((line.Y2 - line.Y1) * dot.X - (line.X2 - line.X1) * dot.Y
                                       + line.X2 * line.Y1 - line.Y2 * line.X1)
                              / Math.Sqrt(Math.Pow(line.Y2 - line.Y1, 2) + Math.Pow(line.X2 - line.X1, 2));
            return distance;
        }

        public static int FindCircleInside(Point position, List<Unit> listOfUnits, int grgr)
        {
            foreach (var unit in listOfUnits.Where(unit => GetDistanceBetweenPoints(unit.Position, position) < grgr * .5))
                return listOfUnits.IndexOf(unit);
            return -1;
        }

        public static int FindLineClose(Point pos, List<Line> collectionOfLines)
        {
            foreach (var line in collectionOfLines.Where(line => GetDistanceToLine(pos, line) < 20
                                                                 && Math.Abs(pos.X - line.X1)
                                                                 + Math.Abs(pos.X - line.X2) < Math.Abs(line.X1 - line.X2) + 1
                                                                 && Math.Abs(pos.Y - line.Y1)
                                                                 + Math.Abs(pos.Y - line.Y2) < Math.Abs(line.Y1 - line.Y2) + 1))
            {
                return collectionOfLines.IndexOf(line);
            }
            return -1;
        }

        public static bool CheckIfAdd(Point position, List<Unit> listOfUnits, int grgr, int myIndex)
        {
            return listOfUnits.All(unit => !(GetDistanceBetweenPoints(unit.Position, position) <= grgr + 5) || unit.Index == myIndex);
        }

        public static bool CheckIfAlone(Point position, int myIndex, List<Unit> listOfUnits, int grgr)
        {
            return listOfUnits.All(unit => !(GetDistanceBetweenPoints(unit.Position, position) <= grgr + 5) || unit.Index == myIndex);
        }

        public static bool CheckIfNotCloseToBorder(Point position, int myIndex, double canvaslWidth, double canvasHeigh, int grgr)
        {
            return !(2 > position.X - grgr * .5)
                && !(canvaslWidth < position.X + grgr * .5 + 2)
                && !(2 > position.Y - grgr * .5)
                && !(canvasHeigh < position.Y + grgr * .5 + 2);
        }

        public static int CountNetworkNumber(Point position, int numOfNetw, double canvasWdth, double canvasHth)
        {
            switch (numOfNetw)
            {
                case 2:
                    return position.X < canvasWdth*.5 ? 0 : 1;
                case 3:
                    if (position.Y > canvasHth*2/3)
                        return 2;
                    return position.X < canvasWdth * .5 ? 0 : 1;
                default:
                    return 0;
            }
        }
    }
}
