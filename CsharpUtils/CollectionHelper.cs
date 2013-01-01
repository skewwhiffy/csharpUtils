using System.Collections.Generic;
using System.Linq;

namespace CsharpUtils
{
  public static class CollectionHelper
  {
    public static List<T> ToSingletonList<T>(this T singleton)
    {
      return new List<T> {singleton};
    }

    public static bool IsOneOf<T>(this T obj, params T[] collection)
    {
      return collection.ToList().Contains(obj);
    }
  }
}
