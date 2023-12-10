using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Komorka
    {   
        public long numerTelefonu;
        public string? odebranySMS;//sms może miec wartość null więc dałem znak zapytania

        public Komorka(long numerTelefonu)
        {
            this.numerTelefonu=numerTelefonu;

        }
        //nasza metoda akcesorowa służy tylko do ODCZYTU numeru telefonu
        public long Numer//akcesor który odczytuje numer telefonu
        {
            get { return numerTelefonu; }
        }

        public void OdbierzSMS(string sms)//składa się w wyslij SMS
        {
            odebranySMS=
                sms;
        }
        public void CzytajSMS()
        {
            Console.WriteLine($"{odebranySMS}");
        }
        public void WyslijSMS(Komorka komorka,string sms)//komorka to nowy obiekt
        {   
                Console.WriteLine($"wysyłanie sms o treści {sms} z numeru {numerTelefonu} na numer {komorka.numerTelefonu}");
                komorka.OdbierzSMS(sms);
        }



        public void WyslijSMS1(OperatorGSM @operator,long numer, string sms)
        {
            Komorka odbiorca = @operator.Wyszukaj(numer);
            if (odbiorca!=null)
            {
                odbiorca.OdbierzSMS(sms);
            }


        }
    }
}
