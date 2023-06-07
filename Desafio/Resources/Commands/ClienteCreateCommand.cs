using Desafio.Models;
using MediatR;

namespace Desafio.Resources.Commands
{
    public class ClienteCreateCommand : IRequest <Cliente>
    {
        public string ClienteName { get; set; }
        public string ClienteEmail { get; set; }
    }
}
