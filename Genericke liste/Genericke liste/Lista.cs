using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genericke_liste
{
    internal class Lista<T>
    {

        List<T> ucenici = new List<T>();
        public void dodaj(T x) {
            ucenici.Add(x);
        }
        public void ispisi(ListBox lb, ComboBox cb)
        {
            foreach(T x in ucenici)
                lb.Items.Add(x);
            foreach (T x in ucenici)
                cb.Items.Add(x);
        }
        public void obrni()
        {
            ucenici.Reverse();
        }
        public void obrniIzbor(int index, int broj)
        {
            ucenici.Reverse(index, broj);
        }
        public void sortiraj()
        {
            ucenici.Sort();
        }
        public void ubaci(int index, T vrednsot)
        {
            ucenici.Insert(index, vrednsot);
        }
        public bool nalaziSe(ComboBox cb)
        {
            if (ucenici.Contains((T)cb.SelectedItem))
                return true;
            else return false;
        }
        public void kopirajUNiz(ListBox lb)
        {
            T[] nizUcenika = ucenici.ToArray();
            foreach (T n in nizUcenika)
                lb.Items.Add(n);
        }
        public void NovaLista(int i, int broj, ListBox l)
        {
            List<T> novaLista = ucenici.GetRange(i, broj);
            foreach(T x in novaLista)
                l.Items.Add(x);
        }
        public void brisi()
        {
            ucenici.Clear();
        }
    }
}
