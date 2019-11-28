using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GradeR.Specs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
    //[TestClass]
    //public class TestEvaluationComponent
    //{
    //    [TestMethod]
    //    public virtual void shouldConstruct()
    //    {
    //        var item = new EvaluationComponent("Lab 5", "Unit Testing", 6);
    //        Assert.IsNotNull(item);
    //    }

    //    [TestMethod]
    //    public virtual void shouldGetDescription()
    //    {
    //        var item = new EvaluationComponent("Lab 5", 6);
    //        assertThat(item.Description, is_Renamed("Lab 5"));
    //    }

    //    [TestMethod]
    //    public virtual void shouldTrimDescriptionWhitespace()
    //    {
    //        var item = new EvaluationComponent(" Lab/t6  ", 6);
    //        assertThat(item.Description, is_Renamed("Lab 6"));
    //    }

    //    [TestMethod]
    //    public virtual void shouldGetWeight()
    //    {
    //        var item = new EvaluationComponent("Lab 5", 6);
    //        assertThat(item.Weight, is_Renamed(6));
    //    }

    //    [TestMethod]
    //    public virtual void shouldRequireDescription()
    //    {
    //        var item = new EvaluationComponent("", 6);
    //    }

    //    [TestMethod]
    //    public virtual void shouldRejectNullDescription()
    //    {
    //        var item = new EvaluationComponent(null, 6);
    //    }

    //    [TestMethod]
    //    public virtual void shouldRejectAllWhitespaceDescription()
    //    {
    //        var item = new EvaluationComponent(" /t  ", 6);
    //    }
    //    //UPGRADE_ISSUE: The following fragment of code could not be parsed and was not converted. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1156'"
    //    [TestMethod]
    //    public virtual void shouldRejectExcessiveDescriptions()
    //    {
    //        StringBuilder builder = new StringBuilder();
    //        builder.setLength(EvaluationComponent.MAX_DESCRIPTION + 1);

    //        item = new EvaluationComponent(builder.toString(), 6);
    //    }
    //    //UPGRADE_ISSUE: The following fragment of code could not be parsed and was not converted. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1156'"
    //    [TestMethod]
    //    public virtual void shouldRejectNegativeWeights()
    //    {
    //        item = new EvaluationComponent("Lab 5", -1);
    //    }
    //    //UPGRADE_ISSUE: The following fragment of code could not be parsed and was not converted. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1156'"
    //    [TestMethod]
    //    public virtual void shouldRejectZeroWeights()
    //    {
    //        item = new EvaluationComponent("Lab 5", 0);
    //    }
    //}
}
