namespace LibraryManagement
{
    public class Book
    {
        private int _id;
        private string _title;
        private string _author;
        private string _isbn;
        
        public Book(int id, string title, string author, string isbn)
        {
            _id = id;
            _title = title;
            _author = author;
            _isbn = isbn;
        }
        
        public int GetId()
        {
            return _id;
        }
        
        public string GetTitle()
        {
            return _title;
        }
        
        override public string ToString()
        {
            return _title + " by " + _author + " (" + _isbn + ")";
        }
    }
}