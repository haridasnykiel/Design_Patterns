namespace Design_Patterns.FactoryPattern
{
    public class BadDuration
    {
        //This method is completely immutable.
        private readonly long _ticks;
        public long Ticks { get { return _ticks; } }

        //public long Ticks2 { get; private set; } // This will do the same as the above 2 lines except that it can be 
        //be changed anywhere in this class. So it is not completely immutable.

        //The will make the changing porperty immutable as it is readonly and private and cannot be changed anywhere apart
        //from when the object is instaniated and the value is passed into the constructor.

        //These are all overload constructors for this type, but due to each constructor expecting the same parameter types,
        //It will not compile, as it will think they are the same, it does not matter if they have different names the type 
        //is the same.
        //The solution is to create static methods also known as factory methods which will allow the user to get the ticks
        //in milliseconds and seconds.
        //The below shows an example of a basic factory pattern.
        private BadDuration(long ticks)
        {
            _ticks = ticks;
        }

        public static BadDuration FromMilliseconds(long milliseconds)
        {
            return new BadDuration(milliseconds * 10000); 
        }   
        
        public static BadDuration FromTicks(long ticks)
        {
            return new BadDuration(ticks); 
        }  

        public static BadDuration FromSeconds(long seconds)
        {
            return new BadDuration(seconds * 10000 * 1000);
        }
    }
}