using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_Update_Delete
{
    class Radnik
    {
        int id;
        string ime;
        string prezime;
        double plata;
        int brod;
        int idos;

        public Radnik()
        {
        }
        public Radnik(int id, string ime, string prezime, double plata, int brod, int idos)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.brod = brod;
            this.idos = idos;
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
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
        public double Plata
        {
            get { return plata; }
            set { plata = value; }
        }
        public int Brod
        {
            get { return brod; }
            set { brod = value; }
        }
        public int Idos
        {
            get { return idos; }
            set { idos = value; }
        }
        public override string ToString()
        {
            return id + " " + ime + " " + prezime + " " + prezime + " " + plata + " " + brod + " " + idos;
        }
    }
    }
