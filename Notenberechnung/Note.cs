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
            Console.WriteLine("Note eingeben");
            note.Value = ConsoleHelper.ReadDecimal();
            note.Datum = ConsoleHelper.DatumErfasser();
            return note;

        }
    }
}
