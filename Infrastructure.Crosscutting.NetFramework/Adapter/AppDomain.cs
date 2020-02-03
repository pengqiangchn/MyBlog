using System.Collections.Generic;
using System.Reflection;
using Microsoft.Extensions.DependencyModel;
using System.Linq;

namespace Infrastructure.Crosscutting.NetFramework.Adapter
{
    public class AppDomain
    {
        public static AppDomain CurrentDomain { get; private set; }

        static AppDomain()
        {
            CurrentDomain = new AppDomain();
        }

        public Assembly[] GetAssemblies()
        {
            var assemblies = new List<Assembly>();
            var dependencies = DependencyContext.Default.RuntimeLibraries.Where(d => d.Name.ToLower().EndsWith("dto") || d.Name.ToLower().EndsWith("dtos"));

            foreach (var library in dependencies)
            {
                var assembly = Assembly.Load(new AssemblyName(library.Name));
                assemblies.Add(assembly);
            }
            return assemblies.ToArray();
        }

        //private static bool IsCandidateCompilationLibrary(RuntimeLibrary compilationLibrary)
        //{
        //    return compilationLibrary.Name == ("NLayerApp")
        //        || compilationLibrary.Dependencies.Any(d => d.Name.StartsWith("NLayerApp"));
        //}
    }
}
