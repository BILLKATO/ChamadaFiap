using ChamadaFiap.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RecrutamentoApi.Dados
{
    public class CourseSyllabusConfiguration : IEntityTypeConfiguration<CourseSyllabus>
    {
        public void Configure(EntityTypeBuilder<CourseSyllabus> builder)
        {
            builder
                .HasOne(courseSyllabus => courseSyllabus.ClassPeriod)
                .WithMany(classPeriod => classPeriod.CourseSyllabus)
                .HasForeignKey(courseSyllabus => courseSyllabus.ClassPeriodId);
        }
    }
}
