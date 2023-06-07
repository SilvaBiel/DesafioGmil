using Desafio.Context;
using Desafio.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Desafio.Resources.Queries
{
    public class GetClienteByIdQueryHandler : IRequestHandler<GetClienteByIdQuery, Cliente>
    {
        private readonly AppDbContext _context;
        public GetClienteByIdQueryHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Cliente> Handle(GetClienteByIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Clientes.FirstOrDefaultAsync(x => x.ClienteId == request.Id, cancellationToken);
        }
    }
}
