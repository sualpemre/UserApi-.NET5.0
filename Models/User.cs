
using System;
namespace UsersApi.Models
{
    public class User
    {
        public int Id{get;set;}
        public string UserName{get;set;}
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public string Email{get;set;}
        public string Password{get;set;}
        public bool isAdmin{get;set;}
        public DateTime DateCreated{get;set;}
    }
}