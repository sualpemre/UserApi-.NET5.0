using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UsersApi.Models;

namespace UsersApi.Data
{
    public interface IDataContext
    {
         DbSet<User> Users{get;set;}

         Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}