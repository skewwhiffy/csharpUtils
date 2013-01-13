using System;
using System.Collections.Generic;
using CsharpUtils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CsharpUtilsTest
{
  [TestClass]
  public class StringHelperTest
  {
    #region Truncate last chars

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

    [TestMethod]
    public void TruncateLastCharWorks()
    {
      var test = new List<string> {"a", "ab", "abcde"};
      test.ForEach(s => Assert.AreEqual(s.TruncateLastChars(1), s.TruncateLastChar()));
    }

    [TestMethod]
    public void TruncateEndingWorks()
    {
      Assert.AreEqual("SomeRandomString", "SomeRandomStringWithEnding".TruncateEnding("WithEnding"));
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void TruncateEndingThrowsWhenSourceDoesNotHaveEnding()
    {
      "SomeRandomString".TruncateEnding("TheEnding");
    }

    #endregion

    #region Ends with

    [TestMethod]
    public void EndsWithOneOfWorksWithNoArgs()
    {
      Assert.IsFalse("blah".EndsWithOneOf());
    }

    [TestMethod]
    public void EndsWithOneOfWorksWithOneArg()
    {
      Assert.IsTrue("blahDeBlah".EndsWithOneOf("Blah"));
      Assert.IsFalse("blahDeBlah".EndsWithOneOf("blah"));
    }

    [TestMethod]
    public void EndsWithOneOfWorksWithMultipleArgs()
    {
      Assert.IsTrue("amo".EndsWithOneOf("o", "a"));
      Assert.IsFalse("amor".EndsWithOneOf("o", "a"));
    }

    #endregion
  }
}
