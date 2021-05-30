using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsersApi.Entities;
using UsersApi.Models;

namespace UsersApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController: ControllerBase
    {
        private readonly IUserEntity _userEntity;

        public UserController(IUserEntity userEntity)
        {
            _userEntity = userEntity;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id){
            var user = await _userEntity.Get(id);
            if(user == null) {
                 return NotFound();
            } 
            return Ok(user);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers(){
            var users = await _userEntity.GetAll();
            return Ok(users);
        }

        
        [HttpPost]
        public async Task<ActionResult> CreateUser(User _user){
            User user = new(){
                UserName = _user.UserName,
                FirstName = _user.FirstName,
                LastName = _user.LastName,
                Email = _user.Email,
                Password = _user.Password , 
                DateCreated = DateTime.Now,
                isAdmin = _user.isAdmin
            };

            await _userEntity.Add(user);

            return Ok();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int id){
            await _userEntity.Delete(id);

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateUser(int id , User _user){
            User user = new(){
                UserName = _user.UserName,
                FirstName = _user.FirstName,
                LastName = _user.LastName,
                Email = _user.Email,
                Password = _user.Password , 
                DateCreated = DateTime.Now,
                isAdmin = _user.isAdmin
            };

            await _userEntity.Update(user);
            return Ok();
        }
    }
}