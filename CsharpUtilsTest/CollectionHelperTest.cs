using System;
using System.Collections.Generic;
using CsharpUtils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CsharpUtilsTest
{
  [TestClass]
  public class CollectionHelperTest
  {
    #region ToSingletonList

    [TestMethod]
    public void ToSingletonListWorks()
    {
      const String testString = "testString";
      List<String> toTest = testString.ToSingletonList();
      Assert.AreEqual(1, toTest.Count);
      Assert.AreEqual(testString, toTest[0]);
    }

    [TestMethod]
    public void ToSingletonListWorksWithNull()
    {
      List<String> toTest = (null as String).ToSingletonList();
      Assert.AreEqual(1, toTest.Count);
      Assert.IsNull(toTest[0]);
    }

    #endregion

    #region IsOneOf

    [TestMethod]
    public void IsOneOfWorksWithEmptyList()
    {
      const String testString = "testString";
      Assert.IsFalse(testString.IsOneOf());
    }

    [TestMethod]
    public void IsOneOfWorksWhenIsOneOf()
    {
      const String testString = "testString";
      Assert.IsTrue(testString.IsOneOf("hello", testString, "goodbye"));
    }

    [TestMethod]
    public void IsOneOfWorksWhenIsNotOneOf()
    {
      const String testString = "testString";
      Assert.IsFalse(testString.IsOneOf("hello", "goodbye"));
    }

    #endregion
  }
}
