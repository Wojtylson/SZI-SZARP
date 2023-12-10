using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using LAB8;
internal class BANK1
{
    private static int liczbaKont;
    private string nazwa;
    public ArrayList TablicaKont;
    public BANK1(string nazwa)//konstruktor którzy przy okazji tworzy tablice
    {
        this.nazwa=nazwa;
        TablicaKont = new ArrayList();
    }


    public string Nazwa
    {
        get { return nazwa; }
        set { nazwa= value; }
    }
    public Konto1 ZalozKonto(string imie, string nazwisko)//zabranie z konta
    {
        
            Konto1 nowekonto = new Konto1(imie, nazwisko);
            TablicaKont.Add(nowekonto);             
            liczbaKont++;//sprawdzam ile kont jest 
            Console.WriteLine("Konto założone pomyślnie");     
            return nowekonto;                 
    }
    public void ListaKont()
    {
        foreach(Konto1 konto in TablicaKont)//nie mamy iterowania więc szukamy dla każdego
        {
            konto.StanKonta();
        }
    }
    public Konto1 ZnajdzKonto(long numer)
    {
        foreach (Konto1 konto in TablicaKont)
        {
            if (konto?.Numer==numer)
            {
                return konto;

            }
        }
        Console.WriteLine($"Konto o numerze {numer} nie istnieje");
        return null;
            }

        }

 internal class Konto1
{
    private string Imie; //{ get; set; }
    private string Nazwisko;//{ get; set; }
    private long numer;//{ get; }
    public decimal Saldo;
    Random rand = new Random();
    private static long Numerseed = 1234567890;
    public Konto1(string imie, string nazwisko)//konstruktor(THIS)
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
    public void Przelej2(BANK1 bank, long numer, decimal kwota)
    {
        Konto1 odbiorca = bank.ZnajdzKonto(numer);//znajdujemy odbiorcę przelewu używając tablicy kont
        if (odbiorca != null)
        {
            odbiorca.Wplac(kwota);//to jest operacja w koncie które zakładamy
            Wyplac(kwota);//to jest operacja w tym koncie

        }
    }
}




