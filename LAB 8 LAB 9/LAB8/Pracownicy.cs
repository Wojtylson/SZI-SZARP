using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB;

internal class Pracownik
{    public string imie { get; set; }
    public string nazwisko { get; set; }

    public Pracownik(string imie, string nazwisko)
    {
        this.imie=imie;
        this.nazwisko=nazwisko;
    }
    public virtual decimal Wyplata()//bedziemy to nadpisywać
    {

        return 0m;///zwraca jakiegos decimala
    }

}
internal class PracownikGodzinowy : Pracownik
{
    public decimal stawkaGodzinowa { get; set; }
    public int liczbaGodzin { get; set; }
    public PracownikGodzinowy(decimal stawkaGodzinowa, int liczbaGodzin,string imie,string nazwisko) : base(imie, nazwisko)
    {
        this.stawkaGodzinowa=stawkaGodzinowa;
        this.liczbaGodzin=liczbaGodzin;
        this.imie = imie;
        this.nazwisko= nazwisko;
    }
    public override decimal Wyplata()//nadpisujemy "overrride"
    {
        if (liczbaGodzin<=160)
        {
            return stawkaGodzinowa*liczbaGodzin;
        }
        else
        {
            return stawkaGodzinowa*160+(stawkaGodzinowa*1.5m*(liczbaGodzin-160));
        }
    }

}
internal class PracownikAkordowy : Pracownik
{
    public decimal stawkaAkordowa { get; set; }
    public int liczbaJednostek { get; set; }
    public PracownikAkordowy(decimal stawkaAkordowa, int liczbaJednostek,string imie,string nazwisko):base(imie,nazwisko)
    {
        this.stawkaAkordowa=stawkaAkordowa;
        this.liczbaJednostek=liczbaJednostek;
        this.imie=imie;
        this.nazwisko=nazwisko;
    }
    public override decimal Wyplata()
    {
        return stawkaAkordowa*liczbaJednostek;



    }

}
internal class PracownikProwizyjny : Pracownik
{
    public decimal pensjaPodstawowa { get; set; }
    public decimal prowizja { get; set; }
    public int liczbaJednostek { get; set; }

    public PracownikProwizyjny(decimal pensjaPodstawowa, int liczbaJednostek, decimal prowizja,string imie,string nazwisko):base(imie,nazwisko)
    {
        this.pensjaPodstawowa=pensjaPodstawowa;
        this.liczbaJednostek=liczbaJednostek;
        this.prowizja=prowizja;
        this.imie=imie;
        this.nazwisko=nazwisko;

    }
    public override decimal Wyplata()
    {
        return pensjaPodstawowa+(prowizja*liczbaJednostek);
    }
}




