using System;
using System.Collections.Generic;
using System.IO;

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
                                                        // So this would include List, Array and so on.
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


        public void ReportSpy(Spy spy) 
        {
            var name = spy.Name; //The requirements say that this should not be valid.
            Person spyAsPerson = spy;
            var spayName = spyAsPerson.Name; //Even if the name property was hidden in the spy class.
                                            //The type can be converted to a Person and then the name prop would available. 
        } 


        public void LeakyAbstraction(Stream stream) 
        {
            if(stream.CanSeek) 
            {
                stream.Position = 0; // Here we are saying that if a stream can support seeking then go back to the beginning of it.
                //So not all classes that inherit stream can seek. So this is a porp that is not used by all streams. (LeakyAbstraction)
                
            }
        }

        public void ArraysBreakLiskov() 
        {
            IList<string> strings = new string[5]; //arrays are fixed size in C#
            strings.Add("Hello"); //So this will fail. As Arrays are fixed size and a list are not fixed and can be added to.
            //In terms of Listov this type is broken. 

            
        }
    }
}