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
                    Console.Write("Nicht Zugelassen");

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
                    Console.Write("Nicht Zugelassen");

                }
            }
        }

        public static DateTime DatumErfasser()
        {
            Console.Write("Jahr eingeben");
            var year = ReadInt();
            Console.Write("Monat eingeben");
            var month = ReadInt();
            Console.Write("Tag eingeben");
            var day = ReadInt();

            return new DateTime(year, month, day);
        }
    }
}
 yx yx yx  yx x x xy x y xy xy x y xxy yxyx yx xx yxy xx y xy x xy  x