using ISorterNamespace;
using System;
using System.Text.RegularExpressions;

namespace ExactSearch
{
    class ExactSearch : ISearcher
    {
        public string MethodName => "Exact Search";

        public string MethodDescription => "This search method is case-sensitive and count number of spaces";

        public string MethodVersion => "v1";

        public event EventHandler<SearchingIsFinishedEventArgs> SearchingIsFinished;

        public void Search(string textForSearching, string[] fileContent)
        {
            string searchResult;

            Regex regex = new Regex(textForSearching);
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
