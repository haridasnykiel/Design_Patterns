using System;
using Xunit;

namespace C__Design_Patterns.InversionOfControl.DependencyInjection
{ 
    public class OrderServiceTests
    {

        [Fact]
        public void OrderDatabaseTests() 
        {
            var orderDb = OrderDatabase.Instance;
            var orderDb2 = OrderDatabase.Instance;
            Assert.True(orderDb == orderDb2);
            Console.WriteLine(orderDb.SaveOrder("Shoes"));
            Assert.True(orderDb is OrderDatabase);
            Assert.True(orderDb.SaveOrder("Toy") != "");

        }

        [Fact]
        public void OrderServiceClassTests() 
        {
            var service = new OrderService(OrderDatabase.Instance);
            var service2 = new OrderService();
            Assert.True(service is OrderService);
            Assert.True(service._orderSaver is OrderDatabase);
            Assert.True(service2 is OrderService);
            Assert.True(service2._orderSaver is OrderDatabase);
            Console.WriteLine(service.AcceptOrder("Spoons")); // When this is run this is executed first?
            Console.WriteLine(service.AcceptOrder("Stuff"));
        }

        
        
    }
}