using System;
using Xunit;
namespace C__Design_Patterns.InversionOfControl.ServiceLocator
{ 
    public class OrderServiceTests
    {

        [Fact]
        public void ServiceLocatorTests() 
        {
           var orderService = new OrderService();
           Assert.True(orderService is OrderService);
           Assert.True(orderService.AcceptOrder("Cool") != null);
           Console.WriteLine(orderService.AcceptOrder("Cool"));

        }

        
        
    }
}