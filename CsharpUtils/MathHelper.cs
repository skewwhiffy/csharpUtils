namespace CsharpUtils
{
  public static class MathHelper
  {
    public static bool EqualWithTolerance(this int expected, int actual, double tolerance)
    {
      return ((double) expected).EqualWithTolerance(actual, tolerance);
    }

    public static bool EqualWithTolerance(this double expected, double actual, double tolerance)
    {
      double toleranceAbsolute = expected * tolerance;
      double lowest = expected - toleranceAbsolute;
      double highest = expected + toleranceAbsolute;
      return actual >= lowest && actual <= highest;
    }
  }
}
