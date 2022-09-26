using CqrsMadiatRExampel.Models;
using MediatR;

namespace SqrsMadiateRExampel.Qeuaries
{
    public record GetProductByIdQuery(int Id):IRequest<Product>;
   
}
