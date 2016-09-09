using System.ComponentModel.DataAnnotations;

namespace EntityCodeFirstPractice
{
    public class Member
    {
        [Key]
        public int memberID { get; set; }
        public string nickname { get; set; }
        public int guildID { get; set; }

        public virtual Guild guild { get; set; }

        public Member() { }
    }
}