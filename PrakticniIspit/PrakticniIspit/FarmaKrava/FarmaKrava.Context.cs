﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FarmaKrava
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FarmaKravaEntity : DbContext
    {
        public FarmaKravaEntity()
            : base("name=FarmaKravaEntity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Krava> Kravas { get; set; }
        public virtual DbSet<Pasmina> Pasminas { get; set; }
        public virtual DbSet<ProizvodnaMlijeka> ProizvodnaMlijekas { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}