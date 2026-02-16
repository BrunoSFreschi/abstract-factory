using abstract_factory.Interface;

namespace abstract_factory.Logic.Stripe;

internal class StripeProcessor : IPaymentProcessor
{
    public string ProcessTransaction(decimal amount, string cardNumber)
    {
        Console.WriteLine($"Stripe: Processando ${amount}...");
        return $"STRIPE-{Guid.NewGuid().ToString()[..8]}";
    }
}