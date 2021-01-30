using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace IssueTracker.Respository
{
    public static class AutoMapProperty
    {
        /// <summary>
        /// Map property of one type to another.
        /// </summary>
        /// <typeparam name="T">Target type.</typeparam>
        /// <typeparam name="S">Source type.</typeparam>
        /// <param name="source">Source type instance.</param>
        /// <returns>Instance of target type.</returns>
        public static T MapProperty<T, S>(S source)
        {
            if (source == null) return default(T);

            // Create Instance.
            T targetInstance = Activator.CreateInstance<T>();
            System.Type targetType = targetInstance.GetType();
            List<PropertyInfo> sourceProperties = source.GetType().GetProperties().ToList();

            sourceProperties.ForEach(srcProp =>
            {
                PropertyInfo targetProp;

                // Check if both property have same name and type.
                if ((targetProp =
                        targetType.GetProperty(srcProp.Name, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance)) != null &&
                        (targetProp.PropertyType.FullName == srcProp.PropertyType.FullName))
                {
                    try
                    {
                        targetProp.SetValue(targetInstance, srcProp.GetValue(source, null));
                    }
                    catch
                    {
                        // Log error.
                    }
                }
            });

            return targetInstance;
        }

        public static List<T> MapPropertyForList<T, S>(List<S> source)
        {
            if (source == null) return null;

            List<T> targetInstance = new List<T>();

            foreach (var listItem in source)
            {
                T instanceT = AutoMapProperty.MapProperty<T, S>(listItem);
                targetInstance.Add(instanceT);
            }

            return targetInstance;
        }
    }
}