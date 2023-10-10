using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genericke_klase
{
    internal class Generici<T>
    {
        private T a;
        public Generici(T a)
        {
            this.a = a;
        }
        public Generici() { }
        public void prikaziVrednost(TextBox tb)
        {
            tb.Text = a.ToString();
        }
        public void prikaziTip(TextBox tb)
        {
            tb.Text = typeof(T).ToString();
        }

    }
}
