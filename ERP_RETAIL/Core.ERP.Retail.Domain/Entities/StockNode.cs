using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Core.ERP.Retail.Domain

namespace Core.ERP.Retail.Domain.Entities
{
    public class StockNode
    {
        public Guid Id { get; set; }
        public Guid ProductID { get; set; }
        public Guid LocationID { get; set; }
    }
}
