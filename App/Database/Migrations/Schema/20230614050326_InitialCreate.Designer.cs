﻿// <auto-generated />
using AutoTrack.App.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutoTrack.App.Database.Migrations.Schema
{
    [DbContext(typeof(AutoTrackDbContext))]
    [Migration("20230614050326_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AutoTrack.App.Notes.Models.Note", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("AutoTrack.App.Organizations.Models.Organization", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Subdomain")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.HasIndex("Subdomain");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("AutoTrack.App.ProcessSteps.Models.ProcessStep", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("ProcessId")
                        .HasColumnType("bigint");

                    b.Property<long>("StepId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("ProcessStep");
                });

            modelBuilder.Entity("AutoTrack.App.Processes.Models.Process", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<long>("WorkshopId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Processes");
                });

            modelBuilder.Entity("AutoTrack.App.Statuses.Models.Status", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<long>("WorkshopId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("AutoTrack.App.Steps.Models.Step", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<long>("WorkshopId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Steps");
                });

            modelBuilder.Entity("AutoTrack.App.VehicleProcessSteps.Models.VehicleProcessStep", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("Done")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<long>("StatusId")
                        .HasColumnType("bigint");

                    b.Property<long>("StepId")
                        .HasColumnType("bigint");

                    b.Property<long>("VehicleProcessId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("VehicleProcessSteps");
                });

            modelBuilder.Entity("AutoTrack.App.Vehicles.Models.Vehicle", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<long>("OrganizationId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("AutoTrack.App.VehileProcesses.Models.VehicleProcess", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Done")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<long>("ProcessId")
                        .HasColumnType("bigint");

                    b.Property<long>("StatusId")
                        .HasColumnType("bigint");

                    b.Property<string>("VehicleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long>("WorkshopId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("VehicleProcesses");
                });

            modelBuilder.Entity("AutoTrack.App.Workshops.Models.Workshop", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("OrganizationId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Workshops");
                });

            modelBuilder.Entity("NoteVehicleProcess", b =>
                {
                    b.Property<long>("NotesId")
                        .HasColumnType("bigint");

                    b.Property<long>("VehicleProcessId")
                        .HasColumnType("bigint");

                    b.HasKey("NotesId", "VehicleProcessId");

                    b.ToTable("NoteVehicleProcess");
                });

            modelBuilder.Entity("NoteVehicleProcessStep", b =>
                {
                    b.Property<long>("NotesId")
                        .HasColumnType("bigint");

                    b.Property<long>("VehicleProcessStepId")
                        .HasColumnType("bigint");

                    b.HasKey("NotesId", "VehicleProcessStepId");

                    b.ToTable("NoteVehicleProcessStep");
                });

            modelBuilder.Entity("AutoTrack.App.ProcessSteps.Models.ProcessStep", b =>
                {
                    b.HasOne("AutoTrack.App.Processes.Models.Process", "Process")
                        .WithMany()
                        .HasForeignKey("ProcessId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AutoTrack.App.Steps.Models.Step", "Step")
                        .WithMany()
                        .HasForeignKey("StepId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Process");

                    b.Navigation("Step");
                });

            modelBuilder.Entity("AutoTrack.App.Processes.Models.Process", b =>
                {
                    b.HasOne("AutoTrack.App.Workshops.Models.Workshop", null)
                        .WithMany()
                        .HasForeignKey("WorkshopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AutoTrack.App.Statuses.Models.Status", b =>
                {
                    b.HasOne("AutoTrack.App.Workshops.Models.Workshop", null)
                        .WithMany()
                        .HasForeignKey("WorkshopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AutoTrack.App.Steps.Models.Step", b =>
                {
                    b.HasOne("AutoTrack.App.Workshops.Models.Workshop", null)
                        .WithMany()
                        .HasForeignKey("WorkshopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AutoTrack.App.VehicleProcessSteps.Models.VehicleProcessStep", b =>
                {
                    b.HasOne("AutoTrack.App.Statuses.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AutoTrack.App.Steps.Models.Step", "Step")
                        .WithMany()
                        .HasForeignKey("StepId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AutoTrack.App.VehileProcesses.Models.VehicleProcess", null)
                        .WithMany("VehicleProcessSteps")
                        .HasForeignKey("VehicleProcessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Status");

                    b.Navigation("Step");
                });

            modelBuilder.Entity("AutoTrack.App.Vehicles.Models.Vehicle", b =>
                {
                    b.HasOne("AutoTrack.App.Organizations.Models.Organization", null)
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AutoTrack.App.VehileProcesses.Models.VehicleProcess", b =>
                {
                    b.HasOne("AutoTrack.App.Processes.Models.Process", "Process")
                        .WithMany()
                        .HasForeignKey("ProcessId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AutoTrack.App.Statuses.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AutoTrack.App.Vehicles.Models.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId");

                    b.HasOne("AutoTrack.App.Workshops.Models.Workshop", null)
                        .WithMany()
                        .HasForeignKey("WorkshopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Process");

                    b.Navigation("Status");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("AutoTrack.App.Workshops.Models.Workshop", b =>
                {
                    b.HasOne("AutoTrack.App.Organizations.Models.Organization", null)
                        .WithMany("Workshops")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NoteVehicleProcess", b =>
                {
                    b.HasOne("AutoTrack.App.Notes.Models.Note", null)
                        .WithMany()
                        .HasForeignKey("NotesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoTrack.App.VehileProcesses.Models.VehicleProcess", null)
                        .WithMany()
                        .HasForeignKey("VehicleProcessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NoteVehicleProcessStep", b =>
                {
                    b.HasOne("AutoTrack.App.Notes.Models.Note", null)
                        .WithMany()
                        .HasForeignKey("NotesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoTrack.App.VehicleProcessSteps.Models.VehicleProcessStep", null)
                        .WithMany()
                        .HasForeignKey("VehicleProcessStepId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AutoTrack.App.Organizations.Models.Organization", b =>
                {
                    b.Navigation("Workshops");
                });

            modelBuilder.Entity("AutoTrack.App.VehileProcesses.Models.VehicleProcess", b =>
                {
                    b.Navigation("VehicleProcessSteps");
                });
#pragma warning restore 612, 618
        }
    }
}
