using System;
using System.Collections.Generic;

namespace LibraryManagement
{
    public class Accounts
    {
        private readonly List<Account> _users;

        public Accounts()
        {
            _users = new List<Account>();
            _users.Add(new Account(1, "Atham", AccountRole.Admin));
            _users.Add(new Account(2, "Jushkin", AccountRole.Librarian));
            _users.Add(new Account(3, "Alan", AccountRole.Student));
        }
        
        public Account GetAccount(int id, Account account)
        {
            if (account.IsAdmin())
            {
                return _users.Find(x => x.GetId() == id);
            } else 
            {
                throw new Exception("You are not authorized to perform this action");
            }
        }
        
        public List<Account> GetAccounts(Account account)
        {
            if (account.IsAdmin())
            {
                return _users;
            } else 
            {
                throw new Exception("You are not authorized to perform this action");
            }
        }
        
        public Account GetAccountByName(string username)
        {
            return _users.Find(x => x.GetName() == username);
        }
        
        public void AddAccount(string name, Account account)
        {
            if (account.GetRole() == AccountRole.Admin || account.GetRole() == AccountRole.Librarian)
            {
                _users.Add(new Account(_users.Count + 1, name, AccountRole.Student));
            }
            else
            {
                throw new Exception("You're not allowed to create user");
            }
        }
        
        public void RemoveAccount(int id, Account account)
        {
            if (account.GetRole() == AccountRole.Admin)
            {
                _users.Remove(GetAccount(id, account));
            }
            else
            {
                throw new Exception("You are not allowed to remove this account");
            }
        }
    }
}