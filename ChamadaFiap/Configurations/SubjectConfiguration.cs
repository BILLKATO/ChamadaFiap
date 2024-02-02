using ChamadaFiap.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RecrutamentoApi.Dados
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder
                .HasOne(subject => subject.Course)
                .WithMany(course => course.Subjects)
                .HasForeignKey(subject => subject.CourseId);
        }
    }
}
