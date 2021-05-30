
using Microsoft.EntityFrameworkCore;
using UsersApi.Models;
namespace UsersApi.Data
{
    public class IDataContext
    {
        DbSet<User> Users {get;set;}
    }
}