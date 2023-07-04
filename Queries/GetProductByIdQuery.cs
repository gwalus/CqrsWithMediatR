using CqrsMediatorExample.Models;
using MediatR;

namespace CqrsMediatorExample.Queries
{
    public record GetProductByIdQuery(int Id) : IRequest<Product>;
}
