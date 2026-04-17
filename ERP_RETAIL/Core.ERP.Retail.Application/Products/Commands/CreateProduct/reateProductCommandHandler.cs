using Core.ERP.Retail.Application.Interfaces;
using Core.ERP.Retail.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ERP.Retail.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        // Inyectamos la interfaz de la base de datos, NUNCA la implementación directa de EF Core
        public CreateProductCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            // 1. Instanciar la entidad pura del Dominio
            var entity = new Product
            {
                Id = Guid.NewGuid(),
                SKU = request.SKU,
                Name = request.Name,
                BasePrice = request.BasePrice
            };

            // 2. Agregarla a la memoria del contexto
            _context.Products.Add(entity);

            // 3. Empujar los cambios a la base de datos
            await _context.SaveChangesAsync(cancellationToken);

            // 4. Devolver el nuevo ID
            return entity.Id;
        }
    }
}
