﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LinkedInContext : DbContext
    {
        public LinkedInContext()
            : base("name=LinkedInContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<aspnet_Applications> aspnet_Applications { get; set; }
        public virtual DbSet<aspnet_Membership> aspnet_Membership { get; set; }
        public virtual DbSet<aspnet_Paths> aspnet_Paths { get; set; }
        public virtual DbSet<aspnet_PersonalizationAllUsers> aspnet_PersonalizationAllUsers { get; set; }
        public virtual DbSet<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }
        public virtual DbSet<aspnet_Profile> aspnet_Profile { get; set; }
        public virtual DbSet<aspnet_Roles> aspnet_Roles { get; set; }
        public virtual DbSet<aspnet_SchemaVersions> aspnet_SchemaVersions { get; set; }
        public virtual DbSet<aspnet_Users> aspnet_Users { get; set; }
        public virtual DbSet<aspnet_WebEvent_Events> aspnet_WebEvent_Events { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Connection_Requeset> Connection_Requeset { get; set; }
        public virtual DbSet<Education_Organization> Education_Organization { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Like> Likes { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Profile_Views> Profile_Views { get; set; }
        public virtual DbSet<Shared_Post> Shared_Post { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User_Com_Experience> User_Com_Experience { get; set; }
        public virtual DbSet<User_Details> User_Details { get; set; }
        public virtual DbSet<User_Education> User_Education { get; set; }
        public virtual DbSet<User_Language> User_Language { get; set; }
        public virtual DbSet<User_Skill> User_Skill { get; set; }
    }
}