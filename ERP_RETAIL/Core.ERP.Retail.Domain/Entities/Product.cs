using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ERP.Retail.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public decimal BasePrice { get; set; }

    }
}
