using System;
using Xunit;

namespace C__Design_Patterns.Interfaces
{
    public class InterfaceDemoTests
    {
        [Fact]
        public void HasExpired() 
        {
           FakeClock fakeClock = new FakeClock(); 
           Licence licence = new Licence(fakeClock.Now().AddTicks(-1), fakeClock.Now()); 
           Assert.True(licence.HasExpired);
        }

        [Fact]
        public void HasNotExpired() 
        {
           FakeClock fakeClock = new FakeClock();
           Licence licence = new Licence(fakeClock.Now().AddTicks(1), fakeClock.Now()); 
           Assert.True(!licence.HasExpired);
        }

        [Fact]
        public void HasJustExpired() 
        {
           FakeClock fakeClock = new FakeClock(); 
           var current = fakeClock.Now().AddTicks(-1);
           var expiry = fakeClock.Now();
           Licence licence = new Licence(expiry, current); 
           Assert.True(!licence.HasExpired);
           current = fakeClock.Now().AddTicks(1);
           //Assert.True(licence.HasExpired);
        }

    
    }

    
}