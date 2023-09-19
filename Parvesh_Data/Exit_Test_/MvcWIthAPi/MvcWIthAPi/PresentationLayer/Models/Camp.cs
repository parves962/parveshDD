using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWIthAPi.PresentationLayer.Models
{
    public class Camp
    {
        [Key]
        public int id { get; set; }

        public string Campname { get; set; }

        
        public int Rate { get; set; }

        
        public int Capacity { get; set; }

        public string Desciption { get; set; }

        public int TotalStay { get; set; }


        public bool? Flag { get; set; }

        [DataType(DataType.Date)]
        public DateTime  Checkin { get; set; }

        [DataType(DataType.Date)]
        public DateTime Checkout { get; set; }

        public string? Image { get; set; }

        public float AverageRating { get; set; }

        public int UserCounter { get; set; }

        public int OverallRating { get; set; }
    }
}
