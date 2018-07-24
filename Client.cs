using System;
using Xunit;

namespace C__Design_Patterns
{
    
    public class Client
    {

        // static void Main(string[] args)
        // {
        //     //Singleton singleton = new Singleton();
        //     Console.WriteLine("Start Here"); // dotnet 4 
        //     Singleton instance1 = Singleton.Instance;
        //     Singleton instance2 = Singleton.Instance;
        //     instance1.DoSomething();
        //     Console.WriteLine(instance1 == instance2);
            
            
        // }
        [Fact]
        public void Test1() 
        {
            Singleton instance1 = Singleton.Instance;
            Singleton instance2 = Singleton.Instance;
            Assert.Equal(instance1, instance2);
            instance1.DoSomething();
        }
    }


}
