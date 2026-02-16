using abstract_factory.Logic.MercadoPago;

namespace abstract_factory.Interface;

internal interface IPaymentGatewayFactory
{
    IPaymentValidator CreateValidator();
    IPaymentProcessor CreateProcessor();
    IPaymentLogger CreateLogger();
}