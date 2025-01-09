namespace Ordering.Infrastructure.Data.Extensions
{
    internal class InitialData
    {
        public static IEnumerable<Customer> Customers =>
            new List<Customer>
            {
                Customer.Create(CustomerId.Of(new Guid("3B82AAEC-AA02-4C85-9C0E-337A90EAD5C6")),"mehmet","mehmet@gmail.com"),
                Customer.Create(CustomerId.Of(new Guid("46F35C75-5A89-40DB-8608-2DFA0665AF88")),"john","john@gmail.com")
            };

        public static IEnumerable<Product> Products =>
            new List<Product>
            {
                Product.Create(ProductId.Of(new Guid("90076E6E-12BA-4157-938B-3B2DA38BE862")), "IPhone X", 500),
                Product.Create(ProductId.Of(new Guid("31380227-CCD7-4D01-AD39-F3F810DB5956")), "Samsung X10", 400),
                Product.Create(ProductId.Of(new Guid("31380227-CCD7-4D01-AD39-F3F810DB5957")), "Huawei Plus", 650),
                Product.Create(ProductId.Of(new Guid("D7DF9A0E-7731-4B18-8442-A075A26FB547")), "Xiaomi Mi", 450)
            };

        public static IEnumerable<Order> OrdersWithItems
        {
            get
            {
                var address1 = Address.Of("mehmet", "ozkaya", "mehmet@gmail.com", "Bahcelievler No:4", "Turkey", "Istanbul", "38050");
                var address2 = Address.Of("john", "doe", "john@gmail.com", "Broadway No:1", "England", "Istanbul", "08050");

                var payment1 = Payment.Of("mehmet", "5555555555444444", "12/28", "355", 1);
                var payment2 = Payment.Of("john", "8885555555444444", "06/30", "222", 2);

                var order1 = Order.Create(
                    OrderId.Of(Guid.NewGuid()),
                    CustomerId.Of(new Guid("3B82AAEC-AA02-4C85-9C0E-337A90EAD5C6")),
                    OrderName.Of("ORD_1"),
                    shippingAddress: address1,
                    billingAddress: address1,
                    payment1);
                order1.Add(ProductId.Of(new Guid("90076E6E-12BA-4157-938B-3B2DA38BE862")), 2, 500);
                order1.Add(ProductId.Of(new Guid("31380227-CCD7-4D01-AD39-F3F810DB5956")), 1, 400);

                var order2 = Order.Create(
                    OrderId.Of(Guid.NewGuid()),
                    CustomerId.Of(new Guid("46F35C75-5A89-40DB-8608-2DFA0665AF88")),
                    OrderName.Of("ORD_2"),
                    shippingAddress: address2,
                    billingAddress: address2,
                    payment2);
                order2.Add(ProductId.Of(new Guid("31380227-CCD7-4D01-AD39-F3F810DB5957")), 1, 650);
                order2.Add(ProductId.Of(new Guid("D7DF9A0E-7731-4B18-8442-A075A26FB547")), 2, 450);

                return new List<Order> { order1, order2 };
            }
        }
    
    
    }
}
