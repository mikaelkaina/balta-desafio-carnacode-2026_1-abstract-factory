using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services;

public class PaymentService
{
    private readonly IPaymentProcessor _processor;
    private readonly IPaymentValidator _validator;
    private readonly IPaymentLogger _logger;

    public PaymentService(IPaymentGatewayFactory factory)
    {
        _processor = factory.CreatePaymentProcessor();
        _validator = factory.CreatePaymentValidator();
        _logger = factory.CreatePaymentLogger();
    }

    public void ProcessPayment(decimal amount, string cardNumber)
    {
        if (!_validator.ValidateCard(cardNumber))
        {
            _logger.LogPayment("Cartão inválido");
            return;
        }

        var result = _processor.ProcessTransaction(amount, cardNumber);
        _logger.LogPayment($"Transação processada: {result}");
    }
}