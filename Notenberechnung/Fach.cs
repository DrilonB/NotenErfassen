using System;
using System.Collections.Generic;
using System.Text;

namespace Notenberechnung
{
    class Fach
    {


      
        

        public string Name { get; set; }
        public List<Note> Noten { get; } = new List<Note>();

        public static Fach CreateFach()
        {
            var fach = new Fach();
            Console.WriteLine("Fach eingeben\n");
            fach.Name = Console.ReadLine();
            return fach;
                
        }

        /// <summary>
        /// erzeugt eine neue Note
        /// </summary>
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
