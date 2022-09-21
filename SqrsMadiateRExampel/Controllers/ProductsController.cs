using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SqrsMadiateRExampel.Commands;
using SqrsMadiateRExampel.Handlers;
using SqrsMadiateRExampel.Notifications;
using SqrsMadiateRExampel.Qeuaries;

namespace SqrsMadiateRExampel.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ISender _sender;
        private readonly IPublisher _publisher;
        public ProductsController(ISender sender,IPublisher publisher)
        {
            _sender = sender;
            _publisher = publisher;
        } 

        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            var tresult =await  _sender.Send(new GetProductsQeury());
            return Ok(tresult);
        }

        [HttpGet("{id:int}", Name = "GetById")]
        public async Task<ActionResult> GetById(int id)
        {
            var product = await _sender.Send(new GetProductByIdQuery(id));
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct([FromBody]Product product)
        {
           var newProductToReturn= await _sender.Send(new AddProductCommand(product));
            await _publisher.Publish(new ProductAddNotifications(newProductToReturn));

            return CreatedAtRoute("GetproductById",
                new { id = newProductToReturn.Id }, newProductToReturn);
        }
    }
}
