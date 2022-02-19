using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    internal class Korisnici
    {
        int oib;
        string ime, prezime;

        public Korisnici(int oib, string ime, string prezime)
        {
            this.oib = oib;
            this.ime = ime;
            this.prezime = prezime;
        }

        public int Oib { get => oib; set => oib = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
    }
}
