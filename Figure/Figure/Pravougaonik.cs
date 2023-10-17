using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    internal class Pravougaonik : _2DFigura
    {
        protected float sirina, duzina;
        public Pravougaonik(float x, float y, float sirina, float duzina):base(x, y)
        {
            this.sirina = sirina;
            this.duzina = duzina;
        }

        public override float povrsina()
        {
            return sirina * duzina;
        }
    }
}
