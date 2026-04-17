using Core.ERP.Retail.Application.Interfaces;

namespace Core.ERP.Retail.API.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        // Simulamos los datos que en el futuro sacaremos del Token JWT
        public string? UserId => "user-cajero-001";
        public string? Role => "StoreCashier";

        public List<Guid> GetAllowedLocations()
        {
            // Simulamos el ID de la tienda física en la que está parado el cajero
            return new List<Guid>
            {
                Guid.Parse("11111111-1111-1111-1111-111111111111")
            };
        }

        public bool IsSuperAdmin() => false;
    }
}