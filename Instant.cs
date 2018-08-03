using System;
namespace C__Design_Patterns 
{

    class FakeClock : IClock
    {
        public DateTime Now() 
        {
            var datetime = new DateTime(2010, 3, 2, 14, 32, 22);
            return datetime;
        }
        
    }

    class Clock : IClock 
    {
        public DateTime Now() 
        {
            return new DateTime();  
        }   
    }
}