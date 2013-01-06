namespace CsharpUtils
{
  public static class StringHelper
  {
    public static string TruncateLastChars(this string source, int number)
    {
      return source.Substring(0, source.Length - number);
    }
  }
}
