using System;
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

    public static void ForEach<T>(this IEnumerable<T> items, Action<T> action)
    {
      foreach (T item in items)
      {
        action(item);
      }
    }

    public static bool EquivalentTo<T>(this List<T> left, List<T> right)
    {
      if (left == null)
      {
        return right == null || right.Count == 0;
      }
      if (right == null)
      {
        return left.Count == 0;
      }
      if (left.Count != right.Count)
      {
        return false;
      }
      if (left.Count == 0)
      {
        return true;
      }
      List<T> newLeft = left.ToList();
      List<T> newRight = right.ToList();
      while (newLeft.Count > 0)
      {
        if (!newRight.Contains(newLeft[0]))
        {
          return false;
        }
        newRight.Remove(newLeft[0]);
        newLeft.RemoveAt(0);
      }
      return true;
    }
  }
}
