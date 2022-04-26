﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToSic.Razor.Internals
{
    public static class ReplaceExtension
    {
        /// <summary>
        /// Returns a new string in which all occurrences of a specified string in the current instance are replaced with another specified string.
        /// This is to be used in .NET Framework or .netstandard 2.0 because .NET 5+ already has this string.Replace() method
        /// https://stackoverflow.com/a/36317315
        /// </summary>
        /// <param name="str">The string performing the replace method.</param>
        /// <param name="oldValue">The string to be replaced.</param>
        /// <param name="newValue">The string replace all occurrences of oldValue.</param>
        /// <param name="comparisonType">Type of the comparison.</param>
        /// <returns></returns>
        public static string Replace(this string str, string oldValue, string newValue, StringComparison comparisonType)
        {
            newValue = newValue ?? string.Empty;
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(oldValue) || oldValue.Equals(newValue, comparisonType))
            {
                return str;
            }
            int foundAt;
            while ((foundAt = str.IndexOf(oldValue, 0, comparisonType)) != -1)
            {
                str = str.Remove(foundAt, oldValue.Length).Insert(foundAt, newValue);
            }
            return str;
        }
    }
}
