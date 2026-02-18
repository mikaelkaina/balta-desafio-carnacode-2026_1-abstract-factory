namespace AbstractFactory.Services.Interfaces;

public interface IPaymentGatewayFactory
{
    IPaymentProcessor CreatePaymentProcessor();
    IPaymentValidator CreatePaymentValidator();
    IPaymentLogger CreatePaymentLogger();
}
