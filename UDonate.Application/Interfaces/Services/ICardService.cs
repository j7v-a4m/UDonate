using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDonate.Application.DTOs;

namespace UDonate.Application.Interfaces.Services
{
    public interface ICardService
    {
        Task AddCard(CardDTO card);
    }
}
