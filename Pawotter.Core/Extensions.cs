﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Pawotter.Core
{
    public static class Extensions
    {
        public static string CreatedAtString(this DateTime dateTime) => dateTime.ToString("yyyy/MM/dd HH:mm");
    }

    static class Object
    {
        internal static bool SequenceEqual<T>(IList<T> left, IList<T> right)
        {
            if (left == null && right == null) return true;
            if (ReferenceEquals(left, right)) return true;
            return left.SequenceEqual(right);
        }

        internal static int GetHashCode(object o) => o == null ? 0 : o.GetHashCode();

        internal static int GetHashCode(params object[] objects)
        {
            var hashCode = 0;
            foreach (object obj in objects)
            {
                hashCode = hashCode ^ GetHashCode(obj);
            }
            return hashCode;
        }
    }
}
