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
    public class SelfCheck_E3_Account : Examples.Specs.E3_Account
    {
        protected override string FullyQualifiedClassName => typeof(Examples.Account).FullName;

        protected override string AssemblyName => GetType().Assembly.FullName;
    }
    public class SelfCheck_E4_ElapsedTime : Examples.Specs.E4_ElapsedTime
    {
        protected override string FullyQualifiedClassName => typeof(Examples.ElapsedTime).FullName;

        protected override string AssemblyName => GetType().Assembly.FullName;
    }
    public class SelfCheck_E5_ResolveExpressions : Examples.Specs.E5_ResolveExpressions
    {
        protected override string FullyQualifiedClassName => typeof(Examples.ResolveExpressions).FullName;

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
    public class SelfCheck_E9_Angle : Examples.Specs.E9_Angle
    {
        protected override string FullyQualifiedClassName => typeof(Examples.Angle).FullName;

        protected override string AssemblyName => GetType().Assembly.FullName;
    }
    public class SelfCheck_E10_StockItem : Examples.Specs.E10_StockItem
    {
        protected override string FullyQualifiedClassName => typeof(Examples.StockItem).FullName;

        protected override string AssemblyName => GetType().Assembly.FullName;
    }
    public class SelfCheck_E11_Die : Examples.Specs.E11_Die
    {
        protected override string FullyQualifiedClassName => typeof(Examples.Die).FullName;

        protected override string AssemblyName => GetType().Assembly.FullName;
    }
    public class SelfCheck_E12_ParkingCounter : Examples.Specs.E12_ParkingCounter
    {
        protected override string FullyQualifiedClassName => typeof(Examples.ParkingCounter).FullName;

        protected override string AssemblyName => GetType().Assembly.FullName;
    }
    public class SelfCheck_E13_QuadraticEquation : Examples.Specs.E13_QuadraticEquation
    {
        protected override string FullyQualifiedClassName => typeof(Examples.QuadraticEquation).FullName;

        protected override string AssemblyName => GetType().Assembly.FullName;
    }
    #endregion

    #region Practice
    #endregion
}
