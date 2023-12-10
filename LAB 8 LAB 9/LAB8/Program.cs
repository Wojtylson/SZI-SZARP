
using LAB8;
using LAB;
using System.Collections;
using System.ComponentModel;

internal class Program
{   //DODAŁEM KLASY I BANK DO KLASY BANK,
    //BANK-Zwykła tablica konta
    //BANK1-ArrayList
    //BANK2-Hashtable
    private static void Main(string[] args)
    {
        //CircleTest();
        //TestArrayList();
        //TestHashTable();
        //1
        /*     Konto k = new Konto("wojtek", "kantor");
            Console.WriteLine(k.imie);
            Console.WriteLine(k.nazwisko);
            Console.WriteLine(k.Numer);
            //k.imie="kacper";
            //k.nazwisko="suski";
            //k.Numer=123124;//numer posiada tylko właściwość get która pozwala jedynie na jego odczytanie.
            //nie możemy zmienić bo w klasie Konto te właściwości ustawiłem na prywatne(private set), jedynie możemy odczytać, możemy oczywiście ustawic tak aby można było zmienic imię i nazwisko posiadacza konta
        */
        //2
        /*
            BANK b = new BANK("MBANK");
            Konto k1 = b.ZalozKonto("Kacper", "Suski");
            Konto k2 = b.ZalozKonto("Wiktor", "Kostera");
            Console.WriteLine("Stan kont przed operacjami");
            b.ListaKont();
            Console.WriteLine("\n");
            k1.Przelej1(b, b.TablicaKont[1].Numer, 500);
            k2.Wplac(1000);
            b.TablicaKont[0].Wplac(1000);
           // b.ListaKont();
            k2.Przelej1(b, b.TablicaKont[0].Numer, 1000);
            Console.WriteLine("Stan kont po operacjach");
            b.ListaKont();
        */
        //3
        /*
            BANK1 b1 = new BANK1("PKO");
            Konto1 k3 = b1.ZalozKonto("Wojciech", "Kantor");
            Konto1 k4 = b1.ZalozKonto("Filip", "Regulski");
            Console.WriteLine("Stan kont przed operacjami");
            b1.ListaKont();
            Console.WriteLine("\n");
            k3.Wplac(1000);
            k4.Wyplac(100);
            b1.ListaKont();
            k3.Przelej2(b1, k4.Numer, 200);
            Console.WriteLine("Stan kont po operacjach");
            b1.ListaKont();
        */
        //4
        /*
        BANK2 b2 = new BANK2("Alior Bank");
        Konto2 k5 = b2.ZalozKonto("Łukasz", "Maczek");
        Konto2 k6 = b2.ZalozKonto("Szymon", "Popkiewicz");
        Console.WriteLine("Stan kont przed operacjami");
        b2.ListaKont();
        Console.WriteLine("\n");
        k5.Wplac(13000);
        k6.Wyplac(400);
        k5.Przelej3(b2, k6.Numer, 10000);
        k6.Przelej3(b2, k5.Numer, 2000);
        Console.WriteLine("Stan kont po operacjach");
        b2.ListaKont();
        */
        Pracownik p = new PracownikAkordowy(20, 20, "Wojtek", "Kantor");









    }

    public static void CircleTest()
    {
        Circle c = new Circle(2);
        Console.WriteLine(c.Promien);//metoda get
        c.Promien=3;//metoda set
        Console.WriteLine(c.Promien);//get
        c.Promien=-2;//set
        Console.WriteLine(c.Promien);
    }
    public static void TestArrayList()
    {   //arraylist może przechowywać obiekty
        ArrayList list = new ArrayList();
        Circle c1 = new Circle(2);
        list.Add(c1);
        list.Add(new Circle(5));
        list.Add(new Circle(3));
        for(int i = 0; i<list.Count; i++)
        {
            Circle? c = (Circle)list[i];//konieczne rzutowanie
            Console.WriteLine(c.Promien);
        }
    }
    public static void TestHashTable()
    {   //zawiera klucze(indeksy) i wartości przypisane do indeksów
        Hashtable phonebook = new Hashtable();
        long numerAli = 65345346;
        phonebook.Add("ala",numerAli);//kluczem jest imię
        phonebook.Add("ola", (long)13456743);
        phonebook.Add("ela", (long)5345345);
        if (phonebook.ContainsKey("ala"))//"ala" to indeks
        {
            long numer = (long)phonebook["ala"];
            Console.WriteLine(numer);

        }
        else
        {
            Console.WriteLine("Ten numer nie należy do nikogo");
        }




    }
}
