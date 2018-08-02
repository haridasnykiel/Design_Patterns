using System;
using Xunit;

namespace C__Design_Patterns
{
    public class InterfaceDemoTests
    {
        [Fact]
        public void HasExpired() 
        {
           Licence licence = new Licence(new DateTime(2010, 03, 21)); 
           Assert.True(licence.HasExpired);
        }

        [Fact]
        public void HasNotExpired() 
        {
           Licence licence = new Licence(new DateTime(2020, 03, 21));
           Assert.True(!licence.HasExpired);
        }

        [Fact]
        public void InstantClassTest1() 
        {
           Instant time = new Instant();
            Console.WriteLine("Hellshauidfoha");
           Console.WriteLine(time.ReturnDateTime() + " !!!!!!!!!");
           Assert.NotNull(time.ReturnDateTime());
        }
    }
}