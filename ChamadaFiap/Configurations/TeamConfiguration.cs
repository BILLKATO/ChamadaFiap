using ChamadaFiap.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RecrutamentoApi.Dados
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder
                .HasOne(team => team.Course)
                .WithMany(course => course.Teams)
                .HasForeignKey(team => team.CourseId);
        }
    }
}
