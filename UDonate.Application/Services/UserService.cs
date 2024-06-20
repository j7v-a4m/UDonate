using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDonate.Application.DTOs;
using UDonate.Application.Interfaces.Services;

namespace UDonate.Application.Services
{
    internal class UserService : IUserService
    {
        public async Task<string> Login(string email, string password)
        {
            string token = "test-login-token";
            return token;
        }

        public Task Register(UserDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
