using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{  public enum Stopien
    {

        Strzelec,
        Pikinier,
        Kawalerzysta,


    }

    public class Osadnik
    {

        public static int populacja;


        string nazwisko;
        string wioska;
        DateTime dataNarodzin;
        decimal masa;
        double predkosc;

        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string Wioska { get => wioska; set => wioska = value; }
        public DateTime DataNarodzin { get => dataNarodzin; set => dataNarodzin = value; }
        public decimal Masa { get => masa; set => masa = value; }
        public double Predkosc { get => predkosc; set => predkosc = value; }

        static Osadnik()
        {
            populacja = 15;
        }
        public Osadnik()
        {

            populacja++;
        }

        public Osadnik(string nazwisko, string wioska, DateTime dataNarodzin, decimal masa, double predkosc) : this()
        {
            this.nazwisko = nazwisko;
            this.wioska = wioska;
            this.dataNarodzin = dataNarodzin;
            this.masa = masa;
            this.predkosc = predkosc;

        }
        virtual public double Sila()
        {
            return (double)masa * predkosc;
        }
   
        public override string ToString()
        {
           string datanarodzinstring = dataNarodzin.ToString();



            return ($"{nazwisko} z wioski {wioska}, Siła: {Sila()}");
        }




    }

}

