namespace Design_Patterns.OpenClosedAndSubstitution
{
    public class Point 
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    
    public class FormatPoints
    {
        //The commented code will always call the override version of FormatPoint but the non commented code will
        //only call the overside version if the FormatPoint(x,y) version is called. 
        //So by making a seemingly harmless implementation change of the FormatPoint(x,y) method this changes the behaviour
        //both the methods. (if the commented code is still used.)
        //you can just start to seal the class by removing the virtual keyword from the methods.
        //This will make the inheritance much less useful.
        //If you find yourself jus sealing all the methods then you might as well seal the whole class.
        //Now you will have to think to yourself what the class is ment to do for inheritance.
        public virtual string FormatPoint(Point point) 
        {
            //return FormatPoint(point.X, point.Y);
            return string.Format("x={0} : y={1}", point.X, point.Y);  
        }

        public virtual string FormatPoint(int x, int y) 
        {
            //return string.Format("x={0} : y={1}", x,y); 
            return FormatPoint(new Point {X = x, Y = y});
        }
    }

    public class BreakingPoint : FormatPoints 
    {
        public override string FormatPoint(int x, int y)
        {
            return base.FormatPoint(x,y) + "<========="; 
        }
    }
}