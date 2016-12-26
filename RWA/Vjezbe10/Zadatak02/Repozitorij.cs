using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zadatak02.Models;

namespace Zadatak02
{
    public static class Repozitorij
    {
        public static List<StudentModel> studenti { get; set; }

        static Repozitorij()
        {
            studenti = new List<StudentModel>();
        }

        public static void DodajStudenta(StudentModel student)
        {
            studenti.Add(student);
        }
    }
}