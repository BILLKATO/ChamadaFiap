using ChamadaFiap.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RecrutamentoApi.Dados
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder
                .HasOne(student => student.Team)
                .WithMany(team => team.Students)
                .HasForeignKey(student => student.TeamId);
        }
    }
}
