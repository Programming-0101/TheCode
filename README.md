# TheCode

Download Alpha Pre-Release via NuGet:

```
Install-Package Programming.HOT.Topics -Version 0.1.1
```

To run tests, create classes such as the following:

```csharp
public class Specs_For__E1_Calculator : Topic.E.Examples.Specs.E1_Calculator
{
    protected override string FullyQualifiedClassName => typeof(Topic.E.Examples.Calculator).FullName;
    protected override string AssemblyName => GetType().Assembly.FullName;
}

public class Specs_For__E2_Person : Topic.E.Examples.Specs.E2_Person
{
    protected override string FullyQualifiedClassName => typeof(Topic.E.Examples.Person).FullName;

    protected override string AssemblyName => GetType().Assembly.FullName;
}

public class Specs_For__E6_Circle : Topic.E.Examples.Specs.E6_Circle
{
    protected override string FullyQualifiedClassName => typeof(Topic.E.Examples.Circle).FullName;

    protected override string AssemblyName => GetType().Assembly.FullName;
}

public class Specs_For__E7_Square : Topic.E.Examples.Specs.E7_Square
{
    protected override string FullyQualifiedClassName => typeof(Topic.E.Examples.Square).FullName;

    protected override string AssemblyName => GetType().Assembly.FullName;
}

public class Specs_For__E8_Fraction : Topic.E.Examples.Specs.E8_Fraction
{
    protected override string FullyQualifiedClassName => typeof(Topic.E.Examples.Fraction).FullName;

    protected override string AssemblyName => GetType().Assembly.FullName;
}

public class Specs_For__E9_Angle : Topic.E.Examples.Specs.E9_Angle
{
    protected override string FullyQualifiedClassName => typeof(Topic.E.Examples.Angle).FullName;

    protected override string AssemblyName => GetType().Assembly.FullName;
}
```
