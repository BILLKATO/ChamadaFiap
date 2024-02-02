using ChamadaFiap.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RecrutamentoApi.Dados
{
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder
                .HasOne(_class => _class.Teacher)
                .WithMany(teacher => teacher.Classes)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(_class => _class.TeacherId);

            builder
                .HasOne(_class => _class.Team)
                .WithMany(team => team.Classes)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(_class => _class.TeamId);

            builder
                .HasOne(_class => _class.Subject)
                .WithMany(subject => subject.Classes)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(_class => _class.SubjectId);
        }
    }
}
