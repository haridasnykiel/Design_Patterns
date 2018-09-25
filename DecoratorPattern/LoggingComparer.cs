using System;
using System.Collections.Generic;

namespace Design_Patterns.DecoratorPattern
{
    public sealed class LoggingComparer<T> : IComparer<T>
    {
        IComparer<T> _comparer;

        public LoggingComparer(IComparer<T> comparer)
        {
            _comparer = comparer;
        }

        public int Compare(T x, T y)
        {
            int result = _comparer.Compare(x, y);
            string value = $"Compare({x},{y}) == {result}";
            Console.WriteLine(value);
            return result;
        }
    }
}