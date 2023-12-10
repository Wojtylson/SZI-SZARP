using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lab7;


    internal class Program
    {
        private static void Main(string[] args)
        {
        /*Konto konto1 = new Konto("Wojtek", "Kantor");
        Konto konto2 = new Konto("Kacper", "Suski");
        konto1.StanKonta();
        konto2.StanKonta();
        konto1.Wplac(1000);
        konto2.Wplac(500);
        konto1.Wyplac(300);
        konto1.Przelej(konto2, 500);
        konto1.Wyplac(400);
        BANK bank = new BANK("MBANK");
        Konto konto = bank.ZalozKonto("Wojtek", "Kantor");
        Konto konto3 = bank.ZalozKonto("Kacper", "Suski");
        Console.Write("\n");
        bank.ListaKont();
        bank.TablicaKont[0].Wplac(1000);
        bank.TablicaKont[1].Wplac(500);
        bank.TablicaKont[0].Wyplac(300);
        bank.TablicaKont[0].Przelej1(bank, bank.TablicaKont[1].numer, 500);
        bank.TablicaKont[0].Wyplac(400);
        bank.TablicaKont[0].StanKonta();
        bank.TablicaKont[1].StanKonta();
        bank.ListaKont();*/
        Komorka k = new Komorka(6054045);
        Komorka n = new Komorka(12312435);
        k.WyslijSMS(n, "Siema");
        n.CzytajSMS();
        k.WyslijSMS(n, "Dobrze się czjesz?");
        k.WyslijSMS(n, "*czujesz");
        n.CzytajSMS();
        
        OperatorGSM operatorGSM = new OperatorGSM();
        Komorka K1=new Komorka(3141231);
        Komorka K2 = new Komorka(123412312);
        operatorGSM.Rejestruj(K1);
        operatorGSM.Rejestruj(K2);
        operatorGSM.tablica_komorek[0].WyslijSMS1(operatorGSM, operatorGSM.tablica_komorek[1].Numer, "siema");
        operatorGSM.tablica_komorek[1].CzytajSMS();
        operatorGSM.tablica_komorek[1].WyslijSMS1(operatorGSM, operatorGSM.tablica_komorek[0].Numer, "Hejka");
        operatorGSM.tablica_komorek[0].CzytajSMS();
        operatorGSM.tablica_komorek[1].WyslijSMS1(operatorGSM, 123123124123, "OK");
        

      
    }
    }


