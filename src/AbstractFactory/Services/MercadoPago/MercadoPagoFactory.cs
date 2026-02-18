using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.MercadoPago;

public class MercadoPagoFactory : IPaymentGatewayFactory
{
    public IPaymentProcessor CreatePaymentProcessor() => new MercadoPagoProcessor();
    public IPaymentValidator CreatePaymentValidator() => new MercadoPagoValidator();
    public IPaymentLogger CreatePaymentLogger() => new MercadoPagoLogger();
}