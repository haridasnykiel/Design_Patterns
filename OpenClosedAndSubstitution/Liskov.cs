using System;
using System.Collections.Generic;

namespace Design_Patterns.OpenClosedAndSubstitution
{


    public interface IItems
    {
        List<string> Items { get; }
    }

    public class Item : IItems
    {
        //public List<string> Items => new List<int> {2,3,3}; // This will return an error when compiling because 
                                                            // it is not adhering to the interfaces contract.
        public List<string> Items => new List<string> {"hello", "stuff"}; // This is adhering to the interface contract
                                                                        // because it is setting the correct type to the prop.
                                                                        // Which violates the Liskov substituadbility principle.
    }

    public class Liskov
    {
        static void PrintSequence<T>(IEnumerable<T> items) // Any good implementation of IEnumerable should be 
                                                        //able to be passed into this method and iterated on.
        {
            if(items is IList<T>) 
            {
                //Do something special
                // In this method we want to achieve the same results but it may be easier to do in List.
                // This is the reason for this if statement.
                // Ultimately the result should always be the same.
            }
            foreach (T item in items)
            {
                Console.WriteLine(item.ToString());
            }

            // The C# compiler will enforce this principle.
        } 
    }
}