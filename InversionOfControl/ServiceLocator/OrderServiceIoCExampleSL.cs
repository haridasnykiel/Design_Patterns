// Inversion of Control examples using service locator.
using System;
namespace C__Design_Patterns.InversionOfControl.ServiceLocator
{
    public interface IOrderSaver 
    {
        string SaveOrder(string order);
    }

    class OrderDatabase : IOrderSaver
    {
        public static readonly OrderDatabase Instance = new OrderDatabase(); 

        private OrderDatabase()
        {
            Console.WriteLine("Constructor");
        }

        public string SaveOrder(string order ) =>  "Saved " + order + " to orderDb"; 
    }

    public class ServiceLocator 
    {
        public static IOrderSaver OrderSaver {get; set;}
        public static IOrderSaver GetOrderSaver() // This class will set the implementation for the interface to be used
                                                    // by the OrderService class. 
        {
            if (OrderSaver == null)
                OrderSaver = OrderDatabase.Instance; // this is the interface implementation used. 
            return OrderSaver;
        }
    }

    class OrderService 
    {
        public string AcceptOrder(string order) 
        {
            return ServiceLocator.GetOrderSaver().SaveOrder(order);
        }
    }
}