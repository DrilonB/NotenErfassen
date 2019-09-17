using System;
using System.Collections.Generic;

namespace Notenberechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fach> faecher = new List<Fach>();
           
            bool exit = false;

            do
            {


                Console.WriteLine("Was moechten Sie bearbeiten?\n");
                Console.WriteLine("Faecher");
                Console.WriteLine("Noten");
                switch (Console.ReadLine())
                {
                    case "Faecher":

                        var fach = Fach.CreateFach();

                        faecher.Add(fach);
                        
                        break;
                    case "Noten":
                        foreach (var Fach in faecher)
                        {
                            Console.WriteLine(Fach.Name);   
                        }
                        Console.Write("Welchem Fach möchten Sie eine Note zuteilen?");
                        var input = Console.ReadLine();
                        if (input = faecher)
                        {

                        }


                        break;
                    case "exit":
                        exit = true;
                        break;
                }
            } while (!exit);


            //faecher.Remove(/*Fach eingabe*/);
            //fach.Noten.Remove(/*Ausgewählte Note*/{

            //});
            Console.Write("Beliebige Taste druecken...");
            Console.ReadKey();
        }
    }
}
