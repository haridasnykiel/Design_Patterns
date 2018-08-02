using System;
namespace C__Design_Patterns 
{
    class Instant 
    { 

        public string ReturnDateTime() 
        {
            var datetime = new DateTime(2000, 1, 2, 14, 32, 22);
            var value = datetime.ToShortDateString();
            return "Value";
        }
    }
}