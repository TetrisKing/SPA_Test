using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPATest
{
    public class TrainingProduct
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public DateTime IntroductionDate { get; set; }
        public string URL { get; set; }
        public decimal Price { get; set; }
    }
}