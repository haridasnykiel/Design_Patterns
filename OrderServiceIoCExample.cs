// Inversion of Control examples.
using System;
namespace C__Design_Patterns 
{
    //IoC using dependency injection

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

        public string SaveOrder(string order ) =>  "Saved " + order + " to orderDb";
    }

    class OrderService 
    {
        public readonly IOrderSaver _orderSaver;
        public OrderService(IOrderSaver orderSaver)
        {   
            _orderSaver = orderSaver;   
        }
        public string AcceptOrder(string order) 
        {
            return _orderSaver.SaveOrder(order);
        }
    }
}