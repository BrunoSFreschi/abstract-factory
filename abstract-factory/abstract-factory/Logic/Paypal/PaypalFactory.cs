using abstract_factory.Interface;

namespace abstract_factory.Logic.Paypal;

internal class PaypalFactory : IPaymentGatewayFactory
{
    public IPaymentValidator CreateValidator() => new PaypalValidator();
    public IPaymentProcessor CreateProcessor() => new PaypalProcessor();
    public IPaymentLogger CreateLogger() => new PaypalLogger();
}