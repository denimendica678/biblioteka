using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    internal class Knjige
    {
        int isbn;
        string naziv, autor;

        public Knjige(int isbn, string naziv, string autor)
        {
            this.isbn = isbn;
            this.naziv = naziv;
            this.autor = autor;
        }

        public int Isbn { get => isbn; set => isbn = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Autor { get => autor; set => autor = value; }
    }
}
