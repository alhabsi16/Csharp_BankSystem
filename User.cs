﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BankSystem
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Account> Accounts { get; set; }

        public User()
        {
            Accounts = new List<Account>();
        }
        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            Accounts = new List<Account>();
        }
        private string HashPassword(string password)
        {
            return password;
        }
    }
}
