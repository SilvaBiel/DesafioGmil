using Desafio.Models;
using MediatR;

namespace Desafio.Resources.Commands
{
    public class ClienteUpdateCommand : IRequest <Cliente>
    {
        public int ClienteId { get; set; }
        public string ClienteName { get; set; } = string.Empty;
        public string ClienteEmail { get; set; } = string.Empty;
    }
}
