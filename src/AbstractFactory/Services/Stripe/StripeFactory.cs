using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.Stripe;

public class StripeFactory : IPaymentGatewayFactory
{
    public IPaymentProcessor CreatePaymentProcessor() => new StripeProcessor();
    public IPaymentValidator CreatePaymentValidator() => new StripeValidator();
    public IPaymentLogger CreatePaymentLogger() => new StripeLogger();
}