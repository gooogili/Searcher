using System.Collections.Generic;
using ISorterNamespace;

namespace SearchInFile.View.Interfaces
{
    public interface IMainView
    {
        void ShowSearchResults(string methodName, string searchResult, int startResult, int lineLenght);
    }
}
