using abstract_factory.Interface;

namespace abstract_factory.Logic.MercadoPago;

internal class MercadoPagoValidator : IPaymentValidator
{
    public bool ValidateCard(string cardNumber)
    {
        Console.WriteLine("MercadoPago: Validando cartão...");
        return cardNumber.Length == 16 && cardNumber.StartsWith("5");
    }
}