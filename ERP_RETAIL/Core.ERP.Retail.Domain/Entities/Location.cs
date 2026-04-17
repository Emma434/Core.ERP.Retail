using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ERP.Retail.Domain.Enums;
//using Core.ERP.Retail.Domain

namespace Core.ERP.Retail.Domain.Entities
{
    public class Location
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public LocationType Type { get; set; }
    }
}
