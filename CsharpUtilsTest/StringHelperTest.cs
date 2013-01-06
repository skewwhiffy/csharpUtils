using System;
using CsharpUtils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CsharpUtilsTest
{
  [TestClass]
  public class StringHelperTest
  {
    [TestMethod]
    public void TruncateLastCharsWorks()
    {
      Assert.AreEqual("hell", "hellish".TruncateLastChars(3));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TruncateLastThrowsWhenNumberOfCharsExceedsLength()
    {
      "hell".TruncateLastChars(50);
    }
  }
}
