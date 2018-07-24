using System;
namespace C__Design_Patterns
{
    public class Singleton //User can only create one instance of the class. Static can be used if the instance is not required. If instance is required then the 
        //class can only be instantiated once.
    {
        //private static readonly object mutex = new object(); // This is to ensure that 2 instances of the singleton class cannot be created even 
        //when there are multiple threads 
        private static readonly Singleton instance = new Singleton(); // The way that static intialisers work in dotnet is that only one thread is allowed to access the 
        //initialser at a time.
        private Singleton()
        { 
        }

        public static Singleton Instance {get {return instance; } }
        // {
        //     get 
        //     {
        //         if(instance == null) // To ensure the lock is not activated if there is already an instance of the object.
        //         {
        //             lock (mutex) // If the another instance comes in and there is already an instance inside creating the instance then this will have to wait.
        //             {
        //                 if(instance == null) // If the second instance comes in before the instance is created then this will stop another instance from being created. 
        //                 {
        //                     instance = new Singleton(); // 
        //                 }
        //             }
        //         }
        //         return instance;
        //     }
        // }

        public void DoSomething() 
        {
            Console.WriteLine("HELLOOOOOOOOOOOOOO!!!");
        }
    }
}
