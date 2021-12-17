using System;

namespace LibraryManagement
{
    public class Account
    {
        private readonly int _id;
        private string _name;
        private AccountRole _role;
        
        public Account(int id, string name, AccountRole role)
        {
            _id = id;
            _name = name;
            _role = role;
        }

        public AccountRole AccountRole
        {
            get => default;
            set
            {
            }
        }

        public int GetId()
        {
            return _id;
        }
        
        public string GetName()
        {
            return _name;
        }
        
        public void SetName(string name)
        {
            if (name.Length > 0)
            {
                _name = name;
            } else
            {
                throw new ArgumentException("Name cannot be empty");
            }
        }

        public void SetRole(AccountRole role, Account account)
        {
            if (account.GetRole() == AccountRole.Admin)
            {
                _role = role;
            }
            else
            {
                throw new ArgumentException("Only admin can change role");
            }
        }

        public AccountRole GetRole ()
        {
            return _role;
        }
        
        public bool IsAdmin()
        {
            return _role == AccountRole.Admin || _role == AccountRole.Librarian;
        }
        
        public void SetRole (AccountRole role, AccountRole userRole)
        {
            if (userRole == AccountRole.Admin)
            {
                _role = role;
            } else
            {
                throw new ArgumentException("Only admin can change role");
            }
        }
    }
}