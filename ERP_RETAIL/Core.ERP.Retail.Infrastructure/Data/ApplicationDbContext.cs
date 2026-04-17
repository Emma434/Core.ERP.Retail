using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ERP.Retail.Application.Interfaces;
using Core.ERP.Retail.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Core.ERP.Retail.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Location> Locations => Set<Location>();
        public DbSet<StockNode> StockNodes => Set<StockNode>();
        public DbSet<InventoryTransfer> InventoryTransfers => Set<InventoryTransfer>();
        public DbSet<InventoryTransferLine> InventoryTransferLines => Set<InventoryTransferLine>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // AQUÍ APLICAMOS EL DISEÑO DE MONOLITO MODULAR
            // Separamos lógicamente las tablas por contexto de negocio

            // Contexto: Catálogo
            builder.Entity<Product>().ToTable("Products", "Catalog");

            // Contexto: Inventario y Nodos
            builder.Entity<Location>().ToTable("Locations", "Inventory");
            builder.Entity<StockNode>().ToTable("StockNodes", "Inventory");

            // Contexto: Logística (Motor de Transferencias)
            builder.Entity<InventoryTransfer>().ToTable("InventoryTransfers", "Logistics");
            builder.Entity<InventoryTransferLine>().ToTable("InventoryTransferLines", "Logistics");

            // --- Configuraciones adicionales (Fluent API) ---
            // Asegurarse de que un producto no pueda estar duplicado en una misma locación
            builder.Entity<StockNode>()
                .HasIndex(sn => new { sn.ProductID, sn.LocationID })
                .IsUnique();
        }
    }
}
