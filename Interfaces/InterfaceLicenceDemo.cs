using System;

namespace C__Design_Patterns.Interfaces // Date Times in dotnet give a false sense of security.
{                              // What time zone is this in? This is the question to this problem. 
                                //Is the time zone the same here as itis in other parts of the world, no.
     class Licence 
     {
         private readonly DateTime expiry;
         private readonly DateTime clock;
         public Licence(DateTime expiry, DateTime clock)
         {
            this.expiry = expiry;
            this.clock = clock;
         }

         public bool HasExpired
         {
            get { return clock >= expiry; } 
         }

     }





}