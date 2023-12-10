using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using LAB8;
internal class BANK2
{
    private static int liczbaKont;
    private string nazwa;
    public Hashtable TablicaKont;
    public BANK2(string nazwa)//konstruktor którzy przy okazji tworzy tablice
    {
        this.nazwa=nazwa;
        TablicaKont = new Hashtable();
    }


    public string Nazwa
    {
        get { return nazwa; }
        set { nazwa= value; }
    }
    public Konto2 ZalozKonto(string imie, string nazwisko)//zabranie z konta
    {

        Konto2 nowekonto = new Konto2(imie, nazwisko);
        TablicaKont.Add(nowekonto.Numer, nowekonto);
        liczbaKont++;//sprawdzam ile kont jest 
        Console.WriteLine("Konto założone pomyślnie");
        return nowekonto;
    }
    public void ListaKont()
    {
        foreach (Konto2 konto in TablicaKont.Values)//nie mamy iterowania więc szukamy dla każdego
        {
            konto.StanKonta();



        }
    }
    public Konto2 ZnajdzKonto(long numer)
    {
        foreach (Konto2 konto in TablicaKont.Values)
        {
            if (TablicaKont.ContainsKey(numer))
            {
                return konto;

            }
        }
        Console.WriteLine($"Konto o numerze {numer} nie istnieje");
        return null;
    }

}

internal class Konto2
{
    private string Imie; //{ get; set; }
    private string Nazwisko;//{ get; set; }
    private long numer;//{ get; }
    public decimal Saldo;
    Random rand = new Random();
    private static long Numerseed = 1234567890;
    public Konto2(string imie, string nazwisko)//konstruktor(THIS)
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
    public void Przelej3(BANK2 bank, long numer, decimal kwota)
    {
        Konto2 odbiorca = bank.ZnajdzKonto(numer);//znajdujemy odbiorcę przelewu używając tablicy kont
        if (odbiorca != null)
        {
            odbiorca.Wplac(kwota);//to jest operacja w koncie które zakładamy
            Wyplac(kwota);//to jest operacja w tym koncie

        }
    }
}




