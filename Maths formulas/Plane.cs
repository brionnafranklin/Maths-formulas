using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths_formulas
{
    class Plane
    {
        protected float _a = 0;
        protected float _b = 0;
        protected float _c = 0;
        protected float _d = 0;

        public Plane(float a, float b, float c, float d)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
        }
        public float getA()
        {
            return _a;
        }
        public float getB()
        {
            return _b;
        }
        public float getC()
        {
            return _c;
        }
        public float getD()
        {
            return _d;
        }
    }
}
