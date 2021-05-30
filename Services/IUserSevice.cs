using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using UsersApi.Entities;

namespace UsersApi.Services
{
    public interface IUserSevice
    {
         AuthenticateResponse Authenticate(AuAuthenticateRequest model);
         IEnumarable<User> GetAll();
         User GetById(int id);
    }
}