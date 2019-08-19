using MyClassLibrary.CLasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class Task1_4_1
    {
        private static Point _upperLeft;
        private static Point _lowerRight;


        private static double Length()
        {
            return _upperLeft.Y - _lowerRight.Y;
        }

        private static double Width()
        {
            return _lowerRight.X - _upperLeft.X;
        }


        private static double Perimeter()
        {
            return Width() * 2 + Length() * 2;
        }


        private static double Square()
        {
            return Width() * Length();
        }

        


        
    }
}
