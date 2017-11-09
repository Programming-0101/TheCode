/* ************************
 * This file contains concrete instances of the abstract test classes in
 * Topic E
 */

namespace Topic.E
{
    #region Examples
    
    public class SelfCheck_E1_Calculator : Examples.Specs.E1_Calculator
    {
        protected override string FullyQualifiedClassName => typeof(Examples.Calculator).FullName;
        protected override string AssemblyName => GetType().Assembly.FullName;
    }
    public class SelfCheck_E2_Person : Examples.Specs.E2_Person
    {
        protected override string FullyQualifiedClassName => typeof(Examples.Person).FullName;

        protected override string AssemblyName => GetType().Assembly.FullName;
    }
    public class SelfCheck_E6_Circle : Examples.Specs.E6_Circle
    {
        protected override string FullyQualifiedClassName => typeof(Examples.Circle).FullName;

        protected override string AssemblyName => GetType().Assembly.FullName;
    }
    public class SelfCheck_E7_Square : Examples.Specs.E7_Square
    {
        protected override string FullyQualifiedClassName => typeof(Examples.Square).FullName;

        protected override string AssemblyName => GetType().Assembly.FullName;
    }
    public class SelfCheck_E8_Fraction : Examples.Specs.E8_Fraction
    {
        protected override string FullyQualifiedClassName => typeof(Examples.Fraction).FullName;

        protected override string AssemblyName => GetType().Assembly.FullName;
    }
    //E9_Angle
    public class SelfCheck_E9_Angle : Examples.Specs.E9_Angle
    {
        protected override string FullyQualifiedClassName => typeof(Examples.Angle).FullName;

        protected override string AssemblyName => GetType().Assembly.FullName;
    }
    #endregion

    #region Practice
    #endregion
}
