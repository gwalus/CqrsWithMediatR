using CqrsMediatorExample.Models;
using MediatR;

namespace CqrsMediatorExample.Queries
{
    public record GetProductsQuery : IRequest<IEnumerable<Product>>;    
}
