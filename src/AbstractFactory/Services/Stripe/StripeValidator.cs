using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.Stripe;

public class StripeValidator : IPaymentValidator
{
    public bool ValidateCard(string cardNumber)
    {
        if (cardNumber.Length == 16 && cardNumber.StartsWith("4"))
        {
            Console.WriteLine("Stripe: Cartão válido");
            return true;
        }
        Console.WriteLine("Stripe: Cartão inválido");
        return false;
    }
}