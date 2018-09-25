using Design_Patterns.Strategy_Pattern;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xunit;


namespace Design_Patterns.DecoratorPattern
{
    public class LoggingComparerTests
    {
        [Fact]
        public void LoggingComparerTest()
        {
            var persons = StrategyPattern.people.ToList();
            //Console.WriteLine("Persons: " + persons.First());
            persons.Sort(new LoggingComparer<Person>(new AgeComparer()));
        }


    }
}