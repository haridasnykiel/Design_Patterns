
using System;
using Xunit;


namespace Design_Patterns.FactoryPattern
{
    public class BadDurationTests 
    {
        [Fact]
        public void FromSeconds() 
        {
            var badDuration = BadDuration.FromSeconds(5);
            Console.WriteLine("TICKS: " + badDuration);
            Assert.Equal(50000000, badDuration.Ticks);
        }


        [Fact]
        public void Ticks() 
        {
            //var badDuration = new BadDuration(ticks: 10); //This method is not very readable to make the user just pass 10. 10 of what.
            //There is not much context.
            var badDuration = BadDuration.FromTicks(10); // This method is more consistent with how the other values are being passed
            //And much more readable.
            Console.WriteLine("TICKS: " + badDuration);
            Assert.Equal(10, badDuration.Ticks);
        }
    }
}