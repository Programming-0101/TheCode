/* ************************
 * This file contains concrete instances of the abstract test classes in
 * Topic E
 */

namespace Topic.E.Examples.Specs
{
    public class SelfCheck_E1_Calculator : E1_Calculator
    {
        protected override string FullyQualifiedClassName => "Topic.E.Examples.Calculator";
        protected override string AssemblyName => "Topic.xUnit.Specs";
    }
}
