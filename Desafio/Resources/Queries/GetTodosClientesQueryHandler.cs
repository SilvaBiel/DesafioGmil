using Desafio.Context;
using Desafio.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Desafio.Resources.Queries
{
    public class GetTodosClientesQueryHandler : IRequestHandler<GetTodosClientesQuery, IEnumerable<Cliente>>
    {
        private readonly AppDbContext _context;

        public GetTodosClientesQueryHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Cliente>> Handle(GetTodosClientesQuery request, CancellationToken cancellationToken)
        {
            return await _context.Clientes.ToListAsync();
        }
    }
}
