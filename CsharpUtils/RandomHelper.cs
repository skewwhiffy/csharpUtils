using System;

namespace CsharpUtils
{
  public static class RandomHelper
  {
    private static readonly Random RANDOM = new Random();

    public static bool NextFairCoin
    {
      get { return Next(2) == 0; }
    }

    public static int Next(int max)
    {
      return RANDOM.Next(max);
    }
  }
}
