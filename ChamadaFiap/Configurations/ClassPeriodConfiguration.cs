using ChamadaFiap.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RecrutamentoApi.Dados
{
    public class ClassPeriodConfiguration : IEntityTypeConfiguration<ClassPeriod>
    {
        public void Configure(EntityTypeBuilder<ClassPeriod> builder)
        {
            builder
                .HasOne(classPeriod => classPeriod.Class)
                .WithMany(_class => _class.ClassPeriods)
                .HasForeignKey(classPeriod => classPeriod.ClassId);
        }
    }
}
