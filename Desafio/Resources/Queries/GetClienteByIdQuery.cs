using Desafio.Models;
using MediatR;

namespace Desafio.Resources.Queries
{
    public class GetClienteByIdQuery : IRequest<Cliente>
    {
        public int Id { get; set; }
    }
}
