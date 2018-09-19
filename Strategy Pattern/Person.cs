namespace Design_Patterns.Strategy_Pattern
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("{1} : {2}", Name, Age);
        }
    }
}