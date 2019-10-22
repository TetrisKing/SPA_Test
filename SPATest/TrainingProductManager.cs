using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace SPATest
{
    public class TrainingProductManager
    {
        public List<TrainingProduct> Get(TrainingProduct searchEntity)
        {
            List<TrainingProduct> ret = new List<TrainingProduct>();
            ret.Add(CreateTrainingProduct(1,"Tractor", "2019-10-01", "urlurl", 10.99m));
            ret.Add(CreateTrainingProduct(1, "Double Tractor", "2019-10-02", "urlurl", 100.99m));
            ret.Add(CreateTrainingProduct(1, "Plane", "2019-09-01", "urlurl", 12.99m));
            ret.Add(CreateTrainingProduct(1, "Shed", "2019-08-01", "urlurl", 18.99m));
            ret.Add(CreateTrainingProduct(1, "Chair", "2018-10-01", "urlurl", 1.09m));
            if (searchEntity != null && !string.IsNullOrEmpty(searchEntity.ProductName))
            {
                ret = ret.FindAll(t => t.ProductName.ToLower().Contains(searchEntity.ProductName.ToLower()));
            }

            return ret;
        }

        private TrainingProduct CreateTrainingProduct(int Id, string name, string date, string url, decimal price)
        {
            return new TrainingProduct() { ProductId = Id, ProductName = name, IntroductionDate = Convert.ToDateTime(date), URL = url, Price = price };
        }
    }
}