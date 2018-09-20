using ISorterNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace InexactSearch
{
    class InexactSearch : ISearcher
    {
        public string MethodName => "Inexact Search";

        public string MethodDescription => "This search method is is case-sensitive and does not pay attention to spaces";

        public string MethodVersion => "v1";

        public event EventHandler<SearchingIsFinishedEventArgs> SearchingIsFinished;

        public void Search(string textForSearching, string[] fileContent)
        {
            string searchResult;
            textForSearching = textForSearching.Replace("\\s+", " ");
            Regex regex = new Regex(textForSearching, RegexOptions.IgnoreCase);

            foreach (var line in fileContent)
            {
                var searchResultMatch = regex.Match(line);
                if (searchResultMatch.Success)
                {
                    searchResult = line;
                    SearchingIsFinished?.Invoke(this, new SearchingIsFinishedEventArgs(MethodName, line, searchResultMatch.Index, searchResultMatch.Length));
                    return;
                }
            }

            searchResult = "";
            SearchingIsFinished?.Invoke(this, new SearchingIsFinishedEventArgs(MethodName, searchResult, 0, 0));
        }
    }
}
