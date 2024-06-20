using System.ComponentModel.DataAnnotations;

namespace UDonate.API.Contracts.Card
{
    public record CardRequest(
        [Required] string cardNum,
        [Required] string expireDate,
        [Required] string embosName,
        [Required] Guid ownerId
        );
}
