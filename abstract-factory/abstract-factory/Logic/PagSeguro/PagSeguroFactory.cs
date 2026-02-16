using abstract_factory.Interface;

namespace abstract_factory.Logic.PagSeguro;

public class PagSeguroFactory : IPaymentGatewayFactory
{
    public IPaymentValidator CreateValidator() => new PagSeguroValidator();
    public IPaymentProcessor CreateProcessor() => new PagSeguroProcessor();
    public IPaymentLogger CreateLogger() => new PagSeguroLogger();
}
