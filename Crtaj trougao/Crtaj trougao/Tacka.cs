using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crtaj_trougao
{
    internal class Tacka<T>
    {
        private T x;
        private T y;
        public T X { get { return x; } set {  x = value; } }
        public T Y { get { return y; } set { y = value; } }
        public Tacka() { }
        public Tacka(T x, T y)
        {
            X = x;
            Y = y;
        }
        public string ispis()
        {
            return "(" + X.ToString() + ", " + Y.ToString() + ")";
        }
    }
}
