using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary.CLasses
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }


        //public static double Distanse_Points(Point x1, Point y1)
        //{
        //    return Math.Sqrt((x1.X - y1.X) * (x1.X - y1.X) + (x1.Y - y1.Y) * (x1.Y - y1.Y));
        //}
    }
}
