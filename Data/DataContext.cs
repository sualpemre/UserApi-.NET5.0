using Microsoft.EntityFrameworkCore;
using UsersApi.Models;
namespace UsersApi.Data
{
    public class DataContext:DbContext , IDataContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}