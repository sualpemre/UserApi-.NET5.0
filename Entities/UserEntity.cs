using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UsersApi.Data;
using UsersApi.Models;

namespace UsersApi.Entities
{
    public class UserEntity : IUserEntity
    {
        private readonly IDataContext _context; 
        public UserEntity(IDataContext _context)
        {
            this._context = _context;
        }

        public async Task Add(User _user)
        {
            _context.Users.Add(_user);
            await _context.SaveChangesAsync();
            
        }

        public async Task Delete(int id)
        {
            var item = await _context.Users.FindAsync(id);
            if(item==null) {
                throw new NullReferenceException();
            } 
            _context.Users.Remove(item);
            await _context.SaveChangesAsync();
        }

        public async Task<User> Get(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<IEnumerable<User>> GetAll()
        {

            return await _context.Users.ToListAsync();
        }

        public async Task Update(User _user)
        {
            var item = await _context.Users.FindAsync(_user.Id); 
            if(item==null) {
                throw new NullReferenceException();
            } 
            item.UserName = _user.UserName;
            item.FirstName = _user.FirstName;
            item.LastName = _user.LastName;
            item.Email = _user.Email;
            item.Password = _user.Password;
            item.isAdmin = _user.isAdmin;
            await _context.SaveChangesAsync();
        }
    }
}