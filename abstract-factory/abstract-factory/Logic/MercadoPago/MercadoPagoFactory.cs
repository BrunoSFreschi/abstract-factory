using abstract_factory.Interface;

namespace abstract_factory.Logic.MercadoPago;

public class MercadoPagoFactory : IPaymentGatewayFactory
{
    public IPaymentValidator CreateValidator() => new MercadoPagoValidator();
    public IPaymentProcessor CreateProcessor() => new MercadoPagoProcessor();
    public IPaymentLogger CreateLogger() => new MercadoPagoLogger();
}
