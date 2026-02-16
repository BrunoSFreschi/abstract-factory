namespace abstract_factory.Interface;

public interface IPaymentValidator
{
    bool ValidateCard(string cardNumber);
}