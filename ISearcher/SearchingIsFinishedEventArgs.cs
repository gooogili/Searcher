namespace ISorterNamespace
{
    public class SearchingIsFinishedEventArgs
    {
        public string MethodName { get; set; }
        public string SearchResult { get; set; }
        public int StartFromCharacter { get; set; }
        public int LenghtOfLine { get; set; }

        public SearchingIsFinishedEventArgs(string methodName, string searchResult, int startFromCharacter, int lenghtOfLine)
        {
            MethodName = methodName;
            SearchResult = searchResult;
            StartFromCharacter = startFromCharacter;
            LenghtOfLine = lenghtOfLine;
        }
    }
}
