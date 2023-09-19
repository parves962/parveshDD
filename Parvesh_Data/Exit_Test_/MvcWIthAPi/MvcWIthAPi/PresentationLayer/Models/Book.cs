using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWIthAPi.PresentationLayer.Models
{
    public class Book
    {
        [Key]
        public int id { get; set; }

        public string BRN { get; set; }

        public int Campid { get; set; }

        public string Address { get; set; }
        public string State { get; set; }

        public string Country { get; set; }

        public int Zipcode { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
