using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public class Sklep
    {
        public List<Piekarnik> piekarniks;

        private List<Klient> klients;

        public Sklep()
        {
            piekarniks = new List<Piekarnik>();
            klients = new List<Klient>();
        }

        
        public Sklep(List<Piekarnik> piekarniksList)
        {
            piekarniks = piekarniksList;
        }



        public void PrintPiekarniks()
        {
            //for (int i = 1; i < piekarniks.Count; i++)
            //{
            //    Console.WriteLine($"{piekarniks[i].name},{piekarniks[i].tempreture}");
            //}

            foreach (var item in piekarniks)
            {
                Console.WriteLine($"{item.name},{item.tempreture}");
            }

            int i = 0;
       
            do
            {
                Console.WriteLine($"{piekarniks[i].name},{piekarniks[i].tempreture}");
                i++;

            } while (i < piekarniks.Count);
        }

      
        public void KlientWchodziDoSklepu(Klient klient)
        {
            klients.Add(klient);
        }

        public void KlientWchodziDoSklepu(string imie, string nazwisko, double stanKonta)
        {
            Klient klient = new Klient();
            klient.klientImie = imie;
            klient.klientNazwisko = nazwisko;
            klient.accountStatus = stanKonta;
            klients.Add(klient);
        }

        public void KlientWychodziZeSklepu(Klient klient)
        {
            klients.Remove(klient);

        }

        public void KlientWychodziZeSklepu(int id)
        {
            
            Klient klient = new Klient();

            foreach (var item in klients)
            {
                if (item.Id == id)
                {
                    klient = item;
                }
            }

            if (klient.Id != null)
            {
                klients.Remove(klient);
            }
        }
    }
}
