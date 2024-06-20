using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDonate.Core.Models
{
    public class User(
        Guid id,
        string firstName,
        string lastName,
        string email,
        string passwordHash)
        : BaseEntity(id)
    {
        public string FirstName { get; } = firstName;
        public string LastName { get; } = lastName;
        public string Email { get; } = email;
        public string PasswordHash { get; } = passwordHash;
        public ICollection<Card> Cards { get; set; }
    }
}
