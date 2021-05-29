using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PD.Service.Contact.Data
{

    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        {
        }

        public DbSet<Models.Contact> Contacts { get; set; }
        public DbSet<Models.ContactInfo> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Contact>().ToTable("Contact");
            modelBuilder.Entity<Models.Contact>().Property(s => s.Name).IsRequired();
            modelBuilder.Entity<Models.Contact>().Property(s => s.LastName).IsRequired();
            modelBuilder.Entity<Models.Contact>().Property(s => s.UUID).IsRequired();
            modelBuilder.Entity<Models.Contact>().HasKey(s => s.ID);


            modelBuilder.Entity<Models.ContactInfo>().ToTable("ContactInfo");
            modelBuilder.Entity<Models.ContactInfo>().Property(s => s.ContactInfoType).IsRequired();
            modelBuilder.Entity<Models.ContactInfo>().Property(s => s.ContactInfoContent).IsRequired();
        }
    }

}
