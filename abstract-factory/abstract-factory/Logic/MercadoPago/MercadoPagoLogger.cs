using abstract_factory.Interface;

namespace abstract_factory.Logic.MercadoPago;

internal class MercadoPagoLogger : IPaymentLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[MercadoPago Log] {DateTime.Now}: {message}");
    }
}