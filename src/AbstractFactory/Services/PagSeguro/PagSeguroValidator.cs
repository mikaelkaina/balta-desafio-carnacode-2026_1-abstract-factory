using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.PagSeguro;

public class PagSeguroValidator : IPaymentValidator
{
    public bool ValidateCard(string cardNumber)
    {
        if (cardNumber.Length == 16)
        {
            Console.WriteLine("PagSeguro: Cartão válido");
            return true;
        }
        Console.WriteLine("PagSeguro: Cartão inválido");
        return false;
    }
}