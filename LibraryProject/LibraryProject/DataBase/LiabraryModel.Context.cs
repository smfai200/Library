﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryProject.DataBase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LiabraryEntities : DbContext
    {
        public LiabraryEntities()
            : base("name=LiabraryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<BookPlace> BookPlaces { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Catagory> Catagories { get; set; }
        public virtual DbSet<IssuedBook> IssuedBooks { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<Student> Students { get; set; }
    }
}