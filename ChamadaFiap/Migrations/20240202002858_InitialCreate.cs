using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ChamadaFiap.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttendanceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Finish = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Classes_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Classes_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisterEnrollment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassPeriods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassPeriods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassPeriods_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Finish = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClassPeriodId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    AttendanceTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendances_AttendanceTypes_AttendanceTypeId",
                        column: x => x.AttendanceTypeId,
                        principalTable: "AttendanceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendances_ClassPeriods_ClassPeriodId",
                        column: x => x.ClassPeriodId,
                        principalTable: "ClassPeriods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendances_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CourseSyllabuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassPeriodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSyllabuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseSyllabuses_ClassPeriods_ClassPeriodId",
                        column: x => x.ClassPeriodId,
                        principalTable: "ClassPeriods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Arquitetura e Desenvolvimento .Net" },
                    { 2, "Banco de Dados" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "ricardo@fiap.com.br", "Ricardo" },
                    { 2, "girafales@fiap.com.br", "Girafales" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CourseId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Fundamentos da Cyber Seguranca", "Fundamentos da Cyber Seguranca" },
                    { 2, 1, "Arquitetura de Banco de Dados", "Arquitetura de Banco de Dados" },
                    { 4, 2, "Arquitetura de Banco de Dados", "Arquitetura de Banco de Dados" },
                    { 5, 2, "Fundamentos da Cyber Seguranca", "Fundamentos da Cyber Seguranca" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CourseId", "Finish", "Name", "Start" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 1, 26, 21, 28, 58, 279, DateTimeKind.Local).AddTicks(2887), "2NETR", new DateTime(2024, 2, 1, 21, 28, 58, 279, DateTimeKind.Local).AddTicks(2871) },
                    { 2, 2, new DateTime(2025, 1, 26, 21, 28, 58, 279, DateTimeKind.Local).AddTicks(2895), "1NETR", new DateTime(2024, 2, 1, 21, 28, 58, 279, DateTimeKind.Local).AddTicks(2895) }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Name", "SubjectId", "TeacherId", "TeamId" },
                values: new object[,]
                {
                    { 1, "Aula1", 1, 1, 1 },
                    { 2, "Aula2", 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "RegisterEnrollment", "TeamId" },
                values: new object[,]
                {
                    { 1, "Gabriel", "RM643234", 1 },
                    { 2, "Fernando", "RM644564", 2 }
                });

            migrationBuilder.InsertData(
                table: "ClassPeriods",
                columns: new[] { "Id", "ClassId", "FinishTime", "StartTime" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 2, 2, 0, 28, 58, 279, DateTimeKind.Local).AddTicks(3065), new DateTime(2024, 2, 1, 21, 28, 58, 279, DateTimeKind.Local).AddTicks(3063) },
                    { 2, 1, new DateTime(2024, 2, 2, 3, 28, 58, 279, DateTimeKind.Local).AddTicks(3085), new DateTime(2024, 2, 2, 0, 28, 58, 279, DateTimeKind.Local).AddTicks(3084) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_AttendanceTypeId",
                table: "Attendances",
                column: "AttendanceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_ClassPeriodId",
                table: "Attendances",
                column: "ClassPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_StudentId",
                table: "Attendances",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_SubjectId",
                table: "Classes",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TeacherId",
                table: "Classes",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TeamId",
                table: "Classes",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassPeriods_ClassId",
                table: "ClassPeriods",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSyllabuses_ClassPeriodId",
                table: "CourseSyllabuses",
                column: "ClassPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_TeamId",
                table: "Students",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_CourseId",
                table: "Subjects",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CourseId",
                table: "Teams",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "CourseSyllabuses");

            migrationBuilder.DropTable(
                name: "AttendanceTypes");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "ClassPeriods");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
