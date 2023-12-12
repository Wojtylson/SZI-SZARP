using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class Dowodca : Osadnik
    {
        public string rang;
        public string Rang
        {
            get => rang; set
            {
                if (value.ToString().Length < 4 || Char.IsUpper(value[0]))
                {

                    throw new NieprawidlowaRangaException();
                }
               rang=value;
            }
        }
        public Dowodca(string rang)
        {
            this.rang = rang;
        }


        public class NieprawidlowaRangaException:Exception{}

        public override double Sila()
        {
            return base.Sila()*100;
        }
        public override string ToString()
        {

            return ($"{rang} z wioski{Wioska}-{Nazwisko}");

        }



    }
}
