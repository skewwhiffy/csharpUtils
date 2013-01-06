using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpUtils
{
  public static class EnumHelper
  {
    public static List<T> GetValues<T>()
      where T : struct, IConvertible
    {
      if (!typeof (T).IsEnum)
      {
        throw new ArgumentException("T must be an enum type");
      }
      return Enum.GetValues(typeof (T)).Cast<T>().ToList();
    }
  }
}
