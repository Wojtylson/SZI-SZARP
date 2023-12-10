
using System.Collections.Generic;
using System.Runtime.Versioning;
using static Polaczenie;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Console.WriteLine(":)");
        (double, int) krotka1 = (4.5, 3);//Krotka to uporządkowany ciąg matematyczny
        Console.WriteLine($"Krotka z elementami {krotka1.Item1} i {krotka1.Item2}.");
        (double suma, int liczba) krotka2 = (4.5, 3);
        Console.WriteLine($"Suma {krotka2.liczba} elemntów wynosi {krotka2.suma}");
        

        Dictionary<int, string> nazwyLiczb = new();
        nazwyLiczb.Add(0, "Zero");
        nazwyLiczb.Add(1, "Jeden");
        nazwyLiczb.Add(2, "Dwa");
        nazwyLiczb.Add(3, "Trzy");
        foreach(KeyValuePair<int, string>kvp in nazwyLiczb)
        {
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }
        nazwyLiczb[0]="Zerówka";
        nazwyLiczb[1]="Jedynka";
        nazwyLiczb[2]="Dwójka";
        nazwyLiczb[3]="Trójka";
        foreach (KeyValuePair<int, string> kvp in nazwyLiczb)
        {
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }
        */
        Abonent a = new Abonent("Wojtek", "Kantor", "600157242");
        Abonent b = new Abonent("Kacper", "Suski", "5054545454");
        Abonent c = new Abonent("Wiktor", "Koster", "123456789");
        OperatorSieci d = new OperatorSieci("TMOBILE");
        d.DodajAbonenta(a);
        d.DodajAbonenta(b);
        d.DodajAbonenta(c);
        a.Zadzwon(20, EnumTaryfa.taryfa2);
        b.Zadzwon(30, EnumTaryfa.taryfa3);
        c.Zadzwon(100, EnumTaryfa.taryfa1);
        Console.WriteLine(d.ToString());
        c.Zadzwon(32, EnumTaryfa.taryfa2);
        Console.WriteLine(d.ToString());
    }

}


enum EnumTaryfa//wyliczeniowy
{
    taryfa1=1,
    taryfa2=2,
    taryfa3=4,


}

interface IAbonent
        
{
    public string PodajDane();
    public void Zadzwon(double czas, EnumTaryfa taryfa);
    public (int, decimal) PodsumowanieRozmow();
}



class Polaczenie
{
    private double czasTrwania { get; set; }
    public decimal oplata { get; set; }
    public bool wykonane { get; set; }

    public Polaczenie(double czasTrwania, decimal oplata, bool wykonane)
    {
        this.czasTrwania=czasTrwania;
        this.oplata=oplata;
        this.wykonane=wykonane;
    }

    internal class Abonent : IAbonent
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string numerTelefonu { get; set; }
        public List<Polaczenie> Polaczenia { get; set; }

        public Abonent(string imie, string nazwisko, string numerTelefonu)
        {
            this.imie=imie;
            this.nazwisko=nazwisko;
            this.numerTelefonu=numerTelefonu;
            this.Polaczenia= new List<Polaczenie>();
        }
        public string PodajDane()
        {
            return ($"{imie},{nazwisko}");

        }
        public (int, decimal) PodsumowanieRozmow()//zwraca krotkę
        {
            int rozmowy = 0;
            decimal oplaty = 0;
            foreach (Polaczenie polaczenie in Polaczenia)
            {
                if (polaczenie.wykonane)
                {
                    rozmowy++;
                    oplaty+=polaczenie.oplata;
                }
            }
            return (rozmowy, oplaty);//krotka
        }
        public void Zadzwon(double czas, EnumTaryfa taryfa)
        {
            double liczba = new Random().NextDouble();//od 0 do 1
            if (liczba<0.3)
            {
                Polaczenia.Add(new Polaczenie(0, 0, false));
                Console.WriteLine("Polaczenie się nie powiodło");
            }
            else
            {
                decimal oplata = (decimal)taryfa*(decimal)czas;
                Polaczenia.Add(new Polaczenie(czas, oplata, true));
                Console.WriteLine("Polaczenie się powiodło");
            }


        }
        public override string ToString()

        {
            (int, decimal) podsumowanie = PodsumowanieRozmow();
            return ($"{PodajDane()},liczba rozmów: [{podsumowanie.Item1},oplata: {podsumowanie.Item2}]");

        }

    }
    internal class OperatorSieci
    {

        private string nazwa { get; set; }
        public Dictionary<string, Abonent> abonenci { get; set; }

        public OperatorSieci(string nazwa)
        {
            this.nazwa=nazwa;
            this.abonenci=new Dictionary<string, Abonent>();
        }

        public void DodajAbonenta(Abonent abonent)
        {
            abonenci.Add(abonent.numerTelefonu, abonent);
        }
        public Abonent WyszukajAbonenta(string numerTelefonu)
        {
            if (abonenci.ContainsKey(numerTelefonu))
            {

                return abonenci[numerTelefonu];
            }
            else
            {
                return null;
            }


        }
        public override string ToString()
    {
        decimal zysk = 0;
        string daneAbonenta;
        foreach (Abonent abonent in abonenci.Values)
        {
            (int,decimal) podsumowanie = abonent.PodsumowanieRozmow();
            zysk += podsumowanie.Item2;
        }

        foreach (Abonent abonent in abonenci.Values)
        {
            daneAbonenta = abonent.ToString();
            Console.WriteLine(daneAbonenta);
        }
        return $"\nOperator: {nazwa} [sumaryczny zysk: {zysk}]";
    }
}
}





