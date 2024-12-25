using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6
{

    //public   class Employee0
    //   {

    //   }
    internal struct Point

    {
        #region Attributes

        public int X;
        public int Y;
        #endregion
        #region Constructor
        public Point(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }
        public Point(int Number)
        {
            {
                X = Y = Number;
            }
        }
        #endregion
        public override string ToString()
        {

            return $"({X},{Y})";
        }

    }
}