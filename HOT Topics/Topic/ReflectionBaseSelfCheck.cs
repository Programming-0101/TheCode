using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topic.Specs;
using Xunit;

namespace Topic
{
    public class SampleSUT
    {
        private const double PI = 3.14159;
        private static int Count = 0;
        private int WholeNumber;
        public double RealNumber { get; private set; }
        public SampleSUT(int whole, double real)
        {
        }
        public void TryThis(string data) { }
        private int OrThis(int num, string text, bool check) { return 0; }
    }
    public class ReflectionBaseTest : ReflectionBase<SampleSUT>
    {
        [Fact, Trait("AdHoc", "Require Field")]
        public void Should_Require_Private_Field()
        {
            var sut = Class.Requires(SUT_Type)
                .ToHaveA(AccessModifier.Private)
                .Field(typeof(int))
                .Named("WholeNumber")
                .ThatIs(Declared.Instance);
        }
        [Fact, Trait("AdHoc", "Require Method")]
        public void Should_Require_Public_Method()
        {
            var sut = Class.Requires(SUT_Type)
                .ToHaveA(AccessModifier.Public)
                .Method(typeof(void), typeof(string))
                .Named("TryThis")
                .ThatIs(Declared.Instance);
            sut.AssertExists();
        }

    }
}
