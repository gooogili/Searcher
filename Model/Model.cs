﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchInFile.Models.Interfaces;
using ISorterNamespace;

namespace SearchInFile.Models
{
    public class Model : IModel
    {
        public List<ISearcher> Searchers { get; set; }
        public List<string> namesOfSeachers { get; set; }
        public StreamReader fileContent { get; set; }

        private static Model _modelInstance;

        public static Model GetModelInstance()
        {
            if (_modelInstance == null)
            {
                _modelInstance = new Model();
            }
            return _modelInstance;
        }

        public string[] LoadFile(string fullPathToFile)
        {
            string[] fileContent = File.ReadAllLines(fullPathToFile);
            
            return fileContent;
        }

        public void SeachersLoading()
        {
            Searchers = DllHunter.FindSearchers();
        }
    }
}
