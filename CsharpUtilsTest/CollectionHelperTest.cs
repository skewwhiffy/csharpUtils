using System;
using System.Collections.Generic;
using System.Linq;
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

    #region ForEach

    [TestMethod]
    public void ForEachWorks()
    {
      int total = 0;
      Enumerable.Range(1, 20).ForEach(x => total += x);
      Assert.AreEqual(210, total); // 210 is the sum of naturals up to and including 20.
    }

    #endregion

    #region IsEquivalentTo

    [TestMethod]
    public void IsEquivalentToWorksWithEmptyCollections()
    {
      Assert.IsTrue(new List<int>().EquivalentTo(new List<int>()));
    }

    [TestMethod]
    public void IsEquivalentToWorksWithNullCollections()
    {
      Assert.IsTrue((null as List<int>).EquivalentTo(new List<int>()));
      Assert.IsTrue(new List<int>().EquivalentTo(null));
    }

    [TestMethod]
    public void IsEquivalentWorksWhenNotEquivalent()
    {
      Assert.IsFalse(new List<int> {1, 2, 3, 2}.EquivalentTo(new List<int> {1, 2, 3, 3}));
    }

    [TestMethod]
    public void IsEquivalentWorksWhenEquivalent()
    {
      Assert.IsTrue(new List<int> {1, 2, 2, 3}.EquivalentTo(new List<int> {3, 1, 2, 2}));
    }

    #endregion
  }
}
