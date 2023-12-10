using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LAB8;


    internal class BANK
    {
        private static int maxliczbaKont = 10;
        private static int liczbaKont = 0;
        private string nazwa;
        public Konto []TablicaKont;  //tablica typu Konto i w niej tworzymy konta
        
        public BANK(string nazwa)//konstruktor którzy przy okazji tworzy tablice
        {
            this.nazwa=nazwa;
            TablicaKont = new Konto[maxliczbaKont];//utworzenie 10 elementowej tablicy kont
        }


        public string Nazwa
    {
        get { return nazwa; }
        set { nazwa= value;}
    }
        public Konto ZalozKonto(string imie,string nazwisko)//zabranie z konta
        {   
            if (liczbaKont<maxliczbaKont)
            {
                Konto nowekonto = new Konto(imie, nazwisko);
                TablicaKont[liczbaKont] = nowekonto;                //tworzymy obiekt klasy Konto, który dziedziczy wszystkie swoje właściwości
                liczbaKont++;
                Console.WriteLine("Konto założone pomyślnie");     //tylko że wywołujemy go bank.TablicaKont[0].StanKonta(), musimy tyle napisać
            return nowekonto;                 //aby przebić się do własności klasy Konto, bo kontem jest TablicaKont[i].
               //bo zwiekszamy liczbaKont o 1
            }
            else
            {
            Console.WriteLine("Nie udało się założyć konta :(");
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
        Console.WriteLine($"Konto o numerze {numer} nie istnieje"); 
            return null;

        }



}
  internal class Konto
{
    private string Imie; //{ get; set; }
    private string Nazwisko;//{ get; set; }
    private long numer;//{ get; }
    public decimal Saldo;
    Random rand = new Random();
    private static long Numerseed = 1234567890;
    public Konto(string imie, string nazwisko)//konstruktor(THIS)
    {
        this.Imie=imie;
        this.Nazwisko=nazwisko;
        this.numer=NumerKonta();
        this.Saldo=NadajSaldo();
    }
    public long Numer
    {
        get { return numer; }
    }
    public string imie
    {
        get { return Imie; }
         private set { if (value is string) { Imie=(string)value; } }
    }
    public string nazwisko
    {
        get { return Nazwisko; }
        private set { if (value is string) { Nazwisko=(string)value; } }
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





