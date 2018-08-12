using System;

namespace C__Design_Patterns.Interfaces // Date Times in dotnet give a false sense of security.
{                              // What time zone is this in? This is the question to this problem. 
                                //Is the time zone the same here as itis in other parts of the world, no.
     class Licence 
     {
         private readonly DateTime expiry;
         private readonly IClock clock;
         public Licence(DateTime expiry, IClock clock)
         {
            this.expiry = expiry;
            this.clock = clock;
         }

         public bool HasExpired
         {
            get { return clock.Now() > expiry; } // UtcNow will always get the current date and time. 
                                                    // if you want to test the boundaries of this code then you will need to control the DateTime and have a clock that does not move.
                                                    // Or a clock that when set will not go forward unless it is set it is told too. 
         }

     }





}