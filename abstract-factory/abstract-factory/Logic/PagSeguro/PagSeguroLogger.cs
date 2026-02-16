using abstract_factory.Interface;

namespace abstract_factory.Logic.PagSeguro;

internal class PagSeguroLogger : IPaymentLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"PagSeguro Log: {message}");
    }
}
