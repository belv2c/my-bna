using System;

namespace my_bna.Models
{
    public class Note
    {
        public int Note_Id { get; set; }
        public int User_Id { get; set; }
        public string NoteTitle { get; set; }
        public DateTime NoteDate { get; set; }
        public string NoteBody { get; set; }
        public bool IsPublic { get; set; }
    }
}