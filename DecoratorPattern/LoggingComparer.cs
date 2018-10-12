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

    //This is generally not such a good method of doing this.
    //The issue is that you have had to make the method into
    //a virtual method.
    //It is very difficult to predict which method should be virtual.
    //This can cause issues if someone overrides the method
    //then there the method could conflict with the already existing
    //method.
    //This could cause lots of conflicts between methods.

    public static class ReversingComparer {
        public static IComparer<T> For<T> (IComparer<T> comparer) {
            return new ReversingComparer<T> (comparer); // This type only knows about logging.
        }
    }

    public static class LoggingComparer {
        public static IComparer<T> For<T> (IComparer<T> comparer) {
            return new LoggingComparer<T> (comparer);
        }
    }
}