using SearchInFile.Models.Interfaces;
using SearchInFile.View.Interfaces;
using System.IO;
using System.Collections.Generic;
using SearchInFile.Models;
using ISorterNamespace;

namespace SearchInFile.Presenters
{
    public class Presenter
    {
        private readonly IMainView _view;
        private readonly IModel _model;

        public Presenter(IMainView view)
        {
            _view = view;
            _model = Model.GetModelInstance();
        }

        public void OnMainViewLoad()
        {
            _model.SeachersLoading();
        }

        public List<string> GetInformationAboutSeachers()
        {
            List<string> seachersInformation = new List<string>();
            string seacherInformation = "";

            foreach (var seacher in _model.Searchers)
            {
                seacherInformation = "Name: " + seacher.MethodName + ";\n Description: " + seacher.MethodDescription + ";\n Version: " + seacher.MethodVersion;
                seachersInformation.Add(seacherInformation);
            }

            return seachersInformation;
        }

        public bool IsFileExist(string fullPathToFile)
        {
            if (File.Exists(fullPathToFile))
            {
                return true;
            }
            return false;
        }

        public void StartSearch(string searchQuery, string fullPathToFile)
        {
            string[] fileContent = _model.LoadFile(fullPathToFile);
            foreach (var searcher in _model.Searchers)
            {
                searcher.SearchingIsFinished += OnSearchingFinished;
                searcher.Search(searchQuery, fileContent);
                searcher.SearchingIsFinished -= OnSearchingFinished;
            }
        }

        public void OnSearchingFinished(object sender, SearchingIsFinishedEventArgs e)
        {
            _view.ShowSearchResults(e.MethodName, e.SearchResult, e.StartFromCharacter, e.LenghtOfLine);
        }
    }
}
