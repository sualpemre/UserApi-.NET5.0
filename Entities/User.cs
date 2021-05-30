
using System;
using System.Text.Json.Serialization;
namespace UsersApi.Models
{
    public class User
    {
        public int Id{get;set;}
        public string UserName{get;set;}
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public string Email{get;set;}

        [JsonIgnore]
        public string Password{get;set;}
        public DateTime DateCreated{get;set;}
    }
}