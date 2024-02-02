using ChamadaFiap.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Reflection.Emit;

namespace RecrutamentoApi.Dados
{
    public class AttendanceConfiguration : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder
                .HasOne(attendance => attendance.ClassPeriod)
                .WithMany(classPeriod => classPeriod.Attendances)
                .HasForeignKey(attendance => attendance.ClassPeriodId);

            builder
               .HasOne(attendance => attendance.Student)
               .WithMany(student => student.Attendances)
               .OnDelete(DeleteBehavior.NoAction)
               .HasForeignKey(attendance => attendance.StudentId);

            builder
               .HasOne(attendance => attendance.AttendanceType)
               .WithMany(attendanceType => attendanceType.Attendances)
               .HasForeignKey(attendance => attendance.AttendanceTypeId);
        }
    }
}
