﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAB2_2.Lib
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DABHandin_2_2Entities : DbContext
    {
        public DABHandin_2_2Entities() : base("name=DABHandin_2_2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AddressType> AddressTypes { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<CountryCode> CountryCodes { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TelephoneCompany> TelephoneCompanies { get; set; }
        public virtual DbSet<TelephoneNumber> TelephoneNumbers { get; set; }
        public virtual DbSet<ZipCode> ZipCodes { get; set; }
    }
}
