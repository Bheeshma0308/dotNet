using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace studentdetails.Models
{
    public class Studentviewmodel
    {
        public int Id { get; set; }
        [DisplayName("FName")]
        public string FName { get; set; }
        [DisplayName("LName")]
        public string LName { get; set; }
        [DisplayName("DOB")]
        public DateTime DOB { get; set; }
        [DisplayName("address")]
        public string address { get; set; }
        [DisplayName("Name")]
        public string fullname { 
            get { return FName + " " + LName; } 
        }

    }
}
