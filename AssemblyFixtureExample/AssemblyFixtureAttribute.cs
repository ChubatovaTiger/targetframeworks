using System;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class AssemblyFixtureAttribute : Attribute
{
    public AssemblyFixtureAttribute(Type fixtureType)
    {
        FixtureType = fixtureType;
    }

    public Type FixtureType { get; private set; }
    static void Main(string[] args)
    {
        // Display the number of command line arguments.
        Console.WriteLine("hi");
    }
}
