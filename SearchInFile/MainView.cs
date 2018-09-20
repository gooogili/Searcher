using System;
using System.Collections.Generic;
using ISorterNamespace;
using SearchInFile.Presenters;
using SearchInFile.View.Interfaces;

namespace SearchInFile.View
{
    class MainView : IMainView
    {
        private Presenter presenter;
        readonly List<ISearcher> searchers = new List<ISearcher>();

        public MainView()
        {
            presenter = new Presenter(this);
            presenter.OnMainViewLoad();
            CreateMainMenu();
        } 

        public void CreateMainMenu()
        {
            string choiseButton;
            int pressedButton;
            string pathToFile = "";

            do
            {
                Console.Clear();
                Console.WriteLine("### MAIN MENU ###");
                Console.WriteLine("Press 1 for searching in file");
                Console.WriteLine("Press 2 for reading information about modules");
                Console.WriteLine("Press 3 for exit");
                Console.Write("\n" + "Press any key: ");

                choiseButton = Console.ReadLine();

                if (int.TryParse(choiseButton, out pressedButton))
                {
                    switch (pressedButton)
                    {
                        case 1:
                            Console.Clear();
                            if (pathToFile == "")
                            {
                                Console.WriteLine("Please, enter fool path to file");
                                Console.Write("> ");
                                pathToFile = Console.ReadLine();
                            }                            
                            bool isExistedFile = presenter.IsFileExist(pathToFile);
                            if (!isExistedFile)
                            {
                                pathToFile = "";
                                Console.WriteLine("File not found. Check if path is correct");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please, enter text for search");
                                Console.Write("> ");
                                string searchQuery = Console.ReadLine();
                                presenter.StartSearch(searchQuery, pathToFile);
                            }
                            Console.WriteLine("\nPlease, press any key");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            List<string> informationAboutSearchers = presenter.GetInformationAboutSeachers();
                            foreach (var aboutSearcher in informationAboutSearchers)
                            {
                                Console.WriteLine();
                                Console.WriteLine(aboutSearcher);
                            }
                            Console.ReadKey();
                            break;
                        case 3:
                            break;
                        default:
                            Console.Clear();
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                }


            } while (pressedButton != 3);
        }

        public void ShowSearchResults(string methodName, string searchResult, int startResult, int lineLenght)
        {
            if ((startResult == 0) && (lineLenght == 0))
            {
                Console.WriteLine(methodName + "wasn't found anything.");
            }
            else
            {
                string firstPartOfLine = searchResult.Substring(0, startResult);
                string secondPartOfLine = searchResult.Substring(startResult, lineLenght);
                string thirdPartOfLine = searchResult.Substring(lineLenght + startResult);
                Console.Write(methodName + "found search query in this line: " + firstPartOfLine);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(secondPartOfLine);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(thirdPartOfLine);
            }

        }
    }
}
