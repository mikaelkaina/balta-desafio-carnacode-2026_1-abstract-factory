using System;
using AbstractFactory.Services;
using AbstractFactory.Services.MercadoPago;
using AbstractFactory.Services.PagSeguro;
using AbstractFactory.Services.Stripe;

namespace DesignPatternChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Pagamentos ===\n");
            const decimal amount = 200.00m;
            const string cardNumber = "5234567890123456";

            var mercadoPagoFactory = new MercadoPagoFactory();
            var mercadoPagoService = new PaymentService(mercadoPagoFactory);
            mercadoPagoService.ProcessPayment(amount, cardNumber);

            Console.WriteLine();

            var pagSeguroFactory = new PagSeguroFactory();
            var paymentService = new PaymentService(pagSeguroFactory);
            paymentService.ProcessPayment(amount, cardNumber);

            Console.WriteLine();

            var stripeFactory = new StripeFactory();
            var stripeService = new PaymentService(stripeFactory);
            stripeService.ProcessPayment(amount, cardNumber);

            Console.WriteLine();
        }
    }
}