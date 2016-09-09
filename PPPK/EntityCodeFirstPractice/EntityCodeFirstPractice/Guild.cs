using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityCodeFirstPractice
{
    public class Guild
    {
        [Key]
        public int guildID { get; set; }
        public string name { get; set; }

        public virtual List<Member> members { get; set; }

        public Guild() { }
    }
}