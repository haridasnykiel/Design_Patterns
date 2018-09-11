using System;
using Xunit;

namespace Design_Patterns.OpenClosedAndSubstitution
{
    public class PointExampleTests
    {
        [Fact]
        public void BreakageTest1() 
        {
           var breakage = new BreakingPoint();
           var point = breakage.FormatPoint(new Point{X = 1, Y = 2});
           Console.WriteLine("Point Example test 1 : " + point); 
        }

        [Fact]
        public void BreakageTest2() 
        {
           var breakage = new BreakingPoint();
           var point = breakage.FormatPoint(1,2);
           Console.WriteLine("Point Example test 2 : " + point); 
        }
    }
}