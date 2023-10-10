using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcija
{
    internal class Kolekcija
    {
        private static int o = 0;
        public static void Unos(ArrayList lista, ListBox l)
        {
            for(int i = 0; i < lista.Count; i++)
            {
                l.Items.Add(lista[i]);
            }
        }
        public static void brisanjeElemenata(ArrayList lista, int index)
        {
            if (index >= 0 && index < lista.Count)
            {
                lista.Remove(lista[index]);
            }
        }
    }
}
