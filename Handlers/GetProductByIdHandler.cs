using CqrsMediatorExample.Models;
using CqrsMediatorExample.Queries;
using CqrsMediatorExample.Storage;
using MediatR;

namespace CqrsMediatorExample.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly FakeDataStore _fakeDataStore;

        public GetProductByIdHandler(FakeDataStore fakeDataStore)
        {
            _fakeDataStore = fakeDataStore;
        }

        public Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return _fakeDataStore.GetProductById(request.Id);
        }
    }
}
