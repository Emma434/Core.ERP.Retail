using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Core.ERP.Retail.Application.Products.Commands.CreateProduct
{
    // IRequest<Guid> significa que cuando este comando termine, devolverá el ID del producto creado.
    public record CreateProductCommand(string SKU, string Name, decimal BasePrice) : IRequest<Guid>;
}