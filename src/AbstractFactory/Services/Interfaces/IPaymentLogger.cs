namespace AbstractFactory.Services.Interfaces;

public interface IPaymentLogger
{
    void LogPayment(string processMessage);
}