using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Design_Patterns.Strategy_Pattern;
using Xunit;

namespace Design_Patterns.DecoratorPattern {
    public class LoggingComparerTests {
        [Fact]
        public void LoggingComparerTest () {
            var persons = StrategyPattern.people.ToList ();
            persons.Sort (LoggingComparer.For (new AgeComparer ()));
            foreach (var person in persons) {
                Console.WriteLine (person);
            }
        }

        [Fact]
        public void ReversingComparerTest () {
            var persons = StrategyPattern.people.ToList ();
            persons.Sort (ReversingComparer.For (new AgeComparer ()));
            foreach (var person in persons) {
                Console.WriteLine (person);
            }
        }

    }
}