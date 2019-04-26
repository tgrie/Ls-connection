﻿using System;
using System.Linq;

namespace RayanCNC.LSConnection.Extentions
{
    public static class StringExtentionMethods
    {
        public static bool Any(this string data, string[] valuesToCHeck) => valuesToCHeck.Any(data.Contains);

        public static bool Any(this string data, char[] valuesToCHeck)
            => valuesToCHeck.Any(c => data.Contains(c.ToString()));

        public static bool StartWith(this string data, string[] valuesToCHeck) => valuesToCHeck.Any(data.StartsWith);

        public static bool ShouldHaveJustOne(this string data, char[] valuesToCHeck) => !valuesToCHeck.Any(c => data.Count(ch => ch == c) > 1);

        public static string[] SplitWithOne(this string data, char[] valuesToCHeck)
        {
            var first = valuesToCHeck.First(c => data.Contains(c.ToString()));
            return data.Split(first);
        }

        public static string RemoveCharFromStart(this string data, char charValue)
        {
            while (data.StartsWith(charValue.ToString()))
                data = data.Substring(1);
            return data;
        }
    }
}