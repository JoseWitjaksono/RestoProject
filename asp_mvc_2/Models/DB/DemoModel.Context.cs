﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace asp_mvc_2.Models.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RestoDBEntities : DbContext
    {
        public RestoDBEntities()
            : base("name=RestoDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<laporan> laporan { get; set; }
        public virtual DbSet<LOOKUPRole> LOOKUPRole { get; set; }
        public virtual DbSet<menu> menu { get; set; }
        public virtual DbSet<pelanggan> pelanggan { get; set; }
        public virtual DbSet<SYSUser> SYSUser { get; set; }
        public virtual DbSet<SYSUserProfile> SYSUserProfile { get; set; }
        public virtual DbSet<SYSUserRole> SYSUserRole { get; set; }
        public virtual DbSet<LOOKUPRole> LOOKUPRoles { get; set; }
        public virtual DbSet<SYSUser> SYSUsers { get; set; }
        public virtual DbSet<SYSUserProfile> SYSUserProfiles { get; set; }
        public virtual DbSet<SYSUserRole> SYSUserRoles { get; set; }
    }
}