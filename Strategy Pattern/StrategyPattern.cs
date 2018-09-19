using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Design_Patterns.Strategy_Pattern
{
    public class StrategyPattern
    {
        private static readonly ReadOnlyCollection<Person> people = new List<Person>
        {
            new Person {Name = "Harry", Age = 23 },
            new Person {Name = "Damodar", Age = 5 },
            new Person {Name = "James", Age = 43 },
            new Person {Name = "Jess", Age = 15 },
            new Person {Name = "John", Age = 32 },
            new Person {Name = "Smith", Age = 10 }
        }.AsReadOnly();

    }
}