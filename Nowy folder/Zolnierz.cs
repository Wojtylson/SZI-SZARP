using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{


    public class Zolnierz : Osadnik
    {
        string identyfikator;
        public Stopien stopien;

        public string Identyfikator { get => identyfikator; set => identyfikator = value; }
        public Stopien Stopien { get => stopien;  set => stopien = value; }


        public Zolnierz()
        {

            switch (Stopien)
            {
                case Stopien.Pikinier:
                    {
                        Identyfikator = "PIK-";
                        break;
                    }
                case Stopien.Kawalerzysta:
                    {
                        Identyfikator = "KAW-";
                        break;
                    }
                case Stopien.Strzelec:
                    {
                        Identyfikator = "STRZ-";
                        break;
                    }
                default: break;

            }

        }
        public override double Sila()
        {
            switch (this.Stopien)
            {
                case Stopien.Strzelec:
                    return base.Sila() + 25;
                case Stopien.Pikinier:
                    return base.Sila() + 15;
                case Stopien.Kawalerzysta:
                    return base.Sila() + 30;
            }return base.Sila();
        }


        public override string ToString()
        {
            return ($"{Nazwisko} z {Wioska}, {this.stopien},{Identyfikator} {populacja}");
        }
    }
}