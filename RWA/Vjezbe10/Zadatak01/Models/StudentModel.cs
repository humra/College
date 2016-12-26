using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zadatak01.Models
{
    public class StudentModel
    {
        public string ime { get; set; }
        public string prezime { get; set; }
        public string dolazak { get; set; }
        public string laptop { get; set; }

        public StudentModel() { }
    }
}