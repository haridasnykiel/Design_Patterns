namespace Design_Patterns.OpenClosedAndSubstitution
{
    public class Person
    {
        public string Name {get; set; }
    }

    public class Spy : Person
    {
        //Dont want to know this persons name as he/she is a spy.
        //If you are trying to have this class hide the name prop then the inheritance hierarchy is broken.
    }


}