namespace SimpleCalendar.SDK.Notes
{
    using System;
    using SimpleCalendar.SDK.Extensions;

    public class NoteOfTheDay
    {
        public struct Note
        {
            public string NoteContent;
            public bool IsImportant;
            public int AddNoteToWhichDay;
        }

       /* public Note AddNote(string NContent,bool IsIm)
        {
            var newNote = new Note
            {
                NoteContent = NContent, IsImportant = IsIm
            };
      
            return newNote;
        }
       */

        public Note NewNote(string NContent,bool IsIm, int AddNoteToWhichD) => new Note 
        {
            NoteContent = NContent,
            IsImportant = IsIm,
            AddNoteToWhichDay = AddNoteToWhichD
        };

        public Note AddNote()
        {
            _ = new ConsoleChainer()
                .RetrieveInput("Do ktorego dnia chcesz dodac notke: ", out var whichDay)
                .BreakLine()
                .RetrieveInput("Wpisz zawartosc notki: ", out var noteContent)
                .BreakLine()
                .RetrieveInput("Czy chcesz oflagowac notke jako wazna(y/n)?", out var isImportant)
                .BreakLine();

            return NewNote(noteContent, bool.Parse(isImportant), int.Parse(whichDay));
        }
    }
}