using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityCodeFirstPractice
{
    public class GuildManagementContext : DbContext
    {
        public DbSet<Guild> guilds { get; set; }
        public DbSet<Member> members { get; set; }
    }
}