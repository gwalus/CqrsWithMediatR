using CqrsMediatorExample.Models;
using MediatR;

namespace CqrsMediatorExample.Commands
{
    public record AddProductCommand(Product Product) : IRequest<Product>;    
}
