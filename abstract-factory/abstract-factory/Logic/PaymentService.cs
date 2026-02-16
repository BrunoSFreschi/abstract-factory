using abstract_factory.Interface;

namespace abstract_factory.Logic;

internal class PaymentService(IPaymentGatewayFactory factory)
{
    private readonly IPaymentGatewayFactory _factory = factory;

    public void ProcessPayment(string cardNumber, decimal amount)
    {
        var validator = _factory.CreateValidator();

        if (!validator.ValidateCard(cardNumber))
        {
            Console.WriteLine("Invalid");
            return;
        }

        var processor = _factory.CreateProcessor();
        var result = processor.ProcessTransaction(amount, cardNumber);

        var logger = _factory.CreateLogger();

        logger.Log($"Transação processada: {result}");
    }
}