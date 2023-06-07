using Desafio.Context;
using Desafio.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Desafio.Resources.Commands
{
    public class ClienteDeleteCommandHandler: IRequestHandler<ClienteDeleteCommand, Cliente>
    {
        private readonly AppDbContext _context;

        public ClienteDeleteCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Cliente> Handle(ClienteDeleteCommand request, CancellationToken cancellationToken)
        {
            var cliente = await _context.Clientes.Where(a => a.ClienteId == request.ClienteId).FirstOrDefaultAsync();
            _context.Remove(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }
    }
}
