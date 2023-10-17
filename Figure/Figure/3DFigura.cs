using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    internal abstract class _3DFigura : Figura
    {
        protected float x, y, z;
        public _3DFigura(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        abstract public override float povrsina();
        abstract public float zapremina();
    }
}
