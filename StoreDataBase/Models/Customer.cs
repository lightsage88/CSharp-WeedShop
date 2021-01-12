using System;
using StoreDataBase.Models;
namespace StoreDataBase.Models
{
    public class Customer : IUser {
        public int Id {get; set;}
        public string Username {get; set;}
        public string Password {get; set;}

        public Customer(int _Id, string _Username, string _Password)
        {
            Id = _Id;
            Username = _Username;
            Password = _Password;
        }

    }
}