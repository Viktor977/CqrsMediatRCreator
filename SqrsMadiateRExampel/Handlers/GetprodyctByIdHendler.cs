using CqrsMadiatRExampel.Models;
using MediatR;
using SqrsMadiateRExampel.Qeuaries;

namespace SqrsMadiateRExampel.Handlers
{
    public class GetprodyctByIdHendler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly FakeDataStore _fakeDataStore;
        public GetprodyctByIdHendler(FakeDataStore fake)
        {
           _fakeDataStore= fake;
        }

        public  async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _fakeDataStore.GetById(request.Id);
            return product;               
        }
    }
}
