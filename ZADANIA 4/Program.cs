
using LAB4;


internal class Program
{
    private static void Main(string[] args)
    {

        //testKola1();
        //testProstokat1();
        //testKola2();
        //testProstokat2();
        //testKola3();
        testProstokat3(); 






    }
    static void testKola1()
        {   
  
        double r;
        Console.WriteLine("Podaj promien kola");


        for (int i = 0; i < 1;i++)
        {
            if (double.TryParse(Console.ReadLine(), out r)&r>0)
            {


                
                double obw = Kolo.Obwod(r);
                Console.WriteLine($"Obwod kola o promieniu {r} wynosi {obw:F2}");
            }
            else
            {
                Console.WriteLine("Bledne dane");
                i--;
            
            
            }
        }

    }
    static void testProstokat1()
    {

        int a, b;
        Console.WriteLine("Podaj pierwszy bok prostokąta");
        for (int i = 0; i < 1; i++)
        {
            if(int.TryParse(Console.ReadLine(),out a)&a>0)
            {
                Console.WriteLine("Podaj drugi bok prostokąta");
                for(int j =0; j < 1; j++)
                {
                    if (int.TryParse(Console.ReadLine(), out b)& b>0)
                    {
                       
                        int obw = Prostokat.Obwod(a, b);
                        Console.WriteLine($"Prostokat ma obwód {obw}");


                    }
                    else
                    {
                        Console.WriteLine("Bledne dane! ");
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
    static void testKola2()
    {

        double r;
        Console.WriteLine("Podaj promien kola");


        for (int i = 0; i < 1; i++)
        {
            if (double.TryParse(Console.ReadLine(), out r)&r>0)
            {


                Kolo k = new Kolo(r);
                double obw = k.Obwod();
                Console.WriteLine($"Obwod kola o promieniu {r} wynosi {obw:F2}");
            }
            else
            {
                Console.WriteLine("Bledne dane");
                i--;


            }
        }

    }
    static void testProstokat2()
    {

        int a, b;
        Console.WriteLine("Podaj pierwszy bok prostokąta");
        for (int i = 0; i < 1; i++)
        {
            if (int.TryParse(Console.ReadLine(), out a)&a>0)
            {
                Console.WriteLine("Podaj drugi bok prostokąta");
                for (int j = 0; j < 1; j++)
                {
                    if (int.TryParse(Console.ReadLine(), out b)& b>0)
                    {
                        Prostokat p = new Prostokat(a,b);
                        double obw = p.Obwod();
                        Console.WriteLine($"Prostokat ma obwód {obw}");


                    }
                    else
                    {
                        Console.WriteLine("Bledne dane! ");
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
    
    static void testKola3()
    {
        Kolo k1= new Kolo();
        Kolo k2 = new Kolo(3.4);
        Kolo k3 = new Kolo(5);

        int ile = Kolo.ile;

        Console.WriteLine($"Liczba stworzonych kół wynosi {ile}");
    }
    static void testProstokat3()
    {
        Prostokat q, w, e, r, t, y;
        q = new Prostokat();
        w = new Prostokat(5,7);
        e = new Prostokat(3, 9);
        r = new Prostokat(4, 5);
        t = new Prostokat(3, 4);
        y = new Prostokat(23, 5);
        int ile = Prostokat.ile;
        Console.WriteLine($"Liczba stworzonych prostokątów wynosi {ile}");
    }



}