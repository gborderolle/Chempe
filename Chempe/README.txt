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

Person_client - Usuario cliente, solicitante del crédito
Person_investor - Usuario inversor, prestador de capital
Person_user - Usuario de Chempe, administrativo
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

----

Inversores para desarrollar el negocio:
- Gonzalo Mesorio (UruIT, MiCheque.uy).
- Vinicius Duarte (CGM&A CGM, inConert), contacto junto a Diego Corubolo.
CGM&A: líderes en cobranzas, puede servir el perfil de empresas para cobrar las garantías.


----
Dificultades a superar:
- Ser preferencia en elección de créditos (superar a los "SF: sola firma"). --> Mejorar tasas de interés (el SF tiene el mayor riesgo => tasas más altas).
- Acietar operativa logística y legal de cobra de garantías (tvs, aires acondicionados, autos).
--> La asociación es clave.

- Usar eTickets (obligatorios), los QR para validar la compra. Pedir foto del QR aparte de la factura misma.


----

Definición de Casa de empeño de ChatGRP:
https://beta.openai.com/playground/p/default-chat?model=text-davinci-003
Una casa de empeño es un negocio que ofrece préstamos al por menor con el título de propiedad utilizado como garantía para los préstamos.

https://chat.openai.com/chat
Sí, sé lo que es una casa de empeño. Una casa de empeño es una empresa que presta dinero en efectivo a cambio de que la persona entregue un objeto de valor como garantía. La persona puede recuperar su objeto pagando el préstamo más los intereses acordados en un plazo determinado. Si la persona no paga el préstamo a tiempo, la casa de empeño puede vender el objeto para recuperar su dinero prestado.

--