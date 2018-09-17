using System;
using Xunit;

public class BuilderTests 
{
    [Fact]
    public void ShyPersonTest() 
    {
        var personBuilder = new ShyPerson.PersonBuilder();
        personBuilder.Name = "Phil";
        var shyPerson2 = personBuilder.Build();
        personBuilder.Name = "Smith";
        var shyPerson3 = personBuilder.Build();
        var shyPerson = new ShyPerson.PersonBuilder { Name = "Harry" }.Build();
        var shyPersonName = shyPerson.Name;
        Console.WriteLine("Shy Person 1 " + shyPersonName);
        Assert.True(shyPersonName == "Harry");
        Assert.True(shyPerson2.Name == "Phil");
        Assert.True(shyPerson3.Name == "Smith");
        
    }

}