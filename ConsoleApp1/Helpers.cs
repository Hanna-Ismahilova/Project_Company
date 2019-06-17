using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public class Helpers
    {

        public static void DisplayResult(int temperatureDisplay, bool isONDisplay, string nameDisplay)
        {
            Console.WriteLine($"To jest piekarnik o nazwie {nameDisplay}");
            Console.WriteLine($"Temperatura piekarnika to {temperatureDisplay}");
            Console.WriteLine($"Piekarnik jest wlaczony {isONDisplay}");
        }
    }
}
