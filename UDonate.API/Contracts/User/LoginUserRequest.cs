using System.ComponentModel.DataAnnotations;

namespace UDonate.API.Contracts.User
{
    public record LoginUserRequest(
        [Required] string email,
        [Required] string password
        );
}
