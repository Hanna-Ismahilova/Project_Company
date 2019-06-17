using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public class Sklep
    {
        public List<Piekarnik> piekarniks;

        public Sklep()
        {
            piekarniks = new List<Piekarnik>();
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
        
    }
}
