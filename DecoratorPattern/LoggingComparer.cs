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

    public sealed class ReversingComparer<T> : IComparer<T> {
        IComparer<T> _comparer;

        public ReversingComparer (IComparer<T> comparer) {
            _comparer = comparer;
        }

        public int Compare (T x, T y) {
            int result = _comparer.Compare (y, x);
            Console.WriteLine ($"Compare({x},{y}) == {result}");
            return result;
        }
    }

    // public class InheritanceLoggingAgeComparer : AgeComparer {
    //     public override int Compare (Person x, Person y) { // This is not a great method due to not knowing whether this will need to be overriden or not.
    //         //If someone does override the method this may cause it to conflict with other methods. 
    //         int result = base.Compare (x, y);
    //         Console.WriteLine ($"Compare({x},{y}) == {result}");
    //         return result;
    //     }
    // }

    public static class ReversingComparer {
        public static IComparer<T> For<T> (IComparer<T> comparer) {
            return new ReversingComparer<T> (comparer);
        }
    }

    public static class LoggingComparer {
        public static IComparer<T> For<T> (IComparer<T> comparer) {
            return new LoggingComparer<T> (comparer);
        }
    }
}