using System;
using System.Linq;
using Xunit;

namespace Topic.Specs
{
    public abstract class ReflectionBase<TSUT>
    {
        /// <summary>Supply the full name of your class as "Namespace.ClassName"</summary>
        protected string FullyQualifiedClassName { get { return typeof(TSUT).FullName; } }
        /// <summary>Supply the name of your project assembly (the .dll name)</summary>
        protected string AssemblyName { get { return typeof(TSUT).Assembly.FullName; } }
        /// <summary>The assembly qualified name of the class being tested</summary>
        protected string TypeName { get { return FullyQualifiedClassName + "," + AssemblyName; } }
        /// <summary>Situation Under Test (SUT) Data Type</summary>
        protected Type SUT_Type { get { return Type.GetType(TypeName, true); } }
        /// <summary>New instance of the Situation Under Test (SUT)</summary>
        protected dynamic NewSUT(params object[] args)
        {
            return Activator.CreateInstance(SUT_Type, args);
        }

        //#region Self-Checks
        //[Fact, Trait("Self-Check", "Checking the Test Setup")]
        //public void Derived_Test_Class_Should_Set_FullyQualifiedClassName()
        //{
        //    Assert.True(!string.IsNullOrEmpty(FullyQualifiedClassName), "FullyQualifiedClassName should be a non-empty string in your derived test class");
        //}

        //[Fact, Trait("Self-Check", "Checking the Test Setup")]
        //public void Derived_Test_Class_Should_Set_AssemblyName()
        //{
        //    Assert.True(!string.IsNullOrEmpty(AssemblyName), "AssemblyName should be a non-empty string in your derived test class");
        //}

        //[Fact, Trait("Self-Check", "Checking the Test Setup")]
        //public void Derived_Test_Class_Should_Find_Data_Type_Being_Tested()
        //{
        //    Assert.True(SUT_Type != null, "Error in the AssemblylName or FullyQualifiedClassName; should be able to find the data type of the class being tested");
        //}
        //#endregion
    }
}
