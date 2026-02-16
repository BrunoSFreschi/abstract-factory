using abstract_factory.Interface;

namespace abstract_factory.Logic.PagSeguro;

internal class PagSeguroValidator : IPaymentValidator
{
    public void Log(string message)
    {
        throw new NotImplementedException();
    }

    public bool ValidateCard(string cardNumber)
    {
        Console.WriteLine("PagSeguro: Validando cartão...");
        return cardNumber.Length == 16;
    }
}
