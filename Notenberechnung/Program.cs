using System;
using System.Collections.Generic;

namespace Notenberechnung
{
    class Program
    {
        List<Fach> faecher = new List<Fach>();
        static void Main(string[] args)
        {
            new Program().Start();
           
        }
        public void Start()
        {

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



                        Console.Write("In welchem Fach möchten Sie ihre Noten bearbeiten?");
                        foreach (var Fach in faecher)
                        {
                            Console.WriteLine(Fach.Name);
                        }
                        var inputF = Console.ReadLine();
                        Console.Write("[1] Note hinzufügen");
                        Console.Write("[2] Noten sehen\n");
                        Console.Write("[3] Note löschen");
                        //-----------------------------------------------------------------------------------------------------------
                        var setS = Console.ReadLine();
                        int setI = Convert.ToInt32(setS);
                        switch (setI)
                        {


                            case 1:

                                Note.CreateNote();

                                    break;


                            case 2:






                                foreach (var Fach in faecher)
                                {
                                    if (inputF.Equals(Fach.Name))
                                    {
                                        Fach.ListNoten();

                                        break;
                                    }

                                }
                                break;
                            case 3:

                                break;
                        }


                        //-----------------------------------------------------------------------------------------------------------

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
