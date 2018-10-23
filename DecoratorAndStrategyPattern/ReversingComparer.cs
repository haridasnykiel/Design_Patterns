using System;
using System.Collections.Generic;
using Design_Patterns.Strategy_Pattern;

public sealed class ReversingComparer<T> : IComparer<T> { //Only needs to know how to reverse the comparison operation.
    IComparer<T> _comparer;

    public ReversingComparer (IComparer<T> comparer) {
        _comparer = comparer;
    }

    public int Compare (T x, T y) {
        return _comparer.Compare (y, x);
    }
}