using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace studentdetails.Models.DBEntites
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName ="varchar(50)")]
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime DOB { get; set; }
        public string address { get; set; }


    }
}
