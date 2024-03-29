﻿// <auto-generated />
using System;
using ChamadaFiap;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChamadaFiap.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240202002858_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ChamadaFiap.Entities.Attendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AttendanceTypeId")
                        .HasColumnType("int");

                    b.Property<int>("ClassPeriodId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Finish")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Start")
                        .HasColumnType("datetime2");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AttendanceTypeId");

                    b.HasIndex("ClassPeriodId");

                    b.HasIndex("StudentId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("ChamadaFiap.Entities.AttendanceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AttendanceTypes");
                });

            modelBuilder.Entity("ChamadaFiap.Entities.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.HasIndex("TeamId");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Aula1",
                            SubjectId = 1,
                            TeacherId = 1,
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Aula2",
                            SubjectId = 2,
                            TeacherId = 2,
                            TeamId = 2
                        });
                });

            modelBuilder.Entity("ChamadaFiap.Entities.ClassPeriod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FinishTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("ClassPeriods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClassId = 1,
                            FinishTime = new DateTime(2024, 2, 2, 0, 28, 58, 279, DateTimeKind.Local).AddTicks(3065),
                            StartTime = new DateTime(2024, 2, 1, 21, 28, 58, 279, DateTimeKind.Local).AddTicks(3063)
                        },
                        new
                        {
                            Id = 2,
                            ClassId = 1,
                            FinishTime = new DateTime(2024, 2, 2, 3, 28, 58, 279, DateTimeKind.Local).AddTicks(3085),
                            StartTime = new DateTime(2024, 2, 2, 0, 28, 58, 279, DateTimeKind.Local).AddTicks(3084)
                        });
                });

            modelBuilder.Entity("ChamadaFiap.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Arquitetura e Desenvolvimento .Net"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Banco de Dados"
                        });
                });

            modelBuilder.Entity("ChamadaFiap.Entities.CourseSyllabus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClassPeriodId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClassPeriodId");

                    b.ToTable("CourseSyllabuses");
                });

            modelBuilder.Entity("ChamadaFiap.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisterEnrollment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Gabriel",
                            RegisterEnrollment = "RM643234",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fernando",
                            RegisterEnrollment = "RM644564",
                            TeamId = 2
                        });
                });

            modelBuilder.Entity("ChamadaFiap.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            Description = "Fundamentos da Cyber Seguranca",
                            Name = "Fundamentos da Cyber Seguranca"
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 1,
                            Description = "Arquitetura de Banco de Dados",
                            Name = "Arquitetura de Banco de Dados"
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 2,
                            Description = "Fundamentos da Cyber Seguranca",
                            Name = "Fundamentos da Cyber Seguranca"
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 2,
                            Description = "Arquitetura de Banco de Dados",
                            Name = "Arquitetura de Banco de Dados"
                        });
                });

            modelBuilder.Entity("ChamadaFiap.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "ricardo@fiap.com.br",
                            Name = "Ricardo"
                        },
                        new
                        {
                            Id = 2,
                            Email = "girafales@fiap.com.br",
                            Name = "Girafales"
                        });
                });

            modelBuilder.Entity("ChamadaFiap.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Finish")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            Finish = new DateTime(2025, 1, 26, 21, 28, 58, 279, DateTimeKind.Local).AddTicks(2887),
                            Name = "2NETR",
                            Start = new DateTime(2024, 2, 1, 21, 28, 58, 279, DateTimeKind.Local).AddTicks(2871)
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 2,
                            Finish = new DateTime(2025, 1, 26, 21, 28, 58, 279, DateTimeKind.Local).AddTicks(2895),
                            Name = "1NETR",
                            Start = new DateTime(2024, 2, 1, 21, 28, 58, 279, DateTimeKind.Local).AddTicks(2895)
                        });
                });

            modelBuilder.Entity("ChamadaFiap.Entities.Attendance", b =>
                {
                    b.HasOne("ChamadaFiap.Entities.AttendanceType", "AttendanceType")
                        .WithMany("Attendances")
                        .HasForeignKey("AttendanceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChamadaFiap.Entities.ClassPeriod", "ClassPeriod")
                        .WithMany("Attendances")
                        .HasForeignKey("ClassPeriodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChamadaFiap.Entities.Student", "Student")
                        .WithMany("Attendances")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AttendanceType");

                    b.Navigation("ClassPeriod");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ChamadaFiap.Entities.Class", b =>
                {
                    b.HasOne("ChamadaFiap.Entities.Subject", "Subject")
                        .WithMany("Classes")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ChamadaFiap.Entities.Teacher", "Teacher")
                        .WithMany("Classes")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ChamadaFiap.Entities.Team", "Team")
                        .WithMany("Classes")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("Teacher");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("ChamadaFiap.Entities.ClassPeriod", b =>
                {
                    b.HasOne("ChamadaFiap.Entities.Class", "Class")
                        .WithMany("ClassPeriods")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("ChamadaFiap.Entities.CourseSyllabus", b =>
                {
                    b.HasOne("ChamadaFiap.Entities.ClassPeriod", "ClassPeriod")
                        .WithMany("CourseSyllabus")
                        .HasForeignKey("ClassPeriodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClassPeriod");
                });

            modelBuilder.Entity("ChamadaFiap.Entities.Student", b =>
                {
                    b.HasOne("ChamadaFiap.Entities.Team", "Team")
                        .WithMany("Students")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("ChamadaFiap.Entities.Subject", b =>
                {
                    b.HasOne("ChamadaFiap.Entities.Course", "Course")
                        .WithMany("Subjects")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("ChamadaFiap.Entities.Team", b =>
                {
                    b.HasOne("ChamadaFiap.Entities.Course", "Course")
                        .WithMany("Teams")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("ChamadaFiap.Entities.AttendanceType", b =>
                {
                    b.Navigation("Attendances");
                });

            modelBuilder.Entity("ChamadaFiap.Entities.Class", b =>
                {
                    b.Navigation("ClassPeriods");
                });

            modelBuilder.Entity("ChamadaFiap.Entities.ClassPeriod", b =>
                {
                    b.Navigation("Attendances");

                    b.Navigation("CourseSyllabus");
                });

            modelBuilder.Entity("ChamadaFiap.Entities.Course", b =>
                {
                    b.Navigation("Subjects");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("ChamadaFiap.Entities.Student", b =>
                {
                    b.Navigation("Attendances");
                });

            modelBuilder.Entity("ChamadaFiap.Entities.Subject", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("ChamadaFiap.Entities.Teacher", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("ChamadaFiap.Entities.Team", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
