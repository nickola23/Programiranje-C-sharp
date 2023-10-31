using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datoteke_Osoba
{
    internal class Osoba
    {
        string ime, prezime;
        int god;
        public Osoba()
        {
            ime = string.Empty;
            prezime = string.Empty;
            god = 0;
        }
        public Osoba(String ime, string prezime, int god)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.god = god;
        }
        public Osoba(Osoba o)
        {
            this.ime = o.ime;
            this.prezime = o.prezime;
            this.god = o.god;
        }
        public void citaj(StreamReader sr)
        {
            ime = sr.ReadLine();
            prezime = sr.ReadLine();
            god = Convert.ToInt32(sr.ReadLine());
        }
        public void pisi(StreamWriter sw)
        {
            sw.WriteLine(ime);
            sw.WriteLine(prezime);
            sw.WriteLine(god.ToString());
        }
        public bool starijaOd(Osoba o)
        {
            return god > o.god;
        }
        public bool mladjaOd(Osoba o)
        {
            return god < o.god;
        }
        public bool istoGod(Osoba o)
        {
            return god == o.god;
        }
        public override string ToString()
        {
            return ime + " " + prezime + ", " + god;
        }

    }
}
