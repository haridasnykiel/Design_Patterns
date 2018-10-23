using System;
using System.IO;

namespace Design_Patterns.StatePattern {
    public sealed class StatePattern : IDisposable { // This is a good implementation of the Idisposible interface
        //As there will be no other class available to override the dispose method. 
        //So it is less for confustion or conflicts to occur due other implementations of the dispose method.
        // Read this: https://www.geeksforgeeks.org/state-design-pattern/

        private readonly Stream stream;
        public void Dispose () {
            stream.Dispose ();
        }
    }
}