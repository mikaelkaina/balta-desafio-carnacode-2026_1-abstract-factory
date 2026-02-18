using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.Stripe;

public class StripeLogger : IPaymentLogger
{
    public void LogPayment(string processMessage) => Console.WriteLine($"[Stripe Log] {DateTime.Now}: {processMessage}");
}