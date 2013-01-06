using System;
using System.Collections.Generic;
using System.Linq;
using CsharpUtils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CsharpUtilsTest
{
  [TestClass]
  public class EnumHelperTest
  {
    private enum TestEnum
    {
      // Items not explicitly used, but need to exist for this test to work.
      // ReSharper disable UnusedMember.Local
      Item,
      Item2
      // ReSharper restore UnusedMember.Local
    }

    [TestMethod]
    public void GetValuesWork()
    {
      List<TestEnum> values = EnumHelper.GetValues<TestEnum>();
      int count = 0;
      Enum.GetValues(typeof (TestEnum)).Cast<TestEnum>().ForEach(e =>
        {
          count++;
          Assert.IsTrue(values.Contains(e));
        });
      Assert.AreEqual(count, values.Count);
    }
  }
}
