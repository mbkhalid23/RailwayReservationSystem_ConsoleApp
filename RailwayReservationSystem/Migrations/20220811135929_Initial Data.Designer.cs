﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RailwayReservationSystem.Data;

#nullable disable

namespace RailwayReservationSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220811135929_Initial Data")]
    partial class InitialData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RailwayReservationSystem.Passenger", b =>
                {
                    b.Property<int>("PassengerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PassengerId"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CNIC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PassengerId");

                    b.ToTable("Passengers");

                    b.HasData(
                        new
                        {
                            PassengerId = 1,
                            Age = 26,
                            CNIC = "61101-5621752-1",
                            Contact = "03365266336",
                            DOB = new DateTime(1996, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "M",
                            Name = "Bilal"
                        },
                        new
                        {
                            PassengerId = 2,
                            Age = 26,
                            CNIC = "72202-7652181-3",
                            Contact = "03075266797",
                            DOB = new DateTime(1996, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "M",
                            Name = "Mansoor"
                        },
                        new
                        {
                            PassengerId = 3,
                            Age = 24,
                            CNIC = "83303-1435679-9",
                            Contact = "0307-5266216",
                            DOB = new DateTime(1998, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "M",
                            Name = "Ahsan"
                        });
                });

            modelBuilder.Entity("RailwayReservationSystem.Reservation", b =>
                {
                    b.Property<int>("TicketNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketNo"), 1L, 1);

                    b.Property<int>("PassengerId")
                        .HasColumnType("int");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.HasKey("TicketNo");

                    b.HasIndex("PassengerId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            TicketNo = 1,
                            PassengerId = 1,
                            ScheduleId = 1
                        },
                        new
                        {
                            TicketNo = 2,
                            PassengerId = 2,
                            ScheduleId = 1
                        },
                        new
                        {
                            TicketNo = 3,
                            PassengerId = 3,
                            ScheduleId = 1
                        },
                        new
                        {
                            TicketNo = 4,
                            PassengerId = 3,
                            ScheduleId = 2
                        },
                        new
                        {
                            TicketNo = 5,
                            PassengerId = 3,
                            ScheduleId = 2
                        });
                });

            modelBuilder.Entity("RailwayReservationSystem.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScheduleId"), 1L, 1);

                    b.Property<DateTime>("Arrival")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Departure")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("Journey")
                        .HasColumnType("time");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrainNo")
                        .HasColumnType("int");

                    b.HasKey("ScheduleId");

                    b.HasIndex("TrainNo");

                    b.ToTable("Schedule");

                    b.HasData(
                        new
                        {
                            ScheduleId = 1,
                            Arrival = new DateTime(2022, 8, 9, 23, 45, 0, 0, DateTimeKind.Unspecified),
                            Departure = new DateTime(2022, 8, 9, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Destination = "Karachi",
                            Journey = new TimeSpan(0, 12, 15, 0, 0),
                            Source = "Islamabad",
                            TrainNo = 2
                        },
                        new
                        {
                            ScheduleId = 2,
                            Arrival = new DateTime(2022, 8, 10, 16, 45, 0, 0, DateTimeKind.Unspecified),
                            Departure = new DateTime(2022, 8, 10, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            Destination = "Multan",
                            Journey = new TimeSpan(0, 8, 15, 0, 0),
                            Source = "Karachi",
                            TrainNo = 1
                        },
                        new
                        {
                            ScheduleId = 3,
                            Arrival = new DateTime(2022, 8, 9, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            Departure = new DateTime(2022, 8, 10, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Destination = "Islamabad",
                            Journey = new TimeSpan(0, 2, 30, 0, 0),
                            Source = "Peshawar",
                            TrainNo = 3
                        });
                });

            modelBuilder.Entity("RailwayReservationSystem.Train", b =>
                {
                    b.Property<int>("TrainNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainNo"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("SeatsAvailable")
                        .HasColumnType("int");

                    b.Property<int>("SeatsBooked")
                        .HasColumnType("int");

                    b.HasKey("TrainNo");

                    b.ToTable("Trains");

                    b.HasData(
                        new
                        {
                            TrainNo = 1,
                            Capacity = 200,
                            SeatsAvailable = 197,
                            SeatsBooked = 3
                        },
                        new
                        {
                            TrainNo = 2,
                            Capacity = 100,
                            SeatsAvailable = 100,
                            SeatsBooked = 0
                        },
                        new
                        {
                            TrainNo = 3,
                            Capacity = 150,
                            SeatsAvailable = 150,
                            SeatsBooked = 0
                        });
                });

            modelBuilder.Entity("RailwayReservationSystem.Reservation", b =>
                {
                    b.HasOne("RailwayReservationSystem.Passenger", "Passenger")
                        .WithMany("Reservations")
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RailwayReservationSystem.Schedule", "Schedule")
                        .WithMany("Reservations")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Passenger");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("RailwayReservationSystem.Schedule", b =>
                {
                    b.HasOne("RailwayReservationSystem.Train", "Train")
                        .WithMany("Schedule")
                        .HasForeignKey("TrainNo");

                    b.Navigation("Train");
                });

            modelBuilder.Entity("RailwayReservationSystem.Passenger", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("RailwayReservationSystem.Schedule", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("RailwayReservationSystem.Train", b =>
                {
                    b.Navigation("Schedule");
                });
#pragma warning restore 612, 618
        }
    }
}
