using System.ComponentModel.DataAnnotations;
using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        zad51();
        //zad52();
        //zad53();
        //zad54();
        //zad55test();
        //zad56test();
    }
    static void zad51()
    {
        int[] tab = new int[5];
        for (int i = 0; i < tab.Length; i++)
        {
            Console.WriteLine($"Podaj a[{i+1}]");
            tab[i]=Int32.Parse(Console.ReadLine());
        }
        int a = tab.Max();
        for (int i = 0; i<tab.Length; i++)
        {
            if (tab[i]==a)
            {
                Console.WriteLine($"Największy element znajduje się na {i+1} miejscu");
            }
        }
        Console.WriteLine($"Najwieksza wartość w tablicy wynosi {a}");
    }
    static void zad52()
    {
        Console.WriteLine("1-Mnożenie wektora przez liczbę\n2-Mnożenie wektora przez wektor");
        int a;
        if (int.TryParse(Console.ReadLine(), out a))
        {
            switch (a)
            {
                case 1:
                    wektorliczba();
                    break;
                case 2:
                    wektorwektor();
                    break;
                default:
                    Console.WriteLine("Złe dane :(");
                    break;
            }
        }
    }
    static void wektorliczba()
    {
        Console.WriteLine("Podaj liczbę:");
        int a = Int32.Parse(Console.ReadLine());
        int[] wektor = { 2, 3, 5, 6, 3, 5, -2, -3, 6, 0 };
        int n = wektor.Length;
        int[] wynik = new int[n];
        Console.WriteLine("Wektor");
        for (int i = 0; i<n; ++i)
        {
            Console.Write($"{wektor[i]} ,");
        }
        Console.WriteLine($"\nWektor pomnożony przez {a}");
        for (int i = 0; i<n; ++i)
        {
            wynik[i]=wektor[i]*a;
        }
        for (int i = 0; i<n; ++i)
        {
            Console.Write($"{wynik[i]} ,");
        }




    }
    static void wektorwektor()
    {
        int[] wektor1 = { 3, -4, 0, 6, 7, 2 };
        int[] wektor2 = { 7, 4, 5, 6, 0, 3 };
        int a = wektor1.Length;
        int b = wektor2.Length;
        int n = (a+b)/2;
        int wynik = 0;
        if (a!=b)
        {
            Console.WriteLine("Blad: Wektory nie mają tej samej długości");
        }
        Console.WriteLine("Wektor1:");
        for (int i = 0; i<n; ++i)
        {
            Console.Write($"{wektor1[i]} ,");
        }
        Console.Write("\n");
        Console.WriteLine("Wektor2");
        for (int i = 0; i<n; ++i)
        {
            Console.Write($"{wektor2[i]} ,");
        }
        Console.Write("\n");
        for (int i = 0; i<n; ++i)
        {
            wynik+=wektor1[i]*wektor2[i];
        }
        Console.WriteLine($"Iloczyn skalarny tych wektorów wynosi {wynik}");
    }
    static void zad53()
    {
        Console.WriteLine("1-Mnożenie macierzy przez liczbę\n2-Mnożenie macierzy przez wektor\n3-Mnożenie macierzy przez macierz");
        int a;
        if (int.TryParse(Console.ReadLine(), out a))
        {
            switch (a)
            {
                case 1:
                    macierzliczba();
                    break;
                case 2:
                    macierzwektor();
                    break;
                case 3:
                    macierzmacierz();
                    break;
                default:
                    Console.WriteLine("Złe dane :(");
                    break;
            }
        }
    }
    static void macierzliczba()
    {
        Console.WriteLine("Podaj liczbę:");
        int a = Int32.Parse(Console.ReadLine());
        int[,] macierz = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int wiersze = macierz.GetLength(0);
        int kolumny = macierz.GetLength(1);
        int n = macierz.Length;
        Console.WriteLine("Macierz przed pomnożeniem przez liczbę:");
        for (int i = 0; i<n/wiersze; ++i)
        {
            for (int j = 0; j<n/kolumny; ++j)
            {
                Console.Write($"{macierz[i, j]},");
            }
            Console.Write("\n");
        }
        Console.WriteLine("Macierz po pomnożeniu przez {0}", a);
        for (int i = 0; i<n/wiersze; ++i)
        {
            for (int j = 0; j<n/kolumny; ++j)
            {

                macierz[i, j]*=a;
                Console.Write($"{macierz[i, j]},");
            }
            Console.Write("\n");
        }

    }
    static void macierzwektor()
    {
        int[,] macierz = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int wiersze = macierz.GetLength(0);
        int kolumny = macierz.GetLength(1);
        int n = macierz.Length;
        int[] wektor = new int[3] { 3, -2, 7 };
        int m = wektor.Length;
        if (m!=kolumny)
        {
            Console.WriteLine("Długość wektora nie jest równa liczbie kolumn");
            return;
        }
        Console.WriteLine("Macierz przed pomnożeniem przez wektor:");
        for (int i = 0; i<n/wiersze; ++i)
        {
            for (int j = 0; j<n/kolumny; ++j)
            {
                Console.Write($"{macierz[i, j]},");
            }
            Console.Write("\n");
        }
        int[] wynik = new int[m];
        for (int i = 0; i < wiersze; ++i)
        {
            int suma = 0;
            for (int j = 0; j < kolumny; ++j)
            {
                suma += macierz[i, j] * wektor[j];
            }
            wynik[i] = suma;
        }
        Console.WriteLine("Wynik mnożenia macierzy przez wektor:");
        for (int i = 0; i < wynik.Length; ++i)
        {
            Console.Write($"{wynik[i]}\n");
        }
    }
    static void macierzmacierz()
    {

        int[,] macierz1 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int wiersze1 = macierz1.GetLength(0);
        int kolumny1 = macierz1.GetLength(1);
        int n1 = macierz1.Length;

        int[,] macierz2 = new int[3, 3] { { 3, -3, 2 }, { 1, 8, -5 }, { 0, 3, 6 } };
        int wiersze2 = macierz2.GetLength(0);
        int kolumny2 = macierz2.GetLength(1);
        int n2 = macierz2.Length;
        if (kolumny1!=wiersze2)
        {
            Console.WriteLine("Liczba kolumn w pierwszej macierzy musi być równa liczbie wierszy w drugiej");
        }
        Console.WriteLine("Macierz 1:");
        for (int i = 0; i<n1/wiersze1; ++i)
        {
            for (int j = 0; j<n1/kolumny1; ++j)
            {
                Console.Write($"{macierz1[i, j]},");
            }
            Console.Write("\n");
        }
        Console.WriteLine("Macierz 2:");
        for (int i = 0; i<n2/wiersze2; ++i)
        {
            for (int j = 0; j<n2/kolumny2; ++j)
            {
                Console.Write($"{macierz2[i, j]},");
            }
            Console.Write("\n");
        }
        int[,] wynik = new int[wiersze1, kolumny2];
        int o = wynik.Length;
        for (int i = 0; i < wiersze1; i++)
        {
            for (int j = 0; j < kolumny2; j++)
            {
                int suma = 0;
                for (int k = 0; k < kolumny1; k++)
                {
                    suma += macierz1[i, k] * macierz2[k, j];
                }
                wynik[i, j] = suma;
            }
        }
        Console.WriteLine("Wynik mnożenia macierzy przez macierz wynosi:");
        for (int i = 0; i<o/wiersze1; ++i)
        {
            for (int j = 0; j<o/kolumny2; ++j)
            {
                Console.Write($"{wynik[i, j]},");
            }
            Console.Write("\n");
        }


    }
    static void zad54()
    {
        int[,] a = new int[5, 5];
        for (int i = 0; i<5; ++i)
        {
            for (int j = 0; j<5; ++j)
            {
                if (i == j || i + j == 4)
                {
                    a[i, j] = 1;
                }
                else
                {
                    a[i, j] = 0;
                }

            }
        }
        for (int i = 0; i<5; ++i)
        {
            for (int j = 0; j<5; ++j)
            {
                Console.Write($"{a[i, j]}");
            }
            Console.Write("\n");
        }
    }
    static void zad55(int[] a, int n)
    {
        int i, j, b;
        for (i = 0; i < n-1; i++)
        {
            for (j = 0; j < n-1-i; j++)
            {
                if (a[j] < a[j + 1])
                {
                    continue;
                }
                b = a[j];
                a[j] = a[j + 1];
                a[j + 1] = b;
            }
        }
    } 
    static void zad55test()
            {
                Console.WriteLine("Nieposortowana tablica:");
                int[] a = { 3, 6, 1, 2, 7, 9, 0, };
                int n = a.Length;
                for (int i = 0; i<n; i++)
                {
                    Console.Write($"{a[i]},");
                }
                Console.Write("\nPosortowana tablica: \n");
                zad55(a, n);

                for (int i = 0; i<n; i++)
                {
                    Console.Write($"{a[i]},");
                }
            
                }   
    static void zad56(int[] a, int n)
            {
                for (int i = 0; i < n; ++i)
                {
                    int k = i;
                    for (int j = i + 1; j < n; ++j)
                    {
                        if (a[j] < a[k])
                        {
                            k = j;
                        }
                    }
                    if (k != i)
                    {
                        int temp = a[k];
                        a[k]=a[i];
                        a[i]=temp;
                    }
                }
            }
    static void zad56test()
            {
                Console.WriteLine("Nieposortowana tablica:");
                int[] a = { 3, 6, 1, 2, 7, 9, 0, };
                int n = a.Length;
                for (int i = 0; i<n; i++)
                {
                    Console.Write($"{a[i]},");
                }
                Console.Write("\nPosortowana tablica: \n");
                zad56(a, n);
                for (int i = 0; i<n; i++)
                {
                    Console.Write($"{a[i]},");
                }
            }
 }
    
