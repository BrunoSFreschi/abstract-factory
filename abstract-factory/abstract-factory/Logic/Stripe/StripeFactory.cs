using abstract_factory.Interface;

namespace abstract_factory.Logic.Stripe;

internal class StripeFactory
{
    public static IPaymentValidator CreateValidator() => new StripeValidator();
    public static IPaymentProcessor CreateProcessor() => new StripeProcessor();
    public static IPaymentLogger CreateLogger() => new StripeLogger();
}
