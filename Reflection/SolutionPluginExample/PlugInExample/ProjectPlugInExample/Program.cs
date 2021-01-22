using System;
using System.Linq;
using System.Reflection;

namespace ProjectPlugInExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Assembly pluginAssembly = Assembly.LoadFile(@"C:\Users\spere\source\repos\Aprende-a-programar-desde-cero-con-C-de-Microsoft-.NET\Reflection\SolutionPluginExample\PlugInExample\MyPlugin\bin\Debug\net5.0\MyPlugin.dll");
            var plugins = from type in pluginAssembly.GetTypes()
                          where typeof(IPlugin).IsAssignableFrom(type) && !type.IsInterface
                          select type;
            foreach (Type pluginType in plugins)
            {
                IPlugin plugin = Activator.CreateInstance(pluginType) as IPlugin;
                DumpObject(plugin);
                Console.Read();
            }
        }

        static void DumpObject(object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (PropertyInfo property in properties)
            {
                if (property.PropertyType == typeof(string))
                {
                    Console.WriteLine($"{property.Name} : {property.GetValue(obj)}");
                }
            }
        }
    }
}
