using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demmo_OOP_02
{
    internal struct Point
    {
        #region Attributes
        public int X;
        public int Y;
        #endregion

        #region Constructor
        #region Constructor Overloadng
        //Is A Special Function
        //1. Alwayes Names With Class | Struct Name
        //2. Has no Return Type
        public Point()//Default parameterless constructor not valid begore c#6
        {
            X = default;
            Y = default;
        }

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;

        }
        public Point(int num)
        {
            X = Y = num;
        }
        #endregion
        #endregion

        #region Methods
        //public override string ToString()
        //{
        //    return $"{X},{Y}";
        //}
        #endregion
    }
}
