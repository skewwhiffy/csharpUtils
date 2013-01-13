using System;
using System.Linq;

namespace CsharpUtils
{
  public static class StringHelper
  {
    #region Truncate

    public static string TruncateLastChars(this string source, int number)
    {
      return source.Substring(0, source.Length - number);
    }

    public static string TruncateLastChar(this string source)
    {
      return source.TruncateLastChars(1);
    }

    public static string TruncateEnding(this string source, string ending)
    {
      if (!source.EndsWith(ending))
      {
        throw new InvalidOperationException(string.Format("'{0}' does not end with '{1}'", source, ending));
      }
      return source.TruncateLastChars(ending.Length);
    }

    #endregion

    #region Ends with

    public static bool EndsWithOneOf(this string source, params string[] endings)
    {
      return endings.Any(source.EndsWith);
    }

    #endregion
  }
}
