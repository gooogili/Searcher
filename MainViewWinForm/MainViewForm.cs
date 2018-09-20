using ISorterNamespace;
using SearchInFile.Presenters;
using SearchInFile.View.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainViewWinForm
{
    public partial class MainViewForm : Form, IMainView
    {
        private Presenter _presenter;
        private string FilePath { get; set; }

        public MainViewForm()
        {
            InitializeComponent();
            _presenter = new Presenter(this);
            _presenter.OnMainViewLoad();
        }

        private void startSearchButton_Click(object sender, EventArgs e)
        {
            string searchQuery = searchTextBox.Text;
            if ((searchQuery == ""))
            {
                searchResultRichTextBox.Clear();
                searchResultRichTextBox.Text = "Empty search line. Please, enter search query.";
            }            
            else if ((FilePath == "") || (FilePath == null))
            {
                searchResultRichTextBox.Clear();
                searchResultRichTextBox.Text = "File not exist! Please, add file.";
            }
            else
            {
                searchResultRichTextBox.Clear();
                _presenter.StartSearch(searchQuery, FilePath);
            }
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            string fileName = null;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;
                }
            }

            if (fileName != null)
            {
                FilePath = fileName;
            }
        }

        private void getInformationAboutModulesButton_Click(object sender, EventArgs e)
        {
            searchResultRichTextBox.Clear();

            List<string> informationAboutSearchers = _presenter.GetInformationAboutSeachers();
            foreach (var aboutSearcher in informationAboutSearchers)
            {
                searchResultRichTextBox.Text += aboutSearcher + Environment.NewLine;
            }
        }

        public void ShowSearchResults(string methodName, string searchResult, int startResult, int lineLenght)
        {
            if ((startResult == 0) && (lineLenght == 0))
            {
                searchResultRichTextBox.Text += methodName + "wasn't found anything." + Environment.NewLine;
            }
            else
            {
                searchResultRichTextBox.Text += methodName + "found search query in this line: " + searchResult + Environment.NewLine;                
            }
        }
    }
}
