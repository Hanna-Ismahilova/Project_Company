﻿using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Piekarnik piekarnik1 = new Piekarnik();
            piekarnik1.name = "Samsung";
            piekarnik1.tempreture = 100;
            piekarnik1.isON = true;

            Piekarnik piekarnik2 = new Piekarnik()
            {
                isON = true,
                tempreture = 200,
                name = "Amica"
            };

          
            Helpers.DisplayResult(piekarnik1.tempreture, piekarnik1.isON, piekarnik1.name);

            Sklep biedronka = new Sklep();
            biedronka.piekarniks.Add(piekarnik1);
            biedronka.piekarniks.Add(piekarnik2);

            biedronka.PrintPiekarniks();
          

        







            piekarnik1.tempreture = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"To jest piekarnik o nazwie {piekarnik1.name}");
            Console.WriteLine($"Temperatura piekarnika to  {piekarnik1.tempreture}");
            Console.WriteLine($"Piekarnik jest wlaczony {piekarnik1.isON}");

            Console.ReadKey();
        }
    }
}