using System;
namespace C__Design_Patterns.Singleton
{
    public class Singleton //User can only create one instance of the class. Static can be used if the instance is not required. If instance is required then the 
        //class can only be instantiated once.
    {
       private static class Holder // with this nested class Singleton no longer has anything to initialise 
       // so if the static methods are called no initialisation will occur and the method will just be run.
       // Only when the instance prop is called that the class will be initialised.
       {
            internal static readonly Singleton instance = new Singleton(); // The way that static intialisers work in dotnet is that only one thread is allowed to access the 
            //initialser at a time. So now it will initialise the type before it is first used. Even if a method is called before the instance is initialised.
            static Holder() {} //Empty static constructor - Will initialise this type when it is called. if you do not care when the type gets initialised then do not bother with a static constructure at all.
       }
        
        private Singleton() 
        { 
            Console.WriteLine("Constructor"); 
        }

        public static Singleton Instance {get {return Holder.instance; } }

        public static void SaySomething(string text) 
        {
            Console.WriteLine(text);
        }

        public void DoSomething() 
        {
            Console.WriteLine("HELLOOOOOOOOOOOOOO!!!");
        }
    }
}
