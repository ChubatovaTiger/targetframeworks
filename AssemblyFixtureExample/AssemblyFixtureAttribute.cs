using System;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class AssemblyFixtureAttribute : Attribute
{
    public AssemblyFixtureAttribute(Type fixtureType)
    {
        FixtureType = fixtureType;
        System.WrongMethod1file1();
        System.WrongMethod2file1();
    }

    public Type FixtureType { get; private set; }
}
