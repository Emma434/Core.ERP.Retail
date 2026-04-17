using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ERP.Retail.Domain.Enums;

namespace Core.ERP.Retail.Domain.Entities
{
    public class InventoryTransfer
    { 
        public Guid Id { get; set; }
        public Guid SourceLocationId { get; set; }
        public TransferStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? SentAt { get; set; }
        public DateTime? ReceiveAt { get; set; }
    }
}
