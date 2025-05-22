// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Test, Test!");
Console.WriteLine("Test 4");
Console.WriteLine("Test 5");
Console.WriteLine("Test 6");
Console.WriteLine("Test 7");

public class OrderProcessor
{
    public string ProcessOrder(Order order)
    {
        if (order.Items.Count == 0)
            throw new ArgumentException("Order cannot be empty");

        if (order.Customer.IsBlocked)
            throw new InvalidOperationException("Customer is blocked");

        if (!order.IsPaid)
        {
            if (order.PaymentMethod == "CreditCard")
            {
                if (string.IsNullOrEmpty(order.CreditCardNumber))
                    throw new ArgumentException("Credit card required");
                // Логика оплаты...
            }
            else if (order.PaymentMethod == "PayPal")
            {
                if (string.IsNullOrEmpty(order.PaypalEmail))
                    throw new ArgumentException("PayPal email required");
                // Логика PayPal...
            }
        }

        if (order.PriorityShipping && !order.Customer.IsPremium)
            throw new InvalidOperationException("Premium required for priority");

        // 10+ дополнительных условий...
        return "Order processed";
    }
}