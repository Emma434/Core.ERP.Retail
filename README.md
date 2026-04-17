# Core.ERP.Retail
ERP de gestión de inventario y ventas para local comercial con N-tiendas. Desarrollado con .NET 8, C# y SQL Server, enfocado en el aislamiento de datos (Data Isolation).

# Core.ERP.Retail - Sistema de Gestión Comercial (Monolito Modular)

Core.ERP.Retail es el motor backend de un sistema de planificación de recursos empresariales (ERP) diseñado para el sector retail. Este proyecto está construido bajo los principios de **Clean Architecture** y opera como un **Monolito Modular**, asegurando alta cohesión interna y bajo acoplamiento entre los dominios del negocio (Catálogo, Inventario y Logística).

## 🏗️ Decisiones de Arquitectura y Patrones

Este proyecto no es un CRUD tradicional. Está diseñado para escalar y ser mantenible a largo plazo utilizando prácticas de la industria de nivel Enterprise:

* **Clean Architecture:** Separación estricta de responsabilidades (Domain, Application, Infrastructure, API). El dominio es agnóstico a cualquier tecnología externa.
* **Patrón CQRS (Command Query Responsibility Segregation):** Implementado a través de `MediatR`. Las intenciones de mutación de estado (Commands) están físicamente separadas de las operaciones de lectura (Queries), permitiendo escalar y optimizar cada lado de forma independiente.
* **Pipeline Behaviors (Cross-Cutting Concerns):** Uso de la tubería de MediatR para inyectar comportamientos transversales. La validación de entrada se maneja de forma automática y centralizada usando `FluentValidation` antes de que los comandos alcancen la lógica de negocio.
* **Monolito Modular en Base de Datos:** Uso de Entity Framework Core con separación explícita de esquemas en SQL Server (`Catalog`, `Inventory`, `Logistics`) para prevenir el cruce accidental de fronteras de datos y preparar el sistema para una eventual separación en microservicios si el negocio lo demanda.
* **Thin Controllers:** La capa de API actúa puramente como una interfaz de transporte HTTP. Los controladores no contienen lógica de negocio, simplemente delegan la ejecución a la capa de Aplicación.

## 🚀 Hitos Técnicos Actuales

- [x] Configuración del Core Domain y abstracciones base.
- [x] Implementación de EF Core con inyección de dependencias segura.
- [x] Migraciones y materialización de esquemas modulares en SQL Server.
- [x] Flujo completo CQRS para el módulo de Catálogo (Creación de Productos).
- [x] Intercepción de comandos mediante Validation Pipeline Behavior.

## 💻 Stack Tecnológico
* **.NET 8** (Web API)
* **C# 12**
* **Entity Framework Core**
* **SQL Server**
* **MediatR**
* **FluentValidation**
