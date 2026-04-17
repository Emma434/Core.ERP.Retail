using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ERP.Retail.Domain.Entities
{
    public class InventoryTransferLine
    {
        public Guid Id { get; set; }
        public Guid InventoryTransferId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantiy {  get; set; }
    }
}
