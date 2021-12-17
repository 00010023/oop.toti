using System;

namespace LibraryManagement
{
    public class Client
    {
        protected Account _account;
        protected Accounts _accounts;
        protected Library _library;

        public Client(string name = "Atham")
        {
            // Login time

            _accounts = new Accounts();

            if (_accounts.GetAccountByName(name) == null)
            {
                throw new Exception("Account not found, ask admin to register one!");
            }
            else
            {
                Console.WriteLine("Welcome to the library, {0}", _accounts.GetAccountByName(name).GetName());
                _account = _accounts.GetAccountByName(name);
            }
            

            
            
            // Initialize library
            _library = new Library();
            _library.AddBook("The Lord of the Rings", "J.R.R. Tolkien", "2342awefawef", _account);
            _library.AddBook("The Hobbit", "J.R.R. Tolkien", "43221323bhbj23bhbhfb", _account);
        }

        public Account Account
        {
            get => default;
            set
            {
            }
        }

        public Accounts Accounts
        {
            get => default;
            set
            {
            }
        }

        public Library Library
        {
            get => default;
            set
            {
            }
        }

        public void GetBooks()
        {
            for (int i = 0; i < _library.GetBooks().Count; i++)
            {
                Console.WriteLine(_library.GetBooks()[i].GetTitle());
            }
        }

        public void AddBook(string title, string author, string isbn)
        {
            _library.AddBook(title, author, isbn, _account);
        }
        
        public void RemoveBook(int id)
        {
            _library.RemoveBook(id, _account);
        }

        public void AddUser(string name)
        {
            _accounts.AddAccount(name, _account);
        }
        
        public void RemoveUser(int id)
        {
            _accounts.RemoveAccount(id, _account);
        }
        
        public void GetUser(int id)
        {
            _accounts.GetAccount(id, _account);
        }

        public void GetUsers()
        {
            for (var i = 0; i < _accounts.GetAccounts(_account).Count; i++)
            {
                Console.WriteLine(_accounts.GetAccounts(_account)[i].GetName());
            };
        }
    }
}