// Inversion of Control examples using dependency injection.
using System;
namespace C__Design_Patterns.InversionOfControl.DependencyInjection
{
    interface IOrderSaver 
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

        public string SaveOrder(string order ) =>  "Saved " + order + " to orderDb"; // This is an implementation of the interface method.
    }

    class OrderService 
    {
        public readonly IOrderSaver _orderSaver;
        public OrderService(IOrderSaver orderSaver) // Using dependency injection to get instance of interface.
        {   
            _orderSaver = orderSaver; // Flexible as there can be any implementation of this interface from any class.
        }

         public OrderService() // An extra contructor which will instantiate the orderdatabase class without the need
                                // for the interface to be passed.
        {   
            _orderSaver = OrderDatabase.Instance;   // Not flexible as requires the orderdatabase implementation.
        }
        public string AcceptOrder(string order) 
        {
            return _orderSaver.SaveOrder(order);
        }
    }
}