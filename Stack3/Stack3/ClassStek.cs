using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack3
{
    internal class ClassStek<T>
    {
        Stack<T> ucenici = new Stack<T>();

        public void dodaj(T x)
        {
            ucenici.Push(x);
        }
        public void ispisi(ListBox lb, ComboBox cb)
        {
            foreach(T ucenik in ucenici)
                lb.Items.Add(ucenik);
            foreach(T ucenik in ucenici)
                cb.Items.Add(ucenik);
        }
        public void ukloni()
        {
            ucenici.Pop();
        }
        public T naVrhu()
        {
            return ucenici.Peek();
        }
        public void kopirajNiz(ListBox lb)
        {
            T[] nizUcenici = ucenici.ToArray();
            foreach(T ucenik in nizUcenici)
                lb.Items.Add(ucenik);
        }
        public void brisiStek()
        {
            ucenici.Clear();
        }
        public bool nalaziSe(ComboBox cb)
        {
            if (ucenici.Contains((T)cb.SelectedItem))
                return true;
            else return false;
        }

    }
}
