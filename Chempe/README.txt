Proyecto:
.NET 5 (multiplataforma: mac os, linux, iOS, Android, etc.)
.NET 5 (multiplataforma: desktop, web, mobile, etc.)

Versiones:
Framework: .NET 5
EF: 5.0.17


Ejemplos:

Hipotecalo (¡investigar!)
https://www.hipotecalo.com/

--

MiCheque


----
Guía YT espectacular: https://www.youtube.com/watch?v=uXwmyuvrn1E&list=PL6n9fhu94yhVm6S8I2xd6nYz2ZORd7X2v&index=15&ab_channel=kudvenkat

----
Deployear bd (Code first):

Package Manager Console (seleccionar default project: Domain)

EF Entity framework -> Code first
1) 
add-migration initial

2) 
update-database


----
Terminología:

User_client - Usuario cliente, solicitante del crédito
User_investor - Usuario inversor, prestador de capital
Pledge - Empeño, pignoración
Pledge_status - Estado del empeño
Warrant - Garantía, bien prendedado
Request - Solicitud del crédito por parte del cliente
Approval - Aprobación del crédito por parte de un usuario de Chempeño
Acceptance - Aceptación del crédito por parte del cliente
Assignment - Asignación del crédito a un usuario inversor


Tengo que pedir factura de compra para oficializar los datos relevantes del Bien:
- Fecha de compra
- Antiguedad

=> Calcular la amortización y valor razonable de mercado.

----
Orden del proceso:

1 Request
2 Approval
3 Acceptance
4 Assignment

----
Cuando una entidad nueva (clase):
- Domain
- Service
- Startup.cs -> Registrar service
- Context -> DbSet
- DTOs
- Utls -> MapperConfiguration -->  dto_person = Utls.mapper.Map<DTO_Person>(person);

----
Conceptos importantes:

Primary_coupon_rate: interés del cupón primario, cota máxima de recargo permitido a los inversores (de donde sale la ganancia de Chempe).
Secondary_coupon_rate: interés del cupón secundario, recargo del inversor ganador.


----
Condiciones del préstamo al cliente:

Loan_amount: Importe prestado y a devolver
Secondary_coupon_rate: recargo a pagar
Loan_term: Tiempo de devolución (1, 2 o 3 meses)
Warrant: Bien prendado

