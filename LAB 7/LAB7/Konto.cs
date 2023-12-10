using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Konto
    {
        public string Imie;
        public string Nazwisko;
        public long numer;
        public decimal Saldo;
        Random rand = new Random();
        private static long Numerseed = 1234567890;
        public Konto(string imie, string nazwisko)//konstruktor(THIS)
        {
            this.Imie=imie;
            this.Nazwisko=nazwisko;
            this.numer=NumerKonta();
            //this.numer = GenerowanieNumer();
            this.Saldo=NadajSaldo();
        }
        public long Numer
        {
            get { return numer; }
        }
        //METODY
        private int NadajSaldo()
        {
            return rand.Next(1000, 2000);
        }
        private long NumerKonta()
        {
            return Numerseed++;
        }
        public void Wplac(decimal kwota)
        {
            Saldo += kwota;
            StanKonta();
        }
        public bool MoznaWyplacic(decimal kwota)
        {
            if (kwota<=Saldo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Wyplac(decimal kwota)
        {
            if (MoznaWyplacic(kwota))
            {
                Saldo -= kwota;
                StanKonta();
            }
            else
            {
                Console.WriteLine($"Operacja wypłaty {kwota} nie może być wykonana\n");
                StanKonta();
            }
        }
        public void Przelej(Konto konto, decimal kwota)
        {
            if (MoznaWyplacic(kwota))
            {   //wszystko jest na NASZYM KONCIE
                Saldo -= kwota;  //konto z którego bierzemy jest jakby utworzone
                konto.Saldo += kwota;//dodajemy kwotę na INNE konto
                StanKonta();
                konto.StanKonta();
            }
            if (!MoznaWyplacic(kwota))
            {

                Console.WriteLine($"Przelew w kwocie {kwota} nie może zostać wykonany\n");
                StanKonta();
            }
        }
        public void StanKonta()
        {   
            Console.WriteLine($"{Imie},{Nazwisko},{Numer},{Saldo}\n");
           
        }
        public void Przelej1(BANK bank, long numer, decimal kwota)
        {
            Konto odbiorca = bank.ZnajdzKonto(numer);//znajdujemy odbiorcę przelewu używając tablicy kont
            if (odbiorca != null)
            {
                odbiorca.Wplac(kwota);//to jest operacja w koncie które zakładamy
                Wyplac(kwota);//to jest operacja w tym koncie

            }
        }
    }
}




