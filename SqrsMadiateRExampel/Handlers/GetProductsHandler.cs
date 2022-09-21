using MediatR;
using SqrsMadiateRExampel.Qeuaries;

namespace SqrsMadiateRExampel.Handlers
{
    public class GetProductsHandler : IRequestHandler<GetProductsQeury, IEnumerable<Product>>
    {
        private readonly FakeDataStore _fakeDataStore;
        public GetProductsHandler(FakeDataStore fake) => _fakeDataStore = fake;
        public  async Task<IEnumerable<Product>> Handle(GetProductsQeury request, CancellationToken cancellationToken)
        {
            return await _fakeDataStore.GetProductsAll();
        }
    }
}
