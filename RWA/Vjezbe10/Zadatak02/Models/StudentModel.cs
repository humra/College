using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zadatak02.Models
{
    public class StudentModel
    {
        public Guid StudentID { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string email { get; set; }
        public string status { get; set; }

        public StudentModel() { }
    }
}