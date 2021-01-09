using System.Collections.Generic;

namespace DotnetDocument.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveStart(this string value, string prefixToRemove) =>
            value.StartsWith(prefixToRemove)
                ? value.Substring(prefixToRemove.Length, value.Length - prefixToRemove.Length)
                : value;

        public static string RemoveStart(this string value, IEnumerable<string> prefixesToRemove)
        {
            foreach (var prefixToRemove in prefixesToRemove)
            {
                value = RemoveStart(value, prefixToRemove);
            }

            return value;
        }

        public static string RemoveEnd(this string value, string suffixToRemove) =>
            value.EndsWith(suffixToRemove)
                ? value.Substring(0, value.Length - suffixToRemove.Length)
                : value;

        public static string RemoveEnd(this string value, IEnumerable<string> suffixesToRemove)
        {
            foreach (var suffixToRemove in suffixesToRemove)
            {
                value = RemoveEnd(value, suffixToRemove);
            }

            return value;
        }
    }
}
