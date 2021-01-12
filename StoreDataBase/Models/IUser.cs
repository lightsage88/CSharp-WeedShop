using System;
using StoreDataBase.Models;
namespace StoreDataBase.Models
{
    public interface IUser 
    {
        int Id {get; set;}
        string Username {get; set;}
        string Password {get; set;}
    } 
}