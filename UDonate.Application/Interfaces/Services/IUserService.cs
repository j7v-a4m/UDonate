using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDonate.Application.DTOs;

namespace UDonate.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<string> Login(string email, string password);
        Task Register(UserDTO user);
    }
}
