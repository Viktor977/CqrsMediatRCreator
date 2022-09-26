using CqrsMadiatRExampel.Models;
using MediatR;

namespace SqrsMadiateRExampel.Commands
{
    public record AddProductCommand(Product product) : IRequest<Product>;
    
}
