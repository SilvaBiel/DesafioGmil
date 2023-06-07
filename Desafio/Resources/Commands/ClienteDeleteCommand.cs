using Desafio.Models;
using MediatR;

namespace Desafio.Resources.Commands
{
    public class ClienteDeleteCommand : IRequest<Cliente>
    {
        public int ClienteId { get; set; }
    }
}
