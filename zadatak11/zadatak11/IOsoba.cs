using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak11
{
    internal interface IOsoba
    {
        void Dodeli(int broj, string ime, string prezime);
        string Prikazi();
    }
    public class Student:IOsoba
    {
        int broj;
        string ime, prezime;
        public void Dodeli(int broj, string ime,string prezime)
        {
            this.broj = broj;
            this.ime = ime;
            this.prezime = prezime;
        }
        public string Prikazi()
        {
            return broj + "" + ime + "" + prezime;
        }

    }

}
