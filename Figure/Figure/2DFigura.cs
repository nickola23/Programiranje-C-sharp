using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    internal abstract class _2DFigura : Figura
    {
        protected float x, y;
        public _2DFigura(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        abstract public override float povrsina();
    }
}
