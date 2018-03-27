﻿// <auto-generated />
using DAB2_2RDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DAB2_2RDB.Migrations
{
    [DbContext(typeof(Dab2_2RdbContext))]
    [Migration("20180326181644_AddressTypes")]
    partial class AddressTypes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAB2_2RDB.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("HouseNumber");

                    b.Property<string>("StreetName");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("DAB2_2RDB.Models.AddressType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressId");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("AddressTypes");
                });

            modelBuilder.Entity("DAB2_2RDB.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Context")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("MiddleName");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("DAB2_2RDB.Models.PersonAddress", b =>
                {
                    b.Property<int>("PersonId");

                    b.Property<int>("AddressId");

                    b.HasKey("PersonId", "AddressId");

                    b.HasIndex("AddressId");

                    b.ToTable("PersonAddresses");
                });

            modelBuilder.Entity("DAB2_2RDB.Models.PersonAddressType", b =>
                {
                    b.Property<int>("PersonId");

                    b.Property<int>("AddressTypeId");

                    b.HasKey("PersonId", "AddressTypeId");

                    b.HasIndex("AddressTypeId");

                    b.ToTable("PersonAddressTypes");
                });

            modelBuilder.Entity("DAB2_2RDB.Models.PhoneNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Number")
                        .IsRequired();

                    b.Property<int>("PersonId");

                    b.Property<int?>("TelephoneCompanyId");

                    b.Property<string>("Usage");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("TelephoneCompanyId");

                    b.ToTable("PhoneNumbers");
                });

            modelBuilder.Entity("DAB2_2RDB.Models.TelephoneCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TelephoneCompanies");
                });

            modelBuilder.Entity("DAB2_2RDB.Models.AddressType", b =>
                {
                    b.HasOne("DAB2_2RDB.Models.Address", "Address")
                        .WithMany("AddressTypes")
                        .HasForeignKey("AddressId");
                });

            modelBuilder.Entity("DAB2_2RDB.Models.PersonAddress", b =>
                {
                    b.HasOne("DAB2_2RDB.Models.Address", "Address")
                        .WithMany("PersonAddresses")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAB2_2RDB.Models.Person", "Person")
                        .WithMany("PersonAddresses")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAB2_2RDB.Models.PersonAddressType", b =>
                {
                    b.HasOne("DAB2_2RDB.Models.AddressType", "AddressType")
                        .WithMany()
                        .HasForeignKey("AddressTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAB2_2RDB.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAB2_2RDB.Models.PhoneNumber", b =>
                {
                    b.HasOne("DAB2_2RDB.Models.Person", "Person")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAB2_2RDB.Models.TelephoneCompany", "TelephoneCompany")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("TelephoneCompanyId");
                });
#pragma warning restore 612, 618
        }
    }
}
