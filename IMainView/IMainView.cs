using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISorterNamespace;

namespace SearchInFile.View.Interfaces
{
    public interface IMainView
    {
        void CreateMainMenu(List<ISearcher> searchers);
        void ShowSearchResults(string methodName, string searchResult, int startResult, int lineLenght);
    }
}
