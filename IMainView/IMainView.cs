using System.Collections.Generic;
using ISorterNamespace;

namespace SearchInFile.View.Interfaces
{
    public interface IMainView
    {
        void CreateMainMenu(List<ISearcher> searchers);
        void ShowSearchResults(string methodName, string searchResult, int startResult, int lineLenght);
    }
}
