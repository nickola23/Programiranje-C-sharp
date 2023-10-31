using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    internal class Student : IOsoba
    {
        int broj;
        string ime, prezime;
        public void dodeli(int broj, string ime, string prezime)
        {
            this.broj = broj;
            this.ime = ime;
            this.prezime = prezime;
        }
        public string prikazi()
        {
            return broj + " " + ime + " " + prezime;
        }
    }
}
