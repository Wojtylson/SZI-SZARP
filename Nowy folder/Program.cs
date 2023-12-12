namespace lab11
{


    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime();
            Osadnik o = new Osadnik("WOjtek", "Rabka", d, 30, 23);
            Console.WriteLine(o.ToString());
            Zolnierz z = new Zolnierz();
            z.Stopien = Stopien.Kawalerzysta;

            Console.WriteLine(z.ToString());    
        }


    }
}