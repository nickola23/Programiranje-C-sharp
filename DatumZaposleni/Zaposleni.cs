using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatumZaposleni
{
    internal class Zaposleni
    {
        private string ime, prezime;
        private int godine, meseci, dani;
        private DateTime datumPrijave, datumOdjave;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        public int Godine
        {
            get { return godine; }
            set { godine = value; }
        }
        public int Meseci
        {
            get { return meseci; }
            set { meseci = value; }
        }
        public int Dani
        {
            get { return dani; }
            set { dani = value; }

        }
        public DateTime DatumPrijave
        {
            get { return datumPrijave; }
            set { datumPrijave = value; }
        }
        public DateTime DatumOdjave
        {
            get { return datumOdjave; }
            set { datumOdjave = value; }
        }
        public Zaposleni(){ }
        public Zaposleni(string ime, string prezime, int godine, int meseci, int dani, DateTime datumPrijave, DateTime datumOdjave)
        {
            Ime = ime;
            Prezime = prezime;
            Godine = godine;
            Meseci = meseci;
            Dani = dani;
            DatumPrijave = datumPrijave;
            DatumOdjave = datumOdjave;
        }
        public void pisi(StreamWriter sw)
        {
            sw.WriteLine("Ime i prezime: " + ime + " " + prezime);
            sw.WriteLine("Datum prijave: " + datumPrijave.ToShortDateString());
            sw.WriteLine("Datum odjave: " + datumOdjave.ToShortDateString());
            sw.WriteLine("===================================================");
        }
        public int brDana()
        {
            if (datumOdjave > datumPrijave) dani = (datumOdjave - datumPrijave).Days;
            else dani = 0;
            return dani;
        }
        public string imePrezime()
        {
            return "Ime i prezime: " + ime + " " + prezime;
        }
        public string brDatum()
        {
            return "Datum prijave: " + datumPrijave.ToShortDateString() + "\r\n" + "Datum odjave: " + datumOdjave.ToShortDateString();
        }
        public override string ToString()
        {
            return imePrezime() + "\r\n" + brDatum() + "\r\n" + " " + brDana() + "\r\n" + "===================================================";
        }

    }
}
