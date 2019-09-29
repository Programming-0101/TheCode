using System;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Topic.Specs
{
    public abstract class ReflectionBase<TSUT>
    {
        #region Accessing the SUT as dynamic
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
        #endregion

        #region Testing for the presence of Properties/Fields/Methods
        #region Enumerations
        protected enum AccessModifier
        {
            Public,
            Private,
            Protected,
            PublicInternal,
            ProtectedInternal
        }
        protected enum Declared
        {
            Static = BindingFlags.Static,
            Instance = BindingFlags.Instance
        }
        #endregion

        #region Fluent Builder
        protected class Class : INamedMember, IMemberBuilder, IBinderFlag, IAssertSignature
        {
            private readonly Type SUT;
            private AccessModifier Access { get; set; }
            private string MemberName { get; set; }
            private MemberTypes MemberType { get; set; }
            private Type[] MethodParameters { get; set; }
            private Type DataType { get; set; }
            private Declared InstanceOrStatic { get; set; }

            private Class(Type sut) { SUT = sut; }

            public static INamedMember Requires(Type sut)
            {
                return new Class(sut);
            }

            #region INamedMember implementation
            public IMemberBuilder ToHaveA(AccessModifier access)
            {
                Access = access;
                return this;
            }
            public IBinderFlag Named(string memberName)
            {
                Assert.True(!string.IsNullOrWhiteSpace(memberName), $"Broken test - Expected a member name to search for in the {SUT.Name} data type");
                MemberName = memberName;
                return this;
            }
            #endregion

            #region Key Assertions
            public void AssertExists()
            {
                //// Staged asserts...
                // 0) Get all "possible" matches
                var anyFlags = BindingFlags.Static | BindingFlags.Instance | BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.NonPublic;
                MemberInfo[] found;

                // 1) Member exists (case insensitive)
                found = SUT.FindMembers(MemberType, anyFlags, Type.FilterNameIgnoreCase, MemberName);
                Assert.True(found.Length > 0, $"Expected a {MemberType.ToString()} called \"{MemberName}\" in the {SUT.Name} data type");
                //SUT_Type.FindMembers(memberType, BindingFlags.Static | BindingFlags.Instance | BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.NonPublic

                // 2) Member exists (case sensitive)
                found = SUT.FindMembers(MemberType, anyFlags, Type.FilterName, MemberName);
                Assert.True(found.Length > 0, $"Expected a {MemberType.ToString()} called \"{MemberName}\" in the {SUT.Name} data type, but no CASE-SENSITIVE match was found (check your spelling)");

                // 3) Member is proper type
                switch(MemberType)
                {
                    case MemberTypes.Method: //constructors are similar...
                        AssertMethod();
                        break;
                    case MemberTypes.Field:
                        AssertField();
                        break;
                    case MemberTypes.Property:
                        AssertProperty();
                        break;
                }
            }
            private void AssertMethod()
            {
                // Check Method Return Type
                MethodInfo info;
                info = SUT.GetMethod(MemberName, BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                Assert.True(info.ReturnType == DataType, $"Expected the {MemberName} method to return a {DataType.Name}, but it returns a {info.ReturnType}");

                // Check Method Parameters
                var actualParamTypes = string.Join(",",info.GetParameters().Select(p => p.ParameterType.Name));
                var expectedParamTypes = string.Join(",", MethodParameters.Select(x => x.Name));
                var expectedSignature = $"{DataType.Name} {MemberName}({expectedParamTypes})";
                Assert.True(expectedParamTypes == actualParamTypes, $"Expected the {MemberName} method to have a method signature of {expectedSignature}");

                switch(Access)
                {
                    case AccessModifier.Public:
                        Assert.True(info.IsPublic, $"Expected the {expectedSignature} to be public");
                        break;
                    case AccessModifier.Private:
                        Assert.True(info.IsPrivate, $"Expected the {expectedSignature} to NOT be public");
                        break;
                }

                switch (InstanceOrStatic)
                {
                    case Declared.Static:
                        Assert.True(info.IsStatic, $"Expected the {expectedSignature} to be static");
                        break;
                    case Declared.Instance:
                        Assert.True(!info.IsStatic, $"Expected the {expectedSignature} to be non-static (an instance method)");
                        break;
                }
            }
            private void AssertProperty()
            {
            }
            private void AssertField()
            {

            }
            #endregion

            #region IMemberBuilder implementations
            public INamedMember Method(Type returnType, params Type[] parameterTypes)
            {
                Assert.True(returnType != null, $"Broken test - Expected a data type for the {SUT.Name}.{MemberName} method");
                DataType = returnType;
                MemberType = MemberTypes.Method;
                MethodParameters = parameterTypes;
                return this;
            }

            public INamedMember Field(Type dataType)
            {
                Assert.True(dataType != null, $"Broken test - Expected a data type for the {SUT.Name}.{MemberName} field");
                DataType = dataType;
                MemberType = MemberTypes.Field;
                return this;
            }

            public INamedMember Property(Type dataType)
            {
                Assert.True(dataType != null, $"Broken test - Expected a data type for the {SUT.Name}.{MemberName} property");
                DataType = dataType;
                MemberType = MemberTypes.Property;
                return this;
            }
            #endregion

            #region IBinder implementations
            public IAssertSignature ThatIs(Declared instanceOrStatic)
            {
                InstanceOrStatic = instanceOrStatic;
                return this;
            }
            #endregion
        }
        #endregion

        #region Fluent Interfaces
        protected interface INamedMember
        {
            IMemberBuilder ToHaveA(AccessModifier access);
            IBinderFlag Named(string memberName);
        }
        protected interface IMemberBuilder
        {
            INamedMember Method(Type returnType, params Type[] parameterTypes);
            INamedMember Field(Type dataType);
            INamedMember Property(Type dataType);
        }
        protected interface IAssertSignature
        {
            void AssertExists();

        }
        protected interface IBinderFlag
        {
            IAssertSignature ThatIs(Declared asA);
        }
        #endregion
        #endregion
    }
}
