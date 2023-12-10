using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WLASCIWOSCI //publiczna metoda która zwraca nam wartosc zmiennej kiedy sama zmienna jest prywatna
//połączenie prywatnej zmiennej i publicznej lub prywatnej metody, która ma dostęp do zmiennej

namespace LAB8//get zwraca, set ustawia
{
     internal class Circle
    {
        private double _promien;

        public double Promien
        {

            get { return _promien; }//odczytanie danych z prywatnego pola _promien
            set//wprowadzenie nowych danych do prywatnego pola _promien
            {
                if (value>0)//sprawdzamy czy już jest coś
                {
                    _promien= value;
                }
            }

        }
        //public double Promien { get; set; }
        public Circle(double r)
        {
            this._promien= r;
        }




    }
}
