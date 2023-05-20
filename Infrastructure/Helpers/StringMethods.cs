
using System.Globalization;
using System.Reflection;

namespace Infrastructure.Helpers
{
    public static class StringMethods
    {
        public static List<string> GetParameterNames<T>()
        {
            var parameterNames = new List<string>();
            var type = typeof(T);
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in properties)
            {
                var propertyName = property.Name;
                var transformedName = TransformUpperCamelCaseToTableHeaders(propertyName);
                parameterNames.Add(transformedName);
            }

            return parameterNames;
        }

        private static string TransformUpperCamelCaseToTableHeaders(string input)
        {
            var transformedName = string.Concat(input.Select((x, i) => i > 0 && Char.IsUpper(x) ? " " + x : x.ToString())).TrimStart(' ');
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(transformedName.ToLower());

        }
    }
}
