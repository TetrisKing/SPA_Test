using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace SPATest
{
    public class TrainingProductViewModel
    {
        public TrainingProductViewModel()
        {
            Products = new List<TrainingProduct>();
            EventCommand = "List";
            ListMode();
        }

        public string EventCommand { get; set; }
        public List<TrainingProduct> Products { get; set; }
        public TrainingProduct  SearchEntity { get; set; }
        public bool IsListAreaVisible { get; set; }
        public bool IsSearchAreaVisible { get; set; }
        public bool IsAddAreaVisible { get; set; }

        public TrainingProduct Entity { get; set; }
        public bool IsValid { get; set; }
        public string Mode { get; set; }

        public void HandleRequest()
        {
            switch (EventCommand.ToLower())
            {
                case "list":
                case "search":
                    Get();
                    break;
                case "resetsearch":
                    ResetSearch();
                    Get();
                    break;
                case "add":
                    Add();
                    break;
                case "canceladd":
                    ListMode();
                    break;
                case "save":
                    break;
            }
        }

        private void Add()
        {
            IsValid = true;
            Entity = new TrainingProduct() { IntroductionDate = DateTime.Now, URL = string.Empty, Price = 0 };
            AddMode();
        }


        private void Get()
        {
            TrainingProductManager tgr = new TrainingProductManager();
            Products = tgr.Get(SearchEntity);
        }
        private void ResetSearch()
        {
            SearchEntity = new TrainingProduct();
        }

        private void ListMode()
        {
            IsSearchAreaVisible = true;
            IsListAreaVisible = true;
            IsAddAreaVisible = false;
            Mode = "List;"
        }
        private void AddMode()
        {
            IsSearchAreaVisible = false;
            IsListAreaVisible = false;
            IsAddAreaVisible = true; 
            Mode = "Add;"
        }


    }
}