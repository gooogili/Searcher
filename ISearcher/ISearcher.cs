using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISorterNamespace
{
    public interface ISearcher
    {
        string MethodName { get; }
        string MethodDescription { get; }
        string MethodVersion { get; }

        event EventHandler<SearchingIsFinishedEventArgs> SearchingIsFinished;

        void Search(string textForSearching, string[] fileContent);
    }
}
