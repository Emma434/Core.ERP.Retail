using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ERP.Retail.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.ERP.Retail.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; }
        DbSet<Location> Locations { get; }
        DbSet<StockNode> StockNodes { get; }
        DbSet<InventoryTransfer> InventoryTransfers { get; }
        DbSet<InventoryTransferLine> InventoryTransferLines { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}