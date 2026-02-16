using abstract_factory.Interface;

namespace abstract_factory.Logic.Paypal;

internal class PaypalProcessor : IPaymentProcessor
{
    public string ProcessTransaction(decimal amount, string cardNumber)
    {
        Console.WriteLine($"PagSeguro: Processando R$ {amount}...");
        return $"PAGSEG-{Guid.NewGuid().ToString()[..8]}";
    }
}