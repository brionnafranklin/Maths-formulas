using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths_formulas
{
    class Point
    {
        protected float _x = 0;
        protected float _y = 0;

        public Point()
        {

        }
        public Point(float x, float y)
        {
            _x = x;
            _y = y;
        }
        public float getX()
        {
            return _x;
        }
        public float getY()
        {
            return _y;
        }
    }
}
