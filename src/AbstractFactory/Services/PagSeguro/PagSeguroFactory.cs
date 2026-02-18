using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.PagSeguro;

internal class PagSeguroFactory : IPaymentGatewayFactory
{
    public IPaymentProcessor CreatePaymentProcessor() => new PagSeguroProcessor();
    public IPaymentValidator CreatePaymentValidator() => new PagSeguroValidator();
    public IPaymentLogger CreatePaymentLogger() => new PagSeguroLogger();
}