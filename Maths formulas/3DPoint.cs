using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths_formulas
{
    class _3DPoint : Point
    {
        protected float _z = 0;

        public _3DPoint(float x, float y, float z)
        {
            _x = x;
            _y = y;
            _z = z;
        }
        public float getZ()
        {
            return _z;
        }
    }
}
