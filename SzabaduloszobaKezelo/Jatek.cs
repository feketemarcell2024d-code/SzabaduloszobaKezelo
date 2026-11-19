using System;
using System.Collections.Generic;
using System.Text;

namespace SzabaduloszobaKezelo
{
    public class Jatek
    {
        public string Csapatnev { get; set; }

        public string Palyatipus { get; set; }

        public int Jatekosszama { get; set; }

        public int Idotartamperc { get; set; }

        public int Hasznaltsegitseg { get; set; }


        public Jatek(string sor)
        {

            string[] adatok = sor.Split(';');

            Csapatnev = adatok[0];
            Palyatipus = adatok[1];
            Jatekosszama = int.Parse(adatok[2]);
            Idotartamperc = int.Parse(adatok[3]);
            Hasznaltsegitseg = int.Parse(adatok[4]);
        }
        public int FizetendoOsszeg()
        {
            int egeszar = 0;

            if (Palyatipus == "klasszikus")
            {
                egeszar = 14000;
            }
            else if (Palyatipus == "Horror")
            {
                egeszar = 18000;
            }

            int dijszamito = (Jatekosszama * 3000) + (Hasznaltsegitseg * 1000);
            int vegosszeg = egeszar + dijszamito + Hasznaltsegitseg)

            int tobbletszam = 0
                if (Jatekosszama)
            {

            }

            int pluszdij = 0;

            if (Jatekosszama == 3 )
            {
                pluszdij = 0;
            }
            else if (Jatekosszama < 3)
            {
                pluszdij = 3000;
            }



        }
    }

}
