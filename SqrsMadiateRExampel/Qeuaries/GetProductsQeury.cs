using CqrsMadiatRExampel.Models;
using MediatR;

namespace SqrsMadiateRExampel.Qeuaries
{
    public record GetProductsQeury : IRequest<IEnumerable<Product>> { }
   
}
