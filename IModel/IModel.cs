using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISorterNamespace;

namespace SearchInFile.Models.Interfaces
{
    public interface IModel
    {
        List<ISearcher> Searchers { get; set; }
        List<string> namesOfSeachers { get; set; }

        void SeachersLoading();
        string[] LoadFile(string fullPathToFile);

    }
}
