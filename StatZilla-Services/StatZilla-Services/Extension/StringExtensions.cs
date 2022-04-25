using Newtonsoft.Json;
using System;
using System.Text;

namespace StatZilla_Services.Extensions
{
    /// <summary>
    /// A collection of extension methods provided to simplify string operations
    /// </summary>
    static class StringExtensions
    {
        /// <summary>
        /// Converts a string to its literal representation
        /// </summary>
        /// <param name="str">The string to convert</param>
        /// <returns>The literal representation of the string</returns>
        public static string ToLiteral(this string str)
        {

            return JsonConvert.DeserializeObject<string>($"\"{str}\"");
        }

        public static string ToBase64(this string str)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(str));
        }
    }
}
