using ISorterNamespace;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace SearchInFile.Models
{
    static public class DllHunter
    {
        static public List<ISearcher> FindSearchers()
        {
            List<ISearcher> searchers = new List<ISearcher>();

            string[] dllFiles = Directory.GetFiles(".\\DllModules\\", "*.dll");

            foreach (string dllFile in dllFiles)
            {
                Assembly assembly = Assembly.LoadFile(Path.GetFullPath(dllFile));
                foreach (Type item in assembly.GetTypes())
                {
                    if (!item.IsClass) continue;
                    if (item.GetInterfaces().Contains(typeof(ISearcher)))
                    {
                        searchers.Add((ISearcher)Activator.CreateInstance(item));
                        if (searchers.Count == 2)
                        {
                            return searchers;
                        }
                    }
                }
            }

            return searchers;
        }

    }
}
