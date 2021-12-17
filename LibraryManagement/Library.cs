using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement
{
    public class Library
    {
        private List<Book> _books;
        
        public Library()
        {
            _books = new List<Book>();
        }

        public void AddBook(string title, string author, string isbn, Account account)
        {
            if (account.IsAdmin())
            {
                _books.Add(new Book(_books.Count + 1, title, author, isbn));
            }
            else
            {
                throw new Exception("You are not an admin");
            }
        }
        
        public void RemoveBook(int id, Account account)
        {
            if (account.IsAdmin())
            {
                _books.RemoveAll(x => x.GetId() == id);
            }
            else
            {
                throw new Exception("You are not an admin");
            }
        }
        
        // Getbook by id
        public Book GetBook(int id)
        {
            return _books.FirstOrDefault(book => book.GetId() == id);
        }
        
        public List<Book> GetBooks()
        {
            return _books;
        }
        
        // get a book by its _title
        public Book GetBookByTitle(string title)
        {
            return _books.FirstOrDefault(book => book.GetTitle() == title);
        }
        
    }
}