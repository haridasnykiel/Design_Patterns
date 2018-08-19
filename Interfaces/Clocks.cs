using System;
namespace C__Design_Patterns.Interfaces
{

    class FakeClock : IClock
    {
        public DateTime Now() 
        {
            var datetime = new DateTime(2010, 3, 2, 0, 0, 0);
            return datetime;
        }
        
    }

    class Clock : IClock 
    {
        public DateTime Now() 
        {
            return DateTime.UtcNow;  
        }   
    }
}