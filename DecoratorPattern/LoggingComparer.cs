using System;
using System.Collections.Generic;
using Design_Patterns.Strategy_Pattern;

namespace Design_Patterns.DecoratorPattern {
    public sealed class LoggingComparer<T> : IComparer<T> {
        IComparer<T> _comparer;

        public LoggingComparer (IComparer<T> comparer) {
            _comparer = comparer;
        }

        public int Compare (T x, T y) {
            int result = _comparer.Compare (x, y);
            Console.WriteLine ($"Compare({x},{y}) == {result}");
            return result;
        }
    }

    public class InheritanceLoggingAgeComparer : AgeComparer {
        public int Compare (Person x, Person y) {
            int result = base.Compare (x, y);
            Console.WriteLine ($"Compare({x},{y}) == {result}");
            return result;
        }
    }

    public static class LoggingComparer {
        public static IComparer<T> For<T> (IComparer<T> comparer) {
            return new LoggingComparer<T> (comparer);
        }
    }
}