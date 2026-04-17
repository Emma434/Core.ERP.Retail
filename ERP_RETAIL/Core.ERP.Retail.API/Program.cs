using Core.ERP.Retail.API.Services;
using Core.ERP.Retail.Application.Interfaces; 
using Core.ERP.Retail.Infrastructure.Data;
using Core.ERP.Retail.Application.Products.Commands.CreateProduct;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1. Infraestructura (Base de datos)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Dependencias Propias
builder.Services.AddScoped<ICurrentUserService, CurrentUserService>();
builder.Services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());

// 3. CQRS (MediatR) 
builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(CreateProductCommand).Assembly));

// 4. Controladores y Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// ====================================================
// PUNTO DE NO RETORNO: CONSTRUIR LA APLICACIÓN
// ====================================================
var app = builder.Build();


// ====================================================
// FASE 2: EL PIPELINE HTTP (app)
// Aquí configuramos el tráfico de red
// ====================================================

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); // Mapea las rutas a tus [ApiController]

app.Run();