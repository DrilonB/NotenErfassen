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
            var note = Note.CreateNote();
            Noten.Add(note);
        }


        public void ListNoten()
        {
            foreach (var note in Noten)
            {
              
                var ausgabe = note.AusgabeNote();
                Console.WriteLine(ausgabe);
            }
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
