﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimesheetService.Database;

namespace TimesheetService.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200904155157_sp-InsertTimesheetDetails")]
    partial class spInsertTimesheetDetails
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TimesheetService.Database.Entities.DescriptionTB", b =>
                {
                    b.Property<int>("DescriptionId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<int>("ProjectId");

                    b.Property<int>("TimesheetMasterId");

                    b.Property<int>("UserId");

                    b.HasKey("DescriptionId");

                    b.ToTable("descriptionTB");
                });

            modelBuilder.Entity("TimesheetService.Database.Entities.TimesheetAuditTB", b =>
                {
                    b.Property<int>("ApprovalTimesheetLogID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApprovalUser");

                    b.Property<string>("Comment");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime>("ProcessedDate");

                    b.Property<int>("Status");

                    b.Property<int>("TimesheetID");

                    b.Property<int>("UserID");

                    b.HasKey("ApprovalTimesheetLogID");

                    b.ToTable("timesheetAuditTB");
                });

            modelBuilder.Entity("TimesheetService.Database.Entities.TimesheetDetails", b =>
                {
                    b.Property<int>("TimesheetId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("DaysofWeek");

                    b.Property<int>("Hours");

                    b.Property<DateTime>("Period");

                    b.Property<int>("ProjectId");

                    b.Property<int>("TimesheetMasterId");

                    b.Property<int>("TotalHours");

                    b.Property<int>("UserId");

                    b.HasKey("TimesheetId");

                    b.ToTable("timesheetDetails");
                });

            modelBuilder.Entity("TimesheetService.Database.Entities.TimesheetMaster", b =>
                {
                    b.Property<int>("TimesheetMasterId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime>("FromDate");

                    b.Property<int>("TimesheetStatus");

                    b.Property<DateTime>("ToDate");

                    b.Property<int>("TotalHours");

                    b.Property<int>("UserID");

                    b.HasKey("TimesheetMasterId");

                    b.ToTable("timesheetMaster");
                });
#pragma warning restore 612, 618
        }
    }
}
