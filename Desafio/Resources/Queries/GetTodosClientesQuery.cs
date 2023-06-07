using Desafio.Models;
using MediatR;

namespace Desafio.Resources.Queries
{
    public class GetTodosClientesQuery : IRequest<IEnumerable<Cliente>>
    {
    }
}
