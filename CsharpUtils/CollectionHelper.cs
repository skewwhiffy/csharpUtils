using System.Collections.Generic;

namespace CsharpUtils
{
  public static class CollectionHelper
  {
    public static List<T> ToSingletonList<T>(this T singleton)
    {
      return new List<T> {singleton};
    }
  }
}
