using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityCodeFirstPractice
{
    public class GuildManagementInitializer : System.Data.Entity.CreateDatabaseIfNotExists<GuildManagementContext>
    {
        protected override void Seed(GuildManagementContext context)
        {
            //DO THE THING
        }
    }
}