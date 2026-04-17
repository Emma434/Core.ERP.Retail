using Core.ERP.Retail.Application.Products.Commands.CreateProduct;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Core.ERP.Retail.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        // Inyectamos MediatR, NUNCA el DbContext
        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductCommand command)
        {
            // El controlador no sabe cómo se crea un producto. 
            // Solo se lo lanza a MediatR y espera el resultado (el nuevo ID).
            var productId = await _mediator.Send(command);

            // Devolvemos un HTTP 200 OK con el ID del producto creado.
            // (Nota Senior: Lo ideal en REST es un HTTP 201 CreatedAtAction, pero lo dejaremos en OK hasta que construyamos la consulta GET).
            return Ok(productId);
        }
    }
}
