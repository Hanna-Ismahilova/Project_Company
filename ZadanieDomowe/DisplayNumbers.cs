using System;
using System.Collections.Generic;
using System.Text;

namespace ZadanieDomowe
{
    public class DisplayNumbers
    {
        public static void DisplayNumFromOneToThousand()
        {
            //---1.1 Kazdy w nowej linii---//
            for (int number = 0; number <= 1000; number++)
            {
                Console.WriteLine("Line: " + number);
            }

            //---1.2 Kazdy w tej samej linii---//
            for (int number = 0; number <= 1000; number++)
            {
                Console.Write("Line: " + number);
            }
        }
    }
}
