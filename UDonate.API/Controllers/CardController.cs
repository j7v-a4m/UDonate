using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UDonate.API.Contracts.Card;
using UDonate.Application.Interfaces.Services;

namespace UDonate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardService _cardService;

        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }

        [HttpPost]
        public async Task<IActionResult> AddCard([FromForm] CardRequest request)
        {
            //await _cardService.AddCard(request);
            return Ok(request);
        }
    }
}
