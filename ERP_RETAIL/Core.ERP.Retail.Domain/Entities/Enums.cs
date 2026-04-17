using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ERP.Retail.Domain.Enums
{
    public enum LocationType
    {
        Warehouse = 1,  // Bodega Central / Producción
        Store = 2,      // Tienda Física Permanente
        Event = 3       // Punto de Venta Temporal (Feria/Evento)
    }

    public enum TransferStatus
    {
        Draft = 1,      // El bodeguero está armando las cajas (Aún no sale)
        InTransit = 2,  // Las cajas están en la camioneta (Salió de Bodega, no llega al Evento)
        Completed = 3,  // El evento recibió las cajas e hizo check-in (Stock disponible en el Evento)
        Cancelled = 4   // Se canceló el envío
    }
}