using System;
using System.Collections.Generic;
using System.Text;

namespace mySqlAjandek
{
    class Ajandek
    {       
        public int Id { get; }
        public string Nev { get; set; }
        public string Uzlet { get; set; }

        public Ajandek(int id, string nev, string uzlet)
        {
            Id = id;
            Nev = nev;
            Uzlet = uzlet;
        }

        public override string ToString()
        {
            return Nev;
        }
    }
}
