﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookLove.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbBookLoveEntities : DbContext
    {
        public dbBookLoveEntities()
            : base("name=dbBookLoveEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<Publisher> Publisher { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<Supple> Supple { get; set; }
        public virtual DbSet<Basket> Basket { get; set; }
    }
}
