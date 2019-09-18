using System;
using System.Collections.Generic;
using System.Text;

namespace Notenberechnung
{
    class Fach
    {


      
        

        public string Name { get; set; }
        public List<Note> Noten { get; set; }

        public static Fach CreateFach()
        {
            var fach = new Fach();
            Console.WriteLine("Fach eingeben");
            fach.Name = Console.ReadLine();
            fach.Noten = new List<Note>();
            return fach;
                
        }

        public void AddNote()
        {
            var noteN = Note.CreateNote();
            Noten.Add(noteN);
        }


        public void ListNoten()
        {
            foreach (var note in Noten)
            {
              
                var ausgabe = note.AusgabeNote();
                Console.WriteLine(ausgabe);
            }
        }

        public static Note CreateNote()
        {
            var note = new Note();
            Console.WriteLine("Note eingeben");
            note.Value = ConsoleHelper.ReadDecimal();
            note.Datum = ConsoleHelper.DatumErfasser();
            Note.Add(note);
            return note;

        }





        /*
        public AddFach()
        {
            string Fach;
            return 
        }

        RemoveFach()
        {

        }
        */
    }
}
