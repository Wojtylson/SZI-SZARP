internal class Program
{
    private static void Main(string[] args)
    {
        //p11();
        //p12();
        //p13();
        //p14();
        //p15();
        p16();
    }
    static void p11()
    {
        Console.Write("Podaj promień: ");
        double r;
        if (double.TryParse(Console.ReadLine(), out r))
        {
            if (r >= 0)
            {
                double PoleKola = Math.PI * r * r;
                Console.WriteLine("Pole wynosi {0:0.##}", PoleKola);
            }
            else if (r < 0)
            {
                Console.WriteLine("Podana liczba jest mniejsza od zera :(");
            }
        }
        else
        {
            Console.WriteLine("niepoprawne dane :(");
        }

    }
    static void p12()
    {
        Console.WriteLine("Podaj bok a: ");
        double bok1, bok2;
        double Pole = 0;
        if (double.TryParse(Console.ReadLine(), out bok1))
        {
            Console.WriteLine("Podaj bok b: ");
            {
                if (double.TryParse(Console.ReadLine(), out bok2))
                {
                    Pole = bok1 * bok2;
                    Console.WriteLine("P = {0}", Pole);
                    if (bok1 == bok2)
                    {
                        Console.WriteLine("Dodatkowo jest to kwadrat :P");
                    }
                }
                else
                {
                    Console.WriteLine("Niepoprawne dane :O");
                }

            }
        }
        else { Console.WriteLine("Niepoprawne dane :("); }

    }
    static void p13()
    {
        Console.WriteLine("Podaje proszę liczbę, sprawdzę czy jest parzysta: ");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x % 2 == 0)
        {
            Console.WriteLine("Parzysta");
        }
        else { Console.WriteLine("Nieparzysta"); }
    }
    static void p14()
    {
        Console.WriteLine("Podaje liczbe 1: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaje liczbe 2: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaje liczbe 3: ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Max({0},{1},{2}) = {3}", a, b, c, max(a, b, c));
    }
    static int max(int a, int b, int c)
    {
        if (a >= b && a >= c) { return a; }
        else if (c >= b && c >= a) { return c; }
        else { return b; }
    }
    static void p15()
    {
        Console.WriteLine("Podaj współczynniki równania kwadratowe:");
        Console.Write("a= ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b= ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c= ");
        double c = Convert.ToDouble(Console.ReadLine());
        double delta = b * b - 4 * a * c;
        if (delta > 0)
        {
            Console.WriteLine("\ndelta > 0");
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("x1= {0:F3}\nx2= {1:F3}", x1, x2);
        }
        else if (delta == 0)
        {
            Console.WriteLine("\ndelta = 0");
            double x0 = (-b) / (2 * a);
            Console.WriteLine($"x0= " + x0);
        }
        else
        {
            Console.WriteLine("\ndelta < 0");
            delta = delta * (-1);
            double czesc_urojona = Math.Sqrt(delta);
            Console.WriteLine("xi1 = {0} + {1:F2}i\nxi2 = {2} - {3:F2}i", (-b / 2),
                (czesc_urojona/(2*a)), (-b / 2), czesc_urojona/(2*a));

        }
    }
    static void p16()
    {
        double KursDolara = 4.33;
        double KursEuro = 4.57;
        double KursFrankSzwajcarski = 4.77;
        Console.WriteLine("Podaj ilość złotych, a ja przewalutuję :)");
        double zlote;
        if (double.TryParse(Console.ReadLine(), out zlote))
        {
            Console.WriteLine("1-Euro\n2-Dolar\n3-Frank szwajcarski");
            double a;
            if (double.TryParse(Console.ReadLine(), out a))
            {
                switch (a)
                {
                    case 1:
                        Console.WriteLine("{0:F2} euro", (zlote / KursEuro));
                        break;
                    case 2:
                        Console.WriteLine("{0:F2} dolarów", (zlote / KursDolara));
                        break;
                    case 3:
                        Console.WriteLine("{0:F2} franków szwajcarskich", (zlote / KursFrankSzwajcarski));
                        break;
                    default:
                        Console.WriteLine("Złe dane :(");
                        break;
                }
            }

        }
    }
}











