using System.Collections.Generic;
using System.Threading.Tasks;
using UsersApi.Models;

namespace UsersApi.Entities
{
    public interface IUserEntity
    {
        Task<User> Get(int id);
        Task<IEnumerable<User>> GetAll();
        Task Add(User _user);
        Task Delete(int id);
        Task Update(User _user);
    }
}