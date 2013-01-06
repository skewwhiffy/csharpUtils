using CsharpUtils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CsharpUtilsTest
{
  [TestClass]
  public class MathHelperTest
  {
    #region Equal with tolerance

    [TestMethod]
    public void EqualWithToleranceWorksWhenTrue()
    {
      Assert.IsTrue(100d.EqualWithTolerance(91, 0.1));
      Assert.IsTrue(100d.EqualWithTolerance(109, 0.1));
    }

    [TestMethod]
    public void EqualWithToleranceWorksWhenFalse()
    {
      Assert.IsFalse(100d.EqualWithTolerance(89, 0.1));
      Assert.IsFalse(100d.EqualWithTolerance(111, 0.1));
    }

    #endregion
  }
}
