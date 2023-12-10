using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class OperatorGSM
    {
        private static int maxliczbakomorek = 10;
        private static int liczba_komorek = 0;
        public Komorka[] tablica_komorek;

        public OperatorGSM()//bezparametrowy konstruktor który tworzy tablicę
        {
            tablica_komorek =new Komorka[maxliczbakomorek]; 
        }
        public void Rejestruj(Komorka komorka)

        {
            if (liczba_komorek<maxliczbakomorek)
            {
                tablica_komorek[liczba_komorek]= komorka;
                liczba_komorek++;
                Console.WriteLine("Zarejestrowano pomyślnie!");
            }
            else
            {
                Console.WriteLine("Nie można zarejestrować");        
            }
        }

        public Komorka Wyszukaj(long numer)
        {
            for (int i = 0; i<maxliczbakomorek; i++)
            {
                if (tablica_komorek[i]?.numerTelefonu==numer)
                {
                    return tablica_komorek[i];
                }
            }
                return null;
            }
        }
    }


