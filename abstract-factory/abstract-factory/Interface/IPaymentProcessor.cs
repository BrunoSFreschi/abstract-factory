namespace abstract_factory.Interface;

public interface IPaymentProcessor
{
    string ProcessTransaction(decimal amount, string cardNumber);
}