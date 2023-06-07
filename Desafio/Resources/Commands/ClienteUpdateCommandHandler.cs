using Desafio.Context;
using Desafio.Models;
using MediatR;

namespace Desafio.Resources.Commands
{
    public class ClienteUpdateCommandHandler: IRequestHandler<ClienteUpdateCommand, Cliente>
    {
        private readonly AppDbContext _context;

        public ClienteUpdateCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Cliente> Handle(ClienteUpdateCommand request, CancellationToken cancellationToken)
        {
            var cliente = _context.Clientes.Where(a => a.ClienteId == request.ClienteId).FirstOrDefault();
            if (cliente == null)
            {
                return default;
            }
            else
            {
                cliente.ClienteName = request.ClienteName;
                cliente.ClienteEmail = request.ClienteEmail;
                await _context.SaveChangesAsync();
                return cliente;
            }
        }
    }
}
