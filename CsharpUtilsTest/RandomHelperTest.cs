using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CsharpUtils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CsharpUtilsTest
{
  [TestClass]
  public class RandomHelperTest
  {
    private const double TOLERANCE = 0.1;
    private const int TRIAL_COUNT = 5000;
    private const int TRY_AGAIN_TIMES = 2;

    #region NextFairCoin

    [TestMethod]
    public void NextFairCoinIsFair()
    {
      var results = new List<int>();
      const double expected = TRIAL_COUNT/2d;
      for (int i = 0; i <= TRY_AGAIN_TIMES; i++)
      {
        int trues = 0;
        for (int j = 0; j < TRIAL_COUNT; j++)
        {
          if (RandomHelper.NextFairCoin)
          {
            trues++;
          }
        }
        if (expected.EqualWithTolerance(trues, TOLERANCE))
        {
          return;
        }
        results.Add(trues);
      }
      Assert.Fail("Expected {0}, but got {1}", expected, string.Join(", ", results));
    }

    #endregion

    #region Next integer

    [TestMethod]
    public void NextIsAlwaysBelowMaxAndPositive()
    {
      var random = new Random();
      for (int i = 0; i < TRIAL_COUNT; i++)
      {
        int max = random.Next(1000) + 100; // Just some reasonably large positive number
        int value = RandomHelper.Next(max);
        Assert.IsTrue(value >= 0);
        Assert.IsTrue(value < max);
      }
    }

    [TestMethod]
    public void NextIsUniform()
    {
      var results = new List<Dictionary<int, int>>();
      for (int i = 0; i <= TRY_AGAIN_TIMES; i++)
      {
        const int max = 10;
        Dictionary<int, int> distribution = Enumerable.Range(0, max).ToDictionary(n => n, n => 0);
        for (int j = 0; j < TRIAL_COUNT; j++)
        {
          int value = RandomHelper.Next(max);
          distribution[value]++;
        }
        if (Enumerable.Range(0, max).All(index => (TRIAL_COUNT / max).EqualWithTolerance(distribution[index], TOLERANCE)))
        {
          return;
        }
        results.Add(distribution);
      }
      var failMessage = new StringBuilder("Expected uniform distribution, but got:");
      failMessage.AppendLine();
      results.ForEach(r => failMessage.AppendLine(string.Join(", ", r.Values)));
      Assert.Fail(failMessage.ToString());
    }

    #endregion
  }
}
