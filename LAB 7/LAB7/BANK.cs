using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7

{
    internal class BANK
    {
        private static int maxliczbaKont = 10;
        private static int liczbaKont = 0;
        public string Nazwa;
        public Konto []TablicaKont;  //tablica typu Konto i w niej tworzymy konta

        public BANK(string nazwa)//konstruktor którzy przy okazji tworzy tablice
        {
            this.Nazwa=nazwa;
            TablicaKont = new Konto[maxliczbaKont];//utworzenie 10 elementowej tablicy kont
        }
        public Konto ZalozKonto(string imie,string nazwisko)//zabranie z konta
        {   
            if (liczbaKont<maxliczbaKont)
            {
                Konto nowekonto = new Konto(imie, nazwisko);
                TablicaKont[liczbaKont] = nowekonto;                //tworzymy obiekt klasy Konto, który dziedziczy wszystkie swoje właściwości
                liczbaKont++;
                Console.WriteLine("Konto założone pomyślnie");     //tylko że wywołujemy go bank.TablicaKont[0].StanKonta(), musimy tyle napisać
                return TablicaKont[liczbaKont-1];                  //aby przebić się do własności klasy Konto, bo kontem jest TablicaKont[i].
               //bo zwiekszamy liczbaKont o 1
            }
            else
            {
                return null;
            }
        }
        public void ListaKont()
        {
            for (int i = 0; i<liczbaKont; i++)
            {
                TablicaKont[i].StanKonta();     //pisząc w mainie potrzebujemy jeszcze bank.
            }
        }
        public Konto ZnajdzKonto(long numer)
        {
            for(int i = 0; i<liczbaKont;i++)
            {
                if (TablicaKont[i]?.Numer==numer)       //znak zapytania w razie gdyby było mniej kont, lub nie byłoby żadnego, ale żeby nie wywaliło błędu
                {
                    return TablicaKont[i];
                }
               
            }   
            return null;

        }



    }
}
