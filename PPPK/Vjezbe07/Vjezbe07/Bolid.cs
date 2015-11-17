using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe07
{
    public class Bolid
    {
        public int ID { get; set; }
        public int IDVozac { get; set; }
        public string Naziv { get; set; }

        public Bolid() { }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
