using System;

//This version of a builder pattern will only allow the user to build the ShyPerson by using the Builder type. 
//The name can only be set by using the Builder. 
//Once the instance is created the name can be called by using the instance of ShyPerson.
//The only issue is that there is now 3 lines of code for one property, which can make the code a bit busy 
//which could make it less readable.
//These classes are sealed which means no other class can inherit them.
public sealed class ShyPerson 
{
    private readonly string name;

    public string Name { get { return name; } }

    private ShyPerson(PersonBuilder builder)
    { 
        name = builder.Name;
    }

    public sealed class PersonBuilder 
    {
        public string Name { get; set; }
        public ShyPerson Build() 
        {
            return new ShyPerson(this);
        }
    }
}




//The below approach will allow the user to only instantiate the EfficientPerson type from the Builder type.
//The copy of the person is the only thing that will make it to the public when Build method is called. 
//Once out in the public the name property cannot be changed, it is immutable. This is once the Build method is called.
//If you change something and called it again the other states that were set would be null.
public sealed class EfficientPerson 
{
    private string name; // Not readonly. Therefore it can be set outside of the constructure but onyl within the class.

    private EfficientPerson() // The builder parameter is not actually needed as the name var prop is not readonly.
    {

    }

    public sealed class Builder 
    {
        private EfficientPerson person;

        public string Name
        {
            get { return person.name; }
            set { person.name = value; }
        }

        public EfficientPerson Build() 
        {
            EfficientPerson copyPerson = person;
            person = null;
            return copyPerson;
        }
    }

}



