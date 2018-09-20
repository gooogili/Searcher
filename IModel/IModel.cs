using System.Collections.Generic;
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
