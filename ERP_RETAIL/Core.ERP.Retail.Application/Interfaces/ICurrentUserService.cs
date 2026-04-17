using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ERP.Retail.Application.Interfaces
{
    public interface ICurrentUserService
    {
        string? UserId { get; }
        string? Role { get; }
        List<Guid> GetAllowedLocations();
        bool IsSuperAdmin();
    }
}
