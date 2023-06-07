using Desafio.Context;
using Desafio.Models;
using MediatR;

namespace Desafio.Resources.Commands
{
    public class ClienteCreateCommandHandler : IRequestHandler<ClienteCreateCommand, Cliente>
    {
        private readonly AppDbContext _context;

        public ClienteCreateCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Cliente> Handle(ClienteCreateCommand request, CancellationToken cancellationToken)
        {
            var cliente = new Cliente();
            cliente.ClienteName = request.ClienteName;
            cliente.ClienteEmail = request.ClienteEmail;
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }


    }
}
