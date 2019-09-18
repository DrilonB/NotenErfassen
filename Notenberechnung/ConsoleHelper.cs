using System;
using System.Collections.Generic;
using System.Text;

namespace Notenberechnung
{
    class ConsoleHelper
    {

        public static int ReadInt()
        {
            while (true)
            {


                var line = Console.ReadLine();
                int lineInt;
                bool parsed = int.TryParse(line, out lineInt);
                if (parsed)
                {
                    return lineInt;
                }
                else
                {
                    Console.Write("Nicht Zugelassen\n");

                }
            }
        }


        public static decimal ReadDecimal()
        {
            while (true)
            {


                var line = Console.ReadLine();
                decimal lineDecimal;
                bool parsed = decimal.TryParse(line, out lineDecimal);
                if (parsed)
                {
                    return lineDecimal;
                }
                else
                {
                    Console.Write("Nicht Zugelassen\n");

                }
            }
        }

        public static DateTime DatumErfasser()
        {
            Console.Write("Jahr eingeben\n");
            var year = ReadInt();
            Console.Write("Monat eingeben\n");
            var month = ReadInt();
            Console.Write("Tag eingeben\n");
            var day = ReadInt();

            return new DateTime(year, month, day);
        }

       
    }
}
