using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    internal class Kvadar : _3DFigura
    {
        protected float sirina, duzina, visina;
        public Kvadar(float x, float y, float z, float sirina, float duzina, float visina) : base(x, y, z)
        {
            this.sirina = sirina;
            this.duzina = duzina;
            this.visina = visina;
        }

        public override float povrsina()
        {
            return 2 * ((sirina * duzina) + (sirina * visina) + (visina * duzina));
        }
        public override float zapremina()
        {
            return sirina * duzina * visina;
        }
    }
}
