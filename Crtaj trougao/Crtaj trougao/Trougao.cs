using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crtaj_trougao
{
    internal class Trougao<T>
    {
        private Tacka<T> a;
        private Tacka<T> b;
        private Tacka<T> c;
        public Tacka<T> A { get { return a; } set { a = value; } }
        public Tacka<T> B { get { return b; } set { b = value; } }
        public Tacka<T> C { get { return c; } set { c = value; } }
        public Trougao() { }
        public Trougao(Tacka<T> A, Tacka<T> B, Tacka<T> C)
        {
            a = A;
            b = B;
            c = C;
        }

        public double stranica(Tacka<T> A, Tacka<T> B)
        {
            dynamic x1 = A.X;
            dynamic y1 = A.Y;
            dynamic x2 = A.X;
            dynamic y2 = A.Y;
            return Math.Sqrt(Math.Pow(Math.Abs(x2 - x1), 2) + (Math.Pow(Math.Abs(y2 - y1), 2)));
        }
        public double povrsina()
        {
            dynamic a = stranica(A, B);
            dynamic b = stranica(B, C);
            dynamic c = stranica(A, C);
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        public void crtaj(Graphics g, PictureBox p)
        {
            float w = (float)p.Width;
            float h = (float)p.Height;
            dynamic x1 = A.X;
            dynamic y1 = A.Y;
            dynamic x2 = B.X;
            dynamic y2 = B.Y;
            dynamic x3 = C.X;
            dynamic y3 = C.Y;
            Pen crvenaOlovka = new Pen(Color.Red, 2);
            g.DrawLine(crvenaOlovka, w / 2, 0, w / 2, h);
            g.DrawLine(crvenaOlovka, 0, h / 2, w, h / 2);
            Pen olovka = new Pen(Color.Black, 2);
            g.DrawLine(olovka, (float)x1 + w / 2, h / 2 - (float)y1, (float)x2 + w / 2, h / 2- (float)y2);
            g.DrawLine(olovka, (float)x2 + w / 2, h / 2 - (float)y2, (float)x3 + w / 2, h / 2 - (float)y3);
            g.DrawLine(olovka, (float)x3 + w / 2, h / 2 - (float)y3, (float)x1 + w / 2, h / 2 - (float)y1);
        }
    }
}
