using abstract_factory.Logic;
using abstract_factory.Logic.MercadoPago;
using abstract_factory.Logic.PagSeguro;

var pagSeguroService = new PaymentService(new PagSeguroFactory());
pagSeguroService.ProcessPayment("1234567890123456", 150);

Console.WriteLine();

var mercadoPagoService = new PaymentService(new MercadoPagoFactory());
mercadoPagoService.ProcessPayment("5234567890123456", 200);

Console.WriteLine();