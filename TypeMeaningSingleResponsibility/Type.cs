using System;
using Xunit;

namespace Design_Patterns.TypeMeaningSingleResponsibility
{
    public class Type
    {
        [Fact]
        public void TypeTests() 
        {
            DateTime date = DateTime.Today; // The datetime object can be used to return not just the date but also the time.
            date.AddHours(5); // An object should be focussed on data type. 
            TimeSpan time = date.TimeOfDay; // This is the example as the TimeOfDay will return a TimeSpan object with the hours, minutes and secconds. 
            Assert.True(time is TimeSpan);

            //There is alot that goes into Date Time such divisions of time, time zones, quirks like daytime savings and so on.
            // Just from these examples it becomes obvious that DateTime tries to do too much. 
            // This causes confusion of meaning (Like what does Now prop mean) and utility TimeSpan for time of day. 
        }


        [Fact]
        public void KindConfusion() 
       {
           DateTime kindConfusion = new DateTime(2014, 4, 5, 14, 15, 33);
           Assert.True(DateTimeKind.Unspecified == kindConfusion.Kind); // This shows that the DateTime object does not know if it is local time or utc time. 
            
           DateTime utcTime = kindConfusion.ToUniversalTime(); // Here we can specify the DateTime object to be UTC.
           DateTime localTime = kindConfusion.ToLocalTime(); // Her we specify the DateTime object to be local time.
           // This is an example of the DateTime type trying to do too much. These actions should be broken down into various types.
           
       }

       [Fact]
       public void EqualOrNotEqual() 
       {
           DateTime utcTime1 = new DateTime(2015, 10, 2, 14, 33, 45, DateTimeKind.Utc);
           DateTime utcTime2 = new DateTime(2015, 10, 2, 15, 33, 45, DateTimeKind.Utc);
           Console.WriteLine(utcTime1.Date.ToString() + utcTime1.TimeOfDay);
           Console.WriteLine(utcTime2.Date.ToString() + utcTime2.TimeOfDay);
           Assert.NotEqual(utcTime1, utcTime2);

           var localDateTime1 = utcTime1.ToLocalTime();
           var localDateTime2 = utcTime2.ToLocalTime(); // In previous versions of datetime this localtime  from utc conversion would magically make these times the same.
           // This would mean loss of information as the time orginially set did not match. 
           Console.WriteLine(localDateTime1.Date.ToString() + localDateTime1.TimeOfDay);
           Console.WriteLine(localDateTime2.Date.ToString() + localDateTime2.TimeOfDay);
           Assert.NotEqual(localDateTime1, localDateTime2);
           Assert.True(localDateTime1.Kind == DateTimeKind.Local);
           Assert.True(localDateTime2.Kind == DateTimeKind.Local);

           var utcTime3 = localDateTime1.ToUniversalTime();
           var utcTime4 = localDateTime2.ToUniversalTime();
           Console.WriteLine(utcTime3.Date.ToString() + utcTime3.TimeOfDay);
           Console.WriteLine(utcTime4.Date.ToString() + utcTime4.TimeOfDay);
           Assert.NotEqual(utcTime3, utcTime4);
           Assert.True(utcTime3.Kind == DateTimeKind.Utc);
           Assert.True(utcTime4.Kind == DateTimeKind.Utc);
           // Creating types is relatively cheap. 
           // It is generally betteer to have 2 types even when it feels as though they are similar and could be one. 
           // This is especially good for open source projects. 
           // IF YOU HAVE A TYPE THAT ONLY EVER MEANS ONE CONCEPT THEN IT IS EASIER TO USE THAT CONCEPT.
       }

    }
}