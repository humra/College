using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NIAMU.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ChampionsModel : DbContext
    {
        public ChampionsModel()
            : base("name=ChampionsModelConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Champions> Champions { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Roles>()
                .HasMany(e => e.Champions)
                .WithRequired(e => e.Roles)
                .HasForeignKey(e => e.Role)
                .WillCascadeOnDelete(false);
        }
    }
}