using ChamadaFiap.Entities;
using Microsoft.EntityFrameworkCore;
using RecrutamentoApi.Dados;

namespace ChamadaFiap
{
    public class MyDbContext(DbContextOptions<MyDbContext> options) : DbContext(options)
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseSyllabus> CourseSyllabuses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<AttendanceType> AttendanceTypes { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassPeriod> ClassPeriods { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AttendanceConfiguration());
            modelBuilder.ApplyConfiguration(new ClassConfiguration());
            modelBuilder.ApplyConfiguration(new ClassPeriodConfiguration());
            modelBuilder.ApplyConfiguration(new CourseSyllabusConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new TeamConfiguration());





            modelBuilder.Entity<Course>().HasData(new Course { Id = 1, Name = "Arquitetura e Desenvolvimento .Net" }, new Course { Id = 2, Name = "Banco de Dados" });

            modelBuilder.Entity<Teacher>().HasData(new Teacher { Id = 1, Name = "Ricardo", Email = "ricardo@fiap.com.br" }, new Teacher { Id = 2, Name = "Girafales", Email = "girafales@fiap.com.br" });

            modelBuilder.Entity<Team>().HasData(new Team { Id = 1, Name = "2NETR", Start = DateTime.Now, Finish = DateTime.Now.AddDays(360), CourseId = 1 }, new Team { Id = 2, Name = "1NETR", Start = DateTime.Now, Finish = DateTime.Now.AddDays(360), CourseId = 2 });

            modelBuilder.Entity<Subject>().HasData(new Subject { Id = 1, Name = "Fundamentos da Cyber Seguranca", Description = "Fundamentos da Cyber Seguranca", CourseId = 1 }, new Subject { Id = 2, Name = "Arquitetura de Banco de Dados", Description = "Arquitetura de Banco de Dados", CourseId = 1 });
            modelBuilder.Entity<Subject>().HasData(new Subject { Id = 5, Name = "Fundamentos da Cyber Seguranca", Description = "Fundamentos da Cyber Seguranca", CourseId = 2 }, new Subject { Id = 4, Name = "Arquitetura de Banco de Dados", Description = "Arquitetura de Banco de Dados", CourseId = 2 });

            modelBuilder.Entity<Student>().HasData(new Student { Id = 1, Name = "Gabriel", RegisterEnrollment = "RM643234", TeamId = 1 }, new Student { Id = 2, Name = "Fernando", RegisterEnrollment = "RM644564", TeamId = 2 });

            modelBuilder.Entity<Class>().HasData(new Class { Id = 1, Name = "Aula1", TeacherId = 1, TeamId = 1 , SubjectId = 1}, new Class { Id = 2, Name = "Aula2", TeacherId = 2, TeamId = 2, SubjectId = 2});

            modelBuilder.Entity<ClassPeriod>().HasData(new ClassPeriod { Id = 1, StartTime = DateTime.Now, FinishTime = DateTime.Now.AddHours(3), ClassId = 1 });
            modelBuilder.Entity<ClassPeriod>().HasData(new ClassPeriod { Id = 2, StartTime = DateTime.Now.AddHours(3), FinishTime = DateTime.Now.AddHours(6), ClassId = 1 });


        }

        
    }
}