using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    class Kolo
    {
        public static int ile = 0;
        private double promien;

        //inicjowana z promieniem od razu
        public Kolo(double r)
        {
            promien =r;
            ile++;
        }

        //inicjowana bez promienia
        public Kolo()
        {
            ile++;
        }

        public static double Obwod(double r)
        {
            double obw = 2*Math.PI*r;
            return obw;
        }

        public double Obwod()
        {
            double obw = 2*Math.PI*promien;
            return obw;
        }



    }
    class Prostokat
    {
        public static int ile = 0;
        private double bok1;
        private double bok2;

        //inicjowana z bokami od razu
        public Prostokat(double a,double b)
        {
            bok1=a;
            bok2=b;
            ile++;
            
        }
        //inicjowana bez boków
        public Prostokat() 
        {
            ile++;
                }

        public double Obwod()
        {
            double obw = bok1+bok1+bok2+bok2;
            return obw;
        }


        public static int Obwod(int a, int b)
        {
            int obw = a+a+b+b;
            return obw;


        }


    }
}
