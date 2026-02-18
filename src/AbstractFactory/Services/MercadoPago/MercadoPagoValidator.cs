using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.MercadoPago;

public class MercadoPagoValidator : IPaymentValidator
{
    public bool ValidateCard(string cardNumber)
    {
        if (cardNumber.Length == 16 && cardNumber.StartsWith("5"))
        {
            Console.WriteLine("MercadoPago: Cartão válido");
            return true;
        }

        Console.WriteLine("MercadoPago: Cartão inválido");
        return false;
    }
}