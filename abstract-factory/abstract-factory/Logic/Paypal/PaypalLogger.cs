using abstract_factory.Interface;

namespace abstract_factory.Logic.Paypal;

internal class PaypalLogger : IPaymentLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[MercadoPago Log] {DateTime.Now}: {message}");
    }
}