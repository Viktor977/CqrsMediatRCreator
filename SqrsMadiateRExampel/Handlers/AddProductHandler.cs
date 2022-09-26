using CqrsMadiatRExampel.Models;
using MediatR;
using SqrsMadiateRExampel.Commands;

namespace SqrsMadiateRExampel.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand, Product>
    {
        private readonly FakeDataStore fake;
        public AddProductHandler(FakeDataStore fake)
        {
            this.fake = fake;
        }

        public  async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await fake.AddProduct(request.product);
            return request.product;
        }
    }
}
