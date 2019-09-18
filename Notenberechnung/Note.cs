using System;
using System.Collections.Generic;
using System.Text;

namespace Notenberechnung
{
    class Note
    {
        public decimal Value { get; set; }
        public DateTime Datum { get; set; }



        public static Note CreateNote()
        {
            var note = new Note();
            Console.WriteLine("Note eingeben\n");
            note.Value = ConsoleHelper.ReadDecimal();
            note.Datum = ConsoleHelper.DatumErfasser();
           
            return note;

        }

        public string AusgabeNote()
        {
            return this.Value.ToString() + " " + this.Datum.ToString() + "\n";
        }
    }
}
