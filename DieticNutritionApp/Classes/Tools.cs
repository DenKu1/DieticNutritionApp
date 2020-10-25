using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DieticNutritionApp.Classes
{
    static class Tools
    {
        public static Type GetClassType(string strFullyQualifiedName)
        {
            Type type = Type.GetType(strFullyQualifiedName);

            if (type != null)
                return type;

            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                type = asm.GetType(strFullyQualifiedName);
                if (type != null)
                    return type;
            }

            return null;
        }

        public static List<object> GetFieldsList(object obj)
        {
            var bindingFlags = BindingFlags.Instance |
                   BindingFlags.NonPublic |
                   BindingFlags.Public;
            var fieldValues = obj.GetType()
                                 .GetFields(bindingFlags)
                                 .Select(field => field.GetValue(obj))
                                 .ToList();

            return fieldValues;

        }

        public static string GetBaseFieldName(object obj)
        {
            var bindingFlags = BindingFlags.Instance |
                   BindingFlags.NonPublic |
                   BindingFlags.Public;
            var name = obj.GetType()
                            .BaseType
                            .GetField("name", bindingFlags)
                            .GetValue(obj).
                            ToString();
            return name;

        }

    }
}
