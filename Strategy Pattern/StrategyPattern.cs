using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xunit;

namespace Design_Patterns.Strategy_Pattern
{
    public class StrategyPattern
    {
        public static readonly ReadOnlyCollection<Person> people = new List<Person>
        {
            new Person {Name = "Harry", Age = 23 },
            new Person {Name = "Harry", Age = 5 },
            new Person {Name = "James", Age = 43 },
            new Person {Name = "Jess", Age = 15 },
            new Person {Name = "John", Age = 32 },
            new Person {Name = "Smith", Age = 10 }
        }.AsReadOnly();

        [Fact]
        public void SortingByAge()
        {
            var listOfpeople = people.ToList();
            //All of these comparison methods to the same thing they are just implemented in a different way.
            listOfpeople.Sort(CompareByAge); // Here we are satisfying the delegate type. So we just implemented the delegate.   
            listOfpeople.Sort((x, y) => x.Age.CompareTo(y.Age)); // Here we are using a lambda expression.
            listOfpeople.Sort(new AgeComparer()); // Here we have implemented the Icomparer single method interface to do the same task.
            Console.WriteLine("People: " + listOfpeople.Count);
            foreach (var item in listOfpeople)
            {
                Console.WriteLine("Person: " + item.Name + " " + item.Age);
            }

        }
        //None of these comparison methods know about sorting and the Sort() method does not know how to compare,
        //except for when calling the comparison. You have a clean separation of concerns there. 
        // Separate the concern of using the strategy and implementing it. 
        //This goes back to the S in SOLID, enforcing single responsibility for more flexible code. 
        // Linq is full of strategy patterns.
        static int CompareByAge(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }

    public class AgeComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}