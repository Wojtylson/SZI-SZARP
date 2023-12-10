internal class zadania3
{
    private static void Main(string[] args)
    {
        //p411();
        //zad41();
        //zad42();
        //zad43();
        //zad44();
        //zad45();
        //zad46();
        zad47();

    }


    static void p41()
    {
        int suma = 0;
        int ocena = 0;
        int licznik = 0;
        while (ocena != -1)
        {
            Console.Write("Podaj ocenę: ");
            ocena = Convert.ToInt32(Console.ReadLine());
            suma += ocena;
            licznik += 1;
        }
        if (licznik > 0)
        {
            double srednia = (suma + 1) / (double)(licznik - 1);
            Console.WriteLine("Śrenia z ocen wynosi: {0:N}", srednia);
        }
        else
        {
            Console.WriteLine("Brak danych do obliczenia średniej");
        }
    }
    static void zad41()
    {
        int suma = 0;
        int ocena = 0;
        int licznik = 0;
        do
        {
            Console.Write("Podaj ocenę: ");
            ocena = Convert.ToInt32(Console.ReadLine());
            suma += ocena;
            licznik += 1;

        } while (ocena != -1);

        if (licznik > 0)
        {
            double srednia = (suma + 1) / (double)(licznik - 1);
            Console.WriteLine("Śrenia z ocen wynosi: {0:N}", srednia);
        }
        else
        {
            Console.WriteLine("Brak danych do obliczenia średniej");
        }




    }
    static void zad42()
    {
        int rok = 0;
        long kwota;
        Console.WriteLine("Podaj deponowa kwote");
        for (int i = 0; i < 1; ++i)
        {
            if (long.TryParse(Console.ReadLine(), out kwota))
            {
                double calosc = kwota;
                while (calosc < (2 * kwota))
                {
                    calosc = calosc * 1.06;
                    rok = rok + 1;
                }
                Console.WriteLine($"Nalezy utrzymywac konto {rok} lat");

            }
            else
            {
                Console.WriteLine("Podaj poprawne dane");
                i--;
            }
        }
    }
    static void zad43()
    {
        Console.WriteLine("Zgadnij jaka liczba została wylosowana");
        Random rnd = new Random();
        int a, b;
        Console.WriteLine("Podaj poczatek przedzialu:");
        for (int i = 0; i<1; ++i)
        {
            if (int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Podaj koniec przedzialu:");
                for (int j = 0; j<1; ++j)
                {
                    if (int.TryParse(Console.ReadLine(), out b) &&(b>a))
                    {
                        int c = rnd.Next(a, b);
                        int liczba;
                        int licznik = 0;
                        Console.WriteLine("Podaj liczbę");
                        do
                        {
                            if (int.TryParse(Console.ReadLine(), out liczba))
                            {
                                if (liczba == c)
                                {
                                    Console.WriteLine("Gratulacje, wygrałeś!!! :)))");
                                    licznik++;
                                }
                                else if (liczba < c)
                                {
                                    Console.WriteLine("Za mało!");
                                    licznik++;
                                }
                                else
                                {
                                    Console.WriteLine("Za dużo!");
                                    licznik++;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Błędne dane! Podaj liczbę.");
                            }
                        } while (c != liczba);
                        Console.WriteLine($"Odgadłeś za {licznik} razem");
                    }
                    else
                    {
                        Console.WriteLine("Bledne dane!");
                        j--;
                    }
                }
            }
            else
            {
                Console.WriteLine("Bledna dane!");
                i--;
            }
        }
    }
    static void zad44()
    { 
        int a;
        int licznik = 0;
        Console.WriteLine("Podaj liczbe:");
        for(int i = 0; i<1; ++i)
        {
            if(int.TryParse(Console.ReadLine(),out a) && a>0)
            {
                int liczba = a;
                while (a>1)
                {
                    if (a%2==0) 
                    { 
                    a= a/2;
                    licznik++;
                    }
                    else 
                    {
                    break;
                     }

                }
                if (a==1)
                {
                    Console.WriteLine($"{liczba} to 2^{licznik}");
                }
                else
                {
                    Console.WriteLine($"{liczba} nie można zapisać jako 2^n");
                }
            }
            else
            {
                Console.WriteLine("Bledne dane!");
                i--;
            }
        }
    }
    static void zad45()
    {
        int a, b;
        Console.WriteLine("Sprawdzimy jakieg NWD mają liczby a i b");
        Console.WriteLine("Podaj pierwszą liczbe");
        for (int i = 0; i<1; ++i)
        {
            if (int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Podaj drugą liczbe");
                for(int j=0;j<1; ++j)
                {
                    if (int.TryParse(Console.ReadLine(), out b))
                    {
                        Console.WriteLine($"NWD({a},{b}) to {nwd(a,b)}");

                    }
                    else
                    {
                        Console.WriteLine("Błędne dane! ");
                        j--;
                    }
                }
            }
            else
            {
                Console.WriteLine("Bledne dane!");
                i--;
            }
        }
    }
    static int nwd(int a, int b)
    {
        while (a != b)
        {
            if (a > b)
            {
                a = a - b;
            }
            else
            {
                b = b - a;
            }
        }
        return a;
    }
    static void zad46()
    {
        int n = 0;
        double a = 1.0;
        double pi = 0; 
        double dokladnosc;
        Console.WriteLine("Podaj dokladnośc np. 0,001");
        for (int o = 0; o<1; o++)
        {
            if (double.TryParse(Console.ReadLine(), out dokladnosc) && dokladnosc<1 && dokladnosc>0)
            {
                while (Math.Abs(a)>=dokladnosc)
                {
                    if (n%2==0)
                    {
                        pi+=a;
                    }
                    else
                    {
                        pi-=a;
                    }
                    n++;
                    a=1.0/((2*n)+1);

                }
                
                Console.WriteLine($"Wartosc pi wynosi {4*pi}");


            }
            else
            {
                Console.WriteLine("Podaj poprawne dane!");
                o--;
            }
        }




    }
    static void zad47()
    { int suma_dziel = 0;
        int i = 1;
        int liczba;
        Console.WriteLine("Podaj liczbe, która chcesz sprawdzić czy jest doskonała.\nPrzykładowe liczby doskonałe: 6,28,496,8128");
        for (int m = 0; m<1; ++m)
        {
            if(int.TryParse(Console.ReadLine(),out liczba) && liczba >0)
            {
                i=1;
                suma_dziel=0;


                while (i<=(liczba/2))
                {
                    if (liczba%i==0)
                    {
                        suma_dziel+=i;
                    }
                    i++;
                }



                    if (suma_dziel==liczba)
                    {
                        Console.WriteLine($"{liczba} jest doskonała");
                    }
                    else
                    {
                        Console.WriteLine($"{liczba} nie jest doskonała");
                    }
            }
            else
            {
                Console.WriteLine("Bledne dane!");
                m--;
            }





        }






    }
}