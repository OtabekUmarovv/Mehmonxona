﻿// <auto-generated />
using System;
using Mehmonxona.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Mehmonxona.Data.Migrations
{
    [DbContext(typeof(MehmonxonaDbContext))]
    [Migration("20220803160138_ProjectComplite")]
    partial class ProjectComplite
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("ClientConference", b =>
                {
                    b.Property<long>("ClientsId")
                        .HasColumnType("bigint");

                    b.Property<long>("ConferencesId")
                        .HasColumnType("bigint");

                    b.HasKey("ClientsId", "ConferencesId");

                    b.HasIndex("ConferencesId");

                    b.ToTable("ClientConference");
                });

            modelBuilder.Entity("Mehmonxona.Domain.Entities.Clients.Client", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("Passport")
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Mehmonxona.Domain.Entities.Conferences.ClientConference", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("ClientId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CoferenceId")
                        .HasColumnType("bigint");

                    b.Property<long>("ConferenceId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("CoferenceId");

                    b.ToTable("ClientConferences");
                });

            modelBuilder.Entity("Mehmonxona.Domain.Entities.Conferences.Conference", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long?>("RoomId")
                        .HasColumnType("bigint");

                    b.Property<long>("Room_id")
                        .HasColumnType("bigint");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Time")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Conferences");
                });

            modelBuilder.Entity("Mehmonxona.Domain.Entities.Conferences.EmployeeConference", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("ConferenceId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("EmployeeId")
                        .HasColumnType("bigint");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ConferenceId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeConferences");
                });

            modelBuilder.Entity("Mehmonxona.Domain.Entities.Employees.Employee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<long?>("ConferenceId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Department")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("Passport")
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("numeric");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ConferenceId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Mehmonxona.Domain.Entities.Orders.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("ClientId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("EmployeeId")
                        .HasColumnType("bigint");

                    b.Property<long>("PaymentId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoomId")
                        .HasColumnType("bigint");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("RoomId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Mehmonxona.Domain.Entities.Orders.Payment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Mehmonxona.Domain.Entities.Rooms.Room", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Sign")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("ClientConference", b =>
                {
                    b.HasOne("Mehmonxona.Domain.Entities.Clients.Client", null)
                        .WithMany()
                        .HasForeignKey("ClientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mehmonxona.Domain.Entities.Conferences.Conference", null)
                        .WithMany()
                        .HasForeignKey("ConferencesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Mehmonxona.Domain.Entities.Conferences.ClientConference", b =>
                {
                    b.HasOne("Mehmonxona.Domain.Entities.Clients.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mehmonxona.Domain.Entities.Conferences.Conference", "Conference")
                        .WithMany()
                        .HasForeignKey("CoferenceId");

                    b.Navigation("Client");

                    b.Navigation("Conference");
                });

            modelBuilder.Entity("Mehmonxona.Domain.Entities.Conferences.Conference", b =>
                {
                    b.HasOne("Mehmonxona.Domain.Entities.Rooms.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Mehmonxona.Domain.Entities.Conferences.EmployeeConference", b =>
                {
                    b.HasOne("Mehmonxona.Domain.Entities.Conferences.Conference", "Conference")
                        .WithMany()
                        .HasForeignKey("ConferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mehmonxona.Domain.Entities.Employees.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conference");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Mehmonxona.Domain.Entities.Employees.Employee", b =>
                {
                    b.HasOne("Mehmonxona.Domain.Entities.Conferences.Conference", null)
                        .WithMany("Employees")
                        .HasForeignKey("ConferenceId");
                });

            modelBuilder.Entity("Mehmonxona.Domain.Entities.Orders.Order", b =>
                {
                    b.HasOne("Mehmonxona.Domain.Entities.Clients.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mehmonxona.Domain.Entities.Employees.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mehmonxona.Domain.Entities.Orders.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mehmonxona.Domain.Entities.Rooms.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Employee");

                    b.Navigation("Payment");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Mehmonxona.Domain.Entities.Orders.Payment", b =>
                {
                    b.HasOne("Mehmonxona.Domain.Entities.Orders.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Mehmonxona.Domain.Entities.Clients.Client", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Mehmonxona.Domain.Entities.Conferences.Conference", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Mehmonxona.Domain.Entities.Employees.Employee", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}