using System;
namespace C__Design_Patterns 
{
    class Instant 
    { 

        public DateTime ReturnDateTime(int years, int months, int days, int hours, int mins, int secs) 
        {
            var datetime = new DateTime(years, months, days, hours, mins, secs);
            return datetime;
        }
    }

    class FakeClock : IClock
    {
        Instant _instant;
        public FakeClock()
        {
            
        }
    }
}